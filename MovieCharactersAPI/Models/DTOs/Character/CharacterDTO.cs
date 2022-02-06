using System.Collections.Generic;

namespace MovieCharactersAPI.Models.DTOs.Character
{
    public class CharacterDTO
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Gender { get; set; }
        public string Picture { get; set; }
        public List<int> Movies { get; set; }
    }
}
