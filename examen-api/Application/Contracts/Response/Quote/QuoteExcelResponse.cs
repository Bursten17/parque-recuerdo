using System.ComponentModel;

namespace morcom_api.Application.Contracts.Response.Quote
{
    public class QuoteExcelResponse
    {
        [Description("N° Quote")]
        public string s_id_quote { get; set; }

        [Description("N° Project")]
        public string s_id_project { get; set; }

        [Description("Name Project")]
        public string s_name_project { get; set; }

        [Description("N° Client")]
        public int n_id_client { get; set; }

        [Description("Name Client")]
        public string s_name_client { get; set; }

        [Description("N° Validity")]
        public int n_id_type_validity { get; set; }

        [Description("Validity")]
        public string s_name_type_validity { get; set; }

        [Description("N° Type of Sale")]
        public int n_id_type_of_sale { get; set; }

        [Description("Type of Sale")]
        public string s_name_type_of_sale { get; set; }

        [Description("Description")]
        public string s_description { get; set; }

        [Description("N° Type Community")]
        public int n_id_type_community { get; set; }

        [Description("Type Community")]
        public string s_type_community { get; set; }

        [Description("N° Type Quote")]
        public int n_id_type_quote { get; set; }

        [Description("Type Quote")]
        public string s_type_quote { get; set; }

        [Description("Total")]
        public decimal n_total { get; set; }

        [Description("N° State")]
        public int n_id_state { get; set; }

        [Description("State")]
        public string s_n_state { get; set; }

        [Description("N° User Creator")]
        public int n_user_creator { get; set; }

        [Description("Name Creator")]
        public string s_name_creator { get; set; }

        [Description("Datetime Creation")]
        public string t_datetime_creation { get; set; }

        [Description("N° User Update")]
        public int n_user_update { get; set; }

        [Description("Name Update")]
        public string s_name_update { get; set; }

        [Description("Datetime Update")]
        public string t_datetime_update { get; set; }

        [Description("N° User Assigned")]
        public int n_assigned_user { get; set; }

        [Description("Name Assigned")]
        public string s_name_assigned { get; set; }

        [Description("Datetime Assigment")]
        public string t_datetime_assignment { get; set; }
    }
}