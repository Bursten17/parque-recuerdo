using System;
using System.ComponentModel;

namespace morcom_api.Application.Contracts.Response.Product
{
    public class ProductExcelResponse
    {
        [Description("N° Material")]
        public int n_id_product { get; set; }

        [Description("N° Name Material")]
        public string s_name { get; set; }

        [Description("Price")]
        public decimal n_price { get; set; }

        [Description("N° Category")]
        public int n_id_category { get; set; }

        [Description("Category")]
        public string s_name_category { get; set; }

        [Description("State")]
        public int n_state { get; set; }

        [Description("N° User Creator")]
        public int n_user_creator { get; set; }

        [Description("User Creator")]
        public string s_name_user { get; set; }

        [Description("Date Creation")]
        public string t_datetime_creation { get; set; }

        [Description("N° User Update")]
        public int n_user_update { get; set; }

        [Description("User Update")]
        public string s_name_update { get; set; }
        
        [Description("Date Update")]
        public string t_datetime_update { get; set; }
    }
}