using System;

namespace morcom_api.Application.Contracts.Request.Invoice
{
    public class InvoiceRequestFilter
    {
        public string n_id_invoice_or_s_id_invoice { get; set; }
        public int n_id_type_invoice { get; set; }
        public int? n_id_state { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
    }
}