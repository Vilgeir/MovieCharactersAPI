using System.Collections.Generic;

namespace MovieCharactersAPI.Models.DTOs.Movie
{
    public class MovieDTO
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Picture { get; set; }
        public string Trailer { get; set; }
        public int FranchiseId { get; set; }
        public List<int> Characters { get; set; }
    }
}
