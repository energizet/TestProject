using System;
using System.Collections.Generic;

#nullable disable

namespace TestProject.View.Models
{
    public partial class Game
    {
        public Game()
        {
            GameGenreLinks = new HashSet<GameGenreLink>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DeveloperId { get; set; }

        public virtual Developer Developer { get; set; }
        public virtual ICollection<GameGenreLink> GameGenreLinks { get; set; }
    }
}
