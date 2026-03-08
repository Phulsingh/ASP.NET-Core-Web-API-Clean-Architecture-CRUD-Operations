using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.API
{
    public static class  DependencyInjection
    {
            public static IServiceCollection AddAppDI(this IServiceCollection service)
            {
            service.AddApplicationDI()
                   .AddInfrastructureDI();
                return service;
            }
       
    }
}
