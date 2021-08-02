namespace HealthCare.API.Workers
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Hosting;

    using DataLayer;
    using Microsoft.Extensions.DependencyInjection;

    public class DatabaseCleaner : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public DatabaseCleaner(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await ClearAppointmentHoursTable(stoppingToken);
        }

        private async Task ClearAppointmentHoursTable(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using var scope = _scopeFactory.CreateScope();
                var dbContext = scope.ServiceProvider.GetRequiredService<HealthCareDbContext>();

                //var hours = dbContext.AppointmentHours
                //    //.Where(x => x.AppointmentHour < DateTime.Now.AddHours(-12))
                //    .ToList();

                //dbContext.RemoveRange(hours);

                await dbContext.SaveChangesAsync();

                await Task.Delay(10000);
            }
        }
    }
}
