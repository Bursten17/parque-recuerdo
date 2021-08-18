using System;
using System.Collections.Generic;

namespace morcom_api.Application.Contracts.Request.Project
{
    public class ProjectRequestFilter
    {
        public string n_id_project_or_s_name { get; set; }
        public int? n_id_state { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
        public DateTime? d_start_date_since { get; set; }
        public DateTime? d_start_date_until { get; set; }
        public List<int> a_n_id_user { get; set; }
    }
}