﻿namespace HealthCare.API.Behaviour.Utils
{
    using System;
    using System.Linq;
    using BusinessLayer.Interfaces;
    using Contracts.Interfaces;
    using Contracts.Models;
    using Exceptions;
    using Interfaces;
    using Microsoft.AspNetCore.Http;
    using Utilities.Enums;

    public class HttpSessionResolver : ISessionResolver
    {
        private readonly IAuthService _jwtService;
        private readonly IStorageService _storageService;

        public SessionInfo SessionInfo { get; private set; }

        public HttpSessionResolver(IAuthService jwtService, IStorageService storageService)
        {
            _jwtService = jwtService;
            _storageService = storageService;
        }

        public ResponseResult SetSessionInfo(HttpRequest request, RoleType[] permissions)
        {
            try
            {
                request.Headers.TryGetValue("Authorization", out var token);

                var (userName, userId) = _jwtService.RetrieveTokenData(token);
                var userRole = _storageService.RetrieveUserRole(userId, userName);
                
                if (!permissions.Contains(userRole))
                    throw new UnauthorizedUserException();

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
