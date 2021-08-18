using System;
using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.Category;

namespace morcom_api.Application.Contracts.Response.Supplier
{
    public class SupplierResponse
    {
        public int n_id_supplier { get; set; }
        public string s_name { get; set; }
        public int n_id_country { get; set; }
        public string s_name_country { get; set; }
        public string t_datetime_creation { get; set; }
        public int n_state { get; set; }
        public IEnumerable<CategoryResponse> a_category { get; set; }
    }
}