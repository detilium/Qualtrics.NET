using Qualtrics.Api.Models;
using Qualtrics.Api.Requests;
using Qualtrics.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Services.Interfaces
{
    internal interface IUserService
    {
        ListUserResponse ListUsers(int offset = 0, string username = null);
        GetUserResponse GetUser(string userId);
        SimpleIdResponse CreateUser(CreateUserRequest createUserRequest);
        BaseResponse UpdateUser(UpdateUserRequest updateUserRequest);
        BaseResponse DeleteUser(string userId);
        UserApiTokenResponse GetUserApiToken(string userId);
        UserApiTokenResponse CreateUserApiToken(string userId);
        WhoAmIResponse WhoAmIApiToken(string apiToken);
        WhoAmIResponse WhoAmIAuthorization(string authorization);
    }
}
