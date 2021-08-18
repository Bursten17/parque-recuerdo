namespace morcom_api.Application.Contracts.Response.Quote
{
    public class QuoteComboResponse
    {
        public int n_id_quote { get; set; }
        public string s_id_quote { get; set; }
        public int n_id_type_quote { get; set; }
        public string s_type_quote_name { get; set; }
        public int n_id_state { get; set; }
        public string s_name_state { get; set; }
    }
}