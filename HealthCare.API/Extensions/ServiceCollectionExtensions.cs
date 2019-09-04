namespace HealthCare.API.Extensions
{
    using Authentication;
    using AutoMapper;
    using FluentValidation.AspNetCore;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using Utils;
    using Validation.ModelValidators.UserValidators;
    using Behaviour.Filters;
    using BusinessLayer;
    using BusinessLayer.Interfaces;
    using BusinessLayer.Services;
    using Contracts.Configuration;
    using Contracts.Interfaces;
    using DataLayer;
    using DataLayer.Utils;
    using Interfaces;

    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomMvc(this IServiceCollection services)
        {
            services.AddMvc(options =>
                {
                    options.Filters.Add(typeof(GlobalExceptionFilter));
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddControllersAsServices()
                .AddFluentValidation(f =>
                {
                    f.RegisterValidatorsFromAssemblyContaining<RegisterUserValidator>();
                });

            return services;
        }

        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HealthCareDbContext>(op => op.UseSqlServer(configuration["ConnectionString"]));

            return services;
        }

        public static IServiceCollection AddConfigurations(this IServiceCollection service, IConfiguration configuration)
        {
            service.Configure<SeedSettings>(configuration.GetSection("SeedSettings"));
            service.Configure<JwtAuthentication>(configuration.GetSection("JwtAuthentication"));
            service.Configure<CommonSettings>(configuration.GetSection("CommonSettings"));

            return service;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDataRetriever, DataRetriever>();
            services.AddScoped<ISessionResolver, HttpSessionResolver>();

            services.AddScoped<IContactsService, ContactsService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IMedicalManService, MedicalManService> ();
            services.AddScoped<IMedicalCenterService, MedicalCenterService> ();

            services.AddScoped<IStorageService, DatabaseService>();

            services.AddScoped<IImageService, ImageService>();

            services.AddTransient<IAuthService, JWTService>();

            return services;
        }

        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            return services;
        }
    }
}
