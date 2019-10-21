namespace HealthCare.BusinessLayer.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    using DataLayer.Entities.MedicalCenter;
    using DataLayer.Entities.MedicalMan;
    using DataLayer.Entities.Patient;
    using DataLayer.Entities.Pharmacy;
    using DataLayer.Entities.PharmacyCompany;
    using Exceptions;
    using Microsoft.EntityFrameworkCore;
    using Utilities.Enums;

    public static class CommonInfoExtensions
    {
        public static void AddDepartments(this MedicalCenterInfo dbModel,
            IEnumerable<int> departmentsInRequest,
            IList<MedicalCenterDepartment> currentDepartments,
            int medicalCenterInfoId)
        {
            foreach (var department in departmentsInRequest)
            {
                if (currentDepartments.Any(x => x.MedicalCenterInfoId == department))
                    continue;

                dbModel.MedicalCenterDepartments.Add(new MedicalCenterDepartment
                {
                    MedicalCenterInfoId = medicalCenterInfoId,
                    DepartmentId = department
                });
            }
        }

        public static void AddSpecialties(this MedicalManInfo dbModel,
            IEnumerable<int> specialtiesInRequest,
            IList<MedicalManSpecialty> currentSpecialties,
            int medicalManInfoId)
        {
            foreach (var specialty in specialtiesInRequest)
            {
                if (currentSpecialties.Any(x => x.SpecialtyId == specialty))
                    continue;

                dbModel.Specialties.Add(
                    new MedicalManSpecialty
                    {
                        MedManInfoId = medicalManInfoId,
                        SpecialtyId = specialty
                    });
            }
        }


        public static void AddInfoModel(this DbContext dbContext, int userId, string name, RoleType userRoleType)
        {
            switch (userRoleType)
            {
                case RoleType.Patient:
                {
                    dbContext.CreateInfoObject<PatientInfo>(name, userId);
                    break;
                }
                case RoleType.Doctor:
                {
                    dbContext.CreateInfoObject<MedicalManInfo>(name, userId);
                    break;
                }
                case RoleType.MedicalCenter:
                {
                    dbContext.CreateInfoObject<MedicalCenterInfo>(name, userId);
                    break;
                }
                case RoleType.Pharmacy:
                {
                    dbContext.CreateInfoObject<PharmacyInfo>(name, userId);
                    break;
                }
                case RoleType.PharmacyCompany:
                {
                    dbContext.CreateInfoObject<PharmacyCompanyInfo>(name, userId);
                    break;
                }
                default:
                    throw new IncorrectUserDataException();
            }
        }
    }
}
