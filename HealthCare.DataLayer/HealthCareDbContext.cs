namespace HealthCare.DataLayer
{
    using Microsoft.EntityFrameworkCore;

    using Configurations;
    using Entities.Event;
    using Entities.MedicalCenter;
    using Entities.MedicalData;
    using Entities.MedicalMan;
    using Entities.Notification;
    using Entities.Patient;
    using Entities.Pharmacy;
    using Entities.PharmacyCompany;
    using Entities.Tooltip;
    using Entities.UserAccount;
    using Entities.UserAccount.Contacts;
    using Interfaces;
    using Utils;

    public class HealthCareDbContext : DbContext
    {
        private readonly IDataRetriever _dataRetriever;

        public HealthCareDbContext(IDataRetriever dataRetriever)
        {
            _dataRetriever = dataRetriever;
        }

        public HealthCareDbContext(DbContextOptions options, IDataRetriever dataRetriever) : base(options)
        {
            _dataRetriever = dataRetriever;
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<UserContact> UserContacts { get; set; }

        public DbSet<Email> Emails { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Area> Areas { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Appraisal> Appraisals { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<NotificationUser> NotificationUsers { get; set; }

        public DbSet<NotificationTypeUser> NotificationTypeUsers { get; set; }

        public DbSet<NotificationType> NotificationTypes { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<MedicalManInfo> MedicalManInfos { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Specialty> Specialties { get; set; }

        public DbSet<MedicalManSpecialty> MedicalManSpecialties { get; set; }

        public DbSet<Award> Awards { get; set; }

        public DbSet<MedicalManPrice> MedicalManPrices { get; set; }

        public DbSet<AppointmentHours> AppointmentHours { get; set; }

        public DbSet<MedicalCenterInfo> MedicalCenterInfos { get; set; }

        public DbSet<MedicalCenterDepartment> MedicalCenterDepartments { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<PatientInfo> PatientInfos { get; set; }

        public DbSet<MedicalProfile> MedicalProfiles { get; set; }

        public DbSet<OutpatientCard> OutpatientCards { get; set; }

        public DbSet<MedicalTest> MedicalTests { get; set; }

        public DbSet<MedicalTestAttachment> MedicalTestAttachments { get; set; }

        public DbSet<MedicalTestType> MedicalTestTypes { get; set; }

        public DbSet<IllnessType> IllnessTypes { get; set; }

        public DbSet<IllnessCategory> IllnessCategories { get; set; }

        public DbSet<Allergy> Allergies { get; set; }

        public DbSet<AllergyType>   AllergyTypes { get; set; }

        public DbSet<Treatment> Treatments { get; set; }

        public DbSet<TreatmentMedicament> TreatmentMedicaments { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<MedicamentCategory> MedicamentCategories { get; set; }

        public DbSet<PharmacyCompanyInfo> PharmacyCompanyInfos { get; set; }

        public DbSet<PharmacyCompanyType> PharmacyCompanyTypes { get; set; }

        public DbSet<CompanyType> CompanyTypes { get; set; }

        public DbSet<MedicalCenterDoctor> MedicalCenterDoctors { get; set; }

        public DbSet<PharmacyInfo> PharmacyInfos { get; set; }

        public DbSet<PharmacyDistributor> PharmacyDistributors { get; set; }

        public DbSet<Tooltip> Tooltips { get; set; }

        public DbSet<TooltipItem> TooltipItems { get; set; }

        public DbSet<TooltipPhoto> TooltipPhotos { get; set; }

        public DbSet<TooltipType> TooltipTypes { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<AppraisalComment> AppraisalComments { get; set; }

        public DbSet<Referral> Referrals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);

            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new AppointmentConfig());

            modelBuilder.ApplyConfiguration(new AppraisalCommentConfig());

            modelBuilder.ApplyConfiguration(new AppraisalConfig());

            modelBuilder.ApplyConfiguration(new MedicalCenterDepartmentConfig());

            modelBuilder.ApplyConfiguration(new MedicalCenterDoctorConfig());

            modelBuilder.ApplyConfiguration(new MedicalManSpecialtyConfig());

            modelBuilder.ApplyConfiguration(new NotificationTypeUserConfig());

            modelBuilder.ApplyConfiguration(new NotificationUserConfig());

            modelBuilder.ApplyConfiguration(new OutpatientCardConfig());

            modelBuilder.ApplyConfiguration(new PharmacyCompanyTypeConfig());

            modelBuilder.ApplyConfiguration(new PharmacyDistributorConfig());

            modelBuilder.ApplyConfiguration(new ReferralConfig());

            modelBuilder.ApplyConfiguration(new TreatmentMedicamentConfig());

            modelBuilder.Seed(_dataRetriever);
        }
    }
}
