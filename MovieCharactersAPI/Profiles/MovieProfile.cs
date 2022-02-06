using AutoMapper;
using MovieCharactersAPI.Models;
using MovieCharactersAPI.Models.DTOs.Movie;
using System.Linq;

namespace MovieCharactersAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieCreateDTO>().ReverseMap();
            CreateMap<Movie, MovieUpdateDTO>().ReverseMap();
            CreateMap<Movie, MovieDTO>().ForMember(x => x.Characters, v => v
            .MapFrom(z => z.Characters.Select(c => c.CharacterId).ToArray()));
        }
    }
}