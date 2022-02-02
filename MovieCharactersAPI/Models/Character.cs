using System.Collections.Generic;

namespace MovieCharactersAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Gender { get; set; }
        public string Picture { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
