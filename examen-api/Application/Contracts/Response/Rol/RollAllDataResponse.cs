using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Response.Rol
{
    public class RollAllDataResponse
    {
        public RoleResponse rol { get; set; }
        public IEnumerable<RoleModuleResponse> listModule { get; set; }
    }
}