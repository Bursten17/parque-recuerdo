using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Response.IdentityService
{
    public class UserModuleResponse
    {
        public int n_id_module { get; set; }
        public string s_name_modulo { get; set; }
        public string s_to { get; set; }
        public string s_icon { get; set; }
        public List<UserModuleResponse> a_submodule { get; set; }
        public List<UserOperation> a_operation { get; set; }
    }
}