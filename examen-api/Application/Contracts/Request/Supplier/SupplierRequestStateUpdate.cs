using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Supplier
{
    public class SupplierRequestStateUpdate
    {
        public IEnumerable<SupplierRequestState> listRequest { get; set; }
    }
}