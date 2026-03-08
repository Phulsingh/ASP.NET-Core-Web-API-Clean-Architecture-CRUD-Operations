using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interface;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositeries;

namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyAppDb;Trusted_Connection=True;TrustServerCertificate=True;");
            });

            services.AddScoped<IEmployeeRepositery, EmployeeRepositery>();

            return services;
        }
    }
}
