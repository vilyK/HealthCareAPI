namespace HealthCare.DataLayer.Entities.User
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using MedicalCenter;
    using MedicalData;
    using MedicalMan;
    using Notification;
    using Pharmacy;
    using Utilities.Enums;

    public class User : SystemData
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string PasswordHash { get; set; }

        public string Secret { get; set; }

        public RoleType RoleType { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public User Parent { get; set; }

        public UserContact UserContact { get; set; }

        public MedicalManInfo MedicalManInfo { get; set; }

        public MedicalProfile MedicalProfile { get; set; }

        public MedicalCenterInfo MedicalCenter { get; set; }

        public List<Photo> Photos { get; set; } = new List<Photo>();

        public List<NotificationUser> UserNotifications { get; set; } = new List<NotificationUser>();

        public List<NotificationTypeUser> NotificationTypeUsers { get; set; } = new List<NotificationTypeUser>();

        [InverseProperty("Doctor")]
        public List<OutpatientCard> DoctorsOutpatientCards { get; set; } = new List<OutpatientCard>();

        [InverseProperty("Doctor")]
        public List<Appointment> DoctorAppointments { get; set; } = new List<Appointment>();

        [InverseProperty("Patient")]
        public List<Appointment> PatientAppointments { get; set; } = new List<Appointment>();

        [InverseProperty("Sender")]
        public List<AppraisalComment> SentAppraisalComments { get; set; } = new List<AppraisalComment>();

        [InverseProperty("Sender")]
        public List<Appraisal> SentAppraisals { get; set; } = new List<Appraisal>();

        [InverseProperty("Recipient")]
        public List<AppraisalComment> ReceivedAppraisalComments { get; set; } = new List<AppraisalComment>();

        [InverseProperty("Recipient")]
        public List<Appraisal> ReceivedAppraisals { get; set; } = new List<Appraisal>();

        [InverseProperty("Doctor")]
        public List<MedicalCenterDoctor> DoctorWorkPlaces { get; set; } = new List<MedicalCenterDoctor>();

        [InverseProperty("MedicalCenter")]
        public List<MedicalCenterDoctor> MedicalCenterEmployees { get; set; } = new List<MedicalCenterDoctor>();

        [InverseProperty("Distributor")]
        public List<PharmacyDistributor> DistributorsPerPharmacy { get; set; } = new List<PharmacyDistributor>();

        [InverseProperty("Pharmacy")]
        public List<PharmacyDistributor> PharmaciesPerDistributor { get; set; } = new List<PharmacyDistributor>();
    }
}
