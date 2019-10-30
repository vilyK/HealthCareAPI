namespace HealthCare.API.Behaviour.Extensions
{
    using AutoMapper;
    using FluentValidation.AspNetCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    
    using BusinessLayer.Interfaces;
    using BusinessLayer.Services;
    using BusinessLayer.Services.Authentication;
    using Contracts.Configuration;
    using Contracts.Interfaces;
    using DataLayer;
    using DataLayer.Utils;
    using Filters;
    using Interfaces;
    using Newtonsoft.Json;
    using Templates;
    using Utilities.Helpers.EmailSender;
    using Utils;
    using Validation.ModelValidators;
    using Workers;

    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomMvc(this IServiceCollection services)
        {
            services
                .AddMvc(options =>
                {
                    options.Filters.Add(typeof(GlobalExceptionFilter));
                        
                })
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore)
                .AddFluentValidation(f =>
                {
                    f.RegisterValidatorsFromAssemblyContaining<AddContactValidator>();
                    f.RegisterValidatorsFromAssemblyContaining<UploadImageValidator>();
                    f.RegisterValidatorsFromAssemblyContaining<AddAppointmentValidator>();
                    f.RegisterValidatorsFromAssemblyContaining<AppointmentStatusValidator>();
                    f.RegisterValidatorsFromAssemblyContaining<AppraisalValidator>();
                    f.RegisterValidatorsFromAssemblyContaining<MedicalCenterDataValidator>();
                    f.RegisterValidatorsFromAssemblyContaining<MedicalManDataValidator>();
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
            service.Configure<EmailConfiguration>(configuration.GetSection("EmailConfiguration"));
            service.Configure<EmailConfiguration>(configuration.GetSection("TwilioConfiguration"));

            return service;
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IContactsService, ContactsService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IMedicalManService, MedicalManService>();
            services.AddScoped<IMedicalCenterService, MedicalCenterService>();
            services.AddScoped<IMedicalDataService, MedicalDataService>();
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IAppraisalService, AppraisalService>();
            services.AddScoped<IImageService, ImageService>();

            return services;
        }

        public static IServiceCollection AddSystemServices(this IServiceCollection services)
        {
            services.AddScoped<IStorageService, DatabaseService>();
            services.AddScoped<IDataRetriever, DataRetriever>();
            services.AddScoped<ISessionResolver, HttpSessionResolver>();
            services.AddTransient<IAuthService, JWTService>();

            return services;
        }

        public static IServiceCollection AddHostedServices(this IServiceCollection services)
        {
            services.AddHostedService<DatabaseCleaner>();

            return services;
        }

        public static IServiceCollection AddCommunicationServices(this IServiceCollection services)
        {
            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<ICommunicationService, CommunicationService>();
            services.AddScoped<IRazorViewToStringRenderer, RazorViewToStringRenderer>();

            return services;
        }

        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            return services;
        }
    }
}
