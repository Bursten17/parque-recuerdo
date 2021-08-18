using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.Incoterm;
using morcom_api.Application.Contracts.Response.PurchaseOrderDetail;

namespace morcom_api.Application.Contracts.Response.PurchaseOrde
{
    public class PurchaseOrderAllDataResponse
    {
        public PurchaseOrderResponse purchaseOrder { get; set; }
        public IEnumerable<PurchaseOrderDetailResponse>  listRequestProduct { get; set; }
        public IEnumerable<IncotermResponse> listRequestIncoterm { get; set; }

    }
}