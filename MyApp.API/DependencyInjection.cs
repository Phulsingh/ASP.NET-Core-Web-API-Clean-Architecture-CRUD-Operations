using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.API
{
    public static class  DependencyInjection
    {
            public static IServiceCollection AddAppDI(this IServiceCollection service, IConfiguration configuration)
            {
            service.AddApplicationDI()
                   .AddInfrastructureDI(configuration);
                return service;
            }
       
    }
}
