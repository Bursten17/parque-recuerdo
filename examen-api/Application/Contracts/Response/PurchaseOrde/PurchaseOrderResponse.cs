using System;

namespace morcom_api.Application.Contracts.Response.PurchaseOrde
{
    public class PurchaseOrderResponse
    {
        public int n_id_purchase_order { get; set; }
        public string s_id_purchase_order { get; set; }
        public int n_id_project { get; set; }
        public string s_id_project { get; set; }
        public string s_name_project { get; set; }
        public int n_id_supplier { get; set; }
        public string s_name_supplier { get; set; }
        public string s_customer_references_number { get; set; }
        public int n_assigned_user { get; set; }
        public string s_name_assigned { get; set; }
        public int n_user_creator { get; set; }
        public string s_name_creator { get; set; }
        public string t_datetime_creation { get; set; }
        public int n_id_state { get; set; }
        public string s_name_state { get; set; }
        public DateTime t_datetime_creation_date { get; set; }
        public string s_delivery { get; set; }
        public string s_terms { get; set; }
        public int n_id_type_validity { get; set; }
        public string s_name_validity { get; set; }
        public int n_id_type_of_sale { get; set; }
        public string s_name_type_sale { get; set; }
        public int n_id_type_community { get; set; }
        public string s_name_type_community { get; set; }
    }
}