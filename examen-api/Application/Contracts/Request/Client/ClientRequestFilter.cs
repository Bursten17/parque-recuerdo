using System;

namespace morcom_api.Application.Contracts.Request.Client
{
    public class ClientRequestFilter
    {
        public string n_id_client_or_s_name { get; set; }
        public int? n_client_type { get; set; }
        public int? n_id_country { get; set; }
        public int? n_state { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
    }
}