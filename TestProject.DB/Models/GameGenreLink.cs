using System;
using System.Collections.Generic;

#nullable disable

namespace TestProject.View.Models
{
    public partial class GameGenreLink
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public Guid GenreId { get; set; }

        public virtual Game Game { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
