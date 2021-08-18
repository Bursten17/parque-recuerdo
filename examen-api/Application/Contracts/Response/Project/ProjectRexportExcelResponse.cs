using System.ComponentModel;

namespace morcom_api.Application.Contracts.Response.Project
{
    public class ProjectRexportExcelResponse
    {
        [Description("N ° Project")]
        public string s_id_project { get; set; }

        [Description("Name Project")]
        public string s_name { get; set; }

        [Description("Type Community")]
        public string s_name_type_community { get; set; }

        [Description("Client")]
        public string s_name_client { get; set; }

        [Description("Creation Date")]
        public string t_datetime_creation { get; set; }

        [Description("Start Date")]
        public string d_start_date { get; set; }

        [Description("End Date")]
        public string d_end_date { get; set; }

        [Description("Pay Date")]
        public string d_pay_date { get; set; }

        [Description("Description")]
        public string s_notes { get; set; }

        [Description("State")]
        public string s_name_state { get; set; }

        [Description("User Code")]
        public int n_user_creator { get; set; }

        [Description("User Full Name")]
        public string s_name_user { get; set; }
    }
}