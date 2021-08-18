using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Rol
{
    public class RolRequestUpdate
    {
        public IEnumerable<RolRequestState> listRequest { get; set; }
    }
}