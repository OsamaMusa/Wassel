using Data.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ServicesConfigurations
{
    public static class EFConfiguration 
    {
        public static IServiceCollection AddEFConfiguration(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<WasselAppContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),e=>e.MigrationsAssembly("Wassel")));

            return services;
        }
    }
}
