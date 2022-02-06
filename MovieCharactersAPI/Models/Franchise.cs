﻿using System.Collections.Generic;

namespace MovieCharactersAPI.Models
{
    public class Franchise
    {
        public int FranchiseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
