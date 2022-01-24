using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestProject.DB.Controllers;
using TestProject.DB.Models;
using TestProject.View.Models;

namespace TestProject.DB
{
	public class GameController
	{
		private static GameDbController Games { get; } = new();
		private static DeveloperDbController Developers { get; } = new();
		private static GenreDbController Genres { get; } = new();

		public async Task<IEnumerable<Game>> GetAll()
		{
			return await Games.GetAll();
		}

		public async Task<Game> Get(Guid id)
		{
			return await Games.Get(id);
		}

		public async Task<IEnumerable<Game>> Get(string genreName)
		{
			var games = from game in Db.Entities.Games
						join genreLink in Db.Entities.GameGenreLinks on game.Id equals genreLink.GameId
						where genreLink.Genre.Name == genreName
						select game;
			/*var games2 = Db.Entities.Genres
				.Where(item => item.Name == genreName)
				.SelectMany(item => item.GameGenreLinks)
				.Select(item => item.Game);*/
			return await games.ToListAsync();
		}

		public async Task<Game> Insert(Game item)
		{
			var game1 = new Game
			{
				Name = "Game",
				Developer = new Developer
				{
					Name = "Developer"
				},
				GameGenreLinks = new List<GameGenreLink>
				{
					new() { Genre = new Genre { Name = "genre1" } },
					new() { Genre = new Genre { Name = "genre2" } }
				}
			};

			if (item.Id != Guid.Empty)
			{
				throw new ArgumentException("Game cannot contain Id when inserting.");
			}

			if (item.Developer == null || string.IsNullOrWhiteSpace(item.Developer.Name))
			{
				throw new ArgumentException("Game must contain Developer.");
			}

			if (item.GameGenreLinks == null)
			{
				throw new ArgumentException("Genres cannot be null.");
			}

			item.GameGenreLinks = item.GameGenreLinks.Where(link => link.Genre != null && string.IsNullOrWhiteSpace(link.Genre.Name)).ToList();

			if (item.GameGenreLinks.Count <= 0)
			{
				throw new ArgumentException("Game must contain Genres.");
			}

			var developer = await Developers.Get(item.Developer.Name) ?? await Developers.Insert(item.Developer);
			var game = await Games.Insert(new Game
			{
				Name = item.Name,
				DeveloperId = developer.Id,
			});

			var genres = item.GameGenreLinks
				.Select(link => link.Genre)
				.Select(async genre => await Genres.Get(genre.Name) ?? await Genres.Insert(genre));

			foreach (var genre in genres)
			{
				await Db.Entities.GameGenreLinks.AddAsync(new GameGenreLink
				{
					Id = Guid.NewGuid(),
					GameId = game.Id,
					GenreId = (await genre).Id,
				});
			}

			await Db.Entities.SaveChangesAsync();
			return game;
		}

		public async Task<Game> Update(Game item)
		{
			if (item.Id == Guid.Empty)
			{
				throw new ArgumentException("Game must contain Id when updating.");
			}

			if (item.Developer == null || string.IsNullOrWhiteSpace(item.Developer.Name))
			{
				throw new ArgumentException("Game must contain Developer.");
			}

			if (item.GameGenreLinks == null)
			{
				throw new ArgumentException("Genres cannot be null.");
			}

			item.GameGenreLinks = item.GameGenreLinks.Where(link => link.Genre != null && string.IsNullOrWhiteSpace(link.Genre.Name)).ToList();

			if (item.GameGenreLinks.Count <= 0)
			{
				throw new ArgumentException("Game must contain Genres.");
			}

			var game = await Games.Get(item.Id);
			if (game == null)
			{
				throw new ArgumentException("Game must contain correct Id when updating.");
			}

			var developer = await Developers.Get(item.Developer.Name) ?? await Developers.Insert(item.Developer);
			game.DeveloperId = developer.Id;

			var genres = item.GameGenreLinks
				.Select(link => link.Genre)
				.Select(async genre => await Genres.Get(genre.Name) ?? await Genres.Insert(genre));

			foreach (var genre in genres)
			{
				await Db.Entities.GameGenreLinks.AddAsync(new GameGenreLink
				{
					Id = Guid.NewGuid(),
					GameId = game.Id,
					GenreId = (await genre).Id,
				});
			}

			return await Games.Update(item);
		}

		public async Task<bool> Delete(Guid id)
		{
			return await Games.Delete(id);
		}
	}
}
