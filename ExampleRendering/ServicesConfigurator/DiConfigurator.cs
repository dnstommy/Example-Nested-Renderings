using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using ExampleRendering.Repositories;
using ExampleRendering.Extensions;

namespace ExampleRendering.ServicesConfigurator
{
    public class DiConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            // register each repository and service
            serviceCollection.AddScoped<IBannerRepository, BannerRepository>();
            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }    
}