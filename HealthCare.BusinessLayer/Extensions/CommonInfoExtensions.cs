﻿namespace HealthCare.BusinessLayer.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    using DataLayer.Entities.MedicalCenter;
    using DataLayer.Entities.MedicalMan;
    using DataLayer.Entities.Patient;
    using DataLayer.Entities.UserAccount;
    using Microsoft.EntityFrameworkCore;

    using Utilities.Enums;

    public static class CommonInfoExtensions
    {
        public static void AddSpecialties(this MedicalManInfo dbModel,
            IEnumerable<int> specialtiesInRequest,
            List<MedicalManSpecialty> currentSpecialties,
            int medicalManInfoId)
        {
            foreach (var specialty in specialtiesInRequest)
            {
                if (currentSpecialties.Any(x => x.SpecialtyId == specialty))
                {
                    currentSpecialties.RemoveAll(x => x.SpecialtyId == specialty);
                    continue;
                }

                dbModel.Specialties.Add(
                    new MedicalManSpecialty
                    {
                        MedManInfoId = medicalManInfoId,
                        SpecialtyId = specialty
                    });
            }

            foreach (var currentSpec in currentSpecialties)
                currentSpec.IsDeleted = true;
        }

        public static void AddMedicalCenters(this User dbModel,
            IEnumerable<int> medicalCenterInRequest,
            List<MedicalCenterDoctor> currentMedicalCenters,
            int doctorId)
        {
            foreach (var medicalCenter in medicalCenterInRequest)
            {
                if (currentMedicalCenters.Any(x => x.Id == medicalCenter))
                {
                    currentMedicalCenters.RemoveAll(x => x.Id == medicalCenter);
                    continue;
                }
                
                dbModel.DoctorWorkPlaces.Add(
                    new MedicalCenterDoctor
                    {
                        MedicalCenterId = medicalCenter,
                        DoctorId = doctorId
                    });
            }

            foreach (var currentCenter in currentMedicalCenters)
                currentCenter.IsDeleted = true;
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
                case RoleType.Admin:
                    break;
            }
        }
    }
}
