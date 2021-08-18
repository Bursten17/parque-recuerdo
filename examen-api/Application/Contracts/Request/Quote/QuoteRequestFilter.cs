using System;

namespace morcom_api.Application.Contracts.Request.Quote
{
    public class QuoteRequestFilter
    {
        public string n_id_quote_or_s_id_quote { get; set; }
        public int? n_type_quote { get; set; }
        public int? n_id_state { get; set; }
        public DateTime? t_datetime_creation_since { get; set; }
        public DateTime? t_datetime_creation_until { get; set; }
    }
}