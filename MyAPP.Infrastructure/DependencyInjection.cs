using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interface;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositeries;

namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration  configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IEmployeeRepositery, EmployeeRepositery>();

            return services;
        }
    }
}
