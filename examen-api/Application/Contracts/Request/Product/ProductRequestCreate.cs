namespace morcom_api.Application.Contracts.Request.Product
{
    public class ProductRequestCreate
    {
        public string s_name { get; set; }
        public decimal n_price { get; set; }
        public int n_id_category { get; set; }
    }
}