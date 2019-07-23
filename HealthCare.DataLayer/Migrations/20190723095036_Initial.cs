using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCare.DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllergyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    EventDate = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IllnessCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IllnessCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalTestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalTestTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicamentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    ReasonType = table.Column<int>(nullable: false),
                    NotificationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PricesType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricesType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TooltipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TooltipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoleType = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    AllergyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Allergies_AllergyTypes_AllergyTypeId",
                        column: x => x.AllergyTypeId,
                        principalTable: "AllergyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IllnessTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IllnessCategoryId = table.Column<int>(nullable: false),
                    OtherName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IllnessTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IllnessTypes_IllnessCategories_IllnessCategoryId",
                        column: x => x.IllnessCategoryId,
                        principalTable: "IllnessCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tooltips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    TooltipTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tooltips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tooltips_TooltipTypes_TooltipTypeId",
                        column: x => x.TooltipTypeId,
                        principalTable: "TooltipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    AppointmentDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Reason = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appraisals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    RecipientId = table.Column<int>(nullable: false),
                    SenderId = table.Column<int>(nullable: false),
                    AppraisalType = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    AppraisalDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appraisals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appraisals_Users_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appraisals_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCenterDoctors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    MedicalCenterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCenterDoctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCenterDoctors_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterDoctors_Users_MedicalCenterId",
                        column: x => x.MedicalCenterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCenterInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    IsNzok = table.Column<bool>(nullable: false),
                    HasEmergency = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCenterInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCenterInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalManInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Biography = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    IsNzok = table.Column<bool>(nullable: false),
                    MedicalCenterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalManInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalManInfos_Users_MedicalCenterId",
                        column: x => x.MedicalCenterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypeUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    NotificationTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypeUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationTypeUsers_NotificationTypes_NotificationTypeId",
                        column: x => x.NotificationTypeId,
                        principalTable: "NotificationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificationTypeUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotificationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    NotificationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificationUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutpatientCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Results = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutpatientCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutpatientCards_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutpatientCards_Users_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PharmacyCompanyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    PharmacyCompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyCompanyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PharmacyCompanyInfos_Users_PharmacyCompanyId",
                        column: x => x.PharmacyCompanyId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PharmacyDistributors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    PharmacyId = table.Column<int>(nullable: false),
                    DistributorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyDistributors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PharmacyDistributors_Users_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PharmacyDistributors_Users_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PharmacyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PharmacyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PharmacyInfos_Users_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserContacts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllergyTreatments",
                columns: table => new
                {
                    AllergyId = table.Column<int>(nullable: false),
                    TreatmentId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyTreatments", x => new { x.AllergyId, x.TreatmentId });
                    table.ForeignKey(
                        name: "FK_AllergyTreatments_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AllergyTreatments_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Illness",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IllnessTypeId = table.Column<int>(nullable: false),
                    IllnessPeriod = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illness", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Illness_IllnessTypes_IllnessTypeId",
                        column: x => x.IllnessTypeId,
                        principalTable: "IllnessTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Illnesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IllnessTypeId = table.Column<int>(nullable: false),
                    IllnessPeriod = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illnesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Illnesses_IllnessTypes_IllnessTypeId",
                        column: x => x.IllnessTypeId,
                        principalTable: "IllnessTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TooltipItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    TooltipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TooltipItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TooltipItems_Tooltips_TooltipId",
                        column: x => x.TooltipId,
                        principalTable: "Tooltips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCenterDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    MedicalCenterId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCenterDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCenterDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterDepartments_MedicalCenterInfos_MedicalCenterId",
                        column: x => x.MedicalCenterId,
                        principalTable: "MedicalCenterInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Results = table.Column<string>(nullable: true),
                    MedicalTestDate = table.Column<DateTime>(nullable: false),
                    MedicalCenterId = table.Column<int>(nullable: false),
                    MedicalTestTypeId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalTests_MedicalCenterInfos_MedicalCenterId",
                        column: x => x.MedicalCenterId,
                        principalTable: "MedicalCenterInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalTests_MedicalTestTypes_MedicalTestTypeId",
                        column: x => x.MedicalTestTypeId,
                        principalTable: "MedicalTestTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Awards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Year = table.Column<DateTime>(nullable: false),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    MedManInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Awards_MedicalManInfos_MedManInfoId",
                        column: x => x.MedManInfoId,
                        principalTable: "MedicalManInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalManInfoPrices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    MedManInfoId = table.Column<int>(nullable: false),
                    PriceTypeId = table.Column<int>(nullable: false),
                    Value = table.Column<decimal>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalManInfoPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalManInfoPrices_MedicalManInfos_MedManInfoId",
                        column: x => x.MedManInfoId,
                        principalTable: "MedicalManInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalManInfoPrices_PricesType_PriceTypeId",
                        column: x => x.PriceTypeId,
                        principalTable: "PricesType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalMenSpecialties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    MedMenInfoId = table.Column<int>(nullable: false),
                    SpecialtyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalMenSpecialties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalMenSpecialties_MedicalManInfos_MedMenInfoId",
                        column: x => x.MedMenInfoId,
                        principalTable: "MedicalManInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalMenSpecialties_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: false),
                    MedicalMedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_MedicalManInfos_MedicalMedId",
                        column: x => x.MedicalMedId,
                        principalTable: "MedicalManInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutpatientCardAllergies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    AllergyId = table.Column<int>(nullable: false),
                    OutpatientCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutpatientCardAllergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutpatientCardAllergies_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutpatientCardAllergies_OutpatientCards_OutpatientCardId",
                        column: x => x.OutpatientCardId,
                        principalTable: "OutpatientCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    PhysicalActivityLevel = table.Column<int>(nullable: false),
                    StressLevel = table.Column<int>(nullable: false),
                    BloodGroup = table.Column<int>(nullable: false),
                    PatientInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalProfiles_PatientInfos_PatientInfoId",
                        column: x => x.PatientInfoId,
                        principalTable: "PatientInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    PharmacyCompanyInfoId = table.Column<int>(nullable: false),
                    PharmacyCompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicaments_MedicamentCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MedicamentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicaments_PharmacyCompanyInfos_PharmacyCompanyId",
                        column: x => x.PharmacyCompanyId,
                        principalTable: "PharmacyCompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PharmacyCompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    PharmacyCompanyInfoId = table.Column<int>(nullable: false),
                    CompanyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyCompanyTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PharmacyCompanyTypes_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PharmacyCompanyTypes_PharmacyCompanyInfos_PharmacyCompanyInfoId",
                        column: x => x.PharmacyCompanyInfoId,
                        principalTable: "PharmacyCompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IsCurrent = table.Column<bool>(nullable: false),
                    BlockEntrance = table.Column<string>(nullable: true),
                    Entrance = table.Column<string>(nullable: true),
                    Floor = table.Column<int>(nullable: false),
                    FlatNumber = table.Column<int>(nullable: false),
                    StreetName = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    UserContactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_UserContacts_UserContactId",
                        column: x => x.UserContactId,
                        principalTable: "UserContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    UserContactId = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_UserContacts_UserContactId",
                        column: x => x.UserContactId,
                        principalTable: "UserContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    UserContactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_UserContacts_UserContactId",
                        column: x => x.UserContactId,
                        principalTable: "UserContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IllnessTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IllnessId = table.Column<int>(nullable: false),
                    TreatmentId = table.Column<int>(nullable: false),
                    PatientIllnessId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IllnessTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IllnessTreatments_Illness_IllnessId",
                        column: x => x.IllnessId,
                        principalTable: "Illness",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IllnessTreatments_Illnesses_PatientIllnessId",
                        column: x => x.PatientIllnessId,
                        principalTable: "Illnesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IllnessTreatments_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutpatientCardIllnesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IllnessId = table.Column<int>(nullable: false),
                    OutpatientCardId = table.Column<int>(nullable: false),
                    PatientIllnessId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutpatientCardIllnesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutpatientCardIllnesses_Illness_IllnessId",
                        column: x => x.IllnessId,
                        principalTable: "Illness",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutpatientCardIllnesses_OutpatientCards_OutpatientCardId",
                        column: x => x.OutpatientCardId,
                        principalTable: "OutpatientCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutpatientCardIllnesses_Illnesses_PatientIllnessId",
                        column: x => x.PatientIllnessId,
                        principalTable: "Illnesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TooltipPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    ToolTipItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TooltipPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TooltipPhotos_TooltipItems_ToolTipItemId",
                        column: x => x.ToolTipItemId,
                        principalTable: "TooltipItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalTestAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    MedicalTestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalTestAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalTestAttachments_MedicalTests_MedicalTestId",
                        column: x => x.MedicalTestId,
                        principalTable: "MedicalTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutpatientCardMedicalTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    MedicalTestId = table.Column<int>(nullable: false),
                    OutpatientCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutpatientCardMedicalTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutpatientCardMedicalTests_MedicalTests_MedicalTestId",
                        column: x => x.MedicalTestId,
                        principalTable: "MedicalTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutpatientCardMedicalTests_OutpatientCards_OutpatientCardId",
                        column: x => x.OutpatientCardId,
                        principalTable: "OutpatientCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProfileAllergies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    AllergyId = table.Column<int>(nullable: false),
                    MedicalProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProfileAllergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalProfileAllergies_Allergies_AllergyId",
                        column: x => x.AllergyId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalProfileAllergies_MedicalProfiles_MedicalProfileId",
                        column: x => x.MedicalProfileId,
                        principalTable: "MedicalProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProfileIllnesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IllnessId = table.Column<int>(nullable: false),
                    MedicalProfileId = table.Column<int>(nullable: false),
                    PatientIllnessId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProfileIllnesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalProfileIllnesses_Illness_IllnessId",
                        column: x => x.IllnessId,
                        principalTable: "Illness",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalProfileIllnesses_MedicalProfiles_MedicalProfileId",
                        column: x => x.MedicalProfileId,
                        principalTable: "MedicalProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalProfileIllnesses_Illnesses_PatientIllnessId",
                        column: x => x.PatientIllnessId,
                        principalTable: "Illnesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProfileMedicalTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    MedicalTestId = table.Column<int>(nullable: false),
                    MedicalProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProfileMedicalTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalProfileMedicalTests_MedicalProfiles_MedicalProfileId",
                        column: x => x.MedicalProfileId,
                        principalTable: "MedicalProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalProfileMedicalTests_MedicalTests_MedicalTestId",
                        column: x => x.MedicalTestId,
                        principalTable: "MedicalTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentMedicaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    TreatmentId = table.Column<int>(nullable: false),
                    MedicamentId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentMedicaments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreatmentMedicaments_Medicaments_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TreatmentMedicaments_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AllergyTypes",
                columns: new[] { "Id", "CreateDate", "Description", "IsDeleted", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 23, 12, 50, 35, 891, DateTimeKind.Local).AddTicks(4199), null, false, "Хранителни алергии", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 7, 23, 12, 50, 35, 893, DateTimeKind.Local).AddTicks(2141), null, false, "Лекарствени алергии", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2019, 7, 23, 12, 50, 35, 893, DateTimeKind.Local).AddTicks(4277), null, false, "Алергии към отровата на насекоми", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2019, 7, 23, 12, 50, 35, 893, DateTimeKind.Local).AddTicks(5733), null, false, "Алергии към животни", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2019, 7, 23, 12, 50, 35, 893, DateTimeKind.Local).AddTicks(5984), null, false, "Алергии към фактори на околната среда", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 12, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8026), false, "Велико Търново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7996), false, "Стара Загора", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7962), false, "Разград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7929), false, "Кюстендил", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7899), false, "Варна", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7722), false, "Бургас", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7833), false, "Кърджали", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8057), false, "Ловеч", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7688), false, "София", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7645), false, "Плевен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7344), false, "Добрич", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(7869), false, "Пловдив", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8087), false, "Русе", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8148), false, "Видин", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2019, 7, 23, 12, 50, 35, 851, DateTimeKind.Local).AddTicks(4493), false, "Благоевград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8179), false, "Монтана", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8213), false, "Силистра", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8246), false, "Хасково", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8279), false, "Враца", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8313), false, "Пазарджик", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8342), false, "Сливен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8373), false, "Шумен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8403), false, "Габрово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8433), false, "Перник", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8471), false, "Смолян", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8501), false, "Ямбол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2019, 7, 23, 12, 50, 35, 887, DateTimeKind.Local).AddTicks(8118), false, "Търговище", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 23, 12, 50, 35, 904, DateTimeKind.Local).AddTicks(6873), false, "България", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 7, 23, 12, 50, 35, 905, DateTimeKind.Local).AddTicks(9305), false, "САЩ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessCategories",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 10, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8885), false, "Имунна система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2019, 7, 23, 12, 50, 35, 908, DateTimeKind.Local).AddTicks(9571), false, "Нервната система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8632), false, "Сетивните органи", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8744), false, "Сърдечносъдова система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8773), false, "Опорно-двигателна система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8790), false, "Храносмилателна система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8813), false, "Дихателна система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8830), false, "Кожа и кожни придатъци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8846), false, "Пикочно-полова система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8865), false, "Кръвоносна и лимфна система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2019, 7, 23, 12, 50, 35, 909, DateTimeKind.Local).AddTicks(8904), false, "Ендокринна система", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MedicamentCategories",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name", "UpdateDate" },
                values: new object[] { 1, new DateTime(2019, 7, 23, 12, 50, 35, 956, DateTimeKind.Local).AddTicks(4051), false, "Example", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 13, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4569), false, "Детски нефролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4596), false, "Детски психиатър", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4624), false, "Детски пулмолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(6048), false, "Уролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4790), false, "Диетолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5990), false, "Хирург", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5960), false, "Хематолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4541), false, "Детски невролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(6018), false, "Хомеопат", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4510), false, "Детски кардиолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4337), false, "Анестезиолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4463), false, "Детски гастроентеролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4441), false, "Гръден хирург", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4418), false, "Гастроентеролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4391), false, "Вътрешни болести", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4360), false, "Боуен терапевт", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5929), false, "Фониатър", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4296), false, "Ангиолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4195), false, "Алерголог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2019, 7, 23, 12, 50, 35, 961, DateTimeKind.Local).AddTicks(5656), false, "Акушер-гинеколог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4486), false, "Детски ендокринолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5897), false, "Физиотерапевт", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5869), false, "Уролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5840), false, "УНГ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5210), false, "Общопрактикуващ лекар", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5181), false, "Нефролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5154), false, "Неонатолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5126), false, "Неврохирург", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5097), false, "Невролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5069), false, "Мамолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5237), false, "Озонотерапевт", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5039), false, "Лицево-челюстен хирург", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4981), false, "Кинезитерапевт", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4938), false, "Кардиохирург", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4910), false, "Кардиолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4875), false, "Инфекциозни болести", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4847), false, "Естетичен дерматолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4819), false, "Ендокринолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5012), false, "Клинична генетика", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4755), false, "Детски хирург", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5273), false, "Онколог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5344), false, "Ортопед", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5812), false, "Съдов хирург", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5783), false, "Стоматолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5754), false, "Спортна медицина", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5729), false, "Рентгенолог (Образна диагностика)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5707), false, "Ревматолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5684), false, "Пулмолог (Белодробни болести)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(4653), false, "Детски ревматолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5654), false, "Психотерапевт", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5526), false, "Психиатър", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5489), false, "Пластичен хирург", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5459), false, "Педиатър", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5439), false, "Паразитолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5411), false, "Офталмолог (Очен лекар)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5379), false, "Отоневролог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5563), false, "Психолог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2019, 7, 23, 12, 50, 35, 962, DateTimeKind.Local).AddTicks(5308), false, "Ортодонт", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "AreaId", "CountryId", "CreateDate", "IsDeleted", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 251, 27, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4674), false, "Ямбол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9899), false, "Раковски", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9865), false, "Първомай", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9831), false, "Пловдив", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9795), false, "Перущица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9678), false, "Лъки", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9644), false, "Куклен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9611), false, "Кричим", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9577), false, "Клисура", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9543), false, "Карлово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9507), false, "Калофер", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9473), false, "Брезово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9438), false, "Баня", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9404), false, "Асеновград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, 6, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9371), false, "Момчилград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, 6, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9337), false, "Кърджали", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, 6, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9303), false, "Крумовград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, 6, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9269), false, "Джебел", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, 6, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9235), false, "Ардино", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9202), false, "Черноморец", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9167), false, "Царево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9132), false, "Сунгурларе", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9098), false, "Средец", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9064), false, "Созопол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9028), false, "Свети Влас", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8992), false, "Приморско", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8916), false, "Поморие", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8881), false, "Обзор", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9933), false, "Садово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(9967), false, "Сопот", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1), false, "Стамболийски", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, 7, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(102), false, "Съединение", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1111), false, "Мъглиж", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1088), false, "Крън", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1065), false, "Казанлък", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1042), false, "Гълъбово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1019), false, "Гурково", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, 10, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(996), false, "Цар Калоян", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, 10, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(974), false, "Разград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, 10, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(953), false, "Лозница", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, 10, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(930), false, "Кубрат", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, 10, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(907), false, "Исперих", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, 9, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(885), false, "Завет", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, 9, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(863), false, "Рила", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, 9, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(840), false, "Кюстендил", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8847), false, "Несебър", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, 9, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(818), false, "Кочериново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, 9, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(751), false, "Бобошево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, 9, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(643), false, "Бобов дол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(605), false, "Суворово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(568), false, "Провадия", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(530), false, "Игнатиево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(495), false, "Дългопол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(452), false, "Долни чифлик", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(415), false, "Девня", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(376), false, "Вълчи дол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(336), false, "Варна", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(299), false, "Бяла", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(259), false, "Белослав", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, 8, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(185), false, "Аксаково", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, 9, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(794), false, "Дупница", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8813), false, "Малко Търново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8778), false, "Китен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8744), false, "Карнобат", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7511), false, "Плевен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7475), false, "Левски", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7441), false, "Койнаре", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7407), false, "Кнежа", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7373), false, "Искър", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7339), false, "Долни Дъбник", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7305), false, "Долна Митрополия", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7270), false, "Гулянци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7236), false, "Белене", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 2, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7202), false, "Шабла", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 2, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7168), false, "Тервел", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 2, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7132), false, "Каварна", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 2, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7098), false, "Добрич", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7548), false, "Пордим", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 2, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7045), false, "Генерал Тошево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6974), false, "Якоруда", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6939), false, "Хаджидимово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6904), false, "Симитли", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6868), false, "Сандански", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 252, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6772), false, "Петрич", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6738), false, "Мелник", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6705), false, "Разлог", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6670), false, "Кресна", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6634), false, "Добринище", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6598), false, "Гоце Делчев", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6555), false, "Благоевград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(6385), false, "Белица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 898, DateTimeKind.Local).AddTicks(8519), false, "Банско", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 2, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7009), false, "Балчик", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1133), false, "Николаево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7623), false, "Славяново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7692), false, "Банкя", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8710), false, "Камено", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8675), false, "Каблешково", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8641), false, "Българово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8606), false, "Бургас", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8572), false, "Ахтопол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8531), false, "Ахелой", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 5, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8496), false, "Айтос", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8462), false, "Сливница", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8427), false, "Своге", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8393), false, "Самоков", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8358), false, "Правец", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8323), false, "Пирдоп", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8246), false, "Момин проход", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 3, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7658), false, "Тръстеник", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8212), false, "Костинброд", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8144), false, "Копривщица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8109), false, "Ихтиман", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8075), false, "Златица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8039), false, "Етрополе", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8004), false, "Елин Пелин", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7969), false, "Драгоман", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7934), false, "Долна баня", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7900), false, "Годеч", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7866), false, "Ботевград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7831), false, "Божурище", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7797), false, "София", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7763), false, "Нови Искър", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(7727), false, "Бухово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 4, 1, new DateTime(2019, 7, 23, 12, 50, 35, 900, DateTimeKind.Local).AddTicks(8178), false, "Костенец", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1155), false, "Павел баня", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 250, 27, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4650), false, "Стралджа", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1200), false, "Стара Загора", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 217, 22, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3620), false, "Нова Загора", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 216, 22, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3583), false, "Котел", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 215, 22, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3552), false, "Кермен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 214, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3511), false, "Сърница", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 213, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3470), false, "Стрелча", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 212, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3447), false, "Септември", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 211, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3423), false, "Ракитово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 210, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3400), false, "Пещера", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 209, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3376), false, "Панагюрище", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 208, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3354), false, "Пазарджик", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 207, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3331), false, "Костандово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 206, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3308), false, "Ветрен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 205, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3278), false, "Велинград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 204, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3145), false, "Брацигово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 203, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3122), false, "Белово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 202, 21, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3100), false, "Батак", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 201, 20, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3077), false, "Роман", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 200, 20, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3054), false, "Оряхово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 199, 20, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3031), false, "Мизия", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 198, 20, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3008), false, "Мездра", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 197, 20, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2985), false, "Криводол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 196, 20, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2962), false, "Козлодуй", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 195, 20, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2939), false, "Враца", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 194, 20, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2916), false, "Бяла Слатина", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 193, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2894), false, "Хасково", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 192, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2871), false, "Харманли", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 191, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2849), false, "Тополовград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 218, 22, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3655), false, "Сливен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 219, 22, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3695), false, "Твърдица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 220, 22, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3727), false, "Шивачево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 221, 23, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3762), false, "Велики Преслав", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1178), false, "Раднево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 249, 27, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4627), false, "Елхово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 248, 27, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4604), false, "Болярово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 247, 26, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4580), false, "Чепеларе", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 246, 26, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4493), false, "Смолян", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 245, 26, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4470), false, "Рудозем", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 244, 26, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4447), false, "Неделино", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 243, 26, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4425), false, "Мадан", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 242, 26, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4402), false, "Златоград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 241, 26, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4380), false, "Доспат", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 340, 26, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4358), false, "Девин", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 239, 25, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4335), false, "Трън", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 238, 25, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4313), false, "Радомир", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 190, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2827), false, "Симеоновград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 237, 25, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4290), false, "Перник", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 234, 25, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4219), false, "Батановци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 233, 24, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4197), false, "Трявна", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 232, 24, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4173), false, "Севлиево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 231, 24, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4150), false, "Плачковци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 230, 24, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4128), false, "Дряново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 229, 24, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4106), false, "Габрово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 228, 23, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4084), false, "Шумен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 227, 23, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4061), false, "Смядово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 226, 23, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4030), false, "Плиска", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 225, 23, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3898), false, "Нови пазар", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 224, 23, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3865), false, "Каспичан", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 223, 23, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3828), false, "Каолиново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 222, 23, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(3794), false, "Върбица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 235, 25, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4242), false, "Брезник", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 189, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2804), false, "Свиленград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 236, 25, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(4265), false, "Земен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 187, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2758), false, "Маджарово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1937), false, "Глоджево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 153, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1914), false, "Ветово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 152, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1892), false, "Бяла", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1869), false, "Борово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 150, 13, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1846), false, "Ябланица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, 13, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1823), false, "Угърчин", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, 13, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1801), false, "Троян", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, 13, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1778), false, "Тетевен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, 13, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1750), false, "Луковит", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, 13, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1727), false, "Ловеч", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, 13, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1704), false, "Летница", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, 13, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1680), false, "Априлци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1626), false, "Сухиндол", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 155, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1960), false, "Две могили", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1603), false, "Стражица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1558), false, "Полски Тръмбеш", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1535), false, "Павликени", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1513), false, "Лясковец", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1491), false, "Килифарево", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1468), false, "Златарица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1420), false, "Долна Оряховица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1397), false, "Дебелец", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1374), false, "Горна Оряховица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1352), false, "Велико Търново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1328), false, "Бяла черква", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1301), false, "Шипка", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 188, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2781), false, "Меричлери", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, 11, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1222), false, "Чирпан", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1581), false, "Свищов", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 156, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1983), false, "Мартен", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, 12, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(1446), false, "Елена", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 158, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2028), false, "Сеново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 185, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2710), false, "Ивайловград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2005), false, "Русе", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 186, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2736), false, "Любимец", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 184, 19, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2656), false, "Димитровград", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 183, 18, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2633), false, "Тутракан", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 182, 18, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2610), false, "Силистра", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 180, 18, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2564), false, "Главиница", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 179, 18, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2541), false, "Алфатар", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 178, 17, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2519), false, "Чипровци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 177, 17, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2496), false, "Монтана", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 176, 17, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2473), false, "Лом", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 175, 17, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2450), false, "Вършец", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 174, 17, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2428), false, "Вълчедръм", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 173, 17, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2405), false, "Брусарци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 181, 18, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2587), false, "Дулово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 172, 17, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2381), false, "Бойчиновци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 161, 15, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2098), false, "Омуртаг", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, 14, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2051), false, "Сливо поле", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 162, 15, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2120), false, "Опака", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 164, 16, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2200), false, "Белоградчик", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 165, 16, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2223), false, "Брегово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 166, 16, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2245), false, "Видин", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 163, 15, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2142), false, "Попово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 167, 16, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2267), false, "Грамада", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 168, 16, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2290), false, "Димово", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 169, 16, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2313), false, "Дунавци", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 170, 16, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2336), false, "Кула", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 171, 17, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2358), false, "Берковица", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 160, 15, 1, new DateTime(2019, 7, 23, 12, 50, 35, 901, DateTimeKind.Local).AddTicks(2075), false, "Антоново", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 2362, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1448), 7, false, "Лихен нитидус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2369, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1694), 7, false, "Пемфигус вулгарис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2363, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1484), 7, false, "Лихен стриатус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2364, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1530), 7, false, "Лихен рубер монилиформис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2365, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1576), 7, false, "Папулозен акродерматит в детска възраст (Gianotti-Crosti)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2366, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1606), 7, false, "Други уточнени папулосквамозни увреждания", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2367, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1629), 7, false, "Папулосквамозно увреждане, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2368, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1660), 7, false, "Папулосквамозни увреждания при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2361, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1420), 7, false, "Питириазис рубра пиларис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2374, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1867), 7, false, "Пемфигус, предизвикан от лекарствени средства", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2371, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1781), 7, false, "Пемфигус фолиацеус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2372, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1809), 7, false, "Пемфигус бразилиензис (fogo selvagem)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2373, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1838), 7, false, "Пемфигус еритематозус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2380, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2068), 7, false, "Акантолитични увреждания, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2375, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1899), 7, false, "Други видове пемфигус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2376, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1926), 7, false, "Пемфигус, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2377, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1959), 7, false, "Придобита фоликуларна кератоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2378, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2006), 7, false, "Преходна акантолитична дерматоза (Grover)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2360, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1392), 7, false, "Лихен планус, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2379, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2045), 7, false, "Други уточнени акантолитични увреждания", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2370, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1737), 7, false, "Пемфигус вегетанс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2359, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1358), 7, false, "Други форми на лихен планус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2346, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(296), 7, false, "Pityriasis lichenoides et varioliformis acuta", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2357, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1202), 7, false, "Лихеноидна лекарствена реакция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2336, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9912), 7, false, "Еритематозно състояние, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2381, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2108), 7, false, "Дерматитис херпетиформис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2337, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9961), 7, false, "Еритем при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2338, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(47), 7, false, "Псориазис вулгарис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2339, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(85), 7, false, "Генерализиран пустулозен псориазис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2340, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(115), 7, false, "Акродерматитис континуа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2341, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(147), 7, false, "Палмоплантарна пустулоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2342, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(175), 7, false, "Гутатен псориазис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2343, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(204), 7, false, "Артропатичен псориазис (M07.0-M07.3*, M09.0*)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2344, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(234), 7, false, "Други видове псориазис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2345, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(265), 7, false, "Псориазис, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2347, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(327), 7, false, "Pityriasis lichenoides chronica", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2348, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(363), 7, false, "Лимфоматоидна папулоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2349, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(392), 7, false, "Парапсориазис с малки плаки", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2350, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(422), 7, false, "Парапсориазис с големи плаки", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2351, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(995), 7, false, "Мрежовиден парапсориазис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2352, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1041), 7, false, "Други форми на парапсориазис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2353, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1073), 7, false, "Парапсориазис, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2354, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1103), 7, false, "Питириазис розеа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2355, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1133), 7, false, "Хипертрофичен лихен планус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2356, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1164), 7, false, "Булозен лихен планус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2358, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(1233), 7, false, "Подостър (активен) лихен планус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2382, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2218), 7, false, "Субкорнеален пустулозен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 2412, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4411), 7, false, "Целулит с други локализации", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2384, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2306), 7, false, "Булозни увреждания, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2410, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4298), 7, false, "Целулит на лицето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2411, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4371), 7, false, "Целулит на торса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2413, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4443), 7, false, "Целулит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2414, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4474), 7, false, "Остър лимфаденит на лицето, главата и шията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2415, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4505), 7, false, "Остър лимфаденит на торса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2416, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4535), 7, false, "Остър лимфаденит на горните крайници", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2417, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4565), 7, false, "Остър лимфаденит на долните крайници", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2418, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4594), 7, false, "Остър лимфаденит с други локализации", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2419, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4625), 7, false, "Остър лимфаденит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2420, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4657), 7, false, "Пилонидална киста с абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2421, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4686), 7, false, "Пилонидална киста без абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2422, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4715), 7, false, "Други локални инфекции на кожата и подкожната тъкан", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2423, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4788), 7, false, "Пиодермия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2424, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4817), 7, false, "Еритразма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2425, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4845), 7, false, "Локална инфекция на кожата и подкожната тъкан, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2426, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4873), 7, false, "Доброкачествени новообразия на устната", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2427, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4901), 7, false, "Доброкачествени новообразия на клепача, включително ъгъла на клепачната цепка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2428, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4935), 7, false, "Доброкачествени новообразия на ухото и външния слухов канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2429, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4964), 7, false, "Доброкачествени новообразия на други и неуточнени части на лицето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2430, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4993), 7, false, "Доброкачествени новообразия на окосмената част на главата и шията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2335, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9726), 7, false, "Други уточнени еритематозни състояния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2409, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4267), 7, false, "Целулит на други части на крайниците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2383, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2265), 7, false, "Други уточнени булозни увреждания", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2408, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4237), 7, false, "Целулит на пръст на ръцете и краката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2406, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4179), 7, false, "Импетиго", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2385, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2347), 7, false, "Злокачествено новообразувание на кожа на устните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2386, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2387), 7, false, "Злокачествените новообразувания на кожа на клепачите, включително ъглите на клепачните цепки", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2387, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2430), 7, false, "Злокачествените новообразувания на кожа на ухото и външния слухов канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2388, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2471), 7, false, "Злокачествените новообразувания на кожа на други и неуточнени части на лицето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2389, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2513), 7, false, "Злокачествените новообразувания на кожа на окосмената част на главата и шията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2390, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2559), 7, false, "Злокачествените новообразувания на кожа на тялото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2391, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(2636), 7, false, "Злокачествените новообразувания на кожа на горен крайник, включително областта на раменния пояс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2392, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3301), 7, false, "Злокачествените новообразувания на кожа на долен крайник, включително тазобедрената област", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2393, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3387), 7, false, "Лезия, излизаща извън границите на една и повече посочени локализации на кожата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2394, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3433), 7, false, "Злокачествено новообразувание на кожата, с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2395, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3479), 7, false, "Злокачествен меланом на устната", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2396, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3523), 7, false, "Злокачествен меланом на клепача, включително ъгъла на клепачната цепка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2397, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3685), 7, false, "Злокачествен меланом на ухото и външния слухов канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2398, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3744), 7, false, "Злокачествен меланом на други и неуточнени части на лицето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2399, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3791), 7, false, "Злокачествен меланом на окосмената част на главата и шията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2400, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3827), 7, false, "Злокачествен меланом на тялото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2401, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3930), 7, false, "Злокачествен меланом на горен крайник, включително областта на раменния пояс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2402, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(3974), 7, false, "Злокачествен меланом на долен крайник, включително тазобедрената област", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2403, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4027), 7, false, "Лезия, излизаща извън границите на една и повече посочени локализации на злокачествения меланом на кожата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2404, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4071), 7, false, "Злокачествен меланом на кожата, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2405, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4143), 7, false, "Стафилококов синдром на изгорената кожа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2407, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(4208), 7, false, "Абсцес на кожата, фурункул и карбункул", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2334, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9695), 7, false, "Други хронични фигурирани еритеми", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2273, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7690), 7, false, "Милиариа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2332, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9632), 7, false, "Erythema annulare centrifugum", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2262, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7291), 7, false, "Стеатоцистома мултиплекс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2263, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7321), 7, false, "Други фоликуларни кисти на кожата и подкожната тъкан", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2264, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7354), 7, false, "Фоликуларна киста на кожата и подкожната тъкан, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2265, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7385), 7, false, "Акне келоид", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2266, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7413), 7, false, "Псевдофоликулит на космите на брадата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2267, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7443), 7, false, "Гноен хидраденит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2268, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7473), 7, false, "Други уточнени фоликуларни увреждания", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2269, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7561), 7, false, "Фоликуларно увреждане, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2270, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7597), 7, false, "Милиариа рубра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2261, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7256), 7, false, "Триходермална киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2271, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7628), 7, false, "Милиариа кристалина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2431, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5021), 7, false, "Доброкачествени новообразия на тялото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2274, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7722), 7, false, "Анхидроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2275, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7751), 7, false, "Други болести на екринните потни жлези (СТАФИЛОКОКОВИ ИНФЕКЦИИ НА ПОТНИТЕ ЖЛЕЗИ)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2276, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7781), 7, false, "Болест на екринните потни жлези, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2277, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7811), 7, false, "Бромхидроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2278, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7842), 7, false, "Хромхидроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2279, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7876), 7, false, "Апокринен милиум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2280, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7907), 7, false, "Други болести на апокринните потни жлези", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2281, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7938), 7, false, "Болест на апокринните потни жлези, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2272, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7659), 7, false, "Милиариа профунда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2260, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7225), 7, false, "Епидермална киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2259, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7194), 7, false, "Розацея, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2258, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7165), 7, false, "Други форми на розацея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2237, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6419), 7, false, "Цикатрициална алопеция, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2238, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6449), 7, false, "Трихорексис нодоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2239, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6478), 7, false, "Промени в цвета на косата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2240, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6511), 7, false, "Други аномалии в цвета на косата и косъма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2241, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6542), 7, false, "Аномалия в цвета на косата и косъма, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2242, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6577), 7, false, "Хирзутизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2243, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6609), 7, false, "Придобита ланугинозна хипертрихоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2244, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6641), 7, false, "Локализирана хипертрихоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2245, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6767), 7, false, "Политрихия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2246, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6801), 7, false, "Други форми на хипертрихоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2247, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6830), 7, false, "Хипертрихоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2248, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6860), 7, false, "Акне вулгарис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2249, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6891), 7, false, "Акне конглобата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2250, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6920), 7, false, "Акне вариолиформис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2251, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6951), 7, false, "Акне тропика", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2252, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6985), 7, false, "Акне в детска възраст", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2253, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7016), 7, false, "Acne excoriee des jeunes filles", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2254, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7047), 7, false, "Други форми на акне", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2255, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7075), 7, false, "Акне, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2256, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7105), 7, false, "Периорален дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2257, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7136), 7, false, "Ринофима", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2282, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7967), 7, false, "Вродена алопеция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2283, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(7998), 7, false, "Вродени морфологични аномалии на космите, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2284, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8031), 7, false, "Други вродени аномалии на космите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2285, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8062), 7, false, "Анонихия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2311, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8924), 7, false, "Остър радиационен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2312, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8956), 7, false, "Хроничен радиационен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2313, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9037), 7, false, "Радиационен дерматит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2314, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9074), 7, false, "Еритем от изгаряне (dermatitis ab igne)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2315, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9104), 7, false, "Други уточнени болести на кожата и подкожната тъкан, предизвикани от радиация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2316, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9134), 7, false, "Болест на кожата и подкожната тъкан, предизвикана от радиация, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2317, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9164), 7, false, "Алергична уртикария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2318, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9194), 7, false, "Идиопатична уртикария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2319, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9224), 7, false, "Уртикария от студ или топлина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2320, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9257), 7, false, "Дерматографска уртикария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2321, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9294), 7, false, "Вибрационна уртикария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2322, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9323), 7, false, "Холинергична уртикария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2323, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9352), 7, false, "Контактна уртикария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2324, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9382), 7, false, "Други видове уртикария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2325, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9414), 7, false, "Уртикария, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2326, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9445), 7, false, "Небулозна erythema multiforme", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2327, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9474), 7, false, "Булозна erythema multiforme", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2328, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9504), 7, false, "Токсична епидермална некролиза [Lyell]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2329, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9534), 7, false, "Други видове erythema multiforme", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2330, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9569), 7, false, "Erythema multiforme, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2331, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9601), 7, false, "Токсичен еритем", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2310, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8891), 7, false, "Изменение на кожата, дължащо се на хронична експозиция на нейонизираща радиация, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2333, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(9664), 7, false, "Erythema marginatum", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2309, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8862), 7, false, "Други изменения на кожата, дължащи се на хронична експозиция на нейонизираща радиация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2307, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8802), 7, false, "Кутис лакса сенилис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2286, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8090), 7, false, "Вродена левконихия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2287, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8122), 7, false, "Удължени и хипертрофирали нокти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2288, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8155), 7, false, "Други вродени аномалии на ноктите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2289, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8185), 7, false, "Други уточнени вродени аномалии на кожните придатъци", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2290, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8215), 7, false, "Вродена аномалия на кожните придатъци, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2291, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8298), 7, false, "Слънчево изгаряне първа степен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2292, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8335), 7, false, "Слънчево изгаряне втора степен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2293, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8366), 7, false, "Слънчево изгаряне трета степен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2294, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8397), 7, false, "Други видове слънчево изгаряне", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2295, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8427), 7, false, "Слънчево изгаряне, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2296, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8461), 7, false, "Лекарствена фототоксична реакция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2297, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8493), 7, false, "Лекарствена фотоалергична реакция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2298, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8524), 7, false, "Фотоконтактен дерматит (berloque dermatitis)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2299, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8554), 7, false, "Слънчева уртикария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2300, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8585), 7, false, "Полиморфна слънчева ерупция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2301, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8616), 7, false, "Полиморфна слънчева ерупция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2302, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8646), 7, false, "Остро изменение на кожата, причинено от ултравиолетова радиация, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2303, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8677), 7, false, "Актинична кератоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2304, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8709), 7, false, "Актиничен ретикулоид", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2305, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8743), 7, false, "Cutis rhomboidalis nuchae", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2306, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8772), 7, false, "Пойкилодермия на Civatte", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2308, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(8832), 7, false, "Актиничен гранулом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2432, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5049), 7, false, "Доброкачествени новообразия на горен крайник, включително областта на раменния пояс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2494, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7028), 8, false, "Доброкачествено новообразувание на мъжките полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2434, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5108), 7, false, "Меланоцитен невус на устните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2559, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9038), 8, false, "Липса и аплазия на тестиса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2560, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9066), 8, false, "Хипоплазия на тестиса и скротума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2561, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9102), 8, false, "Други вродени аномалии на тестисите и скротума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2562, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9130), 8, false, "Атрезия на vas deferens", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2563, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9158), 8, false, "Други вродени аномалии на vas deferens, епидидима, семенните мехурчета и простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2564, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9187), 8, false, "Вродена липса и аплазия на половия член", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2565, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9216), 8, false, "Други вродени аномалии на половия член", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2566, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9410), 8, false, "Други уточнени вродени аномалии на мъжките полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2567, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9446), 8, false, "Вродена аномалия на мъжките полови органи, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2558, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9010), 8, false, "Хипоспадия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2568, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9476), 8, false, "Хермафродитизъм, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2570, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9536), 8, false, "Женски псевдохермафродитизъм, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2571, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9564), 8, false, "Псевдохермафродитизъм, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2572, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9593), 8, false, "Неопределен пол, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2573, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9621), 8, false, "Ендометриоза на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2574, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9650), 8, false, "Ендометриоза на яйчника", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2575, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9678), 8, false, "Ендометриоза на маточната тръба", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2576, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9707), 8, false, "Ендометриоза на тазовия перитонеум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2577, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9738), 8, false, "Ендометриоза на ректовагиналния септум и на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2578, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9767), 8, false, "Ендометриоза на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2569, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9507), 8, false, "Мъжки псевдохермафродитизъм, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2557, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8983), 8, false, "Други форми на хипоспадия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2556, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8955), 8, false, "Хипоспадия с вродени хорди", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2555, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8926), 8, false, "Хипоспадия, перинеална", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2534, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8275), 8, false, "Ембрионална киста на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2535, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8304), 8, false, "Вродена фистула между матката и храносмилателната и отделителната система", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2536, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8334), 8, false, "Други вродени аномалии на матката и шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2537, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8363), 8, false, "Вродена аномалия на матката и шийката на матката, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2538, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8392), 8, false, "Вродена липса на влагалище", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2539, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8420), 8, false, "Удвоено влагалище", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2540, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8448), 8, false, "Вродена ректовагинална фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2541, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8476), 8, false, "Атрезия на химена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2542, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8504), 8, false, "Други вродени аномалии на влагалището", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2543, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8533), 8, false, "Срастване на лабиите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2544, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8610), 8, false, "Вродена аномалия на клитора", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2545, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8640), 8, false, "Други вродени аномалии на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2546, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8668), 8, false, "Други уточнени вродени аномалии на женските полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2547, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8697), 8, false, "Вродена аномалия на женските полови органи, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2548, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8725), 8, false, "Ектопичен тестис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2549, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8753), 8, false, "Недесцендиране на тестиса, едностранно", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2550, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8781), 8, false, "Недесцендиране на тестиса, двустранно", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2551, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8809), 8, false, "Недесцендиране на тестиса, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2552, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8838), 8, false, "Хипоспадия на главичката на половия член", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2553, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8870), 8, false, "Хипоспадия на половия член", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2554, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8898), 8, false, "Хипоспадия, пеноскротална", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2579, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9795), 8, false, "Ендометриоза на кожен цикатрикс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2580, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9823), 8, false, "Друга ендометриоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2581, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9851), 8, false, "Ендометриоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2582, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9879), 8, false, "Уретероцеле при жени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2608, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(818), 8, false, "Невъзпалителна болест на яйчника, маточната тръба и широката връзка на матката, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2609, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(848), 8, false, "Полип на тялото на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2610, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(919), 8, false, "Полип на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2611, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(950), 8, false, "Полип на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2612, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(979), 8, false, "Полип на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2613, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1007), 8, false, "Полип на други части на женските полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2614, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1035), 8, false, "Полип на женските полови органи, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2615, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1063), 8, false, "Ендометриална жлезна хиперплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2616, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1091), 8, false, "Ендометриална аденоматозна хиперплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2617, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1121), 8, false, "Хипертрофия на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2618, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1150), 8, false, "Субинволуция на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2619, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1180), 8, false, "Неправилно положение на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2620, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1209), 8, false, "Обръщане на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2621, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1238), 8, false, "Вътрематочни синехии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2622, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1266), 8, false, "Хематометра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2623, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1294), 8, false, "Други уточнени невъзпалителни болести на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2624, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1322), 8, false, "Невъзпалителна болест на матката, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2625, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1350), 8, false, "Ерозио и ектропион на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2626, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1379), 8, false, "Слабо изразена дисплазия на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2627, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1408), 8, false, "Умерена дисплазия на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2628, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1438), 8, false, "Тежко изразена дисплазия на шийката на матката, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2607, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(789), 8, false, "Други невъзпалителни болести на яйчника, маточната тръба и широката връзка на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2533, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8247), 8, false, "Агенезия и аплазия на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2606, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(760), 8, false, "Хематом на широката връзка на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2604, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(703), 8, false, "Завъртане на яйчника, яйчниковия педикул и маточната тръба", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2583, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(9907), 8, false, "Цистоцеле", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2584, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(68), 8, false, "Непълен утеровагинален пролапс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2585, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(98), 8, false, "Пълен утеровагинален пролапс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2586, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(132), 8, false, "Утеровагинален пролапс, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2587, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(160), 8, false, "Ентероцеле на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2588, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(190), 8, false, "Ректоцеле", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2589, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(267), 8, false, "Други форми на пролапс на женските полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2590, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(296), 8, false, "Пролапс на женските полови органи, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2591, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(325), 8, false, "Везиковагинална фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2592, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(353), 8, false, "Други фистули на женските полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2593, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(381), 8, false, "Фистула между вагината и тънките черва", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2594, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(410), 8, false, "Фистула между вагината и дебелите черва", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2595, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(441), 8, false, "Други фистули между черва и женски полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2596, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(470), 8, false, "Фистули, генитално-кожни, при жени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2597, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(499), 8, false, "Други фистули на женските полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2598, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(527), 8, false, "Фистула на женските полови органи, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2599, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(556), 8, false, "Фоликуларна киста на яйчника", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2600, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(584), 8, false, "Киста на жълтото тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2601, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(612), 8, false, "Други и неуточнени кисти на яйчника", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2602, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(642), 8, false, "Придобита атрофия на яйчника и маточната тръба", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2603, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(674), 8, false, "Пролапс и херния на яйчника и маточната тръба", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2605, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(732), 8, false, "Хематосалпинкс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2433, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5078), 7, false, "Доброкачествени новообразия на долен крайник, включително тазобедрената област", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2532, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8219), 8, false, "Еднорога матка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2530, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8163), 8, false, "Други удвоявания на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2460, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6004), 7, false, "Епидермално задебеляване, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2461, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6035), 7, false, "Кератодермия при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2462, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6063), 7, false, "Фоликуларна и парофоликуларна кератоза, проникваща в кожата (болест на Kyrle)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2463, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6092), 7, false, "Реактивна перфорираща колагеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2464, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6120), 7, false, "Пълзяща перфорираща еластоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2465, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6148), 7, false, "Други болести с трансепидермална елиминация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2466, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6178), 7, false, "Болест с трансепидермална елиминация, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2467, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6209), 7, false, "Гангренозна пиодермия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2468, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6237), 7, false, "Декубитална язва", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2459, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5883), 7, false, "Други уточнени болести със задебеляване на епидермиса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2469, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6264), 7, false, "Атрофични увреждания на кожата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2471, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6321), 7, false, "Грануломатозни изменения на кожата и подкожната тъкан", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2472, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6350), 7, false, "Лупус еритематодес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2473, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6378), 7, false, "Други локализирани изменения на съединителната тъкан", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2474, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6408), 7, false, "Кожен васкулит, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2475, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6440), 7, false, "Язва на долен крайник, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2476, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6469), 7, false, "Други болести на кожата и подкожната тъкан, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2477, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6497), 7, false, "Други увреждания на кожата и подкожната тъкан при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2478, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6527), 8, false, "Субмукозен лейомиом на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2479, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6555), 8, false, "Интрамурален лейомиом на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2470, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6293), 7, false, "Хипертрофични увреждания на кожата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2458, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5853), 7, false, "Ксерозис кутис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2457, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5824), 7, false, "Кератозис пунктата (палмарна и плантарна)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2456, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5795), 7, false, "Придобита палмоплантарна кератоза (кератодермия)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2435, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5138), 7, false, "Меланоцитен невус на клепача, включително ъгъла на клепачната цепка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2436, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5166), 7, false, "Меланоцитен невус на ухото и външния слухов канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2437, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5195), 7, false, "Меланоцитен невус на други и неуточнени части на лицето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2438, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5223), 7, false, "Меланоцитен невус на окосмената част на главата и шията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2439, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5251), 7, false, "Меланоцитен невус на тялото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2440, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5279), 7, false, "Меланоцитен невус на горен крайник, включително областта на раменния пояс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2441, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5308), 7, false, "Меланоцитен невус на долен крайник, включително тазобедрената област", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2442, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5341), 7, false, "Постинфламаторна хиперпигментация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2443, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5413), 7, false, "Хлоазма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2444, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5443), 7, false, "Лунички", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2445, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5471), 7, false, "Петна тип \"кафе с мляко\"", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2446, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5508), 7, false, "Друга хиперпигментация, дължаща се на натрупване на меланин", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2447, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5538), 7, false, "Левкодерма, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2448, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5566), 7, false, "Други нарушения, свързани с намалено образуване на меланин", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2449, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5594), 7, false, "Пигментна пурпурична дерматоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2450, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5623), 7, false, "Други уточнени нарушения на пигментацията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2451, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5655), 7, false, "Нарушение на пигментацията, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2452, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5683), 7, false, "Себорейна кератоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2453, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5711), 7, false, "Acanthosis nigricans", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2454, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5739), 7, false, "Образуване на мазоли", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2455, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(5767), 7, false, "Придобита ихтиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2480, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6583), 8, false, "Субсерозен лейомиом на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2481, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6650), 8, false, "Лейомиом на матката, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2482, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6682), 8, false, "Вродена липса на гърда с гръдно зърно", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2483, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6713), 8, false, "Добавъчна гърда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 2509, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7509), 8, false, "Злокачествено новообразувание на аксиларно удължение на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2510, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7537), 8, false, "Лезия, излизаща извън границите на една и повече посочени локализации на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2511, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7568), 8, false, "Злокачествено новообразувание на млечна жлеза, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2512, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7600), 8, false, "Следоперативна бъбречна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2513, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7630), 8, false, "Следоперативна стриктура на уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2514, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7658), 8, false, "Следоперативни адхезии на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2515, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7686), 8, false, "Пролапс на вагината след хистеректомия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2516, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7714), 8, false, "Следоперативни сраствания в малкия таз", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2517, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7742), 8, false, "Дисфункция на стома от пикочните пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2518, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7770), 8, false, "Други увреждания на пикочо-половата система след медицински процедури", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2519, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7799), 8, false, "Увреждане на пикочо-половата система след медицински процедури, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2520, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7830), 8, false, "Доброкачествено новообразувание на яйчника", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2521, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7858), 8, false, "Вродена липса на яйчник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2522, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7929), 8, false, "Аномалия на развитието с киста на яйчника", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2523, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7961), 8, false, "Вродена торзия на яйчник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2524, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7989), 8, false, "Други вродени аномалии на яйчник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2525, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8018), 8, false, "Ембрионална киста на фалопиевата тръба", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2526, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8046), 8, false, "Ембрионална киста на широката връзка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2527, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8075), 8, false, "Други вродени аномалии на фалопиевата тръба и широката връзка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2528, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8106), 8, false, "Агенезия и аплазия на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2529, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8134), 8, false, "Двойна матка с удвояване на шийката на матката и влагалището", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2508, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7480), 8, false, "Злокачествено новообразувание на долен външен квадрант на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2531, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(8191), 8, false, "Двурога матка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2507, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7452), 8, false, "Злокачествено новообразувание на горен външен квадрант на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2505, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7393), 8, false, "Злокачествено новообразувание на горен вътрешен квадрант на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2484, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6741), 8, false, "Липсващо гръдно зърно", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2485, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6769), 8, false, "Добавъчно гръдно зърно", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2486, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6797), 8, false, "Други вродени аномалии на гърдата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2487, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6825), 8, false, "Вродена аномалия на гърдата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2488, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6854), 8, false, "Доброкачествено новообразувание на пениса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2489, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6882), 8, false, "Доброкачествено новообразувание на простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2490, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6911), 8, false, "Доброкачествено новообразувание на тестисите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2491, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6942), 8, false, "Доброкачествено новообразувание на епидидима", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2492, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6970), 8, false, "Доброкачествено новообразувание на скротума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2493, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(6999), 8, false, "Доброкачествено новообразувание на мъжките полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2236, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6389), 7, false, "Други форми на цикатрициална алопеция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2495, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7056), 8, false, "Доброкачествено новообразувание на мъжки полови органи, с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2496, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7086), 8, false, "Доброкачествено новообразувание на бъбрека", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2497, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7116), 8, false, "Доброкачествено новообразувание на бъбречното легенче", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2498, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7145), 8, false, "Доброкачествено новообразувание на уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2499, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7176), 8, false, "Доброкачествено новообразувание на пикочния канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2500, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7205), 8, false, "Доброкачествено новообразувание на уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2501, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7234), 8, false, "Доброкачествено новообразувание на други пикочни органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2502, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7263), 8, false, "Доброкачествено новообразувание на други пикочни органи, с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2503, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7334), 8, false, "Злокачествено новообразувание на мамила и ареола", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2504, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7363), 8, false, "Злокачествено новообразувание на централна част на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2506, new DateTime(2019, 7, 23, 12, 50, 35, 930, DateTimeKind.Local).AddTicks(7423), 8, false, "Злокачествено новообразувание на долен вътрешен квадрант на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2235, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6360), 7, false, "Folliculitis ulerythematosa reticulata", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2173, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4285), 7, false, "Пруриго нодуларис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2233, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6297), 7, false, "Фоликулит, водещ до оплешивяване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1964, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6437), 6, false, "Бактериална пневмония, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1965, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6467), 6, false, "Пневмония, причинена от хламидии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1966, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6498), 6, false, "Пневмония, причинена от други уточнени инфекциозни агенти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1967, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6529), 6, false, "Пневмония при бактериални болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1968, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6559), 6, false, "Пневмония при вирусни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1969, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6590), 6, false, "Пневмония при микози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1970, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6622), 6, false, "Пневмония при паразитни болести", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1971, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6657), 6, false, "Пневмония при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1972, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6688), 6, false, "Пневмония без уточнен причинител", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1963, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6395), 6, false, "Пневмония, причинена от Haemophilus influenzae", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1973, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6720), 6, false, "Гангрена и некроза на белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1975, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6782), 6, false, "Абсцес на белия дроб без пневмония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1976, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6813), 6, false, "Абсцес на медиастинума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1977, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6943), 6, false, "Пиоторакс с фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1978, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6985), 6, false, "Пиоторакс без фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1979, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7028), 6, false, "Атрезия на хоаните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1980, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7056), 6, false, "Агенезия и недоразвитие на носа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1981, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7090), 6, false, "Фисура, инцизура и разцепване на носа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1982, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7133), 6, false, "Вродена перфорация на носната преграда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1983, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7172), 6, false, "Други вродени аномалии на носа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1974, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6751), 6, false, "Абсцес на белия дроб с пневмония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1962, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6354), 6, false, "Пневмония, причинена от Streptococcus pneumoniae", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1961, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6318), 6, false, "Вирусна пневмония, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1960, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6284), 6, false, "Друга вирусна пневмония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1939, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5457), 5, false, "Злокачествено новообразувание на венците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1940, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5505), 5, false, "Злокачествено новообразувание на пода на устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1941, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5552), 5, false, "Злокачествено новообразувание на небцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1942, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5594), 5, false, "Злокачествено новообразувание на други и неуточнени части на устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1943, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5624), 5, false, "Злокачествено новообразувание на околоушната слюнчена жлеза (паротис)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1944, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5658), 5, false, "Злокачествено новообразувание на друга и неуточнена част на големите слюнчени жлези", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1945, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5701), 5, false, "Злокачествено новообразувание на сливицата (тонзила)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1946, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5743), 5, false, "Злокачествено новообразувание на орофаринкса (мезофаринкс)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1947, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5775), 5, false, "Злокачествено новообразувание на носоглътката (назофаринкс)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1948, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5812), 5, false, "Злокачествено новообразувание на пириформения синус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1949, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5842), 5, false, "Злокачествено новообразувание на хипофаринкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1950, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5873), 5, false, "Злокачествено новообразувание с други и неточно определени локализации на устните, устната кухина и фаринкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1951, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5906), 6, false, "Грип с пневмония, идентифициран грипен вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1952, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5937), 6, false, "Грип с други респираторни прояви, идентифициран грипен вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1953, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5968), 6, false, "Грип с други прояви, идентифициран грипен вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1954, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6001), 6, false, "Грип с пневмония, неидентифициран вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1955, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6076), 6, false, "Грип с други респираторни прояви, неидентифициран вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1956, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6110), 6, false, "Грип с други прояви, неидентифициран вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1957, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6148), 6, false, "Аденовирусна пневмония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1958, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6196), 6, false, "Пневмония, причинена от респираторно синцитиален вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1959, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(6242), 6, false, "Пневмония, причинена от вируса на парагрипа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1984, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7201), 6, false, "Вродена аномалия на носа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1985, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7233), 6, false, "Ципеста преграда на ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1986, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7264), 6, false, "Вродена стеноза на субглотиса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1987, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7295), 6, false, "Хипоплазия на ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2013, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8230), 6, false, "Смесен, обикновен и слузно-гноен хроничен бронхит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2014, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8260), 6, false, "Хроничен бронхит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2015, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8288), 6, false, "Синдром на MacLeod", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2016, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8316), 6, false, "Панлобуларeн емфизем", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2017, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8344), 6, false, "Центрилобуларен емфизем", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2018, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8373), 6, false, "Друг емфизем", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2019, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8399), 6, false, "Емфизем, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2020, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8427), 6, false, "Хронична обструктивна белодробна болест с остра респираторна инфекция на долните дихателни пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2021, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8455), 6, false, "Хронична обструктивна белодробна болест с обостряне, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2022, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8540), 6, false, "Друга уточнена хронична обструктивна белодробна болест", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2023, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8575), 6, false, "Хронична обструктивна белодробна болест, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2024, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8605), 6, false, "Астма с преобладаващ алергичен компонент", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2025, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8636), 6, false, "Неалергична астма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2026, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8667), 6, false, "Смесена астма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2027, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8698), 6, false, "Астма, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2028, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8729), 6, false, "Астматичен статус ( Status asthmaticus )", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2029, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8759), 6, false, "Бронхиектатична болест", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2030, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8789), 6, false, "Карцином in situ на ларинкс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2031, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8820), 6, false, "Карцином in situ на трахея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2032, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8851), 6, false, "Карцином in situ на бронх и бял дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2033, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8880), 6, false, "Карцином in situ на други части на дихателната система", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2012, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8201), 6, false, "Слузно-гноен хроничен бронхит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1938, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5414), 5, false, "Лезия, излизаща извън границите на една и повече посочени локализации на устните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2011, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8169), 6, false, "Обикновен хроничен бронхит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2009, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8108), 6, false, "Вродена аномалия на дихателната система, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1988, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7328), 6, false, "Ларингоцеле", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1989, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7357), 6, false, "Вроден ларингеален стридор", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1990, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7389), 6, false, "Други вродени аномалии на ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1991, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7420), 6, false, "Вродена аномалия на ларинкса, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1992, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7451), 6, false, "Вродена трахеомалация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1993, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7482), 6, false, "Други вродени аномалии на трахеята", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1994, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7513), 6, false, "Вродена бронхомалация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1995, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7544), 6, false, "Вродена стеноза на бронха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1996, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7582), 6, false, "Други вродени аномалии на бронхите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1997, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7634), 6, false, "Вродена белодробна кистоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1998, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7681), 6, false, "Добавъчен лоб на белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1999, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7762), 6, false, "Секвестрация на белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2000, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7852), 6, false, "Агенезия на белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2001, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7880), 6, false, "Вродена бронхиектазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2002, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7908), 6, false, "Ектопична тъкан в белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2003, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7934), 6, false, "Хипоплазия и дисплазия на белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2004, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7962), 6, false, "Други вродени аномалии на белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2005, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(7989), 6, false, "Вродена аномалия на белия дроб, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2006, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8023), 6, false, "Аномалия на плеврата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2007, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8050), 6, false, "Вродена киста на медиастинума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2008, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8078), 6, false, "Други уточнени вродени аномалии на дихателната система", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2010, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8137), 6, false, "Бронхит, неуточнен като остър или хроничен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2034, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8909), 6, false, "Карцином in situ на дихателна система, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1937, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5383), 5, false, "Комисура на устните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1935, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5275), 5, false, "Злокачествено новообразувание на долна устна, вътрешна повърхност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1865, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2646), 5, false, "Вродена аномалия на горната част на храносмилателния тракт, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1866, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2684), 5, false, "Вродена липса, атрезия и стеноза на дуоденума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1867, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2718), 5, false, "Вродена липса, атрезия и стеноза на йеюнума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1868, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2752), 5, false, "Вродена липса, атрезия и стеноза на илеума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1869, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2784), 5, false, "Вродена липса, атрезия и стеноза на други уточнени части на тънкото черво", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1870, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2871), 5, false, "Вродена липса, атрезия и стеноза на тънкото черво, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1871, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2906), 5, false, "Вродена липса, атрезия и стеноза на ректума с фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1872, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2937), 5, false, "Вродена липса, атрезия и стеноза на ректума без фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1873, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2969), 5, false, "Вродена липса, атрезия и стеноза на ануса с фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1864, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2600), 5, false, "Други уточнени вродени аномалии на горната част на храносмилателния тракт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1874, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3001), 5, false, "Вродена липса, атрезия и стеноза на ануса без фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1876, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3067), 5, false, "Вродена липса, атрезия и стеноза на дебелото черво, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1877, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3100), 5, false, "Дивертикул на Meckel", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1878, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3130), 5, false, "Болест на Hirschsprung", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1879, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3166), 5, false, "Други вродени функционални нарушения на колона", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1880, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3214), 5, false, "Вродени аномалии на чревното закрепване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1881, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3259), 5, false, "Удвоено черво", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1882, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3298), 5, false, "Ектопичен анус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1883, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3338), 5, false, "Вродена фистула на ректума и ануса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1884, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3369), 5, false, "Персистираща клоака", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1875, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3036), 5, false, "Вродена липса, атрезия и стеноза на други части на дебелото черво", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1863, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2560), 5, false, "Вродена аномалия на стомаха, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1862, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2525), 5, false, "Други уточнени вродени аномалии на стомаха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1861, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2495), 5, false, "Вродена хиатусова херния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1840, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(251), 5, false, "Перитонит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1841, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(278), 5, false, "Други увреждания на перитонеума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1842, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(306), 5, false, "Увреждания на перитонеума при инфекциозни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1843, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(336), 5, false, "Вродени аномалии на устните, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1844, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(367), 5, false, "Анкилоглосия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1845, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(395), 5, false, "Макроглосия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1846, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(422), 5, false, "Вродени аномалии на слюнчените жлези и протоци", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1847, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(450), 5, false, "Вродени аномалии на небцето, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1848, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(479), 5, false, "Други вродени аномалии на устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1849, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(611), 5, false, "Фарингеален джоб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1850, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(640), 5, false, "Други вродени аномалии на фаринкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1851, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(669), 5, false, "Атрезия на хранопровода без фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1852, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(698), 5, false, "Атрезия на хранопровода с трахеоезофагеална фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1853, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(728), 5, false, "Вродена трахеоезофагеална фистула без атрезия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1854, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(756), 5, false, "Вродена стеноза и стриктура на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1855, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(784), 5, false, "Езофагеална ципеста преграда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1856, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(812), 5, false, "Вродена дилатация на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1857, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(840), 5, false, "Дивертикул на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1858, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(868), 5, false, "Други вродени аномалии на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1859, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2377), 5, false, "Вродена аномалия на хранопровода, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1860, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(2449), 5, false, "Вродена хипертрофична пилоростеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1885, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3403), 5, false, "Други уточнени вродени аномалии на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1886, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3448), 5, false, "Вродена аномалия на червата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1887, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3484), 5, false, "Вродени аномалии на жлъчния мехур, жлъчните пътища и черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1888, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3523), 5, false, "Други вродени аномалии на храносмилателната система", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1914, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4528), 5, false, "Дискинезия на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1915, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4563), 5, false, "Дивертикул на хранопровода, придобит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1916, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4595), 5, false, "Синдром на Mallory-Weiss", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1917, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4631), 5, false, "Други уточнени болести на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1918, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4663), 5, false, "Болест на хранопровода, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1919, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4695), 5, false, "Увреждания на хранопровода при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1920, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4733), 5, false, "Язва на стомаха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1921, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4780), 5, false, "Язва на дванадесетопръстника", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1922, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4824), 5, false, "Пептична язва с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1923, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4865), 5, false, "Гастройеюнална язва", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1924, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4902), 5, false, "Гастрит и дуоденит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1925, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4937), 5, false, "Диспепсия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1926, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4976), 5, false, "Други болести на стомаха и дванадесетопръстника", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1927, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5018), 5, false, "Цепка на небцето (Вълча уста)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1928, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5050), 5, false, "Цепка на устната (Заешка устна)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1929, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5081), 5, false, "Цепка на небцето с цепка на устната (Вълча уста със заешка устна)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1930, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5111), 5, false, "Злокачествено новообразувание на устната", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1931, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5141), 5, false, "Злокачествено новообразувание на външна повърхност на горната устна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1932, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5174), 5, false, "Злокачествено новообразувание на външна повърхност на долната устна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1933, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5207), 5, false, "Злокачествено новообразувание на външна устна, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1934, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5244), 5, false, "Злокачествено новообразувание на горна устна, вътрешна повърхност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1913, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4445), 5, false, "Перфорация на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1936, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(5350), 5, false, "Злокачествено новообразувание на устна, неуточнена, вътрешна повърхностт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1912, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4413), 5, false, "Непроходимост на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1910, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4352), 5, false, "Ахалазия на кардията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1889, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3552), 5, false, "Доброкачествено новообразувание на големите слюнчени жлези", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1890, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3581), 5, false, "Ингвинална херния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1891, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3617), 5, false, "Феморална херния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1892, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3701), 5, false, "Пъпна херния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1893, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3737), 5, false, "Вентрална херния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1894, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3767), 5, false, "Диафрагмална херния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1895, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3797), 5, false, "Други абдоминални хернии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1896, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3828), 5, false, "Абдоминална херния, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1897, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3859), 5, false, "Карцином in situ на устни, устна кухина и фаринкс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1898, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3890), 5, false, "Карцином in situ на хранопровод", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1899, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3922), 5, false, "Карцином in situ на стомах", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1900, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3955), 5, false, "Карцином in situ на колон", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1901, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(3996), 5, false, "Карцином in situ на ректосигмоидална област", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1902, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4045), 5, false, "Карцином in situ на ректум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1903, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4088), 5, false, "Карцином in situ на анус и анален канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1904, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4129), 5, false, "Карцином in situ на други и неуточнени части на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1905, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4167), 5, false, "Карцином in situ на черен дроб, жлъчен мехур и жлъчни пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1906, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4195), 5, false, "Карцином in situ на други уточнени храносмилателни органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1907, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4231), 5, false, "Карцином in situ на храносмилателен орган, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1908, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4282), 5, false, "Езофагит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1909, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4319), 5, false, "Гастроезофагеална рефлуксна болест", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1911, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(4382), 5, false, "Язва на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2035, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8941), 6, false, "Остър назофарингит [хрема]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2036, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(8973), 6, false, "Остър синуит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2037, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9004), 6, false, "Остър фарингит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2163, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3988), 7, false, "Контактен дерматит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2164, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4018), 7, false, "Ексфолиативен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2165, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4048), 7, false, "Дерматит от вътрешно приети субстанции", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2166, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4075), 7, false, "Лихен симплекс хроникус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2167, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4102), 7, false, "Пруритус ани", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2168, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4131), 7, false, "Пруритус скроти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2169, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4161), 7, false, "Пруритус вулве", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2170, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4193), 7, false, "Аногенитален пруритус, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2171, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4224), 7, false, "Други видове пруритус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2162, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3954), 7, false, "Иритативен контактен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2172, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4256), 7, false, "Пруритус, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2174, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4313), 7, false, "Други видове пруриго", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2175, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4341), 7, false, "Генерализиран кожен обрив от лекарства и медикаменти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2176, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4426), 7, false, "Локализиран кожен обрив от лекарства и медикаменти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2177, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4464), 7, false, "Дерматит от погълната храна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2178, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4494), 7, false, "Дерматит от други вещества, приети вътрешно", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2179, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4524), 7, false, "Дерматит от неуточнени вещества, приети вътрешно", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2180, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4561), 7, false, "Нумуларен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2181, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4591), 7, false, "Дисхидроза (Помфоликс)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2182, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4621), 7, false, "Кожна автосенсибилизация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2629, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1468), 8, false, "Дисплазия на шийката на матката, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2161, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3924), 7, false, "Алергичен контактен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2160, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3896), 7, false, "Дерматит от пелени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2159, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3870), 7, false, "Себореен дерматит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2138, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3028), 6, false, "Злокачествено новообразувание на средното ухо", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2139, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3061), 6, false, "Злокачествено новообразувание на синусите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2140, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3091), 6, false, "Злокачествено новообразувание на ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2141, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3123), 6, false, "Злокачествено новообразувание на трахеята", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2142, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3154), 6, false, "Злокачествено новообразувание на главни бронхи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2143, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3183), 6, false, "Злокачествено новообразувание на горен лоб, бронх или бял дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2144, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3214), 6, false, "Злокачествено новообразувание на среден лоб, бронх или бял дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2145, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3246), 6, false, "Злокачествено новообразувание на долен лоб, бронх или бял дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2146, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3285), 6, false, "Лезия, излизаща извън границите на една и повече посочени локализации на бронха или белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2147, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3315), 6, false, "Злокачествено новообразувание на бронх или бял дроб, с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2148, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3345), 6, false, "Параганглиомът", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2149, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3373), 6, false, "Хемангиоми и съдови малформации", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2150, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3403), 6, false, "Хистиоцитоза на Лангерхансовите клетки (Еозинофилен гранулом)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2151, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3433), 6, false, "Доброкачествени тумори на носа и синусите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2152, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3463), 7, false, "Атопичен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2153, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3680), 7, false, "Пруриго на Besnier", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2154, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3735), 7, false, "Други форми на атопичен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2155, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3761), 7, false, "Атопичен дерматит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2156, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3787), 7, false, "Себорея капитис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2157, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3815), 7, false, "Себореен дерматит в детска възраст", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2158, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(3842), 7, false, "Други форми на себореен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2183, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4650), 7, false, "Инфекциозен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2184, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4680), 7, false, "Интертригинозен еритем", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2185, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4708), 7, false, "Питириазис алба", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2186, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4736), 7, false, "Друг уточнен дерматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2212, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5601), 7, false, "Линии на Beau", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2213, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5633), 7, false, "Синдром на жълтия нокът", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 2214, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5662), 7, false, "Други болести на ноктите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2215, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5693), 7, false, "Болест на ноктите, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2216, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5722), 7, false, "Бухалковидни нокти, дължащи се на пахидермопериостоза (M89.4ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2217, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5758), 7, false, "Изменения на ноктите при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2218, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5788), 7, false, "Алопеция (капитис) тоталис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2219, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5819), 7, false, "Алопеция универсалис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2220, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5849), 7, false, "Офиазис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2221, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5878), 7, false, "Други форми на алопеция ареата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2222, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5908), 7, false, "Алопеция ареата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2223, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5976), 7, false, "Андрогенна алопеция, предизвикана от лекарствени средства", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2224, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6011), 7, false, "Други видове андрогенна алопеция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2225, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6043), 7, false, "Андрогенна алопеция, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2226, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6080), 7, false, "Телогенно опадане на косата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2227, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6110), 7, false, "Анагенно опадане на косата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2228, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6140), 7, false, "Муцинозна алопеция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2229, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6171), 7, false, "Други уточнени нецикатризиращи форми на опадане на косата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2230, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6203), 7, false, "Нецикатризираща форма на опадане на косата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2231, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6233), 7, false, "Псевдопелагра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2232, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6264), 7, false, "Лихен планопиларис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2211, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5570), 7, false, "Нокътна дистрофия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2137, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2997), 6, false, "Злокачествено новообразувание на носната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2210, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5539), 7, false, "Онихогрифоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2208, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5480), 7, false, "Унгвис инкарнатус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2187, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4767), 7, false, "Дерматит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2188, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4797), 7, false, "Epidermolysis bullosa simplex", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2189, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4829), 7, false, "Epidermolysis bullosa letalis", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2190, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4864), 7, false, "Epidermolysis bullosa dystrophica", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2191, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4896), 7, false, "Други форми на булозна епидермолиза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2192, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4927), 7, false, "Epidermolysis bullosa, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2193, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4957), 7, false, "Ихтиозис вулгарис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2194, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(4987), 7, false, "Х-свързана ихтиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2195, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5018), 7, false, "Ламеларна ихтиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2196, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5048), 7, false, "Вродена булозна ихтиозиформена еритродермия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2197, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5075), 7, false, "Фетална ихтиоза (плод Арлекин)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2198, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5107), 7, false, "Други форми на вродена ихтиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2199, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5195), 7, false, "Вродена ихтиоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2200, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5235), 7, false, "Наследствен лимфедем", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2201, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5268), 7, false, "Xeroderma pigmentosum", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2202, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5298), 7, false, "Мастоцитоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2203, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5327), 7, false, "Incontinentia pigmenti", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2204, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5357), 7, false, "Ектодермална дисплазия (анхидротична)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2205, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5389), 7, false, "Вроден нетуморен невус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2206, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5415), 7, false, "Други уточнени вродени аномалии на кожата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2207, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5445), 7, false, "Вродена аномалия на кожата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2209, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(5510), 7, false, "Онихолиза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2136, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2971), 6, false, "Остър бронхит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2135, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2942), 6, false, "Остър бронхит, причинен от друг уточнен агент", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2134, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2914), 6, false, "Остър бронхит, причинен от еховирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2063, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(320), 6, false, "Плеврален излив, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2064, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(352), 6, false, "Плеврален излив при състояния, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2065, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(382), 6, false, "Плеврално срастване при азбестоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2066, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(477), 6, false, "Плеврално срастване без наличие на азбестоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2067, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(510), 6, false, "Пневмоторакс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2068, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(538), 6, false, "Други увреждания на плеврата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2069, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(566), 6, false, "Плеврално срастване при азбестоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2070, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(595), 6, false, "Плеврално срастване без наличие на азбестоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2071, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(626), 6, false, "Синдром на респираторно разстройство (дистрес) при възрастни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2072, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(660), 6, false, "Белодробен оток", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2073, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(689), 6, false, "Белодробна еозинофилия, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2074, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(720), 6, false, "Други интерстициални белодробни болести", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2075, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(750), 6, false, "Пневмокониоза на въглекопачите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2076, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(779), 6, false, "Пневмокониоза, причинена от азбест и други минерални вещества", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2077, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(809), 6, false, "Пневмокониоза, причинена от прах, съдържаща силиций", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2078, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(839), 6, false, "Пневмокониоза, причинена от друга неорганична прах", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2079, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(871), 6, false, "Пневмокониоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2080, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(906), 6, false, "Пневмокониоза, свързана с туберкулоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2081, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(934), 6, false, "Болест на дихателните пътища, предизвикана от специфична органична прах", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2082, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(965), 6, false, "Хиперсензитивен пневмонит, предизвикан от органична прах", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2083, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(995), 6, false, "Респираторни състояния, причинени от вдишване на химични вещества, газове, дим и пари", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2062, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(285), 6, false, "Респираторни нарушения при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2084, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1027), 6, false, "Пневмонит, причинен от твърди вещества и течности", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2061, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(255), 6, false, "Респираторно нарушение, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2059, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(197), 6, false, "Болести на диафрагмата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2038, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9034), 6, false, "Остър тонзилит (ангина)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2039, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9067), 6, false, "Остър ларингит и трахеит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2040, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9104), 6, false, "Остър обструктивен ларингит [круп] и епиглотит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2041, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9134), 6, false, "Остри инфекции на горните дихателни пътища с множествена и неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2042, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9164), 6, false, "Нарушение на функционирането на трахеостома", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2043, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9192), 6, false, "Остра белодробна недостатъчност след торакална хирургична намеса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2044, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9274), 6, false, "Остра белодробна недостатъчност след извънторакална хирургична намеса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2045, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9306), 6, false, "Хронична белодробна недостатъчност, дължаща се на операция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2046, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9340), 6, false, "Синдром на Mendelson", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2047, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9372), 6, false, "Субглотисна стеноза след медицински процедури", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2048, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9403), 6, false, "Други респираторни нарушения след медицински процедури", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2049, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9432), 6, false, "Респираторно нарушение след медицински процедури, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2050, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9825), 6, false, "Остра дихателна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2051, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9881), 6, false, "Хронична дихателна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2052, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9913), 6, false, "Дихателна недостатъчност, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2053, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(9955), 6, false, "Болести на бронхите, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2054, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(43), 6, false, "Белодробен колапс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2055, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(81), 6, false, "Интерстициален емфизем", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2056, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(109), 6, false, "Компенсаторен емфизем", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2057, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(138), 6, false, "Други увреждания на белия дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2058, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(167), 6, false, "Болести на медиастинума, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2060, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(226), 6, false, "Други уточнени респираторни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2234, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(6330), 7, false, "Абсцедиращ перифоликулит на главата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2085, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1055), 6, false, "Респираторни състояния, причинени от други външни агенти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2087, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1361), 6, false, "Алергичен ринит, причинен от полени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2113, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2217), 6, false, "Хипертрофия на тонзилите с хипертрофия на аденоидите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2114, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2245), 6, false, "Други хронични болести на тонзилите и аденоидите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2115, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2271), 6, false, "Хронична болест на тонзилите и аденоидите, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2116, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2300), 6, false, "Перитонзиларен абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2117, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2328), 6, false, "Хроничен ларингит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2118, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2358), 6, false, "Хроничен ларинготрахеит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2119, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2385), 6, false, "Парализа на гласните връзки и ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2120, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2415), 6, false, "Полип на гласните връзки и ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2121, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2459), 6, false, "Възли на гласните връзки", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2122, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2492), 6, false, "Други болести на гласните връзки", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2123, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2521), 6, false, "Оток на ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2124, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2549), 6, false, "Спазъм на ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2125, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2579), 6, false, "Стеноза на ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2126, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2608), 6, false, "Други болести на ларинкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2127, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2637), 6, false, "Остър бронхит, причинен от Mycoplasma pneumoniae", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2128, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2664), 6, false, "Остър бронхит, причинен от Haemophilus influenzae", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2129, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2693), 6, false, "Остър бронхит, причинен от стрептокок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2130, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2726), 6, false, "Остър бронхит, причинен от коксаки-вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2131, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2761), 6, false, "Остър бронхит, причинен от парагрипен вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2132, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2841), 6, false, "Остър бронхит, причинен от респираторно-синцитиален вирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2133, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2881), 6, false, "Остър бронхит, причинен от риновирус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2112, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2191), 6, false, "Хипертрофия на аденоидите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2086, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1087), 6, false, "Вазомоторен ринит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2111, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2162), 6, false, "Хипертрофия на тонзилите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2109, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2022), 6, false, "Други уточнени болести на носа и носните синуси", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2088, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1404), 6, false, "Други сезонни алергични ринити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2089, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1432), 6, false, "Други алергични ринити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2090, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1459), 6, false, "Алергичен ринит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2091, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1487), 6, false, "Хроничен ринит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2092, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1514), 6, false, "Хроничен назофарингит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2093, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1541), 6, false, "Хроничен фарингит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2094, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1568), 6, false, "Хроничен максиларен синуит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2095, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1595), 6, false, "Хроничен фронтален синуит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2096, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1631), 6, false, "Хроничен етмоидален синуит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2097, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1662), 6, false, "Хроничен сфеноидален синуит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2098, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1690), 6, false, "Хроничен пансинуит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2099, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1718), 6, false, "Други хронични синуити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2100, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1746), 6, false, "Хроничен синуит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2101, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1777), 6, false, "Полип на носните кухини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2102, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1809), 6, false, "Полипозна дегенерация на синуса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2103, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1839), 6, false, "Други полипи на синуса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2104, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1868), 6, false, "Полип на носа, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2105, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1899), 6, false, "Абсцес, фурункул и карбункул на носа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2106, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1933), 6, false, "Киста или мукоцеле на носа и носния синус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2107, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1963), 6, false, "Девиация на носната преграда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2108, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(1992), 6, false, "Хипертрофия на носната раковина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2110, new DateTime(2019, 7, 23, 12, 50, 35, 929, DateTimeKind.Local).AddTicks(2127), 6, false, "Хроничен тонзилит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2630, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1496), 8, false, "Левкоплакия на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2693, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3504), 8, false, "Женско безплодие, свързано с мъжки фактори", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2632, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1552), 8, false, "Стриктура и стеноза на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3156, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9007), 11, false, "Други уточнени видове нетоксична гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3157, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9112), 11, false, "Нетоксична гуша, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3158, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9140), 11, false, "Тиреотоксикоза с дифузна гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3159, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9169), 11, false, "Тиреотоксикоза с токсичен единичен тиреоиден възел", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3160, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9202), 11, false, "Тиреотоксикоза с токсична полинодозна гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3161, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9231), 11, false, "Тиреотоксикоза от ектопична тиреоидна тъкан", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3162, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9259), 11, false, "Тиреотоксикоза, изкуствено предизвикана (factitia)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3163, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9287), 11, false, "Тиреотоксична криза или кома", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3164, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9315), 11, false, "Други видове тиреотоксикоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3155, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8978), 11, false, "Нетоксична полинодозна гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3165, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9343), 11, false, "Тиреотоксикоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3167, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9399), 11, false, "Подoстър тиреоидит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3168, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9428), 11, false, "Хроничен тиреоидит с преходна тиреотоксикоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3169, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9457), 11, false, "Автоимунен тиреоидит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3170, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9485), 11, false, "Медикаментозен тиреоидит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3171, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9513), 11, false, "Други хронични тиреоидити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3172, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9541), 11, false, "Тиреоидит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3173, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9569), 11, false, "Хиперсекреция на калцитонин", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3174, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9596), 11, false, "Дисхормонална гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3175, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9624), 11, false, "Дисхормонална гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3166, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9371), 11, false, "Остър тиреоидит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3154, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8950), 11, false, "Нетоксичен единичен възел на щитовидната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3153, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8922), 11, false, "Нетоксична дифузна гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3152, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8894), 11, false, "Хипотиреоидизъм, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3131, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8131), 9, false, "Анемия, причинена от белтъчен недоимък", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3132, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8160), 9, false, "Други мегалобластни анемии, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3133, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8188), 9, false, "Анемия при скорбут", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3134, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8216), 9, false, "Други уточнени анемии, свързани с храненето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3135, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8244), 9, false, "Анемия, свързана с храненето, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3136, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8424), 11, false, "Вроден йод-недоимъчен синдром, неврологичен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3137, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8460), 11, false, "Вроден йод-недоимъчен синдром, микседемен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3138, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8490), 11, false, "Вроден йод-недоимъчен синдром, смесен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3139, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8518), 11, false, "Вроден йод-недоимъчен синдром, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3140, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8547), 11, false, "Дифузна (ендемична) гуша, свързана с йоден недоимък", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3141, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8576), 11, false, "Полинодозна (ендемична) гуша, свързана с йоден недоимък", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3142, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8604), 11, false, "Гуша (ендемична), свързана с йоден недоимък, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3143, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8633), 11, false, "Други болести на щитовидната жлеза, свързани с йоден недоимък и сродни състояния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3144, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8664), 11, false, "Субклиничен хипотиреоидизъм, причинен от йоден недоимък", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3145, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8693), 11, false, "Вроден хипотиреоидизъм с дифузна гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3146, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8721), 11, false, "Вроден хипотиреоидизъм без гуша", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3147, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8749), 11, false, "Хипотиреоидизъм, дължащ се на лекарства и други екзогенни вещества", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3148, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8778), 11, false, "Постинфекциозен хипотиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3149, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8806), 11, false, "Атрофия на щитовидната жлеза (придобита)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3150, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8834), 11, false, "Микседемна кома", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3151, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8863), 11, false, "Други уточнени видове хипотиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3176, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9652), 11, false, "Болест на щитовидната жлеза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3177, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9681), 11, false, "Инсулинозависим захарен диабет", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3178, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9713), 11, false, "Неинсулинозависим захарен диабет", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3179, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9741), 11, false, "Захарен диабет, свързан с недоимъчно хранене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3205, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(653), 11, false, "Недоимък на други витамини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3206, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(681), 11, false, "Витаминен недоимък, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3207, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(711), 11, false, "Недоимък на селен в храната", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3208, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(739), 11, false, "Недоимък на калций в храната", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3209, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(767), 11, false, "Недоимък на цинк в храната", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3210, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(795), 11, false, "Недоимък на други хранителни елементи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3211, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(824), 11, false, "Други видове недоимък в храната", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3212, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(856), 11, false, "Последици от недохранване и друг хранителен недоимък", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3213, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(885), 11, false, "Доброкачествено новообразувание на Надбъбречна жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3214, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(913), 11, false, "Доброкачествено новообразувание на Паращитовидна жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3215, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(942), 11, false, "Доброкачествено новообразувание на Хипофиза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3216, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(971), 11, false, "Доброкачествено новообразувание на Краниофарингеален канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3217, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1000), 11, false, "Доброкачествено новообразувание на Епифизна (пинеална) жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3218, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1029), 11, false, "Доброкачествено новообразувание на Каротидно телце", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3219, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1059), 11, false, "Доброкачествено новообразувание на Аортно телце и други параганглии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3220, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1088), 11, false, "Доброкачествено новообразувание на Други уточнени ендокринни жлези", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3221, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1117), 11, false, "Доброкачествено новообразувание на Лезия на повече от една ендокринна жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3222, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1146), 11, false, "Доброкачествено новообразувание на щитовидната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3223, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1233), 11, false, "Доброкачествено новообразувание на Ендокринна жлеза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3224, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1263), 11, false, "Злокачествено новообразувание на щитовидната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3225, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1292), 11, false, "Злокачествено новообразувание на надбъбречната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3204, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(625), 11, false, "Недоимък на витамин K", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3130, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8102), 9, false, "Фолиевонедоимъчна анемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3203, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(597), 11, false, "Недоимък на витамин E", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3201, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(534), 11, false, "Рахит, активен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3180, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9814), 11, false, "Други уточнени видове захарен диабет", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3181, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9842), 11, false, "Захарен диабет, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3182, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9871), 11, false, "Недоимък на витамин A с ксероза на конюнктивата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3183, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9899), 11, false, "Недоимък на витамин A с петно на Bitot и ксероза на конюнктивата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3184, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(9937), 11, false, "Недоимък на витамин А с ксероза на корнеята", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3185, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(20), 11, false, "Недоимък на витамин A с кератомалация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3186, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(60), 11, false, "Недоимък на витамин A с нощна слепота", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3187, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(89), 11, false, "Недоимък на витамин A с ксерофталмични цикатрикси на корнеята", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3188, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(118), 11, false, "Други очни прояви при недоимък на витамин A", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3189, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(147), 11, false, "Други прояви на недоимък на витамин A", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3190, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(175), 11, false, "Други прояви на недоимък на витамин A", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3191, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(204), 11, false, "Бери-бери", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3192, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(232), 11, false, "Енцефалопатия на Wernicke", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3193, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(261), 11, false, "Други прояви на недоимък на тиамин", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3194, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(292), 11, false, "Недоимък на тиамин, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3195, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(320), 11, false, "Недоимък на ниацин [пелагра]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3196, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(349), 11, false, "Недоимък на рибофлавин", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3197, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(377), 11, false, "Недоимък на пиридоксин", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3198, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(406), 11, false, "Недоимък на други уточнени витамини от група B", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3199, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(435), 11, false, "Недоимък на витамини от група B, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3200, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(463), 11, false, "Недоимък на аскорбинова киселина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3202, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(566), 11, false, "Недоимък на витамин D, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3226, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1324), 11, false, "Злокачествено новообразувание на други ендокринни жлези и сродни структури", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3129, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8074), 9, false, "Други фолиевонедоимъчни анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3127, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8013), 9, false, "Фолиевонедоимъчна анемия, свързана с храненето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3057, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5902), 9, false, "Други сидеробластни анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3058, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5930), 9, false, "Конгенитална дисеритропоетична анемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3059, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5958), 9, false, "Други уточнени анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3060, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5986), 9, false, "Анемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3061, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6013), 9, false, "Анемия, дължаща се на недостиг на глюкозо-6-фосфат дехидрогеназа [G6PD]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3062, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6042), 9, false, "Анемия, дължаща се на други нарушения на обмяната на глутатиона", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3063, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6071), 9, false, "Анемия, дължаща се на нарушения на ензимите на гликолизата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3064, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6102), 9, false, "Анемия, дължаща се на нарушения в метаболизма на нуклеотидите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3065, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6131), 9, false, "Други анемии, дължащи се на ензимни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3056, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5873), 9, false, "Вторична сидеробластна анемия, предизвикана от лекарствени средства или токсини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3066, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6159), 9, false, "Анемия, дължаща се на ензимно нарушение, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3068, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6215), 9, false, "Бета таласемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3069, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6242), 9, false, "Делта-бета таласемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3070, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6308), 9, false, "Носителство на признака на таласемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3071, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6338), 9, false, "Наследствено персистиране на фетален хемоглобин [HPFH]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3072, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6369), 9, false, "Други таласемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3073, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6396), 9, false, "Таласемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3074, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6424), 9, false, "Сърповидно-клетъчна анемия с криза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3075, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6452), 9, false, "Сърповидно-клетъчна анемия без криза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3076, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6480), 9, false, "Двойни хетерозиготни сърповидно-клетъчни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3067, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6187), 9, false, "Алфа таласемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3055, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5841), 9, false, "Вторична сидеробластна анемия, дължаща се на друго заболяване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3054, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5813), 9, false, "Наследствена сидеробластна анемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3053, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5785), 9, false, "Анемия при хронични болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3032, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5148), 9, false, "Качествени дефекти на тромбоцитите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3033, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5176), 9, false, "Друга нетромбоцитопенична пурпура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3034, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5204), 9, false, "Идиопатична тромбоцитопенична пурпура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3035, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5232), 9, false, "Други първични тромбоцитопении", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3036, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5259), 9, false, "Вторична тромбоцитопения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3037, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5287), 9, false, "Тромбоцитопения, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3038, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5315), 9, false, "Други уточнени хеморагични състояния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3039, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5343), 9, false, "Хеморагично състояние, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3040, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5371), 9, false, "Хемангиом с каквато и да е локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3041, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5401), 9, false, "Лимфангиом с каквато и да е локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3042, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5429), 9, false, "Хронична придобита (чиста) аплазия на еритроцитите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3043, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5457), 9, false, "Преходна придобита (чиста) аплазия на еритроцитите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3044, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5486), 9, false, "Други придобити (чисти) аплазии на еритроцитите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3045, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5514), 9, false, "Придобита (чиста) аплазия на еритроцитите, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3046, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5542), 9, false, "Конституционална апластична анемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3047, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5571), 9, false, "Медикаментозно предизвикана апластична анемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3048, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5602), 9, false, "Апластична анемия, предизвикана от други външни агенти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3049, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5673), 9, false, "Идиопатична апластична анемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3050, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5701), 9, false, "Други уточнени апластични анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3051, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5730), 9, false, "Апластична анемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3052, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5757), 9, false, "Остра постхеморагична анемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3077, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6508), 9, false, "Носителство на признака на сърповидни клетки", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3078, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6536), 9, false, "Други сърповидно-клетъчни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3079, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6565), 9, false, "Наследствена сфероцитоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3080, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6594), 9, false, "Наследствена елиптоцитоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3106, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7372), 9, false, "Метхемоглобинемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3107, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7400), 9, false, "Фамилна еритроцитоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3108, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7428), 9, false, "Вторична полицитемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 3109, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7456), 9, false, "Есенциална тромбоцитоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3110, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7483), 9, false, "Други уточнени болести на кръвта и кръвотворните органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3111, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7512), 9, false, "Болест на кръвта и кръвотворните органи, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3112, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7540), 9, false, "Хистиоцитоза от клетки на Langerhans, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3113, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7569), 9, false, "Хемофагоцитна лимфохистиоцитоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3114, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7599), 9, false, "Хемофагоцитен синдром при инфекция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3115, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7667), 9, false, "Други хистиоцитозни синдроми", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3116, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7696), 9, false, "Други нарушения на кръвта и кръвотворните органи при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3117, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7725), 9, false, "Желязонедоимъчна анемия, вторична, причинена от загуба на кръв (хронична)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3118, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7753), 9, false, "Сидеропенична дисфагия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3119, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7781), 9, false, "Други желязонедоимъчни анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3120, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7809), 9, false, "Желязонедоимъчна анемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3121, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7838), 9, false, "Витамин B12-недоимъчна анемия, причинена от недоимък на вътрешен фактор", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3122, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7869), 9, false, "Витамин B12-недоимъчна анемия, причинена от избирателно нарушаване на усвояването на витамин B12 при хранене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3123, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7898), 9, false, "Дефицит на транскобаламин II", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3124, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7926), 9, false, "Други витамин B12-недоимъчни анемии, свързани с храненето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3125, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7955), 9, false, "Други витамин B12-недоимъчни анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3126, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7984), 9, false, "Витамин B12-недоимъчна анемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3105, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7342), 9, false, "Други метхемоглобинемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3128, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(8042), 9, false, "Фолиевонедоимъчна анемия, причинена от медикаменти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3104, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7313), 9, false, "Вродена метхемоглобинемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3102, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7257), 9, false, "Други болести на далака", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3081, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6622), 9, false, "Други хемоглобинопатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3082, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6650), 9, false, "Други уточнени наследствени хемолитични анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3083, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6678), 9, false, "Наследствена хемолитична анемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3084, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6706), 9, false, "Медикаментозна автоимунна хемолитична анемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3085, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6734), 9, false, "Други автоимунни хемолитични анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3086, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6762), 9, false, "Медикаментозна неавтоимунна хемолитична анемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3087, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6790), 9, false, "Хемолитично-уремичен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3088, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6819), 9, false, "Други неавтоимунни хемолитични анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3089, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6850), 9, false, "Пароксизмална нощна хемоглобинурия [синдром на Marchiafava-Micheli]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3090, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6879), 9, false, "Хемоглобинурия, дължаща се на хемолиза от други външни причини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3091, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6907), 9, false, "Други придобити хемолитични анемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3092, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(6975), 9, false, "Придобита хемолитична анемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3093, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7004), 9, false, "Агранулоцитоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3094, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7032), 9, false, "Функционални нарушения на полиморфно-ядрените неутрофили", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3095, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7061), 9, false, "Други нарушения на белите кръвни клетки", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3096, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7091), 9, false, "Хипоспленизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3097, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7118), 9, false, "Хиперспленизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3098, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7146), 9, false, "Хронична застойна спленомегалия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3099, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7173), 9, false, "Абсцес на далака", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3100, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7201), 9, false, "Кисти на далака", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3101, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7230), 9, false, "Инфаркт на далака", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3103, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(7285), 9, false, "Болест на далака, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3227, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1353), 11, false, "Класическа фенилкетонурия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3228, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1381), 11, false, "Други видове хиперфенилаланинемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3229, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1409), 11, false, "Разстройства на обмяната на тирозина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3355, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5294), 11, false, "Други форми на хиперпаратиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3356, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5325), 11, false, "Хиперпаратиреоидизъм, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3357, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5353), 11, false, "Други уточнени разстройства на паращитовидните жлези", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3358, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5382), 11, false, "Разстройство на паращитовидните жлези, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3359, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5411), 11, false, "Акромегалия и хипофизарен гигантизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3360, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5439), 11, false, "Хиперпролактинемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3361, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5467), 11, false, "Синдром на неадекватна секреция на антидиуретичен хормон", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3362, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5496), 11, false, "Други хиперфункции на хипофизата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3363, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5525), 11, false, "Хиперфункция на хипофизата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3354, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5265), 11, false, "Вторичен хиперпаратиреоидизъм, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3364, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5555), 11, false, "Хипопитуитаризъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3366, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5611), 11, false, "Безвкусен диабет", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3367, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5639), 11, false, "Хипоталамична дисфункция, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3368, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5667), 11, false, "Хипоталамична дисфункция, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3369, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5696), 11, false, "Хипоталамична дисфункция, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3370, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5724), 11, false, "Синдром на Cushing с хипофизарен произход", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3371, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5754), 11, false, "Синдром на Nelson", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3372, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5785), 11, false, "Ектопичен ACTH синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3373, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5813), 11, false, "Медикаментозно предизвикан синдром на Cushing", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3374, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5841), 11, false, "Индуциран от алкохол псевдо-Cushing синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3365, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5583), 11, false, "Медикаментозен хипопитуитаризъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3353, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5237), 11, false, "Първичен хиперпаратиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3352, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5172), 11, false, "Хипопаратиреоидизъм, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3351, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5144), 11, false, "Други форми на хипопаратиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3330, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4478), 11, false, "Следпроцедурен хипопаратиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3331, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4567), 11, false, "Следпроцедурен хипопитуитаризъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3332, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4600), 11, false, "Следпроцедурно разстройство на функциите на яйчниците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3333, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4629), 11, false, "Следпроцедурна тестикуларна хипофункция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3334, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4657), 11, false, "Следпроцедурна адренокортикална(-медуларна) хипофункция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3335, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4685), 11, false, "Други ендокринни и метаболитни разстройства след медицински процедури", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3336, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4714), 11, false, "Ендокринно и метаболитно разстройство след медицински процедури, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3337, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4743), 11, false, "Разстройства на храненето и на обмяната на веществата при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3338, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4775), 11, false, "Локализирано затлъстяване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3339, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4803), 11, false, "Затлъстяване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3340, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4831), 11, false, "Други видове прехранване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3341, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4859), 11, false, "Последици от прехранване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3342, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4887), 11, false, "Квашиоркор", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3343, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4915), 11, false, "Алиментарен маразъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3344, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4943), 11, false, "Квашиоркор при маразъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3345, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4971), 11, false, "Тежко белтъчно-калорийно недохранване, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3346, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5000), 11, false, "Белтъчно-калорийно недохранване от умерена и лека степен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3347, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5029), 11, false, "Белтъчно-калорийно недохранване от умерена и лека степен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3348, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5059), 11, false, "Белтъчно-калорийно недохранване, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3349, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5088), 11, false, "Идиопатичен хипопаратиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3350, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5116), 11, false, "Псевдохипопаратиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3375, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5911), 11, false, "Други състояния с Cushing синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3376, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5940), 11, false, "Други състояния с Cushing синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3377, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5968), 11, false, "Вродени адреногенитални разстройства, свързани с ензимен дефицит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3378, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(5998), 11, false, "Адреногенитално разстройство, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3404, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6783), 11, false, "Други нарушения на пубертета", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3405, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6812), 11, false, "Нарушение в пубертета, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3406, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6842), 11, false, "Автоимунна полигландуларна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3407, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6871), 11, false, "Полигландуларна хиперфункция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3408, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6899), 11, false, "Другa полигландуларнa дисфункция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3409, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6927), 11, false, "Полигландуларна дисфункция, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3410, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6955), 11, false, "Персистираща хиперплазия на тимуса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3411, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6984), 11, false, "Абсцес на тимуса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3412, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7012), 11, false, "Други болести на тимуса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3413, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7039), 11, false, "Болест на тимуса, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3414, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7068), 11, false, "Карциноиден синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3415, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7098), 11, false, "Други състояния на хиперсекреция на чревни хормони", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3416, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7127), 11, false, "Ектопична хормонална секреция, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3417, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7156), 11, false, "Нанизъм, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3418, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7184), 11, false, "Конституционално висок ръст", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3419, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7309), 11, false, "Синдром на андрогенна резистентност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3420, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7341), 11, false, "Други уточнени ендокринни разстройства", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3421, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7371), 11, false, "Ендокринно разстройство, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3422, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7399), 11, false, "Разстройства на ендокринните жлези при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3423, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7430), 11, false, "Недиабетна хипогликемична кома", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3424, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(7458), 11, false, "Други разстройства на ендокринната секреция на панкреаса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3403, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6755), 11, false, "Преждевременен пубертет", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3329, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4450), 11, false, "Следпроцедурна хипоинсулинемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3402, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6727), 11, false, "Закъснял пубертет", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3400, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6671), 11, false, "Други тестикуларни дисфункции", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3379, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6028), 11, false, "Други адреногенитални разстройства", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3380, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6057), 11, false, "Първичен хипералдостеронизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3381, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6086), 11, false, "Вторичен хипералдостеронизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3382, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6114), 11, false, "Вторичен хипералдостеронизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3383, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6141), 11, false, "Хипералдостеронизъм, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3384, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6170), 11, false, "Други видове хиперсекреция на кората на надбъбреците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3385, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6198), 11, false, "Първична недостатъчност на кората на надбъбреците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3386, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6227), 11, false, "Адисонова криза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3387, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6254), 11, false, "Медикаментозно обусловена адренокортикална недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3388, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6287), 11, false, "Други видове и неуточнена адренокортикална недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3389, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6315), 11, false, "Адреномедуларна хиперфункция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3390, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6343), 11, false, "Други уточнени нарушения на надбъбреците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3391, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6372), 11, false, "Болест на надбъбреците, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3392, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6400), 11, false, "Хиперестрогения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3393, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6428), 11, false, "Хиперестрогения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3394, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6456), 11, false, "Синдром на поликистоза на яйчниците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3395, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6484), 11, false, "Първична яйчникова недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3396, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6512), 11, false, "Други овариални дисфункции", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3397, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6585), 11, false, "Овариална дисфункция, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3398, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6614), 11, false, "Тестикуларна хиперфункция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3399, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6643), 11, false, "Тестикуларна хипофункция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3401, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(6699), 11, false, "Тестикуларна дисфункция, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3328, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4422), 11, false, "Следпроцедурен хипотиреоидизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3327, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4394), 11, false, "Разстройство на обмяната на веществата, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3326, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4365), 11, false, "Други уточнени разстройства на обмяната на веществата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3255, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2202), 11, false, "Разстройство на обмяната на въглехидратите, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3256, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2231), 11, false, "Ганглиозидоза GM2", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3257, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2262), 11, false, "Други ганглиозидози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3258, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2290), 11, false, "Други сфинголипидози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3259, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2319), 11, false, "Сфинголипидоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3260, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2347), 11, false, "Липофусциноза на невроните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3261, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2376), 11, false, "Други разстройства на натрупването на липиди", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3262, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2404), 11, false, "Разстройство на липидното натрупване, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3263, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2432), 11, false, "Мукополизахаридоза, тип I", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3264, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2460), 11, false, "Мукополизахаридоза, тип II", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3265, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2529), 11, false, "Други мукополизахаридози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3266, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2560), 11, false, "Мукополизахаридоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3267, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2588), 11, false, "Други разстройства на обмяната на глюкозаминогликаните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3268, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2616), 11, false, "Разстройство на обмяната на глюкозаминогликаните, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3269, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2647), 11, false, "Дефекти в посттранслационната модификация на лизозомните ензими", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3270, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2675), 11, false, "Дефекти в разграждането на глюкопротеините", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3271, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2704), 11, false, "Други разстройства на обмяната на глюкопротеините", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3272, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2732), 11, false, "Разстройство на обмяната на глюкопротеините, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3273, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2763), 11, false, "Чиста хиперхолестеролемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3274, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2791), 11, false, "Чиста хиперглицеридемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3275, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2818), 11, false, "Смесена хиперлипидемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3254, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2171), 11, false, "Други уточнени разстройства на обмяната на въглехидратите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3276, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2846), 11, false, "Хиперхиломикронемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3253, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2143), 11, false, "Разстройства на обмяната на пирувата и глюконеогенезата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3251, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2086), 11, false, "Разстройства на обмяната на галактозата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3230, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1437), 11, false, "Албинизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3231, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1465), 11, false, "Други разстройства на обмяната на ароматните аминокиселини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3232, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1493), 11, false, "Разстройство на обмяната на ароматните аминокиселини, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3233, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1523), 11, false, "Болест на урина като кленов сироп", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3234, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1553), 11, false, "Други разстройства на обмяната на аминокиселините с разклонена верига", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3235, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1582), 11, false, "Разстройство на обмяната на аминокиселините с разклонена верига, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3236, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1611), 11, false, "Разстройство на обмяната на мастните киселини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3237, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1639), 11, false, "Разстройства на транспортирането на аминокиселини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3238, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1668), 11, false, "Разстройства на обмяната на сяра-съдържащите аминокиселини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3239, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1697), 11, false, "Разстройства в метаболитния цикъл на уреята", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3240, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1726), 11, false, "Разстройства на обмяната на лизина и хидроксилизина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3241, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1758), 11, false, "Разстройства на обмяната на орнитина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3242, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1786), 11, false, "Разстройства на обмяната на глицина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3243, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1854), 11, false, "Други уточнени разстройства на обмяната на аминокиселините", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3244, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1885), 11, false, "Разстройство на обмяната на аминокиселините, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3245, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1914), 11, false, "Вроден недоимък на лактаза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3246, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1942), 11, false, "Вторичен недоимък на лактаза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3247, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1970), 11, false, "Вторичен недоимък на лактаза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3248, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(1999), 11, false, "Непоносимост към лактоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3249, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2029), 11, false, "Болест на натрупването на гликоген", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3250, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2058), 11, false, "Разстройства на обмяната на фруктозата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3252, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2114), 11, false, "Други разстройства на чревната резорбция на въглехидратите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3031, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5118), 9, false, "Алергична пурпура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3277, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2874), 11, false, "Други хиперлипидемии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3279, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2930), 11, false, "Недоимък на липопротеини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3305, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3718), 11, false, "Кистозна фиброза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3306, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3747), 11, false, "Наследствена фамилна амилоидоза без невропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3307, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3777), 11, false, "Наследствена фамилна амилоидоза с невропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3308, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3805), 11, false, "Наследствена фамилна амилоидоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3309, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3876), 11, false, "Вторична системна амилоидоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3310, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3905), 11, false, "Ограничена амилоидоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3311, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3933), 11, false, "Ограничена амилоидоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3312, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3962), 11, false, "Амилоидоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3313, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3990), 11, false, "Намаляване обема на течностите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3314, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4019), 11, false, "Хиперосмоларитет и хипернатриемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3315, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4050), 11, false, "Хипоосмоларитет и хипонатриемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3316, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4079), 11, false, "Ацидоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3317, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4107), 11, false, "Алкалоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3318, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4134), 11, false, "Смесено разстройство на алкално-киселинното равновесие", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3319, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4163), 11, false, "Хиперкалиемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3320, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4191), 11, false, "Хипокалиемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3321, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4218), 11, false, "Хиперволемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3322, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4246), 11, false, "Други разстройства във водно-солевото равновесие, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3323, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4276), 11, false, "Разстройства на обмяната на плазмените белтъци, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3324, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4307), 11, false, "Липодистрофия, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3325, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(4337), 11, false, "Липоматоза, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3304, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3690), 11, false, "Кистозна фиброза с други прояви", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3278, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2902), 11, false, "Хиперлипидемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3303, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3662), 11, false, "Кистозна фиброза с чревни прояви", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3301, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3605), 11, false, "Разстройство на минералната обмяна, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3280, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2960), 11, false, "Други разстройства на обмяната на липопротеините", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3281, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(2989), 11, false, "Разстройство на обмяната на липопротеините, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3282, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3021), 11, false, "Хиперурикемия без признаци на възпалителен артрит и подагрозни възли", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3283, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3050), 11, false, "Синдром на Lesch-Nyhan", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3284, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3078), 11, false, "Други разстройства на обмяната на пурина и пиримидина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3285, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3107), 11, false, "Разстройство на обмяната на пурина и пиримидина, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3286, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3135), 11, false, "Наследствена еритропоетична порфирия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3287, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3204), 11, false, "Порфирия кутанеа тарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3288, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3233), 11, false, "Други порфирии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3289, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3261), 11, false, "Дефекти на каталазата и пероксидазата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3290, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3290), 11, false, "Синдром на Gilbert", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3291, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3318), 11, false, "Синдром на Crigler-Najjar", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3292, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3346), 11, false, "Други разстройства на обмяната на билирубина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3293, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3375), 11, false, "Разстройство на обмяната на билирубина, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3294, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3403), 11, false, "Разстройства на обмяната на медта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3295, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3431), 11, false, "Разстройства на обмяната на желязото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3296, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3459), 11, false, "Разстройства на обмяната на цинка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3297, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3487), 11, false, "Разстройства на обмяната на фосфора", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3298, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3520), 11, false, "Разстройства на обмяната на магнезия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3299, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3548), 11, false, "Разстройства на обмяната на калция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3300, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3576), 11, false, "Други разстройства на минералната обмяна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3302, new DateTime(2019, 7, 23, 12, 50, 35, 933, DateTimeKind.Local).AddTicks(3633), 11, false, "Кистозна фиброза с белодробни прояви", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2631, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1524), 8, false, "Старо разкъсване на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3030, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5089), 9, false, "Нарушение на кръвосъсирването, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3028, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5033), 9, false, "Придобит дефицит на факторите на кръвосъсирването", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2758, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5545), 8, false, "Застой и кръвоизлив в простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2759, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5574), 8, false, "Атрофия на простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2760, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5605), 8, false, "Други уточнени увреждания на простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2761, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5639), 8, false, "Увреждане на простатата, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2762, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5668), 8, false, "Кистозно хидроцеле", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2763, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5739), 8, false, "Инфектирано хидроцеле", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2764, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5769), 8, false, "Други форми на хидроцеле", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2765, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5797), 8, false, "Хидроцеле, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2766, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5827), 8, false, "Сперматоцеле", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2757, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5514), 8, false, "Камък на простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2767, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5857), 8, false, "Завъртане на тестиса (торзия)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2769, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5916), 8, false, "Орхит, епидидимит и орхиепидидимит без абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2770, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5944), 8, false, "Безплодие при мъжа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2771, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5972), 8, false, "Изобилен (redundant) препуциум, фимоза и парафимоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2772, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6000), 8, false, "Левкоплакия на половия член", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2773, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6031), 8, false, "Баланопостит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2774, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6060), 8, false, "Други възпалителни увреждания на половия член", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2775, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6091), 8, false, "Приапизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2776, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6123), 8, false, "Импотентност от органичен произход", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2777, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6151), 8, false, "Язва на половия член", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2768, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5885), 8, false, "Орхит, епидидимит и (епидидимо-орхит) орхиепидидимит с абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1839, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(223), 5, false, "Други видове перитонит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2755, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5454), 8, false, "Други възпалителни болести на простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2754, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5425), 8, false, "Простатоцистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2733, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4764), 8, false, "Разязвяване на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2734, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4794), 8, false, "Разязвяване на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2735, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4822), 8, false, "Други уточнени възпалителни болести на вагината и на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2736, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4851), 8, false, "Разязвяване на вулвата при инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2737, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4881), 8, false, "Вагинит, вулвит и вулвовагинит при инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2738, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4909), 8, false, "Вулвовагинално разязвяване и възпаление при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2739, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4939), 8, false, "Солитарна киста на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2740, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5013), 8, false, "Дифузна кистозна мастопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2741, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5048), 8, false, "Фиброаденоза на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2742, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5076), 8, false, "Фибросклероза на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2743, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5104), 8, false, "Ектазия на каналчетата на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2744, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5134), 8, false, "Други доброкачествени дисплазии на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2745, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5163), 8, false, "Доброкачествена дисплазия на млечната жлеза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2746, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5191), 8, false, "Възпалителни болести на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2747, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5222), 8, false, "Хипертрофия на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2748, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5254), 8, false, "Образувание в млечната жлеза, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2749, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5284), 8, false, "Други болести на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2750, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5312), 8, false, "Хиперплазия на простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2751, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5340), 8, false, "Остър простатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2752, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5368), 8, false, "Хроничен простатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2753, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5396), 8, false, "Абсцес на простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2778, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6179), 8, false, "Баланит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2779, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6206), 8, false, "Други уточнени увреждания на половия член", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2780, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6234), 8, false, "Увреждане на половия член, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2781, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6267), 8, false, "Възпалителни увреждания на семенните мехурчета", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2807, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7343), 8, false, "Руптура на пикочния мехур, нетравматична", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2808, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7378), 8, false, "Други уточнени увреждания на пикочния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2809, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7412), 8, false, "Увреждане на пикочния мехур, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2810, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7441), 8, false, "Абсцес на уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 2811, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7472), 8, false, "Неспецифичен уретрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2812, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7503), 8, false, "Други уретрити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2813, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7533), 8, false, "Уретрален синдром, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2814, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7564), 8, false, "Посттравматична стриктура на уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2815, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7596), 8, false, "Постинфекциозна стриктура на уретрата, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2816, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7630), 8, false, "Друга стриктура на уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2817, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7667), 8, false, "Стриктура на уретрата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2818, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7699), 8, false, "Уретрална фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2819, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7730), 8, false, "Дивертикул на уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2820, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7776), 8, false, "Карункул на уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2821, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7824), 8, false, "Пролапс на уретралната мукоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2822, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7903), 8, false, "Други уточнени болести на уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2823, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7956), 8, false, "Болест на уретрата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2824, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7990), 8, false, "Уретрит при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2825, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8022), 8, false, "Други уретрални увреждания при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2826, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8056), 8, false, "Други увреждания на отделителната система", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2827, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8086), 8, false, "Бъбречна остеодистрофия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2806, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7199), 8, false, "Дивертикул на пикочния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2732, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4735), 8, false, "Абсцес на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2805, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7151), 8, false, "Везикална фистула, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2803, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7085), 8, false, "Запушване на шийката на пикочния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2782, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6298), 8, false, "Възпалителни увреждания на семенната връв, на влагалищната обвивка и на семенния канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2783, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6329), 8, false, "Възпалителни увреждания на скротума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2784, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6362), 8, false, "Възпалителни увреждания на други уточнени мъжки полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2785, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6436), 8, false, "Възпалително увреждане на неуточнен мъжки полов орган", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2786, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6465), 8, false, "Атрофия на тестиса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2787, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6504), 8, false, "Съдови увреждания на мъжките полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2788, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6575), 8, false, "Други уточнени увреждания на мъжките полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2789, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6616), 8, false, "Увреждане на мъжки полови органи, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2790, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6649), 8, false, "Увреждания на мъжките полови органи при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2791, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6691), 8, false, "Остър цистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2792, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6725), 8, false, "Интерстициален цистит (хроничен)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2793, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6755), 8, false, "Друг хроничен цистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2794, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6786), 8, false, "Тригонит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2795, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6814), 8, false, "Радиационен цистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2796, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6845), 8, false, "Други цистити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2797, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6879), 8, false, "Цистит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2798, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6910), 8, false, "Незатормозен неврогенен пикочен мехур, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2799, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6944), 8, false, "Рефлекторен неврогенен пикочен мехур, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2800, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(6979), 8, false, "Неврогенна слабост на пикочния мехур, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2801, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7021), 8, false, "Други невромускулни дисфункции на пикочния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2802, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7053), 8, false, "Невромускулна дисфункция на пикочния мехур, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2804, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(7117), 8, false, "Везикоинтестинална фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2828, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8116), 8, false, "Бъбречен инсипиден диабет", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2731, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4706), 8, false, "Подостър и хроничен вулвит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2729, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4650), 8, false, "Подостър и хроничен вагинит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2658, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2440), 8, false, "Вторична аменорея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2659, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2468), 8, false, "Аменорея, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2660, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2498), 8, false, "Първична олигоменорея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2661, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2529), 8, false, "Вторична олигоменорея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2662, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2557), 8, false, "Олигоменорея, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2663, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2587), 8, false, "Обилна и честа менструация с редовен цикъл", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2664, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2615), 8, false, "Обилна и честа менструация с нередовен цикъл", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2665, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2645), 8, false, "Обилна менструация през пубертета", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2666, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2675), 8, false, "Овулаторно кървене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2657, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2412), 8, false, "Първична аменорея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2667, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2704), 8, false, "Обилно кървене в периода преди менопаузата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2669, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2763), 8, false, "Нередовна менструация, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2670, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2797), 8, false, "Посткоитално и контактно кървене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2671, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2825), 8, false, "Други уточнени аномални кръвотечения от матката и вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2672, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2854), 8, false, "Аномално маточно и вагинално кръвотечение, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2673, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2884), 8, false, "Болки в средата на менструалния цикъл", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2674, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2913), 8, false, "Диспареуния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2675, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2940), 8, false, "Вагинизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2676, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2967), 8, false, "Синдром на предменструално напрежение", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2677, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3037), 8, false, "Първична дисменорея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2668, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2733), 8, false, "Други уточнени форми на нередовна менструация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2656, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2383), 8, false, "Невъзпалителна болест на вулвата и на перинеума, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2655, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2354), 8, false, "Други уточнени невъзпалителни болести на вулвата и на перинеума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2654, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2323), 8, false, "Киста на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2633, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1672), 8, false, "Недостатъчност на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2634, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1703), 8, false, "Хипертрофично удължаване на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2635, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1733), 8, false, "Други уточнени невъзпалителни болести на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2636, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1766), 8, false, "Невъзпалителна болест на шийката на матката, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2637, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1795), 8, false, "Слабо изразена вагинална дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2638, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1825), 8, false, "Умерена дисплазия на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2639, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1854), 8, false, "Тежко изразена дисплазия на вагината, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2640, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1882), 8, false, "Дисплазия на вагината, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2641, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1911), 8, false, "Левкоплакия на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2642, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1939), 8, false, "Стриктура и атрезия на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2643, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1968), 8, false, "Плътен девствен пръстен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2644, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(1998), 8, false, "Хематоколпос", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2645, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2026), 8, false, "Други уточнени невъзпалителни болести на вагината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2646, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2054), 8, false, "Невъзпалителна болест на вагината, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2647, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2084), 8, false, "Слабо изразена дисплазия на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2648, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2112), 8, false, "Умерена дисплазия на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2649, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2140), 8, false, "Тежко изразена дисплазия на вулвата, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2650, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2169), 8, false, "Дисплазия на вулвата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2651, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2199), 8, false, "Левкоплакия на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2652, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2230), 8, false, "Атрофия на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2653, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(2258), 8, false, "Хипертрофия на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2678, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3070), 8, false, "Вторична дисменорея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2679, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3099), 8, false, "Дисменорея, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2680, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3127), 8, false, "Други уточнени състояния, свързани с женските полови органи и менструалния цикъл", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2681, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3156), 8, false, "Състояние, свързано с женските полови органи и менструалния цикъл, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2708, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3989), 8, false, "Възпалителна болест на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2709, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4018), 8, false, "Остър параметрит и тазов целулит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2710, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4049), 8, false, "Хроничен параметрит и тазов целулит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2711, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4081), 8, false, "Параметрит и тазов целулит, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2712, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4109), 8, false, "Остър пелвиоперитонит при жени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2713, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4137), 8, false, "Хроничен пелвиоперитонит при жени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2714, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4169), 8, false, "Пелвиоперитонит при жени, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2715, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4198), 8, false, "Пелвиоперитонеални сраствания при жени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2716, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4232), 8, false, "Други уточнени възпалителни болести на женските тазови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2717, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4261), 8, false, "Възпалителна болест на женските тазови органи, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2718, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4292), 8, false, "Туберкулозна инфекция на шийката на матката (А18.1ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2719, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4320), 8, false, "Туберкулозно възпаление на органите и тъканите на малкия таз при жени (А18.1ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2720, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4389), 8, false, "Възпалителна болест на женските тазови органи, предизвикана от сифилис (A51.4ї, A52.7ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2721, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4419), 8, false, "Възпалителна гонококова болест на женските тазови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2722, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4448), 8, false, "Възпалителна болест на женските тазови органи, предизвикана от хламидий (А56.1ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2723, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4477), 8, false, "Възпалителни увреждания на женските тазови органи при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2724, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4509), 8, false, "Киста на Бартолиновата жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2725, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4538), 8, false, "Абсцес на Бартолиновата жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2726, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4565), 8, false, "Други болести на Бартолиновата жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2727, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4593), 8, false, "Болест на Бартолиновата жлеза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2728, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4622), 8, false, "Остър вагинит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2707, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3960), 8, false, "Възпалителна болест на матката, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2730, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(4678), 8, false, "Остър вулвит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2706, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3932), 8, false, "Хронична възпалителна болест на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2704, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3873), 8, false, "Салпингит и оофорит, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2682, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3184), 8, false, "Кървене след менопауза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2683, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3212), 8, false, "Менопауза и състояние на климакс при жени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2684, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3241), 8, false, "Атрофичен вагинит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2685, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3270), 8, false, "Състояния, свързани с изкуствена менопауза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2686, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3301), 8, false, "Други уточнени нарушения на менопаузата и в периода около менопаузата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2687, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3332), 8, false, "Нарушение на менопаузата и в периода около менопаузата, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2688, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3360), 8, false, "Хабитуален аборт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2689, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3388), 8, false, "Женско безплодие, свързано с липса на овулация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2690, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3418), 8, false, "Женско безплодие с тубарен произход", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2691, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3447), 8, false, "Женско безплодие с маточен произход", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2692, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3475), 8, false, "Женско безплодие с цервикален произход", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2694, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3537), 8, false, "Женско безплодие с друг произход", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2695, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3566), 8, false, "Женско безплодие, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2696, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3595), 8, false, "Инфекция, свързана с изкуствено оплождане", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2697, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3624), 8, false, "Хиперстимулация на яйчниците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2698, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3690), 8, false, "Усложнения, свързани с имплантация на оплодена яйцеклетка след in vitro оплождане", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2699, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3722), 8, false, "Усложнения, свързани с имплантация на ембрион", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2700, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3751), 8, false, "Други усложнения, свързани с изкуствено оплождане", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2701, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3781), 8, false, "Усложнение, свързано с изкуствено оплождане, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2702, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3815), 8, false, "Остър салпингит и оофорит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2703, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3843), 8, false, "Хроничен салпингит и оофорит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2705, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(3901), 8, false, "Остра възпалителна болест на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2829, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8194), 8, false, "Други нарушения, които са резултат от увредена функция на бъбречните тубули", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2830, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8226), 8, false, "Нарушение на функцията на бъбречните тубули, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2831, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8255), 8, false, "Сбръчкан бъбрек, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2956, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2808), 9, false, "Лимфосарком", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2957, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2835), 9, false, "В-клетъчен лимфом, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2958, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2863), 9, false, "Други уточнени типове на нехочкинов лимфом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2959, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2932), 9, false, "Нехочкинов лимфом, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2960, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2962), 9, false, "Макроглобулинемия на Waldenstrom", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2961, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2990), 9, false, "Болест на алфа-тежките вериги", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2962, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3019), 9, false, "Болест на гама-тежките вериги", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2963, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3050), 9, false, "Имунопролиферативна болест на тънките черва", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2964, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3078), 9, false, "Други злокачествени имунопролиферативни болести", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2955, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2780), 9, false, "Нехочкинов лимфом, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2965, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3107), 9, false, "Злокачествени имунопролиферативни болести, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2967, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3162), 9, false, "Плазмоклетъчна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2968, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3190), 9, false, "Плазмоцитом, екстрамедуларен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2969, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3218), 9, false, "Остра лимфобластна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2970, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3245), 9, false, "Хронична лимфоцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2971, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3275), 9, false, "Подостра лимфоцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2972, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3304), 9, false, "Пролимфоцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2973, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3331), 9, false, "Косматоклетъчна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2974, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3359), 9, false, "Т-клетъчна левкемия при възрастни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2975, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3387), 9, false, "Друга лимфоидна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2966, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3135), 9, false, "Множествен миелом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2954, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2752), 9, false, "Други уточнени типове на нехочкинов лимфом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2953, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2722), 9, false, "В-клетъчен лимфом, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2952, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2694), 9, false, "Лимфосарком", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2932, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2079), 8, false, "Еписпадия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2933, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2106), 8, false, "Екстрофия на пикочния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2934, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2134), 8, false, "Вродени задни уретрални клапи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2935, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2162), 8, false, "Вродени задни уретрални клапи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2936, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2189), 8, false, "Аномалия на пикочния канал [urachus]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2937, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2261), 8, false, "Вродена липса на пикочен мехур и уретра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2938, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2296), 8, false, "Вроден дивертикул на пикочния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2939, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2325), 8, false, "Други вродени аномалии на пикочния мехур и уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2940, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2354), 8, false, "АГЕНЕЗИЯ НА УРЕТРАТА", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2941, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2381), 8, false, "МЕГАУРЕТРА", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2942, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2409), 8, false, "ВРОДЕНИ ДИВЕРТИКУЛИ НА УРЕТРАТА", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2943, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2437), 8, false, "ДВОЙНА УРЕТРА", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2944, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2464), 8, false, "Вродена аномалия на отделителната система, неуточнена (ВРОДЕНИ АНОМАЛИИ НА ПИКОЧНИЯ МЕХУР)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2945, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2494), 8, false, "Други доброкачествени новообразувания на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3009, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4441), 8, false, "Общ артериален трункус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2946, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2525), 9, false, "Болест на Хочкин", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2947, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2553), 9, false, "Дребноклетъчен с назъбени ядра, фоликуларен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2948, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2581), 9, false, "Смесен, дребноклетъчен с назъбени ядра и едроклетъчен, фоликуларен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2949, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2610), 9, false, "Едроклетъчен, фоликуларени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2950, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2637), 9, false, "Други видове на фоликуларен нехочкинов лимфом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2951, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2666), 9, false, "Фоликуларен нехочкинов лимфом, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2976, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3415), 9, false, "Лимфоидна левкемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2977, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3443), 9, false, "Остра миелоидна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2978, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3471), 9, false, "Хронична миелоидна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2979, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3499), 9, false, "Подостра миелоидна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3006, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4351), 9, false, "Истински хистиоцитен лимфом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3007, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4381), 9, false, "Други уточнени злокачествени новообразувания на лимфната, кръвотворната и сродните им тъкани", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3008, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4412), 9, false, "Злокачествено новообразувание на лимфната, кръвотворната и сродните им тъкани, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3010, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4468), 9, false, "Удвоен изходен отвор на дясната камера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3011, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4497), 9, false, "Дискордантно свързване на камерите с артериите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3012, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4525), 9, false, "Удвоен изходен отвор на лявата камера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3013, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4554), 9, false, "Удвоен камерен входен отвор", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3014, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4582), 9, false, "Дискордантно предсърднокамерно свързване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3015, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4610), 9, false, "Изомерия на предсърдните уши", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3016, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4643), 9, false, "Други вродени аномалии на сърдечните камери и съобщителните отвори", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3017, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4672), 9, false, "Вродена аномалия на сърдечните камери и съобщителните отвори, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3018, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4701), 9, false, "Междукамерен септален дефект", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3019, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4729), 9, false, "Междупредсърден септален дефект", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3020, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4756), 9, false, "Предсърднокамерен септален дефект", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3021, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4784), 9, false, "Дисеминирано вътресъдово съсирване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3022, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4812), 9, false, "Вроден дефицит на фактор VIII", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3023, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4841), 9, false, "Вроден дефицит на фактор IX", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3024, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4874), 9, false, "Болест на фон Вилебранд", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3025, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4901), 9, false, "Вроден дефицит на фактор XI", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3026, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4930), 9, false, "Вроден дефицит на други фактори на кръвосъсирването", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3027, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5003), 9, false, "Хеморагични нарушения, дължащи се на циркулиращи антикоагуланти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3005, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4285), 9, false, "Злокачествен мастоклетъчен тумор", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2931, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2051), 8, false, "Други уточнени вродени аномалии на бъбрека", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3004, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4257), 9, false, "Злокачествена хистиоцитоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3002, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4201), 9, false, "Друга левкемия с неуточнен клетъчен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2980, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3528), 9, false, "Миелоиден сарком", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2981, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3560), 9, false, "Остра промиелоцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2982, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3663), 9, false, "Остра миеломоноцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2983, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3692), 9, false, "Друга миелоидна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2984, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3720), 9, false, "Миелоидна левкемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2985, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3748), 9, false, "Остра моноцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2986, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3775), 9, false, "Хронична моноцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2987, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3803), 9, false, "Подостра моноцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2988, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3830), 9, false, "Друга моноцитна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2989, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3859), 9, false, "Моноцитна левкемия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2990, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3888), 9, false, "Остра еритремия и еритролевкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2991, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3916), 9, false, "Хронична еритремия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2992, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3944), 9, false, "Остра мегакариобластна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2993, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(3972), 9, false, "Мастоклетъчна левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2994, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4000), 9, false, "Остра панмиелоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2995, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4027), 9, false, "Остра миелофиброза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2996, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4055), 9, false, "Друга уточнена левкемия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2997, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4083), 9, false, "Остра левкемия с неуточнен клетъчен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2998, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4112), 9, false, "Хронична левкемия с неуточнен клетъчен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2999, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4144), 9, false, "Подостра левкемия с неуточнен клетъчен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3001, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4172), 9, false, "Друга левкемия с неуточнен клетъчен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3003, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(4229), 9, false, "Болест на Letterer-Siwe", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2930, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(2022), 8, false, "Други уточнени вродени аномалии на бъбрека", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2929, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1991), 8, false, "Ектопичен бъбрек", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2928, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1945), 8, false, "Ектопичен бъбрек", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2857, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9127), 8, false, "Рецидивираща и постоянна хематурия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2858, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9158), 8, false, "Хроничен нефритен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2859, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9186), 8, false, "Нефрозен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2860, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9213), 8, false, "Нефритен синдром, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2861, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9241), 8, false, "Изолирана протеинурия с уточнено морфологично увреждане", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2862, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9270), 8, false, "Наследствена нефропатия, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2863, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9299), 8, false, "Гломерулни увреждания при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2864, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9328), 8, false, "Злокачествено новообразувание на бъбрека, с изключение на бъбречното легенче", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2865, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9357), 8, false, "Злокачествено новообразувание на бъбречното легенче", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2866, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9389), 8, false, "Злокачествено новообразувание на уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2867, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9417), 8, false, "Злокачествено новообразувание на пикочния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2868, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9445), 8, false, "Злокачествено новообразувание на други и неуточнени части на пикочните органи (БЪБРЕЦИ)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2869, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9475), 8, false, "Карцином in situ на ендоцервикс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2870, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9502), 8, false, "Карцином in situ на екзоцервикс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2871, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9530), 8, false, "Карцином in situ на други части на шийката на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2872, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9597), 8, false, "Карцином in situ на шийката на матката, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2873, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9631), 8, false, "Злокачествено новообразувание на пениса ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2874, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9659), 8, false, "Злокачествено новообразувание на простатата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2875, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9687), 8, false, "Злокачествено новообразувание на тестиса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2876, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9715), 8, false, "Злокачествено новообразувание на други и неуточнени части на мъжките полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2877, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9745), 8, false, "Карцином in situ на ендометриум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2856, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9098), 8, false, "Бързо прогресиращ нефритен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2878, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9774), 8, false, "Карцином in situ на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2855, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9070), 8, false, "Остър нефритен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2853, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9013), 8, false, "Други тубулоинтерстициални болести на бъбреците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2832, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8283), 8, false, "Малък бъбрек по неизвестна причина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2833, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8312), 8, false, "Други нарушения на бъбреците и уретера, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2834, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8344), 8, false, "Други увреждания на бъбреците и уретера при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2835, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8373), 8, false, "Камък в бъбрека", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2836, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8401), 8, false, "Камък в уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2837, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8428), 8, false, "Камък в бъбрека с камък в уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2838, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8456), 8, false, "Камък в пикочните пътища, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2839, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8484), 8, false, "Камък в пикочния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2840, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8512), 8, false, "Камъни в уретрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2841, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8540), 8, false, "Друг камък в долните пикочни пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2842, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8570), 8, false, "Камък в долните пикочни пътища, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2843, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8599), 8, false, "Камък в пикочните пътища при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2844, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8627), 8, false, "Бъбречна колика, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2845, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8655), 8, false, "Остра бъбречна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2846, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8682), 8, false, "Хронична бъбречна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2847, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8710), 8, false, "Бъбречна недостатъчност, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2848, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8738), 8, false, "Остър тубулоинтерстициален нефрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2849, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8766), 8, false, "Хроничен тубулоинтерстициален нефрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2850, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8795), 8, false, "Тубулоинтерстициален нефрит, неуточнен като остър или хроничен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2851, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8952), 8, false, "Обструктивна и рефлуксна нефропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2852, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(8983), 8, false, "Тубулоинтерстициални и тубулни увреждания, предизвикани от лекарства и от тежки метали", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2854, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9041), 8, false, "Тубулоинтерстициални увреждания на бъбреците при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3029, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(5061), 9, false, "Други уточнени нарушения на кръвосъсирването", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2879, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9801), 8, false, "Карцином in situ на влагалището", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2881, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9860), 8, false, "Карцином in situ на пениса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2907, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(794), 8, false, "Бъбречна хипоплазия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2908, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(824), 8, false, "Синдром на Potter", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2909, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(851), 8, false, "Вродена единична киста на бъбрека", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2910, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(880), 8, false, "Бъбречна поликистоза, инфантилен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2911, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(911), 8, false, "Бъбречна поликистоза, адулторен тип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 2912, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(943), 8, false, "Бъбречна поликистоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2913, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1178), 8, false, "Бъбречна дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2914, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1372), 8, false, "Медуларна бъбречна киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2915, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1412), 8, false, "Други форми на кистозна болест на бъбреците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2916, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1444), 8, false, "Кистозна болест на бъбреците, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2917, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1475), 8, false, "Вродена хидронефроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2918, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1506), 8, false, "Атрезия и стеноза на уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2919, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1537), 8, false, "Вроден мегауретер", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2920, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1579), 8, false, "Други вродени нарушения в проходимостта на бъбречното легенче и вродени аномалии на уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2921, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1675), 8, false, "Агенезия на уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2922, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1717), 8, false, "Удвоен уретер", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2923, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1756), 8, false, "Неправилно положение на уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2924, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1793), 8, false, "Вроден везико-уретеро-ренален рефлукс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2925, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1830), 8, false, "Други вродени аномалии на уретера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2926, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1867), 8, false, "Добавъчен бъбрек", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2927, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(1905), 8, false, "Лобулиран, сраснал и подковообразен бъбрек", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2906, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(757), 8, false, "Бъбречна хипоплазия, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2880, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9830), 8, false, "Карцином in situ на други и неуточнени женски полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2905, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(688), 8, false, "Бъбречна хипоплазия, едностранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2903, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(623), 8, false, "Бъбречна агенезия, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2882, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9888), 8, false, "Карцином in situ на простата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2883, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(9983), 8, false, "Карцином in situ на други и неуточнени мъжки полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2884, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(25), 8, false, "Лобуларен карцином in situ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2885, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(53), 8, false, "Интрадуктален карцином in situ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2886, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(81), 8, false, "Друг карцином in situ на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2887, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(109), 8, false, "Карцином in situ на млечната жлеза, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2888, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(138), 8, false, "Злокачествено новообразувание на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2889, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(170), 8, false, "Злокачествено новообразувание на влагалището (вагина)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2890, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(199), 8, false, "Злокачествено новообразувание на шийката на матката (цервикс)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2891, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(229), 8, false, "Злокачествено новообразувание на тялото на матката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2892, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(257), 8, false, "Злокачествено новообразувание на матката с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2893, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(327), 8, false, "Злокачествено новообразувание на яйчника", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2894, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(356), 8, false, "Злокачествено новообразувание на други и неуточнени части на женските полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2895, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(386), 8, false, "Злокачествено новообразувание на плацентата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2896, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(416), 8, false, "Доброкачествено новообразувание на вулва", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2897, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(445), 8, false, "Доброкачествено новообразувание на Влагалище", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2898, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(472), 8, false, "Доброкачествено новообразувание на Маточни тръби и връзки", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2899, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(501), 8, false, "Доброкачествено новообразувание на уточнени части на женските полови органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2900, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(531), 8, false, "Доброкачествено новообразувание на Женски полови органи, с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2901, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(560), 8, false, "Доброкачествено ноовообразувание на млечната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2902, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(589), 8, false, "Бъбречна агенезия, едностранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2904, new DateTime(2019, 7, 23, 12, 50, 35, 932, DateTimeKind.Local).AddTicks(651), 8, false, "Бъбречна агенезия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2756, new DateTime(2019, 7, 23, 12, 50, 35, 931, DateTimeKind.Local).AddTicks(5484), 8, false, "Възпалителна болест на простатата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1838, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(195), 5, false, "Остър перитонит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1836, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(138), 5, false, "Болест на черния дроб, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 606, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8996), 3, false, "Вторична хипертония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 607, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9027), 3, false, "Бъбречно-съдова хипертония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 608, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9057), 3, false, "Хипертония, дължаща се на други бъбречни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 609, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9088), 3, false, "Хипертония, дължаща се на ендокринни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 610, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9118), 3, false, "Други видове вторична хипертония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 611, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9152), 3, false, "Вторична хипертония, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 612, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9184), 3, false, "Хипотония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 613, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9215), 3, false, "Идиопатична хипотония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 614, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9245), 3, false, "Ортостатична хипотония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 615, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9274), 3, false, "Хипотония, дължаща се на лекарствени средства", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 616, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9304), 3, false, "Други видове хипотония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 605, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8965), 3, false, "Съчетание на хипертонично сърце с хипертоничен бъбрек", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 617, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9425), 3, false, "Хипотония, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 619, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9499), 3, false, "Други функционални нарушения след сърдечна операция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 620, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9532), 3, false, "Синдром на лимфедем след мастектомия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 621, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9568), 3, false, "Други следпроцедурни болести на органите на кръвообращението, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 622, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9599), 3, false, "Следпроцедурни болести на органите на кръвообращението, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 623, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9632), 3, false, "Сърдечно-съдов сифилис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 624, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9661), 3, false, "Сърдечно-съдови болести при други инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 625, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9694), 3, false, "Атеросклероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 626, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9725), 3, false, "Атеросклероза на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 627, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9756), 3, false, "Атеросклероза на бъбречна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 628, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9790), 3, false, "Атеросклероза на артерии на крайниците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 629, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9822), 3, false, "Атеросклероза на други артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 618, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9469), 3, false, "Посткардиотомен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 604, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8934), 3, false, "Хипертоничен бъбрек (Хипертонична бъбречна болест)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 603, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8904), 3, false, "Хипертонична болест на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 602, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8868), 3, false, "Есенциална (първична) хипертония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 577, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8020), 3, false, "Оклузия и стеноза на други прецеребрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 578, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8061), 3, false, "Оклузия и стеноза на неуточнена прецеребрална артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 579, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8092), 3, false, "Оклузия и стеноза на средна церебрална артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 580, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8124), 3, false, "Оклузия и стеноза на предна церебрална артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 581, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8155), 3, false, "Оклузия и стеноза на задна церебрална артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 582, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8186), 3, false, "Оклузия и стеноза на артерии на малкия мозък", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 583, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8218), 3, false, "Оклузия и стеноза на множество и двустранни церебрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 584, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8247), 3, false, "Оклузия и стеноза на друга церебрална артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 585, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8278), 3, false, "Оклузия и стеноза на неуточнена церебрална артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 586, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8317), 3, false, "Оклузия и стеноза на средна церебрална артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 587, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8349), 3, false, "Дисекация на церебрални артерии без руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 588, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8380), 3, false, "Мозъчна аневризма без руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 589, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8411), 3, false, "Мозъчна атеросклероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 590, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8441), 3, false, "Прогресивна съдова левкоенцефалопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 591, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8473), 3, false, "Хипертонична енцефалопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 592, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8503), 3, false, "Болест Moyamoya", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 593, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8533), 3, false, "Непиогенна тромбоза на вътречерепната венозна система", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 594, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8566), 3, false, "Мозъчен артериит, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 595, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8648), 3, false, "Други уточнени мозъчносъдови болести", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 596, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8683), 3, false, "Мозъчна амилоидна ангиопатия (Е85.-ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 597, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8713), 3, false, "Мозъчен артериит при инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 598, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8745), 3, false, "Мозъчен артериит при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 599, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8774), 3, false, "Мозъчносъдова болест, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 600, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8804), 3, false, "Уремията ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 601, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(8835), 3, false, "Други мозъчносъдови увреждания при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 630, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9855), 3, false, "Генерализирана и неуточнена атеросклероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 576, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7934), 3, false, "Оклузия и стеноза на множество и двустранни прецеребрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 631, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9886), 3, false, "Аневризма и дисекация на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 633, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9948), 3, false, "Аневризма на торакалната аорта с руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 663, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2737), 3, false, "Стриктура на артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 664, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2764), 3, false, "Руптура на артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 665, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2790), 3, false, "Артериална фибромускулна дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 666, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2816), 3, false, "Синдром на притискане на целиачната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 667, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2843), 3, false, "Некроза на артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 668, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2870), 3, false, "Артериит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 669, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2897), 3, false, "Други уточнени болести на артериите и артериолите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 670, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2927), 3, false, "Болест на артериите и артериолите, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 671, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2957), 3, false, "Наследствена хеморагична телеангиектазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 672, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2984), 3, false, "Невус, ненеопластичен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 673, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3010), 3, false, "Други болести на капилярите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 662, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2710), 3, false, "Артериовенозна фистула, придобита", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 674, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3036), 3, false, "Болест на капилярите, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 676, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3093), 3, false, "Аортит при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 677, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3119), 3, false, "Периферна ангиопатия при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 678, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3148), 3, false, "Други увреждания на артериите, артериолите и капилярите при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 679, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3180), 3, false, "Остър неспецифичен идиопатичен перикардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 680, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3207), 3, false, "Инфекциозен перикардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 681, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3234), 3, false, "Други форми на остър перикардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 682, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3265), 3, false, "Остър перикардит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 683, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3340), 3, false, "Хроничен адхезивен перикардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 684, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3374), 3, false, "Хроничен констриктивен перикардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 685, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3403), 3, false, "Хемоперикард, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 686, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3429), 3, false, "Перикарден излив (невъзпалителен)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 675, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3065), 3, false, "Аневризма на аортата при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 661, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2672), 3, false, "Емболия и тромбоза на неуточнена артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 660, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2563), 3, false, "Емболия и тромбоза на други артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 659, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2535), 3, false, "Емболия и тромбоза на илиачна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 634, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(22), 3, false, "Аневризма на торакалната аорта без споменаване на руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 635, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(60), 3, false, "Аневризма на абдоминалната аорта с руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 636, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(94), 3, false, "Аневризма на абдоминалната аорта без споменаване на руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 637, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(129), 3, false, "Аневризма на торако-абдоминалната аорта с руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 638, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(160), 3, false, "Атеросклероза на бъбречна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 639, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(242), 3, false, "Аневризма на торако-абдоминалната аорта без споменаване на руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 640, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(879), 3, false, "Аневризма на аортата с неуточнена локализация, с руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 641, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(1128), 3, false, "Аневризма на аортата с неуточнена локализация без споменаване на руптура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 642, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(1220), 3, false, "Аневризма на каротидна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 643, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(1258), 3, false, "Аневризма на артерия на горен крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 644, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(1712), 3, false, "Аневризма на бъбречна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 645, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(1794), 3, false, "Аневризма на илиачна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 646, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(1834), 3, false, "Аневризма на артерия на долен крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 647, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(1869), 3, false, "Аневризма на други уточнени артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 648, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(1900), 3, false, "Аневризма с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 649, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2229), 3, false, "Атеросклероза на бъбречна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 650, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2273), 3, false, "Синдром на Raynaud", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 651, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2304), 3, false, "Облитериращ тромбангиит (Болест на Buerger)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 652, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2331), 3, false, "Други уточнени болести на периферните съдове", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 653, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2361), 3, false, "Болест на периферните съдове, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 654, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2394), 3, false, "Емболия и тромбоза на абдоминалната аорта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 655, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2423), 3, false, "Емболия и тромбоза на други и неуточнени части на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 656, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2452), 3, false, "Емболия и тромбоза на артерии на горните крайници", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 657, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2480), 3, false, "Емболия и тромбоза на артерии на долните крайници", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 658, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(2507), 3, false, "Емболия и тромбоза на артерии на крайниците, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 632, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(9917), 3, false, "Дисекация на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 575, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7694), 3, false, "Оклузия и стеноза на каротидна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 574, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7661), 3, false, "Оклузия и стеноза на базиларна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 573, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7568), 3, false, "Оклузия и стеноза на вертебрална артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 491, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4522), 3, false, "Флебит и тромбофлебит с друга локализация ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 492, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4554), 3, false, "Флебит и тромбофлебит с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 493, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4586), 3, false, "Тромбоза на порталната вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 494, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4617), 3, false, "Синдром на Budd-Chiari", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 495, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4651), 3, false, "Мигриращ тромбофлебит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 496, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4683), 3, false, "емболия и тромбоза на празна вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 497, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4715), 3, false, "Емболия и тромбоза на бъбречна вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 498, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4747), 3, false, "Емболия и тромбоза на други уточнени вени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 499, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4778), 3, false, "Емболия и тромбоза на неуточнена вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 500, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4808), 3, false, "Варикозни вени на долните крайници с язва", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 501, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4837), 3, false, "Варикозни вени на долните крайници с възпаление", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 490, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4489), 3, false, "Тромбофлебит на долните крайници, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 502, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4871), 3, false, "Варикозни вени на долните крайници с язва и възпаление", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 504, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4941), 3, false, "Хемороиди", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 505, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4973), 3, false, "Вътрешни тромбозирали хемороиди", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 506, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5003), 3, false, "Вътрешни хемороиди с други усложнения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 507, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5084), 3, false, "Вътрешни хемороиди без усложнение", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 508, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5122), 3, false, "Външни тромбозирали хемороиди", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 509, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5153), 3, false, "Външни хемороиди с други усложнения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 510, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5181), 3, false, "Външни хемороиди без усложнение", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 511, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5210), 3, false, "Остатъчни хемороидални кожни белези", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 512, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5247), 3, false, "Тромбозирали хемороиди, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 513, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5278), 3, false, "Хемороиди с други усложнения, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 514, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5388), 3, false, "Хемороиди без усложнение, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 503, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4908), 3, false, "Варикозни вени на долните крайници без язва или възпаление", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 489, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4459), 3, false, "Флебит на долните крайници, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 488, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4429), 3, false, "Тромбофлебит на други дълбоки съдове на долните крайници", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 487, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4398), 3, false, "Флебит на други дълбоки съдове на долните крайници", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 462, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3291), 3, false, "Вътрешносърдечни тромби", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 463, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3449), 3, false, "Ранен перикардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 464, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3483), 3, false, "Късен перикардит (Синдром на Dressler)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 465, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3512), 3, false, "Други текущи усложнения на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 466, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3543), 3, false, "Коронарна тромбоза, неводеща до инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 467, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3574), 3, false, "Коронарната недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 468, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3608), 3, false, "Други форми на остра исхемична болест на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 469, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3642), 3, false, "Остра исхемична болест на сърцето, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 470, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3674), 3, false, "Атеросклеротична сърдечно-съдова болест", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 471, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3707), 3, false, "Атеросклеротична болест на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 472, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3740), 3, false, "Стар инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 473, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3771), 3, false, "Сърдечна аневризма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 474, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3800), 3, false, "Аневризма на коронарна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 475, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3831), 3, false, "Исхемична кардиомиопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 476, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3861), 3, false, "Безсимптомна исхемия на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 477, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3892), 3, false, "Други форми на хроничната исхемична болест на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 478, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3929), 3, false, "Хронична исхемична болест на сърцето, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 479, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3961), 3, false, "Остър ревматизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 480, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3991), 3, false, "Ревматизъм без данни за засягане на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 481, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4022), 3, false, "Ревматизъм със засягане на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 482, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4050), 3, false, "Ревматична хорея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 483, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4080), 3, false, "Флебит на повърхностни съдове на долните крайници", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 484, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4113), 3, false, "Тромбофлебит на повърхностни съдове на долните крайници", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 485, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4320), 3, false, "Флебит на феморална вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 486, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(4366), 3, false, "Тромбофлебит на феморална вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 515, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5424), 3, false, "Варици на хранопровода с кървене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 516, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5457), 3, false, "Варици на хранопровода без кървене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 517, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5487), 3, false, "подезични варици", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 518, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5518), 3, false, "Варици на скротума (варикоцеле)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 548, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6430), 3, false, "Субарахноидален кръвоизлив, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 549, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6457), 3, false, "Вътремозъчен кръвоизлив в хемисфера, субкортикален", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 550, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6484), 3, false, "Вътремозъчен кръвоизлив в хемисфера, кортикален", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 551, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6510), 3, false, "Вътремозъчен кръвоизлив в хемисфера, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 552, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6900), 3, false, "Вътремозъчен кръвоизлив в мозъчния ствол", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 553, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6972), 3, false, "Вътремозъчен кръвоизлив в малкия мозък", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 554, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7009), 3, false, "Вътремозъчен кръвоизлив в мозъчно стомахче", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 555, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7038), 3, false, "Вътремозъчен кръвоизлив с множествена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 556, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7065), 3, false, "Друг мозъчен кръвоизлив", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 557, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7094), 3, false, "Вътремозъчен кръвоизлив, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 558, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7122), 3, false, "Субдурален кръвоизлив (остър)(нетравматичен)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 559, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7150), 3, false, "Нетравматичен екстрадурален кръвоизлив", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 560, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7178), 3, false, "Вътремозъчен кръвоизлив (нетравматичен), неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 561, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7205), 3, false, "Мозъчен инфаркт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 562, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7235), 3, false, "Мозъчен инфаркт, причинен от тромбоза на прецеребрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 563, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7266), 3, false, "Мозъчен инфаркт, причинен от емболия на прецеребрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 564, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7296), 3, false, "Мозъчен инфаркт, причинен от неуточнена оклузия или стеноза на прецеребрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 565, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7324), 3, false, "Мозъчен инфаркт, причинен от тромбоза на церебрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 566, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7354), 3, false, "Мозъчен инфаркт, причинен от емболия на церебрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 567, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7385), 3, false, "Мозъчен инфаркт, причинен от неуточнена оклузия или стеноза на церебрални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 568, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7414), 3, false, "Мозъчен инфаркт, причинен от тромбоза на мозъчна вена - непиогенна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 569, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7450), 3, false, "Мозъчен инфаркт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 570, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7482), 3, false, "Мозъчен инфаркт, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 571, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7510), 3, false, "Инсулт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 572, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(7539), 3, false, "инсулт, неуточнен като кръвоизлив или инфаркт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 547, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6404), 3, false, "Друг субарахноидален кръвоизлив", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 687, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3457), 3, false, "Други уточнени болести на перикарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 546, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6376), 3, false, "Субарахноидален кръвоизлив от интракраниална артерия, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 544, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6318), 3, false, "Субарахноидален кръвоизлив от вертебралната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 519, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5548), 3, false, "Варици на вулвата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 520, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5580), 3, false, "Варици на таза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 521, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5613), 3, false, "Варици на стомаха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 522, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5644), 3, false, "Варикозни вени с неуточнени локализации", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 523, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5675), 3, false, "Варици на скротума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 524, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5706), 3, false, "Постфлебитен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 525, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5736), 3, false, "Притискане на вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 526, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5766), 3, false, "Венозна инсуфициенция (хронична)(периферна)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 527, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5797), 3, false, "Други уточнени увреждания на вените", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 528, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5830), 3, false, "Венозно увреждане, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 529, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5862), 3, false, "Неспецифичен лимфаденит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 530, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5896), 3, false, "Неспецифичен мезентериален лимфаденит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 531, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(5969), 3, false, "Хроничен лимфаденит, с изключение на мезентериален", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 532, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6000), 3, false, "Други неспецифични лимфаденити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 533, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6032), 3, false, "Неспецифичен лимфаденит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 534, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6059), 3, false, "Лимфедем, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 535, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6085), 3, false, "Лимфангит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 536, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6108), 3, false, "Други уточнени неинфекциозни болести на лимфните съдове и лимфните възли", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 537, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6132), 3, false, "Неинфекциозна болест на лимфните съдове и лимфните възли, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 538, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6159), 3, false, "Липомеланотична ретикулоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 539, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6187), 3, false, "Субарахноидален кръвоизлив от сифона и бифуркацията на каротидната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 540, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6214), 3, false, "Субарахноидален кръвоизлив от средната мозъчна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 541, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6240), 3, false, "Субарахноидален кръвоизлив от предната свързваща артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 542, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6266), 3, false, "Субарахноидален кръвоизлив от задната свързваща артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 543, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6292), 3, false, "Субарахноидален кръвоизлив от базиларната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 545, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(6347), 3, false, "Субарахноидален кръвоизлив от други интракраниални артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 688, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3492), 3, false, "Болест на перикарда, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 689, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3516), 3, false, "Перикардит при бактериални болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 690, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3545), 3, false, "Перикардит при други инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 835, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9620), 4, false, "Пиогенен артрит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 836, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9651), 4, false, "Менингококов артрит (А39.8ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 837, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9681), 4, false, "Туберкулозен артрит (А18.0ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 838, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9755), 4, false, "Артрит при Лаймска болест (А69.2ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 839, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9793), 4, false, "Артрит при други бактериални болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 840, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9825), 4, false, "Артрит при рубеола (В06.8ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 841, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9856), 4, false, "Артрит при други вирусни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 842, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9886), 4, false, "Артрит при микози (В35-В49ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 843, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9918), 4, false, "Артрит при други инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 844, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9950), 4, false, "Артропатия след чревна анастомоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 845, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(29), 4, false, "Постдизентерийна артропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 834, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9590), 4, false, "Артрити и полиартрити, предизвикани от други уточнени бактериални агенти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 846, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(63), 4, false, "Постимунизационна артропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 848, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(133), 4, false, "Други реактивни артропатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 849, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(165), 4, false, "Реактивна артропатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 850, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(195), 4, false, "Постменингококов артрит (А39.8ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 851, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(227), 4, false, "Постинфекциозна артропатия при сифилис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 852, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(256), 4, false, "Други постинфекциозни артропатии при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 853, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(289), 4, false, "Реактивна артропатия при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 854, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(321), 4, false, "Серопозитивен ревматоиден артрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 855, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(353), 4, false, "Синдром на Felty", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 856, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(386), 4, false, "Ревматоидна болест със засягане на белия дроб (J99.0*)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 857, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(418), 4, false, "Ревматоиден васкулит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 858, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(448), 4, false, "Ревматоиден артрит със засягане на други органи и системи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 847, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(99), 4, false, "Синдром на Reiter-Leroy", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 833, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9558), 4, false, "Други стрептококови артрити и полиартрити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 832, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9528), 4, false, "Пневмококов артрит и полиартрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 831, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9497), 4, false, "Стафилококов артрит и полиартрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 806, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8634), 3, false, "Други болести на митралната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 807, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8666), 3, false, "Болест на митралната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 808, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8698), 3, false, "Ревматична аортна стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 809, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8730), 3, false, "Ревматична аортна инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 810, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8763), 3, false, "Ревматична аортна стеноза и инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 811, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8797), 3, false, "Други ревматични болести на аортната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 812, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8831), 3, false, "Ревматична болест на аортната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 813, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8868), 3, false, "Трикуспидална стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 814, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8901), 3, false, "Атеросклероза на бъбречна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 815, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8934), 3, false, "Трикуспидална инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 816, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9008), 3, false, "Трикуспидална стеноза и инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 817, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9045), 3, false, "Други болести на трикуспидалната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 818, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9077), 3, false, "Болест на трикуспидалната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 819, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9108), 3, false, "Съчетано засягане на митралната и аортната клапи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 820, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9140), 3, false, "Съчетано засягане на митралната и трикуспидалната клапи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 821, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9172), 3, false, "Съчетано засягане на аортната и трикуспидалната клапи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 822, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9213), 3, false, "Съчетано засягане на митралната, аортната и трикуспидалната клапи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 823, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9243), 3, false, "Други болести на няколко клапи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 824, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9273), 3, false, "Болест на няколко клапи, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 825, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9303), 3, false, "Ревматичен миокардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 826, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9336), 3, false, "Ревматични болести на ендокарда без уточняване на клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 827, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9366), 3, false, "Хроничен ревматичен перикардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 828, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9398), 3, false, "Други уточнени ревматични болести на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 829, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9431), 3, false, "Ревматична болест на сърцето, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 830, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(9465), 4, false, "Пиогенен артрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 859, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(482), 4, false, "Други серопозитивни ревматоидни артрити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 860, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(515), 4, false, "Серопозитивен ревматоиден артрит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 861, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(593), 4, false, "Серонегативен ревматоиден артрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 862, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(625), 4, false, "Болест на Still при възрастни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 892, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1632), 4, false, "Подагра, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 893, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(2122), 4, false, "Кристаловидна артропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 894, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(2522), 4, false, "Болести с отлагане на хидроксиапатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 895, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(3043), 4, false, "Наследствена хондрокалциноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 896, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(3428), 4, false, "Друга хондрокалциноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 897, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(3711), 4, false, "Други уточнени кристалоидни артропатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 898, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(3883), 4, false, "Кристалоидна артропатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 899, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(3935), 4, false, "Хронична постревматична артропатия [Jaccoud]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 900, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(3969), 4, false, "Болест на Kaschin-Beck", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 901, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4002), 4, false, "Вилонодуларен синовит (пигментен)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 902, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4035), 4, false, "Палиндромен ревматизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 903, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4067), 4, false, "Интермитентна хидрартроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 904, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4099), 4, false, "Травматична артропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 905, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4133), 4, false, "Други уточнени артропатии, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 906, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4219), 4, false, "Полиартрит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 907, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4257), 4, false, "Моноартрит, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 908, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4291), 4, false, "Други уточнени артрити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 909, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4323), 4, false, "Артрит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 910, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4354), 4, false, "Подагрозна артропатия, дължаща се на ензимни дефекти и други наследствени нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 911, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4387), 4, false, "Кристалоидна артропатия при други болести на обмяната на веществата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 912, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4419), 4, false, "Диабетна артропатия (Е10-Е14ї с общ четвърти знак .6)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 913, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4449), 4, false, "Липоиден дерматоартрит (Е78.8ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 914, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4479), 4, false, "Артропатия при амилоидоза (Е85.-ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 915, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4511), 4, false, "Артропатия при други болести на ендокринната система, разстройства на храненето и обмяната на веществата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 916, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4547), 4, false, "Невропатична артропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 891, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1601), 4, false, "Друга вторична подагра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 805, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8602), 3, false, "Митрална стеноза и инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 890, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1569), 4, false, "Подагра, предизвикана от нарушение на бъбречната функция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 888, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1504), 4, false, "Подагра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 863, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(656), 4, false, "Ревматоиден бурсит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 864, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(691), 4, false, "Ревматоидни възли", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 865, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(721), 4, false, "Възпалителна полиартропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 866, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(751), 4, false, "Други уточнени ревматоидни артрити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 867, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(783), 4, false, "Ревматоиден артрит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 868, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(813), 4, false, "Дистална интерфалангеална псориатична артропатия (L40.5ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 869, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(844), 4, false, "Инвалидизиращ артрит (L40.5ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 870, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(878), 4, false, "Псориатичен спондилит (L40.5ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 871, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(909), 4, false, "Други псориатични артропатии (L40.5ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 872, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(943), 4, false, "Артропатия при болестта на Crohn [регионален ентерит] (К50.-ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 873, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(979), 4, false, "Артропатия при улцерозен колит (К51.-ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 874, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1010), 4, false, "Други ентеропатични артропатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 875, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1042), 4, false, "Юношески ревматоиден артрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 876, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1074), 4, false, "Юношески анкилозиращ спондилит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 877, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1102), 4, false, "Юношески артрит със системно начало", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 878, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1134), 4, false, "Юношески полиартрит (серонегативен)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 879, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1165), 4, false, "Юношески пауциартикуларен артрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 880, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1196), 4, false, "Други юношески артрити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 881, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1227), 4, false, "Юношески артрит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 882, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1262), 4, false, "Юношески артрит при псориазис (L40.5ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 883, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1343), 4, false, "Юношески артрит при болестта на Crohn (регионален ентерит) (К50.-ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 884, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1379), 4, false, "Юношески артрит при улцерозен колит (К51.-ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 885, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1410), 4, false, "Юношески артрит при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 886, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1443), 4, false, "Идиопатична подагра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 887, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1473), 4, false, "Оловна подагра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 889, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(1534), 4, false, "Медикаментозна подагра", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 461, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3262), 3, false, "Ритъмно-проводни усложнения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 804, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8567), 3, false, "Ревматична митрална инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 802, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8502), 3, false, "Белодробно-съдова болест, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 720, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5463), 3, false, "Ендокардит без уточняване на засегнатата клапа при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 721, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5495), 3, false, "Инфекциозен миокардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 722, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5527), 3, false, "Изолиран миокардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 723, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5560), 3, false, "Други видове остър миокардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 724, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5592), 3, false, "Остър миокардит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 725, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5623), 3, false, "Миокардит при бактериални болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 726, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5655), 3, false, "Миокардит при вирусни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 727, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5860), 3, false, "Миокардит при други инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 728, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5899), 3, false, "Миокардит при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 729, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5930), 3, false, "Дилатативна кардиомиопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 730, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5962), 3, false, "Обструктивна хипертрофична кардиомиопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 719, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5427), 3, false, "Увреждания на няколко клапи при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 731, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5994), 3, false, "Друга хипертрофична кардиомиопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 733, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6057), 3, false, "Ендокардна фиброеластоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 734, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6088), 3, false, "Друга рестриктивна кардиомиопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 735, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6121), 3, false, "Алкохолна кардиомиопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 736, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6156), 3, false, "Кардиомиопатия, причинена от лекарства и други външни фактори", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 737, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6190), 3, false, "Други кардиомиопатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 738, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6220), 3, false, "Кардиомиопатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 739, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6252), 3, false, "Кардиомиопатия при инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 740, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6284), 3, false, "Кардиомиопатия при метаболитни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 741, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6315), 3, false, "Кардиомиопатия при разстройства на храненето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 742, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6348), 3, false, "Кардиомиопатия при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 743, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6381), 3, false, "Атриовентрикуларен блок, първа степен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 732, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6025), 3, false, "Ендомиокардна (еозинофилна) болест", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 718, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5394), 3, false, "Увреждания на пулмоналната клапа при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 717, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5363), 3, false, "Увреждания на трикуспидалната клапа при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 716, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5331), 3, false, "Увреждания на аортната клапа при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 691, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3576), 3, false, "Перикардит при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 692, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3624), 3, false, "Остър и подостър инфекциозен ендокардит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 693, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3701), 3, false, "Остър ендокардит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 694, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3747), 3, false, "Митрална (клапна) инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 695, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3794), 3, false, "Митрален (клапен) пролапс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 696, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3844), 3, false, "Неревматична митрална (клапна) стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 697, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3888), 3, false, "Други неревматични болести на митралната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 698, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(3932), 3, false, "Неревматична болест на митралната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 699, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(4691), 3, false, "Аортна (клапна) стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 700, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(4742), 3, false, "Аортна (клапна) инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 701, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(4773), 3, false, "Аортна (клапна) стеноза и инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 702, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(4801), 3, false, "Други болести на аортната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 703, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(4832), 3, false, "Болест на аортната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 704, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(4864), 3, false, "Неревматична трикуспидална (клапна) стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 705, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(4902), 3, false, "Неревматична трикуспидална (клапна) инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 706, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5006), 3, false, "Неревматична трикуспидална (клапна) стеноза и инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 707, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5040), 3, false, "Други неревматични болести на трикуспидалната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 708, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5071), 3, false, "Неревматична болест на трикуспидалната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 709, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5103), 3, false, "Стеноза на пулмоналната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 710, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5133), 3, false, "Инсуфициенция на пулмоналната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 711, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5166), 3, false, "Стеноза и инсуфициенция на пулмоналната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 712, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5203), 3, false, "Други болести на пулмоналната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 713, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5235), 3, false, "Болест на пулмоналната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 714, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5267), 3, false, "Ендокардит без уточняване на засегнатата клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 715, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(5299), 3, false, "Увреждания на митралната клапа при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 744, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6419), 3, false, "Атриовентрикуларен блок, втора степен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 745, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6450), 3, false, "Атриовентрикуларен блок, пълен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 746, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6481), 3, false, "Друг и неуточнен атриовентрикуларен блок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 747, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6513), 3, false, "Ляв преден хемиблок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 777, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7594), 3, false, "Лявокамерна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 778, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7624), 3, false, "Сърдечна недостатъчност, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 779, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7657), 3, false, "Дефект на сърдечна преграда, придобит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 780, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7692), 3, false, "Руптура на сухожилни хорди, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 781, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7723), 3, false, "Руптура на папиларен мускул, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 782, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7756), 3, false, "Вътресърдечна тромбоза, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 783, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7789), 3, false, "Миокардит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 784, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7820), 3, false, "Миокардна дегенерация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 785, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7852), 3, false, "Сърдечно-съдова болест, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 786, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7884), 3, false, "Кардиомегалия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 787, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7915), 3, false, "Други неточно определени болести на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 788, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7948), 3, false, "Болест на сърцето, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 789, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7984), 3, false, "Други сърдечни увреждания при бактериални болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 790, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8016), 3, false, "Други сърдечни увреждания при други инфекциозни и паразитни болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 791, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8049), 3, false, "Други сърдечни увреждания при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 792, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8082), 3, false, "Белодробна емболия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 793, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8114), 3, false, "Белодробна емболия със споменаване на остро белодробно сърце", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 794, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8237), 3, false, "Белодробна емболия без споменаване на остро белодробно сърце", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 795, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8272), 3, false, "Първична белодробна хипертония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 796, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8307), 3, false, "Кифосколиотично сърце", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 797, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8339), 3, false, "Други уточнени форми на белодробно сърце", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 798, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8373), 3, false, "Белодробно сърце, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 799, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8404), 3, false, "Артериовенозна фистула на белодробните съдове", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 800, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8437), 3, false, "Аневризма на белодробна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 801, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8469), 3, false, "Други уточнени болести на белодробните съдове", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 776, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7561), 3, false, "Застойна сърдечна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 803, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(8534), 3, false, "Митрална стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 775, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7529), 3, false, "Сърдечна аритмия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 773, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7464), 3, false, "Синдром на болния синусов възел", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 748, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6544), 3, false, "Ляв заден хемиблок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 749, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6631), 3, false, "Друг и неуточнен хемиблок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 750, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6665), 3, false, "Ляв бедрен блок, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 751, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6699), 3, false, "Десен фасцикуларен блок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 752, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6731), 3, false, "Друг и неуточнен десен бедрен блок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 753, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6763), 3, false, "Бифасцикуларен блок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 754, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6798), 3, false, "Трифасцикуларен блок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 755, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6830), 3, false, "Неспецифичен вътрекамерен блок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 756, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6861), 3, false, "Друг уточнен сърдечен блок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 757, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6894), 3, false, "Синдром на преждевременно възбуждане", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 758, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6927), 3, false, "Други уточнени проводни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 759, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6959), 3, false, "Проводно нарушение, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 760, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(6993), 3, false, "Спиране на сърцето с успешно възстановяване на сърдечната дейност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 761, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7027), 3, false, "Внезапна сърдечна смър", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 762, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7061), 3, false, "Спиране на сърцето, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 763, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7092), 3, false, "Кръгова (re-entry) камерна аритмия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 764, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7123), 3, false, "Надкамерна тахикардия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 765, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7155), 3, false, "Камерна тахикардия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 766, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7186), 3, false, "Пароксизмална тахикардия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 767, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7219), 3, false, "Предсърдно мъждене и трептене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 768, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7252), 3, false, "Камерно мъждене и трептене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 769, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7284), 3, false, "Преждевременна предсърдна деполаризация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 770, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7317), 3, false, "Преждевременна деполаризация от антриовентрикуларното съединени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 771, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7351), 3, false, "Преждевременна камерна деполаризация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 772, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7431), 3, false, "Друга и неуточнена преждевременна деполаризация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 774, new DateTime(2019, 7, 23, 12, 50, 35, 920, DateTimeKind.Local).AddTicks(7497), 3, false, "Други уточнени сърдечни аритмии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 460, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3230), 3, false, "Руптура (разкъсване) на различни части от сърдечната мускулатура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 459, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3191), 3, false, "Застойна сърдечна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 458, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3160), 3, false, "Тромбоза на камера като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2106), 2, false, "Анестезия на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2140), 2, false, "Рецидивираща ерозия на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2174), 2, false, "Болест на роговицата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2205), 2, false, "Склерит и еписклерит при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 150, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2235), 2, false, "Кератит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2263), 2, false, "Кератоконюнктивит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 152, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2294), 2, false, "Остър иридоциклит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 153, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2374), 2, false, "Подостър иридоциклит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2407), 2, false, "Хроничен иридоциклит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 155, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2439), 2, false, "Иридоциклит, дължащ се на лещи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 156, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2469), 2, false, "Други иридоциклити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2078), 2, false, "Ектазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2500), 2, false, "хифема", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 159, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2564), 2, false, "дегенерация на ириса и цилиарното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 160, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2597), 2, false, "киста на ириса и цилиарното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 161, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2629), 2, false, " бомбажа на ириса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 162, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2662), 2, false, "зеничната оклузия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 163, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2693), 2, false, "зеничната секлузия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 164, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2723), 2, false, "гониосинехия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 165, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2753), 2, false, "иридодиализа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 166, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2786), 2, false, "рецесия на камерния ъгъл", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 167, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2818), 2, false, "синехии на ириса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 168, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2851), 2, false, "Други уточнени болести на ириса и цилиарното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 169, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2882), 2, false, "Други неуточнени болести на ириса и цилиарното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 158, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2531), 2, false, "неоваскуларизация на ириса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2047), 2, false, "Изменения на мембраната на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2018), 2, false, "Инфилтрат на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1988), 2, false, "Везикули по роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1132), 2, false, "Заден склерит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1163), 2, false, "Стафилом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1197), 2, false, "Екваториален стафилом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1228), 2, false, "Кератит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1260), 2, false, "Язва на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1294), 2, false, "Маргинален кератит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1326), 2, false, "Пълзяща язва на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1356), 2, false, "Дълбок интерстициален кератит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1385), 2, false, "Паренхиматозен кератит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1414), 2, false, "Цикатрикси", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1445), 2, false, "Левкома", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1478), 2, false, "Пигментация и отлагания на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1513), 2, false, "Булозна кератопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1611), 2, false, "Корнеални едеми", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1646), 2, false, "Дегенерация на роговица", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1680), 2, false, "Кератоконус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1709), 2, false, "Мек кератоконус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1739), 2, false, "Умерен кератоконус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1769), 2, false, "Напреднал кератоконус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1800), 2, false, "Наследствени дистрофии на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1831), 2, false, "Наследствена дистрофия на епителиалната базална мембрана", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1863), 2, false, "Наследствена гранулозна дистрофия на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1894), 2, false, "Наследствена петниста дистрофия на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1925), 2, false, "Наследствени Фукс дистрофия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1956), 2, false, "Оток на роговицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 170, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2913), 2, false, "увреждания на ириса и цилиарното тяло при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 171, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2942), 2, false, "Хетерохромен циклит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 172, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(2971), 2, false, "Хориоретинално възпаление ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 173, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3003), 2, false, "кръвоизлив и руптура на хороидеята ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 203, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4339), 2, false, "Ангиоидните стрии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 204, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4367), 2, false, "Периферните дегенерации на ретината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 205, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4395), 2, false, "Ретиналната микроаневризма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 206, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4424), 2, false, "Неоваскуларизацията на ретината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 207, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4455), 2, false, "Ретиналният васкулит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 208, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4486), 2, false, "Ретинопатията на Коутс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 209, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4514), 2, false, "Ексудативната ретинопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 210, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4542), 2, false, "Хипертензивната ретинопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 211, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4573), 2, false, "Преретинопатия ( ретролентикуларна ) фиброплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 212, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4610), 2, false, "Пролиферативната витреоретинопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 213, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4643), 2, false, "Ангиоидни ивици на макулата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 214, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4672), 2, false, "Друзите на макулата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 215, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4699), 2, false, "Отворът на макулата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 216, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4729), 2, false, "Старческа дегенерация на макулата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 217, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4756), 2, false, "Наследствените ретинални дистрофии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 218, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4786), 2, false, "Ретиналната пигментоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 219, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4817), 2, false, "Болест на Щаргардт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 220, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4846), 2, false, "други форми на отлепване на ретината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 221, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4881), 2, false, "Вителиформена фовеомакуларна дистрофия при възрастни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 222, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5081), 2, false, "Ретинална хеморагия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 223, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5112), 2, false, "Централна серозна хориоретинопатия ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 224, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5140), 2, false, "Отлепване на ретинален пигментен епител", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 225, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5166), 2, false, "Други уточнени увреждания на ретината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 226, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5194), 2, false, "Увреждане на ретината, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 227, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5223), 2, false, "Начална старческа катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 202, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4310), 2, false, "Дисциформена сенилна дегенерация на макулата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1103), 2, false, "Преден склерит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 201, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4277), 2, false, "Кръвоизливите в ретината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 199, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4204), 2, false, "Други ретинални съдови оклузии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 174, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3033), 2, false, "Глаукома ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 175, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3063), 2, false, " хориоретинални цикатрикси ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 176, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3149), 2, false, " дегенерация на хороидеята ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 177, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3189), 2, false, "наследствена дегенерация на хороидеята ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 178, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3222), 2, false, "отлепване на хороидеята ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 179, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3255), 2, false, "Други уточнени болести на хориоидеята ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 180, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3285), 2, false, "Болест на хориоидеята, неуточнена ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 181, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3315), 2, false, "Други уточнени болести на хориоидеята ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 182, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3345), 2, false, "Други неуточнени болести на хориоидеята ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 183, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3376), 2, false, "Първично (идиопатично, серозно) отлепване на ретината ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 184, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3409), 2, false, "Вторично отлепване на ретината ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 185, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3441), 2, false, "Отлепване на ретината с ретинално разкъсване ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 186, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3469), 2, false, "Дегенеративната ретиносхиза  ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 187, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3499), 2, false, "Тракционната ретиносхиза ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 188, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3525), 2, false, "Ретиносхизис  ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 189, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3554), 2, false, "Ексудативна Ретиносхизис ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 190, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3715), 2, false, "разкъсвания на ретината без отлепване ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 191, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3743), 2, false, "Тракционното отлепване на ретината", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 192, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3776), 2, false, "Остра непроходимост (оклузия) на централната ретинна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 193, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3808), 2, false, "Остра оклузия на ствола на централната ретинна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 194, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3847), 2, false, "Остра оклузия на клон на централната ретинна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 195, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3877), 2, false, "Преходна ретинална артериална оклузия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 196, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3906), 2, false, "Централната ретинална артериална оклузия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 197, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3935), 2, false, "Петното на Холенхорст", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 198, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(3965), 2, false, "ретинална артериална оклузия (клонова, частична, микроемболия)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 200, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(4247), 2, false, "Ретинална съдова оклузия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 228, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5255), 2, false, "Старческа нуклеарна катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1071), 2, false, "Еписклерит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1009), 2, false, "Други уточнени болести на лещата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7818), 2, false, "Девиация на носната преграда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7854), 2, false, "Хипертрофия на носната раковина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7885), 2, false, "Перфорация на носната преграда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7921), 2, false, "Ринолит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7952), 2, false, "Негнойно възпаление на средното ухо", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7985), 2, false, "Гнойно и неуточнено възпаление на средното ухо", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8015), 2, false, "Възпаление и запушване на Евстахиевата тръба", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8045), 2, false, "Възпаление на средното ухо при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8074), 2, false, "Болести на Евстахиевата тръба", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8104), 2, false, "Мастоидит и сродни състояния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8195), 2, false, "Холестеатом на средното ухо", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7786), 2, false, "Мукоцеле на носа и носния синус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8227), 2, false, "Перфорация на тъпанчето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8287), 2, false, "Злокачествено новообразувание на основата на езика", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8318), 2, false, "Нистагъм и други непроизволни движения на очите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8348), 2, false, "Абсолютна зенична неподвижност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8379), 2, false, "Рефлексна зенична неподвижност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8410), 2, false, "Анизокория ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8446), 2, false, "Нарушение на зрението", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8479), 2, false, "Симпатическото възпаление", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8508), 2, false, "Диплопия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8537), 2, false, "Слепота", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8564), 2, false, "Никталопия (Нощна слепота)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8599), 2, false, "Хемералопия (Дневна слепота)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8257), 2, false, "Други болести на тъпанчето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7758), 2, false, "Кисти на носа и носния синус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7727), 2, false, "Карбункул на носа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7699), 2, false, "Фуринкул на носа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6474), 1, false, "Енцефалит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6611), 1, false, "Болест на Хънтингтън", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6648), 1, false, "Болест на Паркинсон", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6677), 1, false, "Наследствена атаксия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6711), 1, false, "Спинална мускулна атрофия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6743), 1, false, "Болест на Алцхаймер", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6775), 1, false, "Множествена склероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6806), 1, false, "Епилепсия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6839), 1, false, "Мигрена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6869), 1, false, "Увреждания на лицевия нерв", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6902), 1, false, "Увреждания на троичния нерв", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6948), 1, false, "Миастения гравис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(6979), 1, false, "Периферна невропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7009), 1, false, "Церебрална парализа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7044), 2, false, "Глосит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7074), 2, false, "Географски език", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7105), 2, false, "Възпален език", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7429), 2, false, "Срединен ромбоиден глосит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7473), 2, false, "Хипертрофия на папилите на езика", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7505), 2, false, "Атрофия на папилите на езика", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7545), 2, false, "Нагънат език", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7577), 2, false, "Глосодиния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7607), 2, false, "Отосклероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7638), 2, false, "Нарушения на вестибуларната функция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(7670), 2, false, "Абсцес на носа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8630), 2, false, "Дефекти на зрителното поле", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8659), 2, false, "Мблиопия ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8689), 2, false, "Други зрителни разстройства", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8719), 2, false, "Аномална трихромазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(151), 2, false, "Фибриларна дегенерация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(180), 2, false, "Витреоретинни дегенерации", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(212), 2, false, "Кръвоизливи в стъкловидното тяло (Хемофталм)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(242), 2, false, "Пролапсът (отлепването) на стъкловидното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(271), 2, false, "Кристални отлагания в стъкловидното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(301), 2, false, "Помътнявания в стъкловидното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(331), 2, false, "Дегенерация на стъкловидното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(360), 2, false, "Отлагания в стъкловидното тяло", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(390), 2, false, "Пробивни наранявания на очната ябълка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(420), 2, false, "Глаукома", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(450), 2, false, "Огнищно хориоретинално възпаление", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(482), 2, false, "Дисеминирано хориоретинално възпаление", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(511), 2, false, "Заден циклит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(543), 2, false, "Болест на Харада", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(573), 2, false, "Хороидитът", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(601), 2, false, "Травматична катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(629), 2, false, "Лекарствено-индуцирана катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(657), 2, false, "Миотонична катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(685), 2, false, "Усложнена катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(712), 2, false, "Детска, юношеска и пресенилната катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(744), 2, false, "Вторична катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(779), 2, false, "Друга уточнена катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(905), 2, false, "Неуточнена катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(947), 2, false, "Афакия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(977), 2, false, "Травматично изместване на лещата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(121), 2, false, "Атрофията на зрителния нерв", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(1040), 2, false, "Болест на лещата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(32), 2, false, "Токсична оптиконевропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9928), 2, false, "Папилитът (Интрабулбарен неврит)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8757), 2, false, "Дихромазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8787), 2, false, "Монохромазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8821), 2, false, "Амблиопия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8851), 2, false, "Астенопия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8882), 2, false, "Метаморфобсия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(8913), 2, false, "Фотофобия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9014), 2, false, "Скотома сцинтиланс (Проблясваща скотома)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9365), 2, false, "Внезапна загуба на зрението", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9406), 2, false, "Диплопия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9434), 2, false, "Хемианопсия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9467), 2, false, "Квадрантна анoпсия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9503), 2, false, "Скотомите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9532), 2, false, "Ахроматопсия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9562), 2, false, "Цветна слепота (Далтонизъм)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9594), 2, false, "Деутераномалия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9625), 2, false, "Паралитичен страбизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9655), 2, false, "Механичният страбизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9686), 2, false, "Конкомитенетен страбизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9716), 2, false, "Хетерофория ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9743), 2, false, "Синдром на Дуейн", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9774), 2, false, "Кривогледство", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9805), 2, false, "Ортофория", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9840), 2, false, "Парализа на погледа (очите)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9869), 2, false, "Недостатъчност на конвергенцията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9898), 2, false, "Интернуклеарната офталмоплегия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, new DateTime(2019, 7, 23, 12, 50, 35, 917, DateTimeKind.Local).AddTicks(9957), 2, false, "Ретробулбарен неврит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 917, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4580), 4, false, "Артропатия при други уточнени болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 229, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5288), 2, false, "Старческата катаракта, морганиев тип ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 231, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5348), 2, false, "Старческа катаракта, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 376, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(120), 3, false, "Трипредсърдно сърце", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 377, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(149), 3, false, "Белодробна инфундибуларна стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 378, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(181), 3, false, "Вродена субаортна стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 379, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(211), 3, false, "Аномалия на коронарните съдове", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 380, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(242), 3, false, "Вроден сърдечен блок", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 381, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(272), 3, false, "Вроден дивертикул на лявата камера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 382, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(305), 3, false, "Вродена малформация на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 383, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(339), 3, false, "Вродени дефекти на перикарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 384, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(374), 3, false, "Неправилно положение на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 385, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(404), 3, false, "Други уточнени вродени аномалии на сърцето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 386, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(434), 3, false, "Вродена аномалия на сърцето, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 375, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(89), 3, false, "Левокардия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 387, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(467), 3, false, "Отворен ductus arteriosus", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 389, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(527), 3, false, "Атрезия на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 390, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(557), 3, false, "Стеноза на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 391, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(588), 3, false, "Липса на аорта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 392, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(618), 3, false, "Аплазия на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 393, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(649), 3, false, "Вродена аневризма на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 394, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(680), 3, false, "Вродена дилатация на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 395, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(713), 3, false, "Аневризма на синуса на Valsalva", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 396, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(744), 3, false, "Двойна аортна дъга", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 397, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(773), 3, false, "Ахипоплазия на аортата (неразвита напълно аорта)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 398, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(856), 3, false, "Персистиращи извивки на аортната дъга", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 399, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(887), 3, false, "Дясна аортна дъга", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 388, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(499), 3, false, "Коарктация на аортата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 374, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(55), 3, false, "Декстрокардия ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 373, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9944), 3, false, "Вродена аномалия на аортната и митралната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 372, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9913), 3, false, "Други вродени аномалии на митралната и аортната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 347, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9087), 3, false, "Други вродени аномалии на сърдечните камери и съобщителните отвори", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 348, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9121), 3, false, "Вродена аномалия на сърдечните камери и съобщителните отвори, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 349, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9152), 3, false, "Междукамерен септален дефект", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 350, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9184), 3, false, "Междупредсърден септален дефект", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 351, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9218), 3, false, "Предсърднокамерен септален дефект", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 352, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9294), 3, false, "Тетралогия на Фало (ТФ, Tetralogy of Fallot)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 353, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9326), 3, false, "Пенталогия на Фало", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 354, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9356), 3, false, "Аортопулмонален септален дефект", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 355, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9386), 3, false, "Дефект на Eisenmenger", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 356, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9416), 3, false, "Други вродени аномалии на сърдечната преграда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 357, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9448), 3, false, "Вродена аномалия на сърдечната преграда, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 358, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9479), 3, false, "Атрезия на клапата на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 359, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9509), 3, false, "Вродена стеноза на клапата на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 360, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9543), 3, false, "Вродена инсуфициенция на клапата на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 361, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9571), 3, false, "Други вродени аномалии на клапата на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 362, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9600), 3, false, "Вродена стеноза на трикуспидалната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 363, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9634), 3, false, "Аномалия на Ebstein", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 364, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9664), 3, false, "Синдром на хипопластичното дясно сърце", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 365, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9691), 3, false, "Други вродени аномалии на трикуспидалната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 366, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9722), 3, false, "Вродена аномалия на трикуспидалната клапа, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 367, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9758), 3, false, "Вродена стеноза на аортната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 368, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9790), 3, false, "Вродена инсуфициенция на аортната клапа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 369, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9820), 3, false, "Вродена митрална стеноза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 370, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9852), 3, false, "Вродена митрална инсуфициенция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 371, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9883), 3, false, "Синдром на хипопластичното ляво сърце", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 400, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(916), 3, false, "Атрезия на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 401, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(944), 3, false, "Стеноза на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 402, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(976), 3, false, "Аберантна белодробна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 403, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1007), 3, false, "Агенезия на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 433, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1999), 3, false, "Вродена варикоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 434, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2030), 3, false, "Вродена аномалия на периферната съдова система, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 435, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2058), 3, false, "Артериовенозна аномалия на прецеребрални съдове", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 436, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2085), 3, false, "Други аномалии на прецеребралните съдове", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 437, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2113), 3, false, "Артериовенозна аномалия на церебрални съдове", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 438, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2146), 3, false, "Други вродени аномалии на церебралните съдове", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 439, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2174), 3, false, "Вродената аневризма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 440, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2203), 3, false, "Други уточнени вродени аномалии на системата на кръвообращението", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 441, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2233), 3, false, "Вродена аномалия на системата на кръвообращението, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 442, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2308), 3, false, "Исхемична болест на сърцето (ИБС)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 443, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2340), 3, false, "Стенокардия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 444, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2368), 3, false, "Остър инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 445, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2397), 3, false, "Повторен инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 446, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2427), 3, false, "Рецидиви на исхемията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 447, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2458), 3, false, "Ритъмно - проводни нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 448, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2486), 3, false, "Сърдечна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 449, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2514), 3, false, "Други усложнения на миокардния инфаркт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 450, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2863), 3, false, "Хемоперикард като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 451, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2922), 3, false, "Междупредсърден дефект като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 452, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2958), 3, false, "Междукамерен дефект като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 453, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(2992), 3, false, "Руптура на сърдечната стена без хемоперикард като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 454, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3034), 3, false, "Руптура на сухожилна хорда като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 455, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3067), 3, false, "Руптура на папиларен мускул като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 456, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3096), 3, false, "Тромбоза на предсърдие като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 457, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(3129), 3, false, "Тромбоза на предсърдно ухо като текущо усложнение на острия инфаркт на миокарда", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 432, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1970), 3, false, "Вродена стриктура на артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 346, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9055), 3, false, "Изомерия на предсърдните уши", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 431, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1940), 3, false, "Вродена аневризма (периферна)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 429, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1877), 3, false, "Липса на артерия или вена, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 404, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1042), 3, false, "Аневризма на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 405, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1072), 3, false, "Аномалия на пулмоналната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 406, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1101), 3, false, "Хипоплазия на белодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 407, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1130), 3, false, "Белодробна артериовенозна аневризма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 408, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1160), 3, false, "Други вродени аномалии на големите артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 409, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1189), 3, false, "Вродена аномалия на големите артерии, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 410, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1219), 3, false, "Вродена стеноза на vena cava", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 411, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1250), 3, false, "Персистираща лява горна куха вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 412, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1281), 3, false, "Тотално аномално вливане на белодробните вени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 413, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1316), 3, false, "Частично аномално вливане на белодробните вени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 414, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1348), 3, false, "Аномално вливане на белодробните вени, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 415, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1382), 3, false, "Аномално вливане на порталната вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 416, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1414), 3, false, "Фистула между порталната вена и чернодробната артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 417, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1444), 3, false, "други вродени аномалии на големите вени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 418, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1475), 3, false, "Липса на долната куха вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 419, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1504), 3, false, "Персистираща vena azygos като продължение на vena cava", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 420, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1597), 3, false, "Персистиране на лява задна кардинална вена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 421, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1631), 3, false, "Синдром на кривата турска сабя (scimatar syndrome)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 422, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1665), 3, false, "Вродена аномалия на голяма вена, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 423, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1693), 3, false, "Вродена липса и хипоплазия на пъпна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 424, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1721), 3, false, "Вродена стеноза на бъбречна артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 425, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1750), 3, false, "Други вродени аномалии на бъбречната артерии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 426, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1780), 3, false, "Периферна артериовенозна аномалия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 427, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1812), 3, false, "Вродена флебектазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 428, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1843), 3, false, "Аберантна подключична артерия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 430, new DateTime(2019, 7, 23, 12, 50, 35, 919, DateTimeKind.Local).AddTicks(1911), 3, false, "Атрезия на артерия или вена, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 230, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5319), 2, false, "Други старчески катаракти ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 345, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(9023), 3, false, "Дискордантно предсърднокамерно свързване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 343, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8958), 3, false, "Дискордантно свързване на камерите с артериите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 261, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6375), 2, false, "други болести, нарушаващи функцията на клепача", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 262, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6404), 2, false, "Ксантелазма на клепача", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 263, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6436), 2, false, "Мадароза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 264, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6463), 2, false, "Хлоазма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 265, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6491), 2, false, "Витилиго", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 266, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6521), 2, false, "Други дегенеративни болести на клепача и околоочната област", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 267, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6556), 2, false, "Хипертрихоза на клепача", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 268, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6585), 2, false, "Задържано чуждо тяло в клепача", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 269, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6613), 2, false, "Други уточнени болести на клепача", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 270, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6643), 2, false, "Болест на клепача, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 271, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6673), 2, false, "Увреждания на клепача при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 260, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6347), 2, false, "Блефарофимозата ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 272, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6702), 2, false, "Дакриоаденит ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 274, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6757), 2, false, "Дакриопс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 275, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6785), 2, false, "Епифора", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 276, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6815), 2, false, "Дакриоцистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 277, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6843), 2, false, "Каналикулит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 278, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6870), 2, false, "Стеноза и инсуфициенция на слъзните пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 279, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6898), 2, false, "Дакриолитът ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 280, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6925), 2, false, "Фистула на слъзните пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 281, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7024), 2, false, "Други изменения на слъзните пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 282, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7058), 2, false, "Други болести на слъзния апарат", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 283, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7090), 2, false, "Стенозата на назолакрималния канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 284, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7121), 2, false, "Болест на слъзния апарат, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 273, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6729), 2, false, "Синдром на сухото око", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 259, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6315), 2, false, "Анкилоблефаронът", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 258, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6280), 2, false, "Птозата на горния клепач", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 257, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6191), 2, false, "Лагофталм ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 232, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5378), 2, false, "Травматична катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 233, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5408), 2, false, "Детска, юношеска и пресенилна катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 234, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5440), 2, false, "Усложнена катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 235, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5470), 2, false, "Катаракта, предизвикана от лекарствени средства", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 236, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5497), 2, false, "Вторична катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 237, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5525), 2, false, "Друга уточнена катаракта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 238, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5553), 2, false, "Катаракта, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 239, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5584), 2, false, "Афакия ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 240, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5614), 2, false, "Травматично изместване на лещата (Изкълчване на лещата)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 241, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5645), 2, false, "Други уточнени болести на лещата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 242, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5675), 2, false, "Болест на лещата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 243, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5705), 2, false, "Катаракта и други увреждания на лещата при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 244, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5737), 2, false, "Конюнктивит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 245, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5817), 2, false, "Птеригиум ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 246, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5849), 2, false, "Ксерозата на конюнктивата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 247, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5881), 2, false, "Други болести на конюнктивата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 248, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5915), 2, false, "Увреждания на конюнктивата при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 249, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5945), 2, false, "Халационът (конюнктивален гранулом)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 250, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(5974), 2, false, "Хордеолум (ечемик на окото)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 251, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6003), 2, false, "Фурункул на клепача", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 252, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6035), 2, false, "Абсцес на клепача", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 253, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6063), 2, false, "Халационът (конюнктивален гранулом)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 254, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6094), 2, false, "Ентропион", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 255, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6126), 2, false, "Трихиазата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 256, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(6157), 2, false, "Ектропион ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 285, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7150), 2, false, "Периостит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 286, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7181), 2, false, "Остиопериостит ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 287, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7208), 2, false, "Острият периостит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 288, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7235), 2, false, "Подостър или хроничен периостит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 318, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8178), 2, false, "Пресбиакузис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 319, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8204), 2, false, "Внезапна идиопатична загуба на слуха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 320, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8231), 2, false, "Друга загуба на слуха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 321, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8258), 2, false, "Оталгията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 322, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8285), 2, false, "Оторея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 323, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8312), 2, false, "Оторагия (кръвотечение от ухото)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 324, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8340), 2, false, "Дегенеративни и съдови болести на ухото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 325, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8370), 2, false, "Шум в ушите (субективен)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 326, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8400), 2, false, "Нарушаване на слуховото възприятие", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 327, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8427), 2, false, "Диплакузис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 328, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8453), 2, false, "Хиперакузис ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 329, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8482), 2, false, "Преходна смяна на слуховия праг", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 330, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8556), 2, false, "Болести на слуховия нерв ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 331, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8587), 2, false, "Невриномът (Шваномът) на слуховия нерв", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 332, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8615), 2, false, "Други уточнени болести на ухото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 333, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8645), 2, false, "Болест на ухото, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 334, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8679), 2, false, "Перихондрит на външното ухо", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 335, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8712), 2, false, "Церумен (ушна кал)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 336, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8744), 2, false, "Неинфекциозни болести на ушната мида (придобити деформации на ушната мида)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 337, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8774), 2, false, "Придобита стеноза на външния слухов проход", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 338, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8801), 2, false, "Други уточнени болести на външното ухо", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 339, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8832), 2, false, "Други увреждания на ухото при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 340, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8863), 3, false, "Общ артериален трункус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 341, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8895), 3, false, "Удвоен изходен отвор на дясната камера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 342, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8925), 3, false, "Удвоен изходен отвор на лявата камера", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 317, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8152), 2, false, "Глухонемота", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 344, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8991), 3, false, "Удвоен камерен входен отвор", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 316, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8123), 2, false, "Невросензорна загуба на слуха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 314, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8058), 2, false, "Външен отит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 289, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7262), 2, false, "Тенонитът ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 290, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7290), 2, false, "Екзофталм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 291, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7318), 2, false, "Енофталм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 292, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7345), 2, false, "деформация на орбитата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 293, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7374), 2, false, "Киста на орбитата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 294, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7405), 2, false, "други болести на орбитата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 295, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7437), 2, false, "Болест на орбитата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 296, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7468), 2, false, "Увреждания на слъзния апарат и орбитата при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 297, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7500), 2, false, "Фибром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 298, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7531), 2, false, "Ксантом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 299, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7560), 2, false, "Хемангиом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 300, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7592), 2, false, "Остеом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 301, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7621), 2, false, "Дермоидна киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 302, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7652), 2, false, "Неврофибром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 303, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7683), 2, false, "Глиом на зрителния нерв", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 304, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7713), 2, false, "Папилом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 305, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7741), 2, false, "Невус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 306, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7819), 2, false, "Ретенционни кисти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 307, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7853), 2, false, "Ретинобластом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 308, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7881), 2, false, "Базоцелуларен карцином", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 309, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7908), 2, false, "Левкоплакия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 310, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7936), 2, false, "Плоскоклетъчен карцином", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 311, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7966), 2, false, "Денокарцином на Мейбомиевите жлез", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 312, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(7996), 2, false, "Малигнен меланом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 313, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8026), 2, false, "Лезия, излизаща извън границите на една и повече посочени локализации на окото и неговите придатъци", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 315, new DateTime(2019, 7, 23, 12, 50, 35, 918, DateTimeKind.Local).AddTicks(8088), 2, false, "Глухота, свързана с нарушение в провеждането на звука (кондуктивна)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1837, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(166), 5, false, "Увреждания на черния дроб при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 918, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4612), 4, false, "Първична генерализирана (остео)артроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 920, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4674), 4, false, "Възли на Bouchard (с артропатия)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1525, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(813), 5, false, "Карцином на черния дроб, първичен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1526, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(842), 5, false, "Карцином на интрахепаталните жлъчни пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1527, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(870), 5, false, "Хепатобластом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1528, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(899), 5, false, "Ангиосарком на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1529, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(927), 5, false, "Други саркоми на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1530, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(956), 5, false, "Други уточнени карциноми на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1531, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(984), 5, false, "Злокачествено новообразувание на черен дроб, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1532, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1012), 5, false, "Злокачествено новообразование на жлъчния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1533, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1042), 5, false, "Злокачествено новообразувание на други и неуточнени части на жлъчните пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1534, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1075), 5, false, "Злокачествено новообразувание на панкреаса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1535, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1104), 5, false, "Злокачествено новообразувание на храносмилателните органи с друга и неточно определена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1524, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(780), 5, false, "Лезия, излизаща извън границите на една и повече посочени локализации на ректума, ануса и аналния канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1536, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1133), 5, false, "Доброкачествено новообразование на устните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1538, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1197), 5, false, "Доброкачествено новообразование на устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1539, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1272), 5, false, "Доброкачествено новообразование на други и неуточнени части на устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1540, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1309), 5, false, "Доброкачествено новообразование на сливица (тонзила)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1541, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1340), 5, false, "Доброкачествено новообразование на други части на орофаринкса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1542, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1369), 5, false, "Доброкачествено новообразование на назофаринкс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1543, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1397), 5, false, "Доброкачествено новообразование на хипофаринкс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1544, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1425), 5, false, "Доброкачествено новообразование на фаринкс, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1545, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1454), 5, false, "Доброкачесвени тумори на дебелото черво", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1546, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1482), 5, false, "Болест на Crohn на тънкото черво", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1547, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1510), 5, false, "Болест на Crohn на дебелото черво", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1548, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1539), 5, false, "Други разновидности на болестта на Crohn", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1537, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1162), 5, false, "Доброкачествено новообразование на език", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1523, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(751), 5, false, "Злокачествено новообразувание на клоакогенна зона", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1522, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(720), 5, false, "Злокачествено новообразувание на анален канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1521, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(691), 5, false, "Злокачествено новообразувание на анус, неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1496, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9628), 5, false, "Злокачествено новообразувание на дъно на стомаха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1497, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9657), 5, false, "Злокачествено новообразувание на тяло на стомаха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1498, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9688), 5, false, "Злокачествено новообразувание на антрум на пилора", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1499, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9757), 5, false, "Злокачествено новообразувание на малка кривина на стомаха, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1500, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9787), 5, false, "Злокачествено новообразувание на голяма кривина на стомаха, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1501, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9817), 5, false, "Лезия, излизаща извън границите на една и повече посочени локализации на стомаха", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1502, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9846), 5, false, "Злокачествено новообразувание на стомах, неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1503, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9875), 5, false, "Злокачествено новообразувание на дванадесетопръстник (дуоденум)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1504, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9907), 5, false, "Злокачествено новообразувание на иеюнум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1505, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9951), 5, false, "Злокачествено новообразувание на илеум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1506, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(35), 5, false, "Злокачествено новообразувание на дивертикул на Meckel", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1507, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(67), 5, false, "Лезия, излизаща извън границите на една и повече посочени локализации на тънките черва", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1508, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(97), 5, false, "Злокачествено новообразувание на тънки черва, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1509, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(125), 5, false, "Злокачествено новообразувание на цекум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1510, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(154), 5, false, "Злокачествено новообразувание на апендикс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1511, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(183), 5, false, "Злокачествено новообразувание на колон асценденс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1512, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(217), 5, false, "Злокачествено новообразувание на флексура хепатика", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1513, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(245), 5, false, "Злокачествено новообразувание на колон трансверзум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1514, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(273), 5, false, "Злокачествено новообразувание на флексура лиеналис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1515, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(303), 5, false, "Злокачествено новообразувание на колон десценденс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1516, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(336), 5, false, "Злокачествено новообразувание на колон сигмоидеум", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1517, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(366), 5, false, "Лезия, излизаща извън границите на една и повече посочени локализации на дебелото черво", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1518, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(396), 5, false, "Злокачествено новообразувание на дебело черво, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1519, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(628), 5, false, "Злокачествено новообразувание на ректосигмоидалната област", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1520, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(663), 5, false, "Злокачествено новообразувание на правото черво (ректум)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1549, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1570), 5, false, "Болест на Crohn, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1495, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9600), 5, false, "Злокачествено новообразувание на кардиа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1550, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1598), 5, false, "Улцерозен (хроничен) ентероколит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1552, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1656), 5, false, "Улцерозен (хроничен) проктит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1582, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2577), 5, false, "Дивертикули на тънкото черво без перфорация или абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1583, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2648), 5, false, "Дивертикули на дебелото черво с перфорация и абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1584, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2678), 5, false, "Дивертикули на дебелото черво без перфорация и абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1585, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2707), 5, false, "Дивертикули на тънкото и на дебелото черво с перфорация и абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1586, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2735), 5, false, "Дивертикули на тънкото и на дебелото черво без перфорация или абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1587, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2765), 5, false, "Дивертикули на червата на неуточнена част, с перфорация и абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1588, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2794), 5, false, "Дивертикули на червата на неуточнена част, без перфорация и абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1589, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2824), 5, false, "Синдром на раздразненото черво с диария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1590, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2855), 5, false, "Синдром на раздразненото черво без диария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1591, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2884), 5, false, "Запек", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1592, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2911), 5, false, "Функционална диария", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1581, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2548), 5, false, "Дивертикули на тънкото черво с перфорация и абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1593, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2939), 5, false, "Неврогенни черва, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1595, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3000), 5, false, "Спазъм на аналния сфинктер", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1596, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3028), 5, false, "Други уточнени функционални нарушения на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1597, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3058), 5, false, "Функционално нарушение на червата, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1598, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3087), 5, false, "Остра анална фисура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1599, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3119), 5, false, "Хронична анална фисура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1600, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3147), 5, false, "Анална фисура, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1601, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3175), 5, false, "Анална фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1602, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3203), 5, false, "Ректална фистула ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1603, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3231), 5, false, "Аноректална фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1604, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3261), 5, false, "Анален абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1605, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3343), 5, false, "Ректален абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1594, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2969), 5, false, "Мегаколон, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1580, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2520), 5, false, "Илеус, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1579, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2491), 5, false, "Друга и неуточнена чревна непроходимост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1578, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2458), 5, false, "Чревни сраствания [бридове] с непроходимост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1553, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1685), 5, false, "Улцерозен (хроничен) ректосигмоидит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1554, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1713), 5, false, "Псевдополипоза на колона", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1555, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1740), 5, false, "Мукозен проктоколит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1556, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1768), 5, false, "Други улцерозни колити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1557, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1796), 5, false, "Улцерозен колит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1558, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1827), 5, false, "Радиационен гастроентерит и колит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1559, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1855), 5, false, "Токсичен гастроентерит и колит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1560, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1883), 5, false, "Алергичен и алиментарен гастроентерит и колит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1561, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1955), 5, false, "Други уточнени неинфекциозни гастроентерити и колити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1562, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1984), 5, false, "Неинфекциозен гастроентерит и колит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1563, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2014), 5, false, "Доброкачествено новообразувание на други и неточно определени части на храносмилателната система", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1564, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2046), 5, false, "Остър апендицит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1565, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2075), 5, false, "Други форми на апендицит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1566, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2106), 5, false, "Апендицит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1567, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2135), 5, false, "Други болести на апендикса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1568, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2163), 5, false, "Остри съдови болести на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1569, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2193), 5, false, "Хронични съдови болести на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1570, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2221), 5, false, "Ангиодисплазия на колона", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1571, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2251), 5, false, "Други съдови болести на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1572, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2281), 5, false, "Съдови болести на червата, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1573, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2312), 5, false, "Паралитичен илеус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1574, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2341), 5, false, "Инвагинация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1575, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2375), 5, false, "Волвулус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1576, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2402), 5, false, "Илеус, предизвикан от жлъчен камък", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1577, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(2430), 5, false, "Друг вид запушване на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1551, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(1628), 5, false, "Улцерозен (хроничен) илеоколит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1494, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9571), 5, false, "Злокачествено новообразувание на хранопровода, неуточнена част", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1493, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9543), 5, false, "Лезия, излизаща извън границите на една и повече посочени локализации на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1492, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9514), 5, false, "Злокачествено новообразувание на долната трета на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1410, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6936), 4, false, "Бурсит на външния страничен лигамент на коляното [Pellegrini-Stieda]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1411, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7004), 4, false, "Тендинит на капачката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1412, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7033), 4, false, "Тендинит на ахилесовото сухожилие", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1413, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7062), 4, false, "Перонеален тендинит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1414, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7090), 4, false, "Други ентезопатии на долен крайник, без стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1415, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7120), 4, false, "Ентезопатия на долен крайник, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1416, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7148), 4, false, "Медиален епикондилит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1417, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7176), 4, false, "Латерален епикондилит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1418, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7203), 4, false, "Периартрит на китката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1419, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7231), 4, false, "Екзостоза на калканеуса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1420, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7259), 4, false, "Метатарзалгия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1409, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6909), 4, false, "Синдром на трактус илео-тибиалис", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1421, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7286), 4, false, "Други ентезопатии на стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1423, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7345), 4, false, "Ентезопатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1424, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7373), 4, false, "Неуточнен ревматизъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1425, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7401), 4, false, "Миалгия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1426, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7429), 4, false, "Неуточнени невралгия и неврит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1427, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7457), 4, false, "Неуточнен паникулит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1428, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7485), 4, false, "Хипертрофия на мастната тъкан под пателата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1429, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7514), 4, false, "Остатъчно чуждо тяло в меките тъкани", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1430, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7543), 4, false, "Болка в крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1431, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7572), 4, false, "Други уточнени увреждания на меките тъкани", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1432, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7600), 4, false, "Увреждане на меките тъкани, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1433, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7632), 4, false, "Позиционна кифоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1422, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7314), 4, false, "Други ентезопатии, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1408, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6881), 4, false, "Екзостоза на криста илиака", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1407, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6853), 4, false, "Псоас-тендинит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1406, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6824), 4, false, "Глутеален тендинит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1381, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6071), 4, false, "Абсцес на синовиалната торбичка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1382, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6098), 4, false, "Други инфекциозни бурсити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1383, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6127), 4, false, "Синовиална поплитеална киста [Baker]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1384, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6155), 4, false, "Други кисти на синовиалната торбичка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1385, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6183), 4, false, "Калциеви отлагания в синовиалната торбичка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1386, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6211), 4, false, "Други бурсити, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1387, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6240), 4, false, "Други уточнени бурсопатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1388, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6268), 4, false, "Бурсопатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1389, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6341), 4, false, "Фиброматоза на палмарната апоневроза [Dupuytren]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1390, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6370), 4, false, "Съединително-тъканни възли в дорзалната повърхност на пръстите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1391, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6399), 4, false, "Фиброматоза на плантарната апоневроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1392, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6426), 4, false, "Възлест фасциит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1393, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6454), 4, false, "Псевдосаркоматозна (пролиферативна) фиброматоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1394, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6482), 4, false, "Фасциит, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1395, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6510), 4, false, "Други фибробластични увреждания", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1396, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6539), 4, false, "Фибробластично увреждане, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1397, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6569), 4, false, "Увреждания на меките тъкани при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1398, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6597), 4, false, "Адхезивен капсулит на рамото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1399, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6625), 4, false, "Синдром на ротаторния маншон на рамото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1400, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6653), 4, false, "Тендинит на бицепса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1401, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6681), 4, false, "Калцифициращ тендинит на рамото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1402, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6709), 4, false, "Синдром на удареното рамо", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1403, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6737), 4, false, "Бурсит на рамото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1404, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6765), 4, false, "Други увреждания на рамото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1405, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6793), 4, false, "Увреждане на рамото, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1434, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7710), 4, false, "Други вторични кифози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1435, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7741), 4, false, "Други и неуточнени кифози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1436, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7769), 4, false, "Плосък гръбначен стълб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1437, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7797), 4, false, "Други лордози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1467, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8742), 4, false, "Друг тип уточнена хернизация на междупрешленен диск", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1468, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8772), 4, false, "Друга уточнена дегенерация на междупрешленен диск", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1469, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8801), 4, false, "Възли на Schmorl", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1470, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8830), 4, false, "Друго уточнено увреждане на междупрешленен диск", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1471, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8858), 4, false, "Увреждане на междупрешленен диск, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1472, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8887), 4, false, "Шийночерепен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1473, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8916), 4, false, "Шийнобрахиален синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1474, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8944), 4, false, "Спинална нестабилност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1475, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8971), 4, false, "Кръстноопашни увреждания, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1476, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8999), 4, false, "Други уточнени дорзопатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1477, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9027), 4, false, "Дорзопатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1478, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9099), 4, false, "Паникулит, поразяващ шийния отдел и гръбначния отдел", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1479, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9131), 4, false, "Радикулопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1480, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9158), 4, false, "Цервикалгия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1481, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9193), 4, false, "Ишиас", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1482, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9223), 4, false, "Лумбаго с ишиас", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1483, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9254), 4, false, "Ниска кръстна болка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1484, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9282), 4, false, "Болка в гръдния отдел на гръбначния стълб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1485, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9312), 4, false, "Друга дорзалгия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1486, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9340), 4, false, "Дорзалгия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1487, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9368), 5, false, "Злокачествено новообразувание на шийна част на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1488, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9397), 5, false, "Злокачествено новообразувание на гръдната част на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1489, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9425), 5, false, "Злокачествено новообразувание на коремната част на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1490, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9457), 5, false, "Злокачествено новообразувание на горната трета на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1491, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(9486), 5, false, "Злокачествено новообразувание на средната трета на хранопровода", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1466, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8713), 4, false, "Увреждания на межпрешленните дискове в поясния и другите отдели на гръбначния стълб с радикулопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1606, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3375), 5, false, "Аноректален абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1465, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8677), 4, false, "Увреждания на междупрешленните дискове в поясния и другите отдели на гръбначния стълб с миелопатия (G99.2*)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1463, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8619), 4, false, "Други увреждания на междупрешленните дискове в шийния отдел", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1438, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7825), 4, false, "Лордоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1439, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7852), 4, false, "Инфантилна идиопатична сколиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1440, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7880), 4, false, "Ювенилна идиопатична сколиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1441, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7908), 4, false, "Други идиопатични сколиози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1442, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7938), 4, false, "Сколиоза при гръдни аномалии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1443, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7969), 4, false, "Невромускулна сколиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1444, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(7997), 4, false, "Други вторични сколиози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1445, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8025), 4, false, "Други форми на сколиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1446, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8053), 4, false, "Сколиоза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1447, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8081), 4, false, "Ювенилен остеохондрит на гръбначния стълб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1448, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8109), 4, false, "Остеохондрит на гръбначния стълб при възрастни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1449, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8137), 4, false, "Остеохондрит на гръбначния стълб, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1450, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8166), 4, false, "Спондилолиза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1451, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8200), 4, false, "Спондилолистеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1452, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8227), 4, false, "Други сраствания на гръбначния стълб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1453, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8256), 4, false, "Рецидивираща атланто-аксисна сублуксация с миелопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1454, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8284), 4, false, "Други рецидивиращи атланто-аксисни сублуксации", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1455, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8313), 4, false, "Други рецидивиращи сублуксации на гръбначния стълб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1456, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8342), 4, false, "Крива шия [torticollis]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1457, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8435), 4, false, "Други уточнени деформиращи дорзопатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1458, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8470), 4, false, "Деформираща дорзопатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1459, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8502), 4, false, "Увреждане на междупрешленните дискове в шийния отдел с миелопатия (G99.2*)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1460, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8531), 4, false, "Увреждане на междупрешленните дискове в шийния отдел с радикулопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1461, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8561), 4, false, "Друг тип хернизация на междупрешленните дискове в шийния отдел", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1462, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8590), 4, false, "Друг тип дегенерация на междупрешленните дискове в шийния отдел", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1464, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(8647), 4, false, "Увреждане на междупрешленните дискове в шийния отдел, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1607, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3403), 5, false, "Ишиоректален абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1608, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3431), 5, false, "Интрасфинктерен абсцес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1609, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3466), 5, false, "Анален полип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1754, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6946), 5, false, "Болест на храносмилателните органи, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1755, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6975), 5, false, "Камъни на жлъчния мехур с остър холецистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1756, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7003), 5, false, "Камъни на жлъчния мехур с друг холецистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 1757, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7032), 5, false, "Камъни на жлъчния мехур без холецистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1758, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7062), 5, false, "Камъни на жлъчните пътища с холангит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1759, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7090), 5, false, "Камъни на жлъчните пътища с холецистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1760, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7119), 5, false, "Камъни на жлъчните пътища без холангит или холецистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1761, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7148), 5, false, "Други видове холелитиаза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1762, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7221), 5, false, "Остър холецистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1763, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7250), 5, false, "Хроничен холецистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1764, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7279), 5, false, "Други видове холецистит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1753, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6915), 5, false, "Други уточнени болести на храносмилателните органи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1765, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7307), 5, false, "Холецистит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1767, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7363), 5, false, "Хидропс на жлъчния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1768, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7391), 5, false, "Перфорация на жлъчния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1769, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7419), 5, false, "Фистула на жлъчния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1770, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7447), 5, false, "Холестероза на жлъчния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1771, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7480), 5, false, "Други уточнени болести на жлъчния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1772, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7508), 5, false, "Болест на жлъчния мехур, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1773, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7536), 5, false, "Холангит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1774, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7565), 5, false, "Запушване на дуктус холедохус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1775, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7593), 5, false, "Перфорация на дуктус холедохус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1776, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7621), 5, false, "Фистула на дуктус холедохус", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1777, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7648), 5, false, "Спазъм на сфинктера на Oddi", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1766, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7336), 5, false, "Запушване на жлъчния мехур", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1752, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6886), 5, false, "Стомашночревен кръвоизлив, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1751, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6859), 5, false, "Мелена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1750, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6831), 5, false, "Хематемеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1725, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6066), 5, false, "Прехапване на буза и устна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1726, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6094), 5, false, "Левкоплакия и други изменения на устния епител, включително и на езика", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1727, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6123), 5, false, "Космата левкоплакия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1728, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6150), 5, false, "Гранулом и грануломоподобни увреждания на устната лигавица", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1729, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6179), 5, false, "Субмукозна фиброза на устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1730, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6208), 5, false, "Хиперплазия на устната лигавица, причинена от дразнене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1731, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6239), 5, false, "Други и неуточнени увреждания на устната лигавица", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1732, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6267), 5, false, "Цьолиакия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1733, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6295), 5, false, "Тропическо шпру", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1734, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6323), 5, false, "Синдром на сляпата бримка, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1735, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6351), 5, false, "Панкреатична стеаторея", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1736, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6378), 5, false, "Нарушена резорбция, причинена от непоносимост, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1737, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6408), 5, false, "Други нарушения на резорбцията в червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1738, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6437), 5, false, "Нарушение на резорбцията в червата, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1739, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6468), 5, false, "Повръщане след хирургична намеса върху стомашночревния тракт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1740, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6496), 5, false, "Синдроми на оперирания стомах", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1741, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6569), 5, false, "Нарушение на резорбцията след хирургична намеса, некласифицирано другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1742, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6598), 5, false, "Следоперативна чревна непроходимост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1743, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6626), 5, false, "Дисфункция след колостомия и ентеростомия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1744, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6655), 5, false, "Постхолецистектомичен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1745, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6682), 5, false, "Други увреждания на храносмилателните органи след медицински процедури, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1746, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6713), 5, false, "Увреждане на храносмилателните органи след медицински процедури, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1747, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6742), 5, false, "Туберкулозно увреждане на червата, перитонеума и мезентериалните лимфни възли (А18.3ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1748, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6774), 5, false, "Мегаколон при болестта на Chagas (B57.3ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1749, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6802), 5, false, "Увреждане на други уточнени храносмилателни органи при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1778, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7676), 5, false, "Жлъчна киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1779, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7705), 5, false, "Други уточнени болести на жлъчните пътища", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1780, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7735), 5, false, "Болест на жлъчните пътища, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1781, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7763), 5, false, "Остър панкреатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1811, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9171), 5, false, "Други хронични хепатити, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1812, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9200), 5, false, "Хроничен хепатит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1813, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9229), 5, false, "Фиброза на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1814, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9257), 5, false, "Склероза на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1815, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9284), 5, false, "Чернодробна фиброза с чернодробна склероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1816, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9312), 5, false, "Първична билиарна цироза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1817, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9341), 5, false, "Вторична билиарна цироза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1818, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9370), 5, false, "Билиарна цироза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1819, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9400), 5, false, "Друга и неуточнена цироза на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1820, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9428), 5, false, "Абсцес на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1821, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9458), 5, false, "Флебит на вена порте", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1822, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9485), 5, false, "Неспецифичен реактивен хепатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1823, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9513), 5, false, "Грануломатозен хепатит, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1824, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9541), 5, false, "Автоимунен хепатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1825, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9569), 5, false, "Други уточнени възпалителни болести на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1826, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9597), 5, false, "Възпалителна болест на черния дроб, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1827, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9783), 5, false, "Мастна дегенерация на черния дроб, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1828, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9822), 5, false, "Хронична пасивна конгестия на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1829, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9851), 5, false, "Центрилобуларна хеморагична некроза на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1830, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9879), 5, false, "Инфаркт на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1831, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9907), 5, false, "Пелиоза на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1832, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9946), 5, false, "Венооклузивна болест на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1833, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(26), 5, false, "Портална хипертония", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1834, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(76), 5, false, "Хепаторенален синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1835, new DateTime(2019, 7, 23, 12, 50, 35, 928, DateTimeKind.Local).AddTicks(107), 5, false, "Други уточнени болести на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1810, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9142), 5, false, "Хроничен активен хепатит, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1724, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6038), 5, false, "Рагада без допълнителни особености", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1809, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9104), 5, false, "Хроничен лобуларен хепатит, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1807, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9047), 5, false, "Чернодробна недостатъчност, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1782, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7790), 5, false, "Хроничен панкреатит с алкохолна етиология", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1783, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7819), 5, false, "Други хронични панкреатити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1784, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7847), 5, false, "Киста на задстомашната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1785, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7934), 5, false, "Псевдокиста на задстомашната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1786, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7963), 5, false, "Други уточнени болести на задстомашната жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1787, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(7992), 5, false, "Болест на задстомашната жлеза, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1788, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8021), 5, false, "Увреждания на жлъчния мехур, жлъчните пътища и задстомашната жлеза при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1789, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8055), 5, false, "Алкохолна мастна дистрофия на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1790, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8084), 5, false, "Алкохолен хепатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1791, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8114), 5, false, "Алкохолна фиброза и склероза на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1792, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8142), 5, false, "Алкохолна цироза на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1793, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8172), 5, false, "Алкохолна чернодробна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1794, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8200), 5, false, "Алкохолна болест на черния дроб, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1795, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8229), 5, false, "Токсично увреждане на черния дроб с холестаза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1796, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8260), 5, false, "Токсично увреждане на черния дроб с чернодробна некроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1797, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8292), 5, false, "Токсично увреждане на черния дроб, протичащо като остър хепатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1798, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8321), 5, false, "Токсично увреждане на черния дроб, протичащо като хроничен персистиращ хепатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1799, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8351), 5, false, "Токсично увреждане на черния дроб, протичащо като хроничен лобуларен хепатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1800, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8380), 5, false, "Токсично увреждане на черния дроб, протичащо като хроничен активен хепатит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1801, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8412), 5, false, "Токсично увреждане на черния дроб с картина на хепатит, некласифицирано другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1802, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8442), 5, false, "Токсично увреждане на черния дроб с фиброза и цироза на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1803, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8474), 5, false, "Токсично увреждане на черния дроб с картина на други нарушения на черния дроб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1804, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8503), 5, false, "Токсично увреждане на черния дроб, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1805, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(8977), 5, false, "Остра или подостра чернодробна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1806, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9019), 5, false, "Хронична чернодробна недостатъчност", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1808, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(9075), 5, false, "Хроничен персистиращ хепатит, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1380, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6042), 4, false, "Увреждане на меките тъкани, свързано с претоварване, натоварване и натиск, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1723, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(6010), 5, false, "Хейлоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1721, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5951), 5, false, "Гландуларен хейлит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1639, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4425), 5, false, "Кариес на емайла", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1640, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4455), 5, false, "Кариес на дентина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1641, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4483), 5, false, "Кариес на цимента", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1642, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4511), 5, false, "Преустановен зъбен кариес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1643, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4539), 5, false, "Одонтоклазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1644, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4568), 5, false, "Друг зъбен кариес", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1645, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4597), 5, false, "Зъбен кариес, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1646, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4629), 5, false, "Повишено изтъркване на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1647, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4658), 5, false, "Абразия на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1648, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4686), 5, false, "Ерозия на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1649, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4714), 5, false, "Патологична резорбция на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1638, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4396), 5, false, "Импактни зъби", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1650, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4742), 5, false, "Хиперциментоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1652, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4840), 5, false, "Отлагания [натрупвания] върху зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1653, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4870), 5, false, "Промяна в цвета на твърдите зъбни тъкани след поникването", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1654, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4900), 5, false, "Други уточнени болести на твърдите зъбни тъкани", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1655, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4930), 5, false, "Болест на твърдите зъбни тъкани, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1656, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(3753), 5, false, "Пулпит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1657, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(3944), 5, false, "Некроза на пулпата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1658, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(3982), 5, false, "Дегенерация на пулпата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1659, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4013), 5, false, "Неправилно образуване на твърди тъкани в пулпата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1660, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4043), 5, false, "Остър апикален периодонтит, произхождащ от пулпата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1661, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4073), 5, false, "Хроничен апикален периодонтит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1662, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4105), 5, false, "Периапикален абсцес с кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1651, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4771), 5, false, "Анкилоза на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1637, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4368), 5, false, "Вложени зъби", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1636, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4340), 5, false, "Нарушение в развитието на зъбите, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1635, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4311), 5, false, "Други нарушения в развитието на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1610, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3494), 5, false, "Ректален полип", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1611, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3522), 5, false, "Пролапс на ануса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1612, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3551), 5, false, "Пролапс на ректума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1613, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3579), 5, false, "Стеноза на ануса и ректума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1614, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3608), 5, false, "Кръвоизлив от ануса и ректума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1615, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3636), 5, false, "Язва на ануса и ректума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1616, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3664), 5, false, "Радиационен проктит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1617, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3694), 5, false, "Други уточнени болести на ануса и ректума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1618, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3726), 5, false, "Болест на ануса и ректума, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1619, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3756), 5, false, "Абсцес на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1620, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3784), 5, false, "Перфорация на червата (нетравматична)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1621, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3812), 5, false, "Фистула на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1622, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3839), 5, false, "Язва на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1623, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3867), 5, false, "Ентероптоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1624, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3895), 5, false, "Полип на колона", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1625, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3923), 5, false, "Други уточнени болести на червата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1626, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3950), 5, false, "Болест на червата, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1627, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(3981), 5, false, "Анодонтия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1628, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4009), 5, false, "Свърхбройни зъби", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1629, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4135), 5, false, "Аномалии в големината и формата на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1630, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4167), 5, false, "Петнисти зъби", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1631, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4197), 5, false, "Нарушения в образуването на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1632, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4225), 5, false, "Наследствени нарушения на структурата на зъба, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1633, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4253), 5, false, "Нарушения при никненето на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1634, new DateTime(2019, 7, 23, 12, 50, 35, 925, DateTimeKind.Local).AddTicks(4281), 5, false, "Синдром на никнене на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1663, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4151), 5, false, "Периапикален абсцес без кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1664, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4179), 5, false, "Радикулерна киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1665, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4207), 5, false, "Други и неуточнени болести на пулпата и периапикалните тъкани", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1666, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4236), 5, false, "Остър гингивит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1696, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5193), 5, false, "Други уточнени кисти в устната кухина, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1697, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5222), 5, false, "Киста в устната кухина, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1698, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5251), 5, false, "Нарушения в развитието на челюстите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1699, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5279), 5, false, "Гигантоклетъчен гранулом, централен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1700, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5307), 5, false, "Възпалителни болести на челюстите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1701, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5335), 5, false, "Алвеолит на челюстите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1702, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5364), 5, false, "Други уточнени болести на челюстите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1703, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5392), 5, false, "Болест на челюстта, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1704, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5422), 5, false, "Атрофия на слюнчена жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1705, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5450), 5, false, "Хипертрофия на слюнчена жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1706, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5479), 5, false, "Сиалоаденит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1707, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5506), 5, false, "Абсцес на слюнчена жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1708, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5534), 5, false, "Фистула на слюнчена жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1709, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5563), 5, false, "Сиалолитиаза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1710, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5590), 5, false, "Мукоцеле на слюнчена жлеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1711, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5618), 5, false, "Нарушения на слюнчената секреция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1712, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5648), 5, false, "Други болести на слюнчените жлези", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1713, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5677), 5, false, "Болест на слюнчена жлеза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1714, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5708), 5, false, "Рецидивиращи афти в устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1715, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5736), 5, false, "Други форми на стоматит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1716, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5765), 5, false, "Флегмон и абсцес в устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1717, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5793), 5, false, "Болести на устните", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1718, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5820), 5, false, "Хейлит без допълнителни особености", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1719, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5893), 5, false, "Ангуларен хейлит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1720, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5922), 5, false, "Ексфолиативен хейлит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1695, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5127), 5, false, "Други кисти на челюстта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1722, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5981), 5, false, "Хейлодиния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1694, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5097), 5, false, "Кисти при развитието (неодонтогенни) в устната кухина", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1692, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5041), 5, false, "Нарушение на зъбите и пародонта, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1667, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4264), 5, false, "Хроничен гингивит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1668, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4291), 5, false, "Остър периодонтит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1669, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4319), 5, false, "Хроничен пародонтит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1670, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4347), 5, false, "Пародонтоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1671, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4374), 5, false, "Други болести на пародонта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1672, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4405), 5, false, "Болест на пародонта, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1673, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4435), 5, false, "Отдръпване на венците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1674, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4463), 5, false, "Хипертрофия на венците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1675, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4544), 5, false, "Нарушения на венците и беззъбата алвеоларна криста, причинени от травма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1676, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4575), 5, false, "Други уточнени нарушения на венците и беззъбата алвеоларна криста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1677, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4604), 5, false, "Нарушение на венците и беззъбата алвеоларна криста, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1678, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4632), 5, false, "Големи аномалии в размерите на челюстите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1679, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4661), 5, false, "Аномалии на челюстночерепните съотношения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1680, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4694), 5, false, "Аномалии в съотношенията между зъбните дъги", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1681, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4723), 5, false, "Аномалии в положението на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1682, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4751), 5, false, "Аномалия на захапката, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1683, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4780), 5, false, "Челюстнолицеви функционални аномалии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1684, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4808), 5, false, "Нарушения на темпоромандибуларната става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1685, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4836), 5, false, "Други челюстнолицеви аномалии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1686, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4864), 5, false, "Челюстнолицева аномалия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1687, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4893), 5, false, "Зъбна ексфолиация, дължаща се на общи причини", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1688, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4925), 5, false, "Загуба на зъби, дължаща се на злополука, екстракция или локално заболяване на пародонта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1689, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4955), 5, false, "Атрофия на беззъбата алвеоларна криста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1690, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(4984), 5, false, "Задържан зъбен корен [ретенционен]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1691, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5013), 5, false, "Други уточнени нарушения на зъбите и пародонта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1693, new DateTime(2019, 7, 23, 12, 50, 35, 927, DateTimeKind.Local).AddTicks(5070), 5, false, "Кисти, свързани с развитието на зъбите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 919, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4643), 4, false, "Възли на Heberden (с артропатия)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1379, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(6010), 4, false, "Други увреждания на меките тъкани, свързани с натоварване, претоварване и натиск", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1377, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5954), 4, false, "Бурсит на големия трохантер", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1065, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5310), 4, false, "Забавена консолидация при фрактура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1066, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5352), 4, false, "Стресови фрактури, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1067, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5386), 4, false, "Патологична фрактура, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1068, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5425), 4, false, "Други нарушения в целостта на костите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1069, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5460), 4, false, "Нарушение в целостта на костите, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1070, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5499), 4, false, "Фиброзна дисплазия (на една кост)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1071, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5537), 4, false, "Флуороза на скелета", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1072, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5584), 4, false, "Хиперостоза на черепа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1073, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5635), 4, false, "Остеит, дължащ се на отлагане на минерални соли (склерозиращ)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1074, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5685), 4, false, "Солитарна костна киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1075, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5725), 4, false, "Аневризмална костна киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1064, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5270), 4, false, "Незараснала фрактура (псевдоартроза)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1076, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5757), 4, false, "Други костни кисти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1078, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5831), 4, false, "Нарушение в плътността и структурата на костта, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1079, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5883), 4, false, "Остеомиелит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1080, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5923), 4, false, "Остър хематогенен остеомиелит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1081, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5960), 4, false, "Други форми на остър остеомиелит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1082, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6044), 4, false, "Подостър остеомиелит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1083, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6085), 4, false, "Мултиплен хроничен остеомиелит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1084, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6126), 4, false, "Хроничен остеомиелит с фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1085, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6167), 4, false, "Други хронични хематогенни остеомиелити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1086, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6210), 4, false, "Други хронични остеомиелити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1087, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6249), 4, false, "Друг остеомиелит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1088, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6288), 4, false, "Остеомиелит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1077, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5783), 4, false, "Други уточнени нарушения в плътността и структурата на костта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1063, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5233), 4, false, "Лошо зараснала фрактура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1062, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5194), 4, false, "Нарушения в целостта на костите ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1061, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5160), 4, false, "Остеомалация при възрастни, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1036, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4125), 4, false, "Остеопороза с патологична фрактура след менопауза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1037, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4153), 4, false, "Остеопороза с патологична фрактура след овариектомия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1038, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4178), 4, false, "Остеопороза с патологична фрактура, дължаща се на следхирургично намаляване на чревната резорбция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1039, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4272), 4, false, "Медикаментозна остеопороза с патологична фрактура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1040, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4322), 4, false, "Идиопатична остеопороза с патологична фрактурa", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1041, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4375), 4, false, "Друга остеопороза с патологична фрактура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1042, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4423), 4, false, "Остеопороза с патологична фрактура, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1043, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4449), 4, false, "Остеопороза след менопауза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1044, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4476), 4, false, "Остеопороза след овариектомия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1045, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4510), 4, false, "Инактивитетна остеопороза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1046, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4546), 4, false, "Остеопороза, дължаща се на следхирургично намаляване на чревната резорбция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1047, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4577), 4, false, "Медикаментозна остеопороза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1048, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4608), 4, false, "Идиопатична остеопороза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1049, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4638), 4, false, "Локализирана остеопороза (Lequesne)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1050, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4678), 4, false, "Други остеопорози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1051, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4715), 4, false, "Остеопороза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1052, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4750), 4, false, "Oстеопороза при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1053, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4789), 4, false, "Остеомалация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1054, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4825), 4, false, "Послеродова остеомалация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1055, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4862), 4, false, "Старческа остеомалация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1056, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4902), 4, false, "Остеомалация при възрастни, дължаща се на намаляване на чревната резорбция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1057, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4941), 4, false, "Остеомалация при възрастни, дължаща се на недоимъчно хранене", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1058, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4984), 4, false, "Болест на костите, свързана с алуминий", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1059, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5020), 4, false, "Други медикаментозни остеомалации при възрастни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1060, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(5119), 4, false, "Друга остеомалация при възрастни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1089, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6328), 4, false, "Медикаментозна остеонекроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1090, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6368), 4, false, "Остеонекроза след предшестваща травма", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1091, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6413), 4, false, "Други вторични остеонекрози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1092, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6452), 4, false, "Други остеонекрози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1122, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7841), 4, false, "Друга ювенилна уточнена остеохондроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1123, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7885), 4, false, "Ювенилна остеохондроза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1124, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7931), 4, false, "Епифизиолиза на бедрената глава (нетравматична)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1125, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7972), 4, false, "Болест на Kienbоck при възрастни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1126, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8072), 4, false, "Дисекиращ остеохондрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1127, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8146), 4, false, "Други уточнени остеохондропатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1128, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8204), 4, false, "Остеохондропатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1129, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8265), 4, false, "Синдром на хондрокосталните съчленения (Tietze)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1130, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8331), 4, false, "Рецидивиращ полихондрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1131, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8376), 4, false, "Хондромалация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1132, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8450), 4, false, "Хондролиза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1133, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8509), 4, false, "Други уточнени увреждания на хрущяла", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1134, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8584), 4, false, "Увреждане на хрущяла, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1135, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8637), 4, false, "Възлест полиартериит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1136, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8710), 4, false, "Полиартериит с увреждане на белия дроб (Churg-Strauss])", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 1137, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8761), 4, false, "Ювенилен полиартериит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1138, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8838), 4, false, "Слузно-кожен-лимфонодуларен синдром (Kawasaki)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1139, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8890), 4, false, "Други състояния, свързани с възлест полиартериит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1140, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(8952), 4, false, "Суперчувствителен ангиит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1141, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9022), 4, false, "Тромботична микроангиопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1142, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9087), 4, false, "Злокачествен срединен гранулом", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1143, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9148), 4, false, "Грануломатоза на Wegener", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1144, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9223), 4, false, "Синдром на аортната дъга (Takayasu)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1145, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9301), 4, false, "Гигантоклетъчен артериит с ревматична полимиалгия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1146, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9362), 4, false, "Други гигантоклетъчни артериити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1121, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7800), 4, false, "Юношеска остеохондроза на предния отдел на стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1035, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4095), 4, false, "Остеопороза с патологична фрактура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1120, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7759), 4, false, "Юношеска остеохондроза на костите на стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1118, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7679), 4, false, "Ювенилна остеохондроза на пателата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1093, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6491), 4, false, "Остеонекроза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1094, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6532), 4, false, "Болест на Paget (Деформиращ остеит)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1095, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6571), 4, false, "Увреждане на черепа при болестта на Paget", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1096, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6610), 4, false, "Увреждане в други кости при болестта на Paget", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1097, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6651), 4, false, "Болест на Paget, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1098, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6692), 4, false, "Алгоневродистрофия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1099, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6731), 4, false, "Преждевременно срастване на епифизата с диафизата (епифизарен стоп)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1100, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6780), 4, false, "Други нарушения в растежа и развитието на костта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1101, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6822), 4, false, "Костна хипертрофия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1102, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6864), 4, false, "Друга хипертрофична остеоартропатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1103, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6912), 4, false, "Остеолиза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1104, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(6963), 4, false, "Остеопатия след полиомиелит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1105, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7116), 4, false, "Други уточнени увреждания на костите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1106, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7189), 4, false, "Болест на костта, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1107, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7235), 4, false, "Остеопатии при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1108, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7274), 4, false, "Юношеска остеохондроза на таза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1109, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7321), 4, false, "Юношеска остеохондроза на бедрената глава (Legg-Calve-Perthes)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1110, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7388), 4, false, "Coxa plana", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1111, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7440), 4, false, "Псевдококсалгия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1112, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7469), 4, false, "Други ювенилни остеохондрози на таза и бедрена-та става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1113, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7497), 4, false, "Ювенилна остеохондроза на таза и бедрената става, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1114, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7534), 4, false, "Ювенилна остеохондроза на раменната кост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1115, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7575), 4, false, "Ювенилна остеохондроза на лъчевата и лакътната кост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1116, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7613), 4, false, "Ювенилна остеохондроза на ръката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1117, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7644), 4, false, "Друга ювенилна остеохондроза на горния крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1119, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(7724), 4, false, "Ювенилна остеохондроза на тибия и фибула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1147, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9408), 4, false, "Други уточнени некротизиращи васкулопатии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1034, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4064), 4, false, "Биомеханично нарушение, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1032, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3982), 4, false, "Съединително-тъканна и дискова стеноза на интервертебралните отвори", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 950, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5721), 4, false, "Първична артроза на други стави", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 951, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5759), 4, false, "Посттравматична артроза на други стави", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 952, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5789), 4, false, "Друга вторична артроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 953, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5819), 4, false, "Друга уточнена артроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 954, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5846), 4, false, "Артроза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 955, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5874), 4, false, "Деформация на пръст(-и)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 956, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5906), 4, false, "Hallux valgus (придобит)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 957, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5937), 4, false, "Hallux rigidus", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 958, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5967), 4, false, "Други деформации на палеца на крак (придобити)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 959, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6000), 4, false, "Деформации тип пръст-чукче на пръстите на крак (придобити)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 960, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6030), 4, false, "Други деформации на пръст(-и) на крак (придобити)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 949, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5644), 4, false, "Артроза на първа карпо-метакарпална става, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 961, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6058), 4, false, "Придобити деформации на пръст(-и) на крак, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 963, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6121), 4, false, "Варусна деформация, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 964, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6149), 4, false, "Флексионна деформация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 965, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6179), 4, false, "Увиснали ръка или ходило [pes eqiinus] (придобити)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 966, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6206), 4, false, "Плоско стъпало [pes planus] (придобито)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 967, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6237), 4, false, "Придобити нокътовидна длан, крива ръка, стъпало с висок свод и криво стъпало", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 968, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6269), 4, false, "Други придобити деформации на глезена и стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 969, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6298), 4, false, "Различна дължина на крайниците (придобита)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 970, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6331), 4, false, "Други уточнени придобити деформации на крайниците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 971, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6366), 4, false, "Придобита деформация на крайник, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 972, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6394), 4, false, "Рецидивираща луксация на пателата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 973, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6528), 4, false, "Рецидивираща сублуксация на пателата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 962, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6089), 4, false, "Валгусна деформация, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 948, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5613), 4, false, "Други вторични артрози на първа карпо-метакарпална става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 947, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5585), 4, false, "Други вторични артрози на първа карпо-метакарпална става, двустранни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 946, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5557), 4, false, "Други посттравматични артрози на първа карпо-метакарпална става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 921, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4706), 4, false, "Вторична множествена артроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 922, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4738), 4, false, "Ерозивна (остео)артроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 923, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4771), 4, false, "Друга полиартроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 924, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4804), 4, false, "Полиартроза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 925, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4842), 4, false, "Първична коксартроза, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 926, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4873), 4, false, "Друга първична коксартроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 927, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4905), 4, false, "Дисплазична коксартроза, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 928, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(4936), 4, false, "Други дисплазични коксартрози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 929, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5021), 4, false, "Посттравматична коксартроза, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 930, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5054), 4, false, "Други посттравматични коксартрози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 931, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5086), 4, false, "Други вторични коксартрози, двустранни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 932, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5118), 4, false, "Други вторични коксартрозие", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 933, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5151), 4, false, "Коксартроза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 934, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5184), 4, false, "Гонартроза ( Артроза на колянната става )", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 935, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5215), 4, false, "Първична гонартроза, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 936, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5248), 4, false, "Други първични гонартрози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 937, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5279), 4, false, "Посттравматична гонартроза, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 938, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5311), 4, false, "Други посттравматични гонартрози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 939, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5341), 4, false, "Други вторични гонартрози, двустранни", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 940, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5372), 4, false, "Други вторични гонартрози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 941, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5403), 4, false, "Гонартроза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 942, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5437), 4, false, "Артроза на първа карпо-метакарпална става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 943, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5466), 4, false, "Първична артроза на първа карпо-метакарпална става, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 944, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5496), 4, false, "Други първични артрози на първа карпо-метакарпална става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 945, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(5525), 4, false, "Посттравматична артроза на първа карпо-метакарпална става, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 974, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6568), 4, false, "Феморопателарни увреждания", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 975, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6607), 4, false, "Други размествания на пателата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 976, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6636), 4, false, "Хондромалация на пателата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 977, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6666), 4, false, "Други увреждания на пателата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1007, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(1794), 4, false, "Ставно увреждане, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1008, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2196), 4, false, "Придобита деформация на носа", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1009, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2252), 4, false, "Деформация на ушната мида, предизвикана от травма и последващ перихондрит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1010, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2298), 4, false, "Други придобити деформации на главата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1011, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2328), 4, false, "Придобита деформация на шията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1012, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2371), 4, false, "Придобита деформация на гръдния кош и ребрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1013, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2406), 4, false, "Придобита деформация на таза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1014, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2437), 4, false, "Други уточнени придобити деформации на костно-мускулната система", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1015, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2468), 4, false, "Придобита деформация на костно-мускулната система, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1016, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2500), 4, false, "Псевдоартроза след артродеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1017, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(2530), 4, false, "Синдром след ламинектомия, некласифициран другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1018, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3062), 4, false, "Пострадиационна кифоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1019, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3151), 4, false, "Кифоза след ламинектомия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1020, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3211), 4, false, "Лордоза след хирургична намеса", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1021, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3270), 4, false, "Пострадиационна сколиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1022, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3326), 4, false, "Фрактура след поставяне на имплантат, ставна протеза или други остеосинтезни средства", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1023, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3387), 4, false, "Други увреждания на костно-мускулната система след медицински процедури", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1024, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3425), 4, false, "Увреждане на костно-мускулната система след медицински процедури, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1025, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3502), 4, false, "Сегментарна или соматична дисфункция", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1026, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3731), 4, false, "Комплексна сублуксация (вертебрална)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1027, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3790), 4, false, "Стеноза на спиналния канал при сублуксация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1028, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3811), 4, false, "Костна стеноза на спиналния канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1029, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3831), 4, false, "Съединително-тъканна стеноза на спиналния канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1030, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3871), 4, false, "Междупрешленна дискова стеноза на спиналния канал", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1031, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(3929), 4, false, "Костна и сублуксационна стеноза на интервертебралните отвори", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1006, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(1634), 4, false, "Други уточнени ставни увреждания", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1033, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(4024), 4, false, "Други биомеханични нарушения", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1005, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(1452), 4, false, "Остеофит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1003, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(703), 4, false, "Ставна болка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 978, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6695), 4, false, "Увреждане на пателата, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 979, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6727), 4, false, "Киста на мениска", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 980, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6759), 4, false, "Дискоиден мениск (вроден)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 981, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6788), 4, false, "Увреждане на мениска в резултат на стара травма или разкъсване", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 982, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6818), 4, false, "Други увреждания на мениска", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 983, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6847), 4, false, "Свободно тяло в става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 984, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6880), 4, false, "Свободно тяло в колянната става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 985, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(6911), 4, false, "Хронична нестабилност на колянната става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 986, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(7074), 4, false, "Други спонтанни руптури на връзка(-и) в колянната става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 987, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(7594), 4, false, "Други вътреставни увреждания на колянната става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 988, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(8208), 4, false, "Вътреставно увреждане на колянната става, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 989, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(8887), 4, false, "Други увреждания на ставния хрущял", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 990, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9206), 4, false, "Увреждания на връзките", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 991, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9261), 4, false, "Патологични луксация и сублуксация на става, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 992, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9308), 4, false, "Рецидивиращи луксация и сублуксация на става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 993, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9343), 4, false, "Контрактура на става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 994, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9376), 4, false, "Ставна анкилоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 995, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9475), 4, false, "Протрузия на ацетабулума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 996, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9509), 4, false, "Други уточнени ставни увреждания, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 997, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9541), 4, false, "Ставно увреждане, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 998, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9570), 4, false, "Хемартроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 999, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9598), 4, false, "Ставна фистула", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1000, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9627), 4, false, "Ставен хиперлакситет", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1001, new DateTime(2019, 7, 23, 12, 50, 35, 921, DateTimeKind.Local).AddTicks(9918), 4, false, "Друга нестабилност на ставата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1002, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(596), 4, false, "Ставен излив", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1004, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(909), 4, false, "Ставна ригидност, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1148, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9504), 4, false, "Некротизираща васкулопатия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1149, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9793), 4, false, "Дисеминиран лекарствен lupus erythematodes", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1150, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9895), 4, false, "Дисеминиран lupus erythematodes с увреждане на други органи или системи", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1295, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3448), 4, false, "Краниосиностоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1296, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3477), 4, false, "Краниофациална дизостоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1297, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3505), 4, false, "Хипертелоризъм", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1298, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3533), 4, false, "Макроцефалия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1299, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3561), 4, false, "Мандибулофациална дизостоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1300, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3589), 4, false, "Окуломандибуларна дизостоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1301, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3662), 4, false, "Други уточнени вродени аномалии на костите на черепа и лицето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1302, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3694), 4, false, "Вродена аномалия на костите на черепа и лицето, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1303, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3723), 4, false, "Разделяне на гръбначния стълб, скрито от кожата (Spina bifida)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1304, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3757), 4, false, "Синдромът на Клипел-Файл", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1305, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3784), 4, false, "Вродена спондилолистеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1294, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3419), 4, false, "Вродена аномалия на крайник (крайници), неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1306, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3812), 4, false, "Вродена сколиоза, дължаща се на вродена костна аномалия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1308, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3869), 4, false, "Шийно ребро", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1309, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3897), 4, false, "Други вродени аномалии на ребрата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1310, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3925), 4, false, "Вродена аномалия на стернума", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1311, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3953), 4, false, "Други вродени аномалии на торакалните кости", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1312, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3982), 4, false, "Вродена аномалия на торакалните кости, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1313, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4013), 4, false, "Ахондрогенеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1314, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4040), 4, false, "Синдром на късото ребро", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1315, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4068), 4, false, "Chondrodysplasia punctata", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1316, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4095), 4, false, "Ахондроплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1317, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4123), 4, false, "Дистрофична дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1318, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4150), 4, false, "Хондроектодермална дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1307, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3840), 4, false, "Други вродени аномалии на гръбначния стълб, несвързани със сколиоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1293, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3390), 4, false, "Други уточнени вродени аномалии на крайник (крайници)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1292, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3362), 4, false, "Arthrogriposis multiplex congenita", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1291, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3333), 4, false, "Други вродени аномалии на долен крайник (крайници), включително и на тазовия пояс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1266, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2521), 4, false, "Вродена липса на подбедрица и стъпало", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1267, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2549), 4, false, "Вродена липса на стъпало и пръст(-и) на стъпало", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1268, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2578), 4, false, "Дефект с намаляване на дължината на бедрената кост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1269, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2606), 4, false, "Дефект с намаляване на дължината на тибията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1270, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2635), 4, false, "Дефект с намаляване на дължината на фибулата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1271, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2664), 4, false, "Вродено разцепване на стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1272, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2695), 4, false, "Други редукционни дефекти на долен крайник (крайници)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1273, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2723), 4, false, "Редукционен дефект на долен крайник, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1274, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2751), 4, false, "Вродена липса на неуточнен крайник (крайници)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1275, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2779), 4, false, "Фокомелия на неуточнен крайник (крайници)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1276, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2808), 4, false, "Други редукционни дефекти на неуточнен крайник (крайници)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1277, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2837), 4, false, "Висок стоеж на лопатката (scapula alta songenita)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1278, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2865), 4, false, "Дисхондроплазия (Болест на Олие)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1279, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2987), 4, false, "Хондроматоза на коляното (chondromatosis genus)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1280, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3021), 4, false, "Етиопатогенеза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1281, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3049), 4, false, "Други вродени аномалии на горен крайник (крайници), включително и на раменния пояс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1282, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3079), 4, false, "Добавъчни карпални кости", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1283, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3107), 4, false, "Клейдокраниална дизостоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1284, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3134), 4, false, "Вродена псевдоартроза на ключицата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1285, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3162), 4, false, "Макродактилия на пръстите на ръцете", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1286, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3190), 4, false, "Деформация на Madelung", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1287, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3219), 4, false, "Радио-улнарната синостоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1288, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3249), 4, false, "Деформация на Shprengel", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1289, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3277), 4, false, "Трифалангеален палец", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1290, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(3305), 4, false, "Вродена аномалия на коляното", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1319, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4179), 4, false, "Спондилоепифизарна дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1320, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4207), 4, false, "Друга остеохондродисплазия с дефекти в растежа на тръбестите кости и гръбначния стълб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1321, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4237), 4, false, "Остеохондродисплазия с дефекти в растежа на тръбестите кости и гръбначния стълб, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1322, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4270), 4, false, "Osteogenesis imperfecta", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1352, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5197), 4, false, "Калцифициращ тендинит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1353, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5225), 4, false, "Щракащ пръст", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1354, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5253), 4, false, "Стенозиращ хроничен теносиновит на палеца [de Quervain]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1355, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5285), 4, false, "Други синовити и теносиновити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1356, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5313), 4, false, "Синовит и теносиновит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1357, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5341), 4, false, "Руптура на поплитеална киста", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1358, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5369), 4, false, "Руптура на синовията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1359, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5397), 4, false, "Спонтанна руптура на екстензорните сухожилия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1360, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5425), 4, false, "Спонтанна руптура на флексорните сухожилия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1361, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5453), 4, false, "Спонтанна руптура на други сухожилия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1362, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5481), 4, false, "Спонтанна руптура на неуточнени сухожилия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1363, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5510), 4, false, "Скъсяване на ахилесовото сухожилие (придобито)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1364, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5540), 4, false, "Друга сухожилна контрактура (на влагалището)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1365, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5569), 4, false, "Синовиална хипертрофия, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1366, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5598), 4, false, "Мигриращ синовит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1367, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5665), 4, false, "Ганглион", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1368, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5695), 4, false, "Други уточнени увреждания на синовията и сухожилията", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1369, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5723), 4, false, "Увреждане на синовията и сухожилията, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1370, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5752), 4, false, "Увреждания на синовиалните обвивки и сухожилията при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1371, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5782), 4, false, "Хроничен крепитиращ синовит на ръката и китката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1372, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5815), 4, false, "Бурсит на ръката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1373, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5843), 4, false, "Бурсит на олекранона", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1374, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5871), 4, false, "Други бурсити на лакътната става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1375, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5899), 4, false, "Препателарен бурсит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1376, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5926), 4, false, "Други бурсити на колянната става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1351, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5169), 4, false, "Други инфекциозни (тено)синовити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1265, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2494), 4, false, "Синдром на Roberts", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1350, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5141), 4, false, "Абсцес на сухожилното влагалище", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1348, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5085), 4, false, "Мускулно увреждане, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1323, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4339), 4, false, "Полиостеозна фиброзна дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1324, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4368), 4, false, "Остеопетроза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1325, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4396), 4, false, "Прогресираща диафизарна дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1326, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4424), 4, false, "Енхондроматоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1327, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4452), 4, false, "Метафизарна дисплазия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1328, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4479), 4, false, "Множествени вродени екзостози", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1329, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4507), 4, false, "Други уточнени остеохондродисплазии", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1330, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4538), 4, false, "Остеохондродисплазия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1331, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4566), 4, false, "Вродени аномалии на костно-мускулната система, некласифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1332, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4595), 4, false, "Миозит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1333, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4623), 4, false, "Травматичен осифициращ миозит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1334, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4651), 4, false, "Прогресиращ осифициращ миозит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1335, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4678), 4, false, "Паралитична калцификация и осификация на мускулите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1336, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4707), 4, false, "Калцификация и осификация на мускулите, свързани с изгаряния", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1337, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4735), 4, false, "Други калцификации в мускулите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1338, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4764), 4, false, "Друга осификация на мускулите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1339, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4795), 4, false, "Калцификация и осификация на мускулите, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1340, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4823), 4, false, "Мускулна диастаза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1341, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4851), 4, false, "Друга мускулна руптура (нетравматична)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1342, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4879), 4, false, "Исхемичен инфаркт на мускулите", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1343, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4907), 4, false, "Синдром от имобилизация (параплегичен)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1344, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4935), 4, false, "Мускулна контрактура", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1345, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(4997), 4, false, "Мускулна атрофия, некласифицирана другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1346, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5028), 4, false, "Мускулна деформация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1347, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5057), 4, false, "Други уточнени мускулни увреждания", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1349, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5113), 4, false, "Увреждания на мускулите при болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1264, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2465), 4, false, "Талидомидова ембриопатия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1263, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2433), 4, false, "Вродената липса на бедро и подбедрица при наличие на стъпало (Фокомелия)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1262, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2403), 4, false, "Вродена пълна липса на долен крайник (крайници)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1180, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1733), 4, false, "Къси кости на долен крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1181, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1767), 4, false, "Лезия, излизаща извън границите на една и повече посочени локализации на костите и ставните хрущяли на крайниците", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1182, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1799), 4, false, "Кости и ставни хрущяли на крайниците, с неуточнена локализация", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1183, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1829), 4, false, "Злокачествено новообразувание на кости на черепа и лицето", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1184, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1858), 4, false, "Злокачествено новообразувание на долна челюст (мандибула)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1185, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1884), 4, false, "Злокачествено новообразувание на гръбначен стълб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1186, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1909), 4, false, "Злокачествено новообразувание на ребра, гръдна кост и ключица", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1187, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1935), 4, false, "Злокачествено новообразувание на кости на таза, сакрума и опашката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1188, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1965), 4, false, "Злокачествено новообразувание на кости и ставни хрущяли, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1189, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1998), 4, false, "Скапула и дълги кости на горен крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1190, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2025), 4, false, "Доброкачествено новообразувание на костите и ставните хрущяли", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1179, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1700), 4, false, "Дълги кости на долен крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1191, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2424), 4, false, "Вродена луксация на бедрото, едностранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1193, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2570), 4, false, "Вродена луксация на бедрото, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1194, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2614), 4, false, "Вродена сублуксация на бедрото, едностранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1195, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2656), 4, false, "Вродена сублуксация на бедрото, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1196, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2706), 4, false, "Вродена сублуксация на бедрото, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1197, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2745), 4, false, "Неустойчиво бедро", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1198, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2786), 4, false, "Други вродени деформации на бедрото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1199, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2824), 4, false, "Вродена деформация на бедрото, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1200, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2859), 4, false, "Конско-варусно (криво) стъпало (talipes equinovarus)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1201, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2894), 4, false, "Варусно изкривяване на костта на петата (talipes calcaneovarus)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1202, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2935), 4, false, "Варус на метатарзалните кости (metatarsus varus)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1203, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2976), 4, false, "вродената варусна деформация на големия пръст на стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1192, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(2509), 4, false, "Вродена луксация на бедрото, двустранна", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1178, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1675), 4, false, "Къси кости на горен крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "IllnessTypes",
                columns: new[] { "Id", "CreateDate", "IllnessCategoryId", "IsDeleted", "Name", "OtherName", "UpdateDate" },
                values: new object[,]
                {
                    { 1177, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1648), 4, false, "Лопатка (скапула) и дълги кости на горен крайник", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1176, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1621), 4, false, "Системни увреждания на съединителната тъкан при други болести, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1151, new DateTime(2019, 7, 23, 12, 50, 35, 922, DateTimeKind.Local).AddTicks(9969), 4, false, "Други форми на дисеминиран lupus erythematodes", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1152, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(70), 4, false, "Дисеминиран lupus erythematodes, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1153, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(104), 4, false, "Ювенилен дерматомиозит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1154, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(143), 4, false, "Други дерматомиозити", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1155, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(219), 4, false, "Полимиозит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1156, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(257), 4, false, "Дерматополимиозит, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1157, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(300), 4, false, "Прогресивна системна склероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1158, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(382), 4, false, "Синдром CR(E)ST", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1159, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(423), 4, false, "Системна склероза, предизвикана от лекарствени средства и химични продукти", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1160, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(500), 4, false, "Други форми на системна склероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1161, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(549), 4, false, "Системна склероза, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1162, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(598), 4, false, "Синдром на Сьогрен (Sjogren)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1163, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(650), 4, false, "Синдром на Behcet", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1164, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(681), 4, false, "Ревматична полимиалгия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1165, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(720), 4, false, "Дифузен (еозинофилен) фасциит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1166, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(760), 4, false, "Мултиплена фибросклероза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1167, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(796), 4, false, "Рецидивиращ паникулит (Weber-Christian)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1168, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(826), 4, false, "Хипермобилен синдром", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1169, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(860), 4, false, "Други уточнени системни увреждания на съединителната тъкан", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1170, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(902), 4, false, "Системни увреждания на съединителната тъкан, неуточнени", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1171, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1236), 4, false, "Дермато(поли)миозит при новообразувания (С00-D48ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1172, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1308), 4, false, "Артропатия при новообразувания (С00-D48ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1173, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1523), 4, false, "Артропатия при хемофилия (D66-D68ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1174, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1560), 4, false, "Артропатия при други болести на кръвта (D50-D76ї)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1175, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(1594), 4, false, "Артропатия при реакции на свръхчувствителност, класифицирани другаде", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1204, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3021), 4, false, "Други вродени варусни деформации на стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1378, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(5982), 4, false, "Други бурсити на тазобедрената става", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1205, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3062), 4, false, "Валгусно изкривяване на костта на петата (talipes calcaneovalgus)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1207, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3144), 4, false, "Други вродени валгусни деформации на стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1237, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5579), 4, false, "Синдактилия тип 5 (SD5)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1238, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5617), 4, false, "Синдактилия тип 6 (SD6)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1239, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5649), 4, false, "Синдактилия тип 7 (SD7)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1240, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5678), 4, false, "Синдактилия тип 8 (SD8)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1241, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5727), 4, false, "Акроцефалосиндактилия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1242, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5797), 4, false, "Плавателна ципа на пръстите на ръка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1243, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5851), 4, false, "Срастването между пръстите на краката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1244, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5886), 4, false, "Синдром на Карпентър", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1245, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1213), 4, false, "Синдром на Аперт", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1246, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1292), 4, false, "Синдром на Едуардс", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1247, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1339), 4, false, "Синдром на Пфайфър", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1248, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1375), 4, false, "Синдром на Милър ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1249, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1408), 4, false, "Синдактилия на пръстите на крак, комбинирана със синостоза", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1250, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1441), 4, false, "Плавателна ципа на пръстите на крак", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1251, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1475), 4, false, "Полисиндактилия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1252, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1743), 4, false, "Синдактилия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1253, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(1998), 4, false, "Вродена пълна липса на горен крайник (крайници)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1254, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2073), 4, false, "Вродена липса на предмишница и предлакът при наличие на китка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1255, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2114), 4, false, "Вродена липса на предмишница и китка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1256, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2153), 4, false, "Вродена липса на китка и пръст(-и)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1257, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2185), 4, false, "Дефект с намаляване на дължината на лъчевата кост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1258, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2285), 4, false, "Дефект с намаляване на дължината на лакътната кост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1259, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2316), 4, false, "Китка тип щипка на рак", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1260, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2345), 4, false, "Други редукционни дефекти на горен крайник (крайници)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1261, new DateTime(2019, 7, 23, 12, 50, 35, 924, DateTimeKind.Local).AddTicks(2375), 4, false, "Редукционен дефект на горен крайник, неуточнен", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1236, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5551), 4, false, "Синдактилия тип 4 (SD4)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1206, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3103), 4, false, "Вродено плоско стъпало (pes planus)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1235, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(5493), 4, false, "Синдактилия тип 3 (SD3)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1233, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4225), 4, false, "Синдактилия тип 1 (SD1) ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1208, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3184), 4, false, "Metatarsus valgus", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1209, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3225), 4, false, "Вдлъбнато стъпало [pes cavus]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1210, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3265), 4, false, "Други вродени деформации на стъпалото", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1211, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3304), 4, false, "Вродена деформация на стъпалото, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1212, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3415), 4, false, "Лицева асиметрия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1213, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3472), 4, false, "Смачкано (компресирано) лице", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1214, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3515), 4, false, "Долихоцефалия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1215, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3550), 4, false, "Плагиоцефалия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1216, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3583), 4, false, "Други вродени деформации на черепа, лицето и челюстта", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1217, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3610), 4, false, "Вродена деформация на гръбначния стълб", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1218, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3646), 4, false, "Pectus excavatum", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1219, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3695), 4, false, "Pectus carinatum", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1234, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4984), 4, false, "Синдактилия тип 2 (SD2)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1220, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3746), 4, false, "Други вродени деформации на гръдния кош", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1222, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3822), 4, false, "Вродена деформация на китката", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1223, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3862), 4, false, "Вродена деформация на коляното", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1224, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3932), 4, false, "Вродено изкривяване на бедрената кост", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1225, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3980), 4, false, "Вродено изкривяване на тибията и фибулата", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1226, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4010), 4, false, "Вродено изкривяване на дългите кости на крака, неуточнено", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1227, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4042), 4, false, "Други уточнени вродени костно-мускулни деформации", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1228, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4071), 4, false, "Полидактилия", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1229, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4107), 4, false, "Добавъчен пръст (пръсти) на ръка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1230, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4136), 4, false, "Добавъчен палец (палци) на ръка", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1231, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4165), 4, false, "Добавъчен пръст (пръсти) на крак", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1232, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(4194), 4, false, "Полидактилия, неуточнена", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1221, new DateTime(2019, 7, 23, 12, 50, 35, 923, DateTimeKind.Local).AddTicks(3782), 4, false, "Вродена деформация на стерноклейдомастоидния мускул", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, new DateTime(2019, 7, 23, 12, 50, 35, 916, DateTimeKind.Local).AddTicks(4193), 1, false, "Менингит", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "Id", "CategoryId", "CreateDate", "IsDeleted", "Name", "PharmacyCompanyId", "PharmacyCompanyInfoId", "UpdateDate" },
                values: new object[] { 1, 1, new DateTime(2019, 7, 23, 12, 50, 35, 937, DateTimeKind.Local).AddTicks(2696), false, "Example", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserContactId",
                table: "Addresses",
                column: "UserContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_AllergyTypeId",
                table: "Allergies",
                column: "AllergyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AllergyTreatments_TreatmentId",
                table: "AllergyTreatments",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_RecipientId",
                table: "Appraisals",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appraisals_SenderId",
                table: "Appraisals",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Awards_MedManInfoId",
                table: "Awards",
                column: "MedManInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_AreaId",
                table: "Cities",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserContactId",
                table: "Emails",
                column: "UserContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Illness_IllnessTypeId",
                table: "Illness",
                column: "IllnessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Illnesses_IllnessTypeId",
                table: "Illnesses",
                column: "IllnessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IllnessTreatments_IllnessId",
                table: "IllnessTreatments",
                column: "IllnessId");

            migrationBuilder.CreateIndex(
                name: "IX_IllnessTreatments_PatientIllnessId",
                table: "IllnessTreatments",
                column: "PatientIllnessId");

            migrationBuilder.CreateIndex(
                name: "IX_IllnessTreatments_TreatmentId",
                table: "IllnessTreatments",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_IllnessTypes_IllnessCategoryId",
                table: "IllnessTypes",
                column: "IllnessCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterDepartments_DepartmentId",
                table: "MedicalCenterDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterDepartments_MedicalCenterId",
                table: "MedicalCenterDepartments",
                column: "MedicalCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterDoctors_DoctorId",
                table: "MedicalCenterDoctors",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterDoctors_MedicalCenterId",
                table: "MedicalCenterDoctors",
                column: "MedicalCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterInfos_UserId",
                table: "MedicalCenterInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalManInfoPrices_MedManInfoId",
                table: "MedicalManInfoPrices",
                column: "MedManInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalManInfoPrices_PriceTypeId",
                table: "MedicalManInfoPrices",
                column: "PriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalManInfos_MedicalCenterId",
                table: "MedicalManInfos",
                column: "MedicalCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalMenSpecialties_MedMenInfoId",
                table: "MedicalMenSpecialties",
                column: "MedMenInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalMenSpecialties_SpecialtyId",
                table: "MedicalMenSpecialties",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProfileAllergies_AllergyId",
                table: "MedicalProfileAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProfileAllergies_MedicalProfileId",
                table: "MedicalProfileAllergies",
                column: "MedicalProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProfileIllnesses_IllnessId",
                table: "MedicalProfileIllnesses",
                column: "IllnessId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProfileIllnesses_MedicalProfileId",
                table: "MedicalProfileIllnesses",
                column: "MedicalProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProfileIllnesses_PatientIllnessId",
                table: "MedicalProfileIllnesses",
                column: "PatientIllnessId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProfileMedicalTests_MedicalProfileId",
                table: "MedicalProfileMedicalTests",
                column: "MedicalProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProfileMedicalTests_MedicalTestId",
                table: "MedicalProfileMedicalTests",
                column: "MedicalTestId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProfiles_PatientInfoId",
                table: "MedicalProfiles",
                column: "PatientInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalTestAttachments_MedicalTestId",
                table: "MedicalTestAttachments",
                column: "MedicalTestId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalTests_MedicalCenterId",
                table: "MedicalTests",
                column: "MedicalCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalTests_MedicalTestTypeId",
                table: "MedicalTests",
                column: "MedicalTestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicaments_CategoryId",
                table: "Medicaments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicaments_PharmacyCompanyId",
                table: "Medicaments",
                column: "PharmacyCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTypeUsers_NotificationTypeId",
                table: "NotificationTypeUsers",
                column: "NotificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTypeUsers_UserId",
                table: "NotificationTypeUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_NotificationId",
                table: "NotificationUsers",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationUsers_UserId",
                table: "NotificationUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCardAllergies_AllergyId",
                table: "OutpatientCardAllergies",
                column: "AllergyId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCardAllergies_OutpatientCardId",
                table: "OutpatientCardAllergies",
                column: "OutpatientCardId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCardIllnesses_IllnessId",
                table: "OutpatientCardIllnesses",
                column: "IllnessId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCardIllnesses_OutpatientCardId",
                table: "OutpatientCardIllnesses",
                column: "OutpatientCardId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCardIllnesses_PatientIllnessId",
                table: "OutpatientCardIllnesses",
                column: "PatientIllnessId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCardMedicalTests_MedicalTestId",
                table: "OutpatientCardMedicalTests",
                column: "MedicalTestId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCardMedicalTests_OutpatientCardId",
                table: "OutpatientCardMedicalTests",
                column: "OutpatientCardId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCards_DoctorId",
                table: "OutpatientCards",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_OutpatientCards_PatientId",
                table: "OutpatientCards",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInfos_UserId",
                table: "PatientInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyCompanyInfos_PharmacyCompanyId",
                table: "PharmacyCompanyInfos",
                column: "PharmacyCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyCompanyTypes_CompanyTypeId",
                table: "PharmacyCompanyTypes",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyCompanyTypes_PharmacyCompanyInfoId",
                table: "PharmacyCompanyTypes",
                column: "PharmacyCompanyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyDistributors_DistributorId",
                table: "PharmacyDistributors",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyDistributors_PharmacyId",
                table: "PharmacyDistributors",
                column: "PharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyInfos_PharmacyId",
                table: "PharmacyInfos",
                column: "PharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_UserContactId",
                table: "Phones",
                column: "UserContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_MedicalMedId",
                table: "Schedules",
                column: "MedicalMedId");

            migrationBuilder.CreateIndex(
                name: "IX_TooltipItems_TooltipId",
                table: "TooltipItems",
                column: "TooltipId");

            migrationBuilder.CreateIndex(
                name: "IX_TooltipPhotos_ToolTipItemId",
                table: "TooltipPhotos",
                column: "ToolTipItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tooltips_TooltipTypeId",
                table: "Tooltips",
                column: "TooltipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentMedicaments_MedicamentId",
                table: "TreatmentMedicaments",
                column: "MedicamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentMedicaments_TreatmentId",
                table: "TreatmentMedicaments",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_UserId",
                table: "UserContacts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ParentId",
                table: "Users",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AllergyTreatments");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Appraisals");

            migrationBuilder.DropTable(
                name: "Awards");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "IllnessTreatments");

            migrationBuilder.DropTable(
                name: "MedicalCenterDepartments");

            migrationBuilder.DropTable(
                name: "MedicalCenterDoctors");

            migrationBuilder.DropTable(
                name: "MedicalManInfoPrices");

            migrationBuilder.DropTable(
                name: "MedicalMenSpecialties");

            migrationBuilder.DropTable(
                name: "MedicalProfileAllergies");

            migrationBuilder.DropTable(
                name: "MedicalProfileIllnesses");

            migrationBuilder.DropTable(
                name: "MedicalProfileMedicalTests");

            migrationBuilder.DropTable(
                name: "MedicalTestAttachments");

            migrationBuilder.DropTable(
                name: "NotificationTypeUsers");

            migrationBuilder.DropTable(
                name: "NotificationUsers");

            migrationBuilder.DropTable(
                name: "OutpatientCardAllergies");

            migrationBuilder.DropTable(
                name: "OutpatientCardIllnesses");

            migrationBuilder.DropTable(
                name: "OutpatientCardMedicalTests");

            migrationBuilder.DropTable(
                name: "PharmacyCompanyTypes");

            migrationBuilder.DropTable(
                name: "PharmacyDistributors");

            migrationBuilder.DropTable(
                name: "PharmacyInfos");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "TooltipPhotos");

            migrationBuilder.DropTable(
                name: "TreatmentMedicaments");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "PricesType");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "MedicalProfiles");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Illness");

            migrationBuilder.DropTable(
                name: "Illnesses");

            migrationBuilder.DropTable(
                name: "MedicalTests");

            migrationBuilder.DropTable(
                name: "OutpatientCards");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "UserContacts");

            migrationBuilder.DropTable(
                name: "MedicalManInfos");

            migrationBuilder.DropTable(
                name: "TooltipItems");

            migrationBuilder.DropTable(
                name: "Medicaments");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "PatientInfos");

            migrationBuilder.DropTable(
                name: "AllergyTypes");

            migrationBuilder.DropTable(
                name: "IllnessTypes");

            migrationBuilder.DropTable(
                name: "MedicalCenterInfos");

            migrationBuilder.DropTable(
                name: "MedicalTestTypes");

            migrationBuilder.DropTable(
                name: "Tooltips");

            migrationBuilder.DropTable(
                name: "MedicamentCategories");

            migrationBuilder.DropTable(
                name: "PharmacyCompanyInfos");

            migrationBuilder.DropTable(
                name: "IllnessCategories");

            migrationBuilder.DropTable(
                name: "TooltipTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
