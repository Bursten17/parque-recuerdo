using System;

namespace morcom_api.Application.Contracts.Request.PuchaseOrder
{
    public class PurchaseOrderRequestFilter
    {
        public string n_id_order_or_s_id_order { get; set; }
        public int? n_id_state { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
    }
}