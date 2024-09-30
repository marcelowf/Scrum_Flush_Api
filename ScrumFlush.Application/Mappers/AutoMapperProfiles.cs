using ScrumFlush.Application.Dtos;
using ScrumFlush.Domain.Entity;
using AutoMapper;

namespace ScrumFlush.Application.Mappers
{
    public class AutoMapperProfiles : Profile
    {
         public AutoMapperProfiles() {
            /*
            CreateMap<UserDTO, User>()
                .ForMember(dest => dest.TeamUsers, opt => opt.MapFrom(src => src.TeamUsers))
                .ForMember(dest => dest.Players, opt => opt.MapFrom(src => src.Players))
                .ReverseMap();
            */
        }
    }
}
