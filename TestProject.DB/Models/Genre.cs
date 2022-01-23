using System;
using System.Collections.Generic;

#nullable disable

namespace TestProject.View.Models
{
    public partial class Genre
    {
        public Genre()
        {
            GameGenreLinks = new HashSet<GameGenreLink>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GameGenreLink> GameGenreLinks { get; set; }
    }
}
