using System;

namespace morcom_api.Application.Contracts.Response.Product
{
    public class ProductResponse
    {
        public int n_id_product { get; set; }
        public string s_name { get; set; }
        public decimal n_price { get; set; }
        public int n_id_category { get; set; }
        public string s_name_category { get; set; }
        public int n_id_sub_category { get; set; }
        public string s_name_sub_category { get; set; }
        public int n_state { get; set; }
        public int n_user_creator { get; set; }
        public string s_name_user { get; set; }
        public string t_datetime_creation { get; set; }

    }
}