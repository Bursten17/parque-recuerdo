using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.IdentityService;

namespace morcom_api.Application.Contracts.Request.Access
{
    public class AccessRequestCreate
    {
        public int n_id_role { get; set; }
        public List<UserModuleResponse> a_modules { get; set; }
    }
}