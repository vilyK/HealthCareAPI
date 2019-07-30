namespace HealthCare.API.Utils
{
    using AutoMapper;
    using Microsoft.Extensions.DependencyInjection;
    using FluentValidation.AspNetCore;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    using Behaviour.Filters;
    using BusinessLayer;
    using BusinessLayer.Interfaces;
    using Contracts.Configuration;
    using DataLayer;
    using DataLayer.Entities.User;
    using DataLayer.Utils;
    using Interfaces;
    using Validation.ModelValidators.UserValidators;

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
            return service;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDataRetriever, DataRetriever>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPatientService, PatientService>();

            return services;
        }

        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            return services;
        }
    }
}
