using Data.Repository;
using Domain.IReporsitory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;
namespace Wassel.ServicesConfigurations
{
    public static class AllConfiguration
    {
        

        public static IServiceCollection RepositoryConfiguration(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
        
        public static IServiceCollection TanvirArjelConfiguration(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddServicesOfAllTypes();
            return services;
        }

    }
}
