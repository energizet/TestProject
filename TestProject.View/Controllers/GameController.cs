using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Domain.Models;

namespace TestProject.View.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class GameController : ControllerBase
	{
		private readonly ILogger<GameController> _logger;

		public GameController(ILogger<GameController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		public Game Create(Game game)
		{
			return new Game
			{
				Id = Guid.NewGuid(),
				Name = "Game",
				Developer = new Developer
				{
					Id = Guid.NewGuid(),
					Name = "Developer"
				},
				Genres = new[]
				{
					new Genre
					{
						Id = Guid.NewGuid(),
						Name = "Genre1"
					},
					new Genre
					{
						Id = Guid.NewGuid(),
						Name = "Genre2"
					}
				}
			};
		}

		[HttpGet]
		public IEnumerable<Game> Read(string genre)
		{
			return new[]
			{
				new Game
				{
					Id = Guid.NewGuid(),
					Name = "Game",
					Developer = new Developer
					{
						Id = Guid.NewGuid(),
						Name = "Developer"
					},
					Genres = new[]
					{
						new Genre
						{
							Id = Guid.NewGuid(),
							Name = "Genre1"
						},
						new Genre
						{
							Id = Guid.NewGuid(),
							Name = "Genre2"
						}
					}
				}
			};
		}

		[HttpGet("{id}")]
		public Game Read(Guid id)
		{
			return new Game
			{
				Id = id,
				Name = "Game",
				Developer = new Developer
				{
					Id = Guid.NewGuid(),
					Name = "Developer"
				},
				Genres = new[]
				{
					new Genre
					{
						Id = Guid.NewGuid(),
						Name = "Genre1"
					},
					new Genre
					{
						Id = Guid.NewGuid(),
						Name = "Genre2"
					}
				}
			};
		}

		[HttpPut]
		public void Update(Game game)
		{

		}

		[HttpDelete]
		public void Delete(Game game)
		{

		}
	}
}
