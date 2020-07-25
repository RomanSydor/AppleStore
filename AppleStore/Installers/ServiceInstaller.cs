using AppleStore.Models;
using AppleStore.Repositories;
using AppleStore.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppleStore.Installers
{
    public class ServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<Cart>();
        }
    }
}
