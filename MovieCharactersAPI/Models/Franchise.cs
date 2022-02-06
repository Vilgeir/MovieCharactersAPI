using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieCharactersAPI.Models
{
    public class Franchise
    {
        //PK
        [Required]
        public int FranchiseId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
