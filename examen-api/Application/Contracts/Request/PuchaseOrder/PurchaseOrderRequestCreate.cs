namespace morcom_api.Application.Contracts.Request.PuchaseOrder
{
    public class PurchaseOrderRequestCreate
    {
        public int n_id_project { get; set; }
        public int n_id_supplier { get; set; }
        public int n_id_type_validity { get; set; }
        public int n_id_type_of_sale { get; set; }
        public int n_id_type_community { get; set; }
        public string s_customer_references_number { get; set; }
        public string s_delivery { get; set; }
        public string s_terms { get; set; }
        public decimal? d_total { get; set; }

    }
}