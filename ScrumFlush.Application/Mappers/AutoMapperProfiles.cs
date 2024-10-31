using ScrumFlush.Domain.Entity;
using AutoMapper;
using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Application.Dtos.Post;

namespace ScrumFlush.Application.Mappers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            #region Get Mappers

            CreateMap<CardGetDTO, Card>()
                .ForMember(dest => dest.Votes, opt => opt.MapFrom(src => src.Votes))
                .ReverseMap();

            CreateMap<CollectionGetDTO, Collection>()
                .ForMember(dest => dest.Cards, opt => opt.MapFrom(src => src.Cards))
                .ReverseMap();

            CreateMap<PlayerGetDTO, Player>()
                .ForMember(dest => dest.RoomPlayers, opt => opt.MapFrom(src => src.RoomPlayers))
                .ForMember(dest => dest.Votes, opt => opt.MapFrom(src => src.Votes))
                .ReverseMap();

            CreateMap<RoomGetDTO, Room>()
                .ForMember(dest => dest.RoomPlayers, opt => opt.MapFrom(src => src.RoomPlayers))
                .ForMember(dest => dest.RoomRounds, opt => opt.MapFrom(src => src.RoomRounds))
                .ReverseMap();

            CreateMap<RoomPlayerGetDTO, RoomPlayer>().ReverseMap();

            CreateMap<RoundGetDTO, Round>()
                .ForMember(dest => dest.Votes, opt => opt.MapFrom(src => src.Votes))
                .ReverseMap();

            CreateMap<SprintGetDTO, Sprint>()
                .ForMember(dest => dest.TeamSprints, opt => opt.MapFrom(src => src.TeamSprints))
                .ForMember(dest => dest.Stories, opt => opt.MapFrom(src => src.Stories))
                .ForMember(dest => dest.Rooms, opt => opt.MapFrom(src => src.Rooms))
                .ReverseMap();

            CreateMap<StorieGetDTO, Storie>()
                .ForMember(dest => dest.Rounds, opt => opt.MapFrom(src => src.Rounds))
                .ReverseMap();

            CreateMap<TeamGetDTO, Team>()
                .ForMember(dest => dest.TeamUsers, opt => opt.MapFrom(src => src.TeamUsers))
                .ForMember(dest => dest.TeamSprints, opt => opt.MapFrom(src => src.TeamSprints))
                .ReverseMap();

            CreateMap<TeamSprintGetDTO, TeamSprint>().ReverseMap();

            CreateMap<TeamUserGetDTO, TeamUser>().ReverseMap();

            CreateMap<UserGetDTO, User>()
                .ForMember(dest => dest.TeamUsers, opt => opt.MapFrom(src => src.TeamUsers))
                .ForMember(dest => dest.Players, opt => opt.MapFrom(src => src.Players))
                .ReverseMap();

            CreateMap<VoteGetDTO, Vote>().ReverseMap();

            #endregion

            #region Post Mappers

            CreateMap<CardPostDTO, Card>().ReverseMap();
            CreateMap<CollectionPostDTO, Collection>().ReverseMap();
            CreateMap<PlayerPostDTO, Player>().ReverseMap();
            CreateMap<RoomPostDTO, Room>().ReverseMap();
            CreateMap<RoomPlayerPostDTO, RoomPlayer>().ReverseMap();
            CreateMap<RoundPostDTO, Round>().ReverseMap();
            CreateMap<SprintPostDTO, Sprint>().ReverseMap();
            CreateMap<StoriePostDTO, Storie>().ReverseMap();
            CreateMap<TeamPostDTO, Team>().ReverseMap();
            CreateMap<TeamSprintPostDTO, TeamSprint>().ReverseMap();
            CreateMap<TeamUserPostDTO, TeamUser>().ReverseMap();
            CreateMap<UserPostDTO, User>().ReverseMap();
            CreateMap<VotePostDTO, Vote>().ReverseMap();

            #endregion

            #region Put Mappers

            CreateMap<CardPutDTO, Card>().ReverseMap();
            CreateMap<CollectionPutDTO, Collection>().ReverseMap();
            CreateMap<PlayerPutDTO, Player>().ReverseMap();
            CreateMap<RoomPutDTO, Room>().ReverseMap();
            CreateMap<RoomPlayerPutDTO, RoomPlayer>().ReverseMap();
            CreateMap<RoundPutDTO, Round>().ReverseMap();
            CreateMap<SprintPutDTO, Sprint>().ReverseMap();
            CreateMap<StoriePutDTO, Storie>().ReverseMap();
            CreateMap<TeamPutDTO, Team>().ReverseMap();
            CreateMap<TeamSprintPutDTO, TeamSprint>().ReverseMap();
            CreateMap<TeamUserPutDTO, TeamUser>().ReverseMap();
            CreateMap<UserPutDTO, User>().ReverseMap();
            CreateMap<VotePutDTO, Vote>().ReverseMap();

            #endregion
        }
    }
}
