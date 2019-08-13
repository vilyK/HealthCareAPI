namespace HealthCare.Contracts.Interfaces
{
    using Microsoft.AspNetCore.Http;

    using Models;

    public interface ISessionResolver
    {
        SessionInfo SessionInfo { get; }

        ResponseResult RetrieveSessionInfo(HttpRequest request);
    }
}
