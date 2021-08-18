using System;
using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.IdentityService;

namespace morcom_api.Application.Contracts.Response.User
{
    public class UsersResponse
    {
        public int n_id_user { get; set; }
        public string s_name { get; set; }
        public string s_last_name { get; set; }
        public string s_mother_last_name { get; set; }
        public string s_mail { get; set; }
        public string s_employee_code { get; set; }
        public int n_id_role { get; set; }
        public string s_name_role { get; set; }
        public int n_id_area { get; set; }
        public string s_name_area { get; set; }
        public int n_id_state { get; set; }
        public string s_name_state { get; set; }
        public int n_gender { get; set; }
        public string d_birthdate { get; set; }
        public string t_datetime_creation { get; set; }
        public IEnumerable<UserOfficeResponse> a_offices { get; set; }
    }
}