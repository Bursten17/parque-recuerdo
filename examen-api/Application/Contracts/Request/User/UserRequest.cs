using System;
using System.Collections.Generic;
using morcom_api.Application.Contracts.Response.IdentityService;

namespace morcom_api.Application.Contracts.Request.User
{
    public class UserRequest
    {
        public string s_name { get; set; }
        public string s_last_name { get; set; }
        public string s_mother_last_name { get; set; }
        public string s_employee_code { get; set; }
        public DateTime d_birthdate { get; set; }
        public int n_id_role { get; set; }
        public int n_id_area { get; set; }
        public int n_gender { get; set; }
        public string s_mail { get; set; }
        public string s_password { get; set; }
    }

    // Correo
    // Año
}