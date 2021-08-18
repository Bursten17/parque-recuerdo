using System;

namespace morcom_api.Application.Contracts.Request.Invoice
{
    public class InvoiceRequestUpdate
    {
        public int? n_id_project { get; set; }
        public int n_id_client { get; set; }
        public int? n_id_quote { get; set; }
        public int n_id_type_invoice { get; set; }
        public int n_id_type_community { get; set; }
        public int n_id_type_of_sale { get; set; }
        public string s_terms { get; set; }
        public string s_notes { get; set; }
        public decimal? n_total { get; set; }
        public DateTime t_delivery_date { get; set; }
        public DateTime t_expiration_date { get; set; }
    }
}