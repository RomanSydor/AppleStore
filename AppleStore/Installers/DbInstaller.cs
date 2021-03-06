﻿using AppleStore.Models;
using AppleStore.Repositories;
using AppleStore.Services;
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
            services.AddScoped<IAppleWatchRepository, AppleWatchRepository>();
            services.AddScoped<IAirPodsRepository, AirPodsRepository>();
            services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            
            services.AddScoped<IPurchaseService, PurchaseService>();
            services.AddScoped<IIPhoneService, IPhoneService>();
            services.AddScoped<IIPadService, IPadService>();
            services.AddScoped<IMacService, MacService>();
            services.AddScoped<IAppleWatchService, AppleWatchService>();
            services.AddScoped<IAirPodsService, AirPodsService>();
        }
    }
}
