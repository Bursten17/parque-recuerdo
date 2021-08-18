using System;

namespace morcom_api.Application.Contracts.Request.Product
{
    public class ProductRequestFilter
    {
        public string n_id_product_or_s_name { get; set; }
        public int? n_id_category { get; set; }
        public int? n_state { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
    }
}