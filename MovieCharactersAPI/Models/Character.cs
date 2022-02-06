using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.Models
{
    public class Character
    {
        //PK
        [Required]
        public int CharacterId { get; set; }     
        [MaxLength(50)]
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Gender { get; set; }
        public string Picture { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
