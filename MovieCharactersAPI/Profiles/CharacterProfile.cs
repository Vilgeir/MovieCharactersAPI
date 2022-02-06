using AutoMapper;
using MovieCharactersAPI.Models;
using MovieCharactersAPI.Models.DTOs.Character;
using System.Linq;

namespace MovieCharactersAPI.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<Character, CharacterCreateDTO>().ReverseMap();
            CreateMap<Character, CharacterUpdateDTO>().ReverseMap();
            CreateMap<Character, CharacterDTO>().ForMember(x => x.Movies, v => v
            .MapFrom(c => c.Movies.Select(c => c.MovieId).ToArray()));
        }
    }
}