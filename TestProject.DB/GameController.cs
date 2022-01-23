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
	class GameController
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
			var game = new Game
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



			await Db.Entities.Games.AddAsync(item);
			await Db.Entities.SaveChangesAsync();
			return item;
		}

		public async Task<Game> Update(Game item)
		{
			Db.Entities.Games.Update(item);
			await Db.Entities.SaveChangesAsync();
			return item;
		}

		public async Task<bool> Delete(Game item)
		{
			Db.Entities.Games.Remove(item);
			return await Db.Entities.SaveChangesAsync() > 0;
		}
	}
}
