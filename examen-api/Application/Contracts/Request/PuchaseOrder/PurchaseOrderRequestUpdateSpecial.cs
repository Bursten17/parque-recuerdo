using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Incoterm;
using morcom_api.Application.Contracts.Request.Notes;
using morcom_api.Application.Contracts.Request.PurchaseOrderDetail;

namespace morcom_api.Application.Contracts.Request.PuchaseOrder
{
    public class PurchaseOrderRequestUpdateSpecial
    {
        public PurchaseOrderRequestUpdate PurchaseOrderRequestUpdate { get; set; }
        public IEnumerable<PurchaseOrderRequestDetailUpdate> listRequestProduct { get; set; }
        public IEnumerable<IncotermRequestUpdate> listRequestIncoterm { get; set; }
    }
}