using AutoMapper;
using Autofac;
using ScrumFlush.Application.Applications;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Application.Mappers;
using ScrumFlush.Service.Interfaces;
using ScrumFlush.Service.Services;
using ScrumFlush.Infrastructure.Repositories;
using ScrumFlush.Core.Interfaces;

namespace ScrumFlush.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfiles>(); // Perfil de mapeamento
            }).CreateMapper())
            .As<IMapper>()
            .InstancePerLifetimeScope();
            
            builder.RegisterType<CardApplicationService>().As<ICardApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<CardService>().As<ICardService>().InstancePerLifetimeScope(); 
            builder.RegisterType<CardRepository>().As<ICardRepository>().InstancePerLifetimeScope();

            builder.RegisterType<CollectionApplicationService>().As<ICollectionApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<CollectionService>().As<ICollectionService>().InstancePerLifetimeScope(); 
            builder.RegisterType<CollectionRepository>().As<ICollectionRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<PlayerApplicationService>().As<IPlayerApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<PlayerService>().As<IPlayerService>().InstancePerLifetimeScope(); 
            builder.RegisterType<PlayerRepository>().As<IPlayerRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<RoomPlayerApplicationService>().As<IRoomPlayerApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<RoomPlayerService>().As<IRoomPlayerService>().InstancePerLifetimeScope(); 
            builder.RegisterType<RoomPlayerRepository>().As<IRoomPlayerRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<RoomApplicationService>().As<IRoomApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<RoomService>().As<IRoomService>().InstancePerLifetimeScope(); 
            builder.RegisterType<RoomRepository>().As<IRoomRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<RoundApplicationService>().As<IRoundApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<RoundService>().As<IRoundService>().InstancePerLifetimeScope(); 
            builder.RegisterType<RoundRepository>().As<IRoundRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<SprintApplicationService>().As<ISprintApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<SprintService>().As<ISprintService>().InstancePerLifetimeScope(); 
            builder.RegisterType<SprintRepository>().As<ISprintRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<StorieApplicationService>().As<IStorieApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<StorieService>().As<IStorieService>().InstancePerLifetimeScope(); 
            builder.RegisterType<StorieRepository>().As<IStorieRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<TeamApplicationService>().As<ITeamApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<TeamService>().As<ITeamService>().InstancePerLifetimeScope(); 
            builder.RegisterType<TeamRepository>().As<ITeamRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<TeamSprintApplicationService>().As<ITeamSprintApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<TeamSprintService>().As<ITeamSprintService>().InstancePerLifetimeScope(); 
            builder.RegisterType<TeamSprintRepository>().As<ITeamSprintRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<TeamUserApplicationService>().As<ITeamUserApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<TeamUserService>().As<ITeamUserService>().InstancePerLifetimeScope(); 
            builder.RegisterType<TeamUserRepository>().As<ITeamUserRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<UserApplicationService>().As<IUserApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope(); 
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            
            builder.RegisterType<VoteApplicationService>().As<IVoteApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<VoteService>().As<IVoteService>().InstancePerLifetimeScope(); 
            builder.RegisterType<VoteRepository>().As<IVoteRepository>().InstancePerLifetimeScope();
        }
    }
}
