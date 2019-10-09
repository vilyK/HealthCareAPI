namespace HealthCare.API.Extensions
{
    using System.Net;
    using System.Net.Mail;
    using Authentication;
    using AutoMapper;
    using FluentValidation.AspNetCore;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using Utils;
    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using BusinessLayer.Services;
    using Contracts.Configuration;
    using Contracts.Interfaces;
    using DataLayer;
    using DataLayer.Utils;
    using Interfaces;
    using RazorProject;
    using Templates;
    using Utilities.Helpers.EmailSender;
    using Validation.ModelValidators.AppraisalValidators;
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
                    f.RegisterValidatorsFromAssemblyContaining<AppraisalValidator>();
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
            service.Configure<EmailConfiguration>(configuration.GetSection("EmailConfiguration"));

            return service;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDataRetriever, DataRetriever>();
            services.AddScoped<ISessionResolver, HttpSessionResolver>();
            services.AddTransient<IAuthService, JWTService>();

            services.AddScoped<IContactsService, ContactsService>();
            services.AddScoped<IUserService, UserService>();

            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<ICommunicationService, CommunicationService>();
            services.AddScoped<IRazorViewToStringRenderer, RazorViewToStringRenderer>();

            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IMedicalManService, MedicalManService>();
            services.AddScoped<IMedicalCenterService, MedicalCenterService>();
            services.AddScoped<IMedicalDataService, MedicalDataService>();

            services.AddScoped<IAppraisalService, AppraisalService>();

            services.AddScoped<IStorageService, DatabaseService>();

            services.AddScoped<IImageService, ImageService>();

            return services;
        }

        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            return services;
        }

        private static SmtpClient PrepareSmtpClientSsl(IConfiguration configuration)
        {
            return new SmtpClient(configuration["EmailConfiguration:SmtpHost"], int.Parse(configuration["EmailConfiguration:SmtpPort"]))
            {
                EnableSsl = true,
                Credentials = new NetworkCredential("vily.karamanova@gmail.com", "obichamsebesi")
            };
        }
    }
}
