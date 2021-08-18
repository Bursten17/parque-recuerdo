using System;

namespace morcom_api.Application.Contracts.Response.Invoice
{
    public class InvoiceResponse
    {
        public int n_id_invoice { get; set; }
        public string s_id_invoice { get; set; }
        public int n_id_client { get; set; }
        public string s_name_client { get; set; }
        public int n_id_project { get; set; }
        public string s_name_project { get; set; }
        public int n_id_type_invoice { get; set; }
        public string s_type_invoice { get; set; }
        public string s_terms { get; set; }        
        public string s_notes { get; set; }
        public int n_user_creator { get; set; }
        public string s_name_creator { get; set; }
        public int n_assigned_user { get; set; }
        public string s_name_assigned { get; set; }
        public string t_datetime_creation { get; set; }
        public int n_id_state { get; set; }
        public string s_name_state { get; set; }
        public DateTime t_datetime_creation_date { get; set; }
        public string t_delivery_date { get; set; }
        public string t_expiration_date { get; set; }
        public int n_id_type_of_sale { get; set; }
        public string s_name_type_sale { get; set; }
        public int n_id_type_community { get; set; }
        public string s_name_type_comunity { get; set; }
        public int n_id_quote { get; set; }
        public string s_id_quote { get; set; }
    }
}