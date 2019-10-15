namespace HealthCare.BusinessLayer.Services
{
    using System.Linq;
    using System.Threading.Tasks;

    using Contracts.Interfaces;
    using Contracts.Models.Appointment.Requests;
    using Contracts.Models.Appointment.Responses;
    using DataLayer;
    using DataLayer.Entities;
    using Extensions;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Exceptions;

    public class AppointmentService : IAppointmentService
    {
        private readonly HealthCareDbContext _dbContext;
        private readonly ISessionResolver _sessionResolver;

        public AppointmentService(HealthCareDbContext dbContext, ISessionResolver sessionResolver)
        {
            _dbContext = dbContext;
            _sessionResolver = sessionResolver;
        }

        public async Task<RequestAppointmentResponse> RequestAppointment(RequestAppointmentRequest request)
        {
            var patientId = _sessionResolver.SessionInfo.UserId;

            //check if DoctorId belongs to doctor
            var doctorExists = _dbContext.Users.Any(x => x.Id == request.DoctorId && x.RoleType == RoleType.Doctor);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => !doctorExists);

            var newAppointment = new Appointment
            {
                PatientId = patientId,
                DoctorId = request.DoctorId, 
                AppointmentDate = request.AppointmentDate,
                Status = AppointmentStatus.Pending
            };

            _dbContext.PersistModel(newAppointment, DatabaseOperation.Insert);

            await _dbContext.SaveChangesAsync();

            return new RequestAppointmentResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public async Task<RequestAppointmentResponse> ChangeAppointmentStatus(ChangeAppointmentStatusRequest request)
        {
            var appointment = _dbContext.Appointments.SingleOrDefault(x => x.Id == request.Id);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => appointment == null);

            appointment.Status = request.Status;

            _dbContext.PersistModel(appointment, DatabaseOperation.Update);

            await _dbContext.SaveChangesAsync();

            return new RequestAppointmentResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }
    }
}
