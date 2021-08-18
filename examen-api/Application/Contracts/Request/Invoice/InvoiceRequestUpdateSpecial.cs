using System.Collections.Generic;
using morcom_api.Application.Contracts.Request.Incoterm;
using morcom_api.Application.Contracts.Request.InvoiceDetail;
using morcom_api.Application.Contracts.Request.Notes;

namespace morcom_api.Application.Contracts.Request.Invoice
{
    public class InvoiceRequestUpdateSpecial
    {
        public InvoiceRequestUpdate invoiceRequestUpdate { get; set; }
        public IEnumerable<InvoiceRequestDetailUpdate> listRequestProduct { get; set; }
        public IEnumerable<IncotermRequestUpdate> listRequestIncoterm { get; set; }
    }
}