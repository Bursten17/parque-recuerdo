namespace morcom_api.Application.Contracts.Request.Phone
{
    public class PhoneRequestCreate
    {
        public string s_phone { get; set; }
        public string s_prefix { get; set; }
        public string s_phone_ex { get; set; }
        public int  n_type_phone { get; set; }
        public int n_id_office { get; set; }
        public int? n_id_supplier { get; set; }
        public int? n_id_client { get; set; }
        public int n_id_user { get; set; }
        public int n_table_type { get; set; }
    }
}