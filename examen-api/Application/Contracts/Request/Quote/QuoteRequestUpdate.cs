namespace morcom_api.Application.Contracts.Request.Quote
{
    public class QuoteRequestUpdate
    {
        public int n_id_client { get; set; }
        public int n_id_project { get; set; }        
        public int n_id_type_validity { get; set; }
        public int n_id_type_of_sale { get; set; }
        public int n_id_type_quote { get; set; }
        public int n_id_type_community { get; set; }        
        public string s_description { get; set; }
        public decimal? n_subtotal_product { get; set; }
        public decimal? n_discount { get; set; }
        public decimal? n_total { get; set; }
    }
}