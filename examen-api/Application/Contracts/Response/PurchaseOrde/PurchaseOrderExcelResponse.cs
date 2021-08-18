using System.ComponentModel;

namespace morcom_api.Application.Contracts.Response.PurchaseOrde
{
    public class PurchaseOrderExcelResponse
    {
        [Description("N° Purchase Order")]
        public string s_id_purchase_order { get; set; }

        [Description("N° Project")]
        public string s_id_project { get; set; }
    
        [Description("Name Project")]
        public string s_name_project { get; set; }

        [Description("Provider")]
        public string s_name_supplier { get; set; }

        [Description("N° Customer References")]
        public string s_customer_references_number { get; set; }

        [Description("Delivery")]
        public string s_delivery { get; set; }

        [Description("Terms")]
        public string s_terms { get; set; }

        [Description("N° User Creator")]
        public int n_user_creator { get; set; }

        [Description("Name Creator")]
        public string s_name_creator { get; set; }

        [Description("Date Creation")]
        public string t_datetime_creation { get; set; }

        [Description("N° User Update")]
        public int n_user_update { get; set; }

        [Description("Name Update")]
        public string s_name_update { get; set; }

        [Description("Date Update")]
        public string t_datetime_update { get; set; } 

        [Description("N° User Assigned")]
        public int n_assigned_user { get; set; }

        [Description("Name Assigned")]
        public string s_name_assigned { get; set; }

        [Description("Date Assignment")]
        public string t_datetime_assignment { get; set; }

        [Description("Total")]
        public decimal d_total { get; set; }
    }
}
