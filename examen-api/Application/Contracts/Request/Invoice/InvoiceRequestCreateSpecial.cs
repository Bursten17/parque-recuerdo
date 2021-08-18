using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Incoterm;
using morcom_api.Application.Contracts.Request.InvoiceDetail;
using morcom_api.Application.Contracts.Request.Notes;

namespace morcom_api.Application.Contracts.Request.Invoice
{
    public class InvoiceRequestCreateSpecial
    {
        public InvoiceRequestCreate invoiceRequestCreate { get; set; }
        public IEnumerable<InvoiceRequestDetailCreate> listRequestProduct { get; set; }
        public IEnumerable<InvoicePurchaseOrderRequest> listRequestPurchaseOrder { get; set; }
        public IEnumerable<IncotermRequestCreate> listRequestIncoterm { get; set; }
        public IEnumerable<notesCreateRequest> listNotes { get; set; }
    }
}