using AppleStore.Models;
using AppleStore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppleStore.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                          options.UseSqlServer(
                              configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IIPhoneRepository, IPhoneRepository>();
            services.AddScoped<IMacRepository, MacRepository>();
            services.AddScoped<IIPadRepository, IPadRepository>();
        }
    }
}
