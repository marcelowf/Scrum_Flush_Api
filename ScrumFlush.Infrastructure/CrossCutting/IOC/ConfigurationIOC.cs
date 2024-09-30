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

            builder.RegisterType<UserApplicationService>().As<IUserApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope(); 
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
        }
    }
}
