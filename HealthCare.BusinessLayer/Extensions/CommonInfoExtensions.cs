namespace HealthCare.BusinessLayer.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    using DataLayer.Entities.MedicalCenter;
    using DataLayer.Entities.MedicalMan;

    public static class CommonInfoExtensions
    {
        public static void AddDepartments(this MedicalCenterInfo dbModel,
            IEnumerable<int> departmentsInRequest,
            IEnumerable<MedicalCenterDepartment> currentDepartments,
            int medicalCenterInfoId)
        {
            foreach (var department in departmentsInRequest.Distinct())
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
            IEnumerable<MedicalManSpecialty> currentSpecialties,
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
    }
}
