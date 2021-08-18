using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Product
{
    public class ProductRequestStateUpdate
    {
        public IEnumerable<ProductRequestState> listRequest { get; set; }
    }
}