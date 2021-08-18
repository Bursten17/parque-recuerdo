using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.Incoterm;
using morcom_api.Application.Contracts.Response.InvoiceDetail;
using morcom_api.Application.Contracts.Response.PurchaseOrde;

namespace morcom_api.Application.Contracts.Response.Invoice
{
    public class InvoiceAllDataResponse
    {
        public InvoiceResponse invoice { get; set; }
        public IEnumerable<InvoiceDetailResponse> listRequestProduct { get; set; }
        public IEnumerable<IncotermResponse> listRequestIncoterm { get; set; }
        public IEnumerable<PurchaseOrderComboResponse> listRequestPurchaseOrder { get; set; }

    }
}