using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using morcom_api.Application.Abstract;

namespace morcom_api.Infrastructure.Security
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCurrentUserIdRol()
        {
            var username = _httpContextAccessor.HttpContext.User?.Claims.FirstOrDefault(u => u.Type == "n_id_role")?.Value;
            return username;
        }

        public string GetCurrentUserName()
        {
            var username = _httpContextAccessor.HttpContext.User?.Claims.FirstOrDefault(u => u.Type == "n_id_user")?.Value;
            return username;
        }
    }
}