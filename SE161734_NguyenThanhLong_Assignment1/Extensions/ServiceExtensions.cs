using DAO.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EStoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            //services.AddScoped<IUserDAO, UserDAO>();
            
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
           // services.AddScoped<IUserService, UserService>();
        }
    }
}
