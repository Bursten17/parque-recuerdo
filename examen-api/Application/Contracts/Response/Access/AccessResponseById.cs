using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.IdentityService;

namespace morcom_api.Application.Contracts.Response.Access
{
    public class AccessResponseById
    {
        public int n_id_role { get; set; }
        public string s_name { get; set; }
        public IEnumerable<UserModuleResponse> a_modules { get; set; }
    }
}