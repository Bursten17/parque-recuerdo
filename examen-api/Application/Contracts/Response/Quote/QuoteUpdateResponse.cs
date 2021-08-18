namespace morcom_api.Application.Contracts.Response.Quote
{
    public class QuoteUpdateResponse
    {
        public int n_id_quote { get; set; }
        public string s_id_quote { get; set; }
        public int n_id_client { get; set; }
        public string s_name_client { get; set; }
        public int n_id_project { get; set; }
        public string s_name_project { get; set; }
        public int n_id_type_validity { get; set; }
        public string s_name_type_validity { get; set; }
        public int n_id_type_of_sale { get; set; }
        public string s_name_type_of_sale { get; set; }
        public int n_id_type_community { get; set; }
        public string s_type_community { get; set; }
        public decimal n_subtotal { get; set; }
        public decimal n_discount { get; set; }
        public decimal n_total { get; set; }
        public int n_assigned_user { get; set; }
        public string s_name_assigned_user { get; set; }
        public int n_user_creator { get; set; }
        public string s_name_user_creator { get; set; }
        public string t_datetime_creation_quote { get; set; }
        public int n_id_type_quote { get; set; }
        public string s_type_quote_name { get; set; }
        public int n_id_state { get; set; }
        public string s_name_state { get; set; }
    }
}