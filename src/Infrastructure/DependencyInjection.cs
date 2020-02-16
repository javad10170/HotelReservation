﻿using Application.Common.Interfaces;
using Common;
using Domain.Entities;
using Infrastructure.Common;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Development;
using Persistence.Production;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, bool isDevelopment)
        {
            services.AddSingleton<IMemoryService, MemoryService>();
            services.AddSingleton<IImageService, ImageService>();

            services.AddScoped<IUserManager, UserManagerService>();
            services.AddScoped<IRoleManager, RoleManagerService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IDateTime, UniversalDateTime>();

            var identity = services.AddDefaultIdentity<AppUser>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 12;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.User.RequireUniqueEmail = true;
            })
                .AddRoles<AppRole>()
                .AddDefaultUI();

            if (isDevelopment)
                identity.AddEntityFrameworkStores<DevelopmentDbContext>();
            else identity.AddEntityFrameworkStores<ProductionDbContext>();

            return services;
        }
    }
}
