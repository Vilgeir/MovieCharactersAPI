using AutoMapper;
using MovieCharactersAPI.Models;
using MovieCharactersAPI.Models.DTOs.Franchise;
using System.Linq;

namespace MovieCharactersAPI.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            CreateMap<Franchise, FranchiseCreateDTO>().ReverseMap();
            CreateMap<Franchise, FranchiseUpdateDTO>().ReverseMap();
            CreateMap<Franchise, FranchiseDTO>().ForMember(x => x.Movies, v => v
            .MapFrom(z => z.Movies.Select(c => c.MovieId).ToArray()));
        }
    }
}
