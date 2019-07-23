namespace HealthCare.API.Utils
{
    using Microsoft.Extensions.DependencyInjection;
    using FluentValidation.AspNetCore;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    using Behaviour.Filters;
    using Contracts.Configuration;
    using DataLayer;
    using DataLayer.Utils;
    using Interfaces;
    using Validation.ModelValidators.Example;

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

            return services;
        }
    }
}
