using ScrumFlush.Application.Dtos;
using ScrumFlush.Domain.Entity;
using AutoMapper;

namespace ScrumFlush.Application.Mappers
{
    public class AutoMapperProfiles : Profile
    {
         public AutoMapperProfiles() {
            
            CreateMap<UserDTO, User>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position))
                //.ForMember(dest => dest.TeamUsers, opt => opt.MapFrom(src => src.TeamUsers))
                //.ForMember(dest => dest.Players, opt => opt.MapFrom(src => src.Players))
                .ReverseMap();
         }
    }
}
