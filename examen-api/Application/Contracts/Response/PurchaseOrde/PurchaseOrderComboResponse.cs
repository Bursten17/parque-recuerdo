using System;

namespace morcom_api.Application.Contracts.Response.PurchaseOrde
{
    public class PurchaseOrderComboResponse
    {
        public int n_id_purchase_order { get; set; }
        public string s_id_purchase_order { get; set; }
        public DateTime t_datetime_creation { get; set; }
    }
}