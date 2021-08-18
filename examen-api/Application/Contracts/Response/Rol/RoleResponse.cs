using System;

namespace morcom_api.Application.Contracts.Response.Rol
{
    public class RoleResponse
    {
        public int n_id_role { get; set; }
        public string n_s_name { get; set; }
        public int n_state { get; set; }
        public string s_description { get; set; }
        public string t_datetime_creation { get; set; }
        
    }
}