using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.IdentityService;

namespace morcom_api.Application.Contracts.Request.Access
{
    public class AccessRequestUpdate
    {
        public List<UserModuleResponse> a_modules { get; set; }
    }
}