using System.Collections.Generic;
using System.Threading.Tasks;
using API.Application.Contracts.Request.IdentityService;
using API.Application.Contracts.Response.IdentityService;
using morcom_api.Application.Contracts.Request.IdentityService;
using morcom_api.Application.Contracts.Response.IdentityService;
using morcom_api.Application.Contracts.Response.Module;
using morcom_api.Application.Contracts.Response.User;

namespace API.Application.Abstract
{
    public interface IIdentityService
    {
        Task<UserResponse> Login(LoginUserRequest request);
        Task<UserResponse> GetCurrentUser();
    }
}
