namespace HealthCare.BusinessLayer.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    using DataLayer.Entities.MedicalCenter;
    using DataLayer.Entities.MedicalMan;

    public static class CommonExtensions
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
            IEnumerable<MedicalMenSpecialty> currentSpecialties,
            int medicalMenInfoId)
        {
            foreach (var specialty in specialtiesInRequest)
            {
                if (currentSpecialties.Any(x => x.SpecialtyId == specialty))
                    continue;

                dbModel.Specialties.Add(
                    new MedicalMenSpecialty
                    {
                        MedMenInfoId = medicalMenInfoId,
                        SpecialtyId = specialty
                    });
            }
        }
    }
}
