using System.Collections.Generic;

namespace MovieCharactersAPI.Models.DTOs.Franchise
{
    public class FranchiseDTO
    {
        public int FranchiseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> Movies { get; set; }
    }
}
