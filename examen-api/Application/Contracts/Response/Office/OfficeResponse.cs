using System;

namespace morcom_api.Application.Contracts.Response.Office
{
    public class OfficeResponse
    {
        public int n_id_office { get; set; }
        public string s_name { get; set; }
        public string s_code { get; set; }
        public string s_description { get; set; }
        public int n_state { get; set; }
        public string t_datetime_creation { get; set; }

        
    }
}