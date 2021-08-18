namespace morcom_api.Application.Contracts.Request.InvoiceDetail
{
    public class InvoiceRequestDetailCreate
    {
        public int n_id_invoice { get; set; }
        public int n_id_product { get; set; }
        public string  s_product_name { get; set; }
        public int n_quantity { get; set; }
        public decimal n_unit_price { get; set; }
        public decimal n_total { get; set; }
    }
}