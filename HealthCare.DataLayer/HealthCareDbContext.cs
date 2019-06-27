namespace HealthCare.DataLayer
{
    using Configurations;
    using Entities;
    using Entities.Event;
    using Entities.MedicalCenter;
    using Entities.MedicalData;
    using Entities.MedicalMan;
    using Entities.Notification;
    using Entities.Patient;
    using Entities.Pharmacy;
    using Entities.PharmacyCompany;
    using Entities.Tooltip;
    using Entities.User;
    using Microsoft.EntityFrameworkCore;

    public class HealthCareDbContext : DbContext
    {
        public HealthCareDbContext()
        {
            
        }

        public HealthCareDbContext(DbContextOptions options)
            : base(options)
        {
            
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

        public DbSet<MedicalMenSpecialty> MedicalMenSpecialties { get; set; }

        public DbSet<Award> Awards { get; set; }

        public DbSet<PriceType> PricesType { get; set; }

        public DbSet<MedicalManInfoPrice> MedicalManInfoPrices { get; set; }

        public DbSet<MedicalCenterInfo> MedicalCenterInfos { get; set; }

        public DbSet<MedicalCenterDepartment> MedicalCenterDepartments { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<PatientInfo> PatientInfos { get; set; }

        public DbSet<MedicalProfile> MedicalProfiles { get; set; }

        public DbSet<OutpatientCard> OutpatientCards { get; set; }

        public DbSet<MedicalTest> MedicalTests { get; set; }

        public DbSet<MedicalTestAttachment> MedicalTestAttachments { get; set; }

        public DbSet<MedicalTestType> MedicalTestTypes { get; set; }

        public DbSet<Illness> Illnesses { get; set; }

        public DbSet<IllnessType> IllnessTypes { get; set; }

        public DbSet<IllnessCategory> IllnessCategories { get; set; }

        public DbSet<Allergy> Allergies { get; set; }

        public DbSet<AllergyType>   AllergyTypes { get; set; }

        public DbSet<MedicalProfileMedicalTest> MedicalProfileMedicalTests { get; set; }

        public DbSet<MedicalProfileAllergy> MedicalProfileAllergies { get; set; }

        public DbSet<MedicalProfileIllness> MedicalProfileIllnesses { get; set; }

        public DbSet<OutpatientCardAllergy> OutpatientCardAllergies { get; set; }

        public DbSet<OutpatientCardIllness> OutpatientCardIllnesses { get; set; }

        public DbSet<OutpatientCardMedicalTest> OutpatientCardMedicalTests { get; set; }

        public DbSet<Treatment> Treatments { get; set; }

        public DbSet<AllergyTreatment> AllergyTreatments { get; set; }
        public DbSet<IllnessTreatment> IllnessTreatments { get; set; }

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

            modelBuilder.ApplyConfiguration(new AllergyTreatmentConfig());

            modelBuilder.ApplyConfiguration(new IllnessTreatmentConfig());

            modelBuilder.ApplyConfiguration(new MedicalCenterDepartmentConfig());

            modelBuilder.ApplyConfiguration(new MedicalCenterDoctorConfig());

            modelBuilder.ApplyConfiguration(new MedicalManInfoPriceConfig());

            modelBuilder.ApplyConfiguration(new MedicalMenSpecialtyConfig());

            modelBuilder.ApplyConfiguration(new MedicalProfileAllergyConfig());

            modelBuilder.ApplyConfiguration(new MedicalProfileMedicalTestConfig());

            modelBuilder.ApplyConfiguration(new NotificationTypeUserConfig());

            modelBuilder.ApplyConfiguration(new NotificationUserConfig());

            modelBuilder.ApplyConfiguration(new OutpatientCardAllergyConfig());

            modelBuilder.ApplyConfiguration(new OutpatientCardIllnessConfig());

            modelBuilder.ApplyConfiguration(new OutpatientCardMedicalTestConfig());

            modelBuilder.ApplyConfiguration(new PharmacyCompanyTypeConfig());

            modelBuilder.ApplyConfiguration(new PharmacyDistributorConfig());

            modelBuilder.ApplyConfiguration(new TreatmentMedicamentConfig());

            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());

            modelBuilder.ApplyConfiguration(new AppraisalConfiguration());

            modelBuilder.ApplyConfiguration(new OutpatientCardConfiguration());
        }
    }
}
