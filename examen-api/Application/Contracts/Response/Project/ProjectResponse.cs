using System;

namespace morcom_api.Application.Contracts.Response.Project
{
    public class ProjectResponse
    {
        public int n_id_project { get; set; }
        public string s_id_project { get; set; }
        public string s_name { get; set; }
        public int n_id_type_community { get; set; }
        public string s_name_type_community { get; set; }
        public int n_id_client { get; set; }
        public string s_name_client { get; set; }
        public string t_datetime_creation { get; set; }
        public string d_start_date { get; set; }
        public string d_end_date { get; set; }
        public string d_pay_date { get; set; }
        public int n_id_state { get; set; }
        public string s_name_state { get; set; }
        public int n_user_creator { get; set; }        
        public string s_name_user_creator { get; set; }
        public DateTime t_datetime_creation_time { get; set; }
    }
}