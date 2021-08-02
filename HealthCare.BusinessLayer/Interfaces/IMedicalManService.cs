namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    using Contracts.Models.Common;
    using Contracts.Models.MedicalManAccount.Data;
    using Contracts.Models.MedicalManAccount.Requests;
    using Contracts.Models.MedicalManAccount.Responses;
    using Contracts.Models.OutpatientCard.Data;
   

    public interface IMedicalManService
    {
        Task<TokenData> PersistPersonalData(PersistPersonalDataRequest request);

        Task<TokenData> AddOutpatientCard(OutPatientCardInfo request, IList<IFormFile> files);

        Task<RetrieveMainDataResponse> RetrievePersonalData();

        Task<RetrieveContactsResponse> RetrieveContacts();

        List<CommonMedicalData> GetByMedicalCenter(int centerId);
       
        StatisticsData GetStatisticsData();
    }
}
