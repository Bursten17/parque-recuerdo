namespace morcom_api.Application.Contracts.Response.Address
{
    public class AddressResponse
    {
        public int n_id_address { get; set; }
        public string s_zip_code { get; set; }
        public string s_address_line_1 { get; set; }
        public string s_address_line_2 { get; set; }
        public string s_city { get; set; }
        public int n_id_country { get; set; }
        public string s_references { get; set; }
        public string s_region { get; set; }
        public int n_id_supplier { get; set; }
        public int n_id_client { get; set; }
        public int n_table_type { get; set; }
    }
}