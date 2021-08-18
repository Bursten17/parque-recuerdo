using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Incoterm;
using morcom_api.Application.Contracts.Request.Notes;
using morcom_api.Application.Contracts.Request.PurchaseOrderDetail;

namespace morcom_api.Application.Contracts.Request.PuchaseOrder
{
    public class PurchaseOrderRequestCreateSpecial
    {
        public PurchaseOrderRequestCreate purchaseOrderRequestCreate { get; set; }
        public IEnumerable<PurchaseOrderRequestDetailCreate> listRequestProduct { get; set; }
        public IEnumerable<IncotermRequestCreate> listRequestIncoterm { get; set; }
        public IEnumerable<notesCreateRequest> listNotes { get; set; }
    }
}