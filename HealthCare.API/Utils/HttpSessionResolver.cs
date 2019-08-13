namespace HealthCare.API.Utils
{
    using System;
    using Authentication.Managers;
    using BusinessLayer.Interfaces;
    using Contracts;
    using Contracts.Interfaces;
    using Contracts.Models;
    using Microsoft.AspNetCore.Http;
    using Utilities.Enums;

    public class HttpSessionResolver : ISessionResolver
    {
        private readonly IAuthService _jwtService;

        public SessionInfo SessionInfo { get; private set; }

        public HttpSessionResolver(IAuthService jwtService)
        {
            _jwtService = jwtService;
        }

        public ResponseResult RetrieveSessionInfo(HttpRequest request)
        {
            try
            {
                request.Headers.TryGetValue("Authorization", out var token);

                var (userName, userId) = _jwtService.RetrieveTokenData(token);

                SessionInfo = new SessionInfo
                {
                    UserId = userId,
                    Username = userName,
                    NewToken = _jwtService.GenerateToken(userName, userId)
                };

                return new ResponseResult
                {
                    ResponseStatus = ResponseStatus.Success
                };
            }
            catch (Exception ex)
            {
                return new ResponseResult
                {
                    ResponseStatus = ResponseStatus.Fail,
                    Message = ex.Message
                };
            }
        }
    }

}
