using System;
using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Invoice
{
    public class InvoiceRequestExcel
    {
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
        public List<int> a_n_id_user { get; set; }
    }
}