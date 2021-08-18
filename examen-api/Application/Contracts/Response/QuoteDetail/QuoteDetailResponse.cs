namespace morcom_api.Application.Contracts.Response.QuoteDetail
{
    public class QuoteDetailResponse
    {
        public int n_id_quote { get; set; }
        public int n_id_product { get; set; }
        public string s_product_name { get; set; }
        public int n_quantity { get; set; }
        public decimal n_unit_price { get; set; }
        public decimal n_total { get; set; }
    }
}