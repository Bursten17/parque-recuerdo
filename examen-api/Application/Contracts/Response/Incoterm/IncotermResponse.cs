namespace morcom_api.Application.Contracts.Response.Incoterm
{
    public class IncotermResponse
    {
        public int n_id_document { get; set; }
        public string s_name_taxes { get; set; }
        public decimal n_amount { get; set; }
        public decimal n_percent { get; set; }
        public int n_id_type_taxes { get; set; }
        public int n_id_quote { get; set; }
        public int n_id_purchase_order { get; set; }
        public int n_id_invoice { get; set; }

    }
}