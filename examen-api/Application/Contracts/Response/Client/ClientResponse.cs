using System;

namespace morcom_api.Application.Contracts.Response.Client
{
    public class ClientResponse
    {
        public int n_id_client { get; set; }
        public string s_name { get; set; }
        public int n_id_country { get; set; }
        public string s_name_country { get; set; }
        public int n_client_type { get; set; }
        public string s_client_type_name { get; set; }
        public string s_type_person_name { get; set; }
        public string t_datetime_creation { get; set; }
        public int n_state { get; set; }
        
    }
}