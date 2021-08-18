using System;

namespace morcom_api.Application.Contracts.Request.Supplier
{
    public class SupplierRequestFilter
    {
        public string n_id_supplier_or_s_name { get; set; }
        // public int? n_id_sub_category { get; set; }
        public int? n_state { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
    }
}