using System;

namespace morcom_api.Application.Contracts.Request.Project
{
    public class ProjectRequest
    {
        public int n_id_client { get; set; }
        public string s_name { get; set; }
        public int n_id_type_community { get; set; }
        public DateTime d_start_date { get; set; }
        public DateTime d_end_date { get; set; }
        public DateTime d_pay_date { get; set; }
    }
}