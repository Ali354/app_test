using AppDbContext.Models;
using AppDbContext.UOW;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FirstWebApp.Services
{
    public static class IDbService
    {
        public static IServiceCollection AddDbService(this IServiceCollection services,
            IConfiguration Configuration)
        {
            services.AddDbContext<ECOMMERCEContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ECOMMERCEContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
