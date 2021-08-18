namespace morcom_api.Application.Contracts.Request.Mail
{
    public class MailRequestCreate
    {
        public string s_name { get; set; }
        public int n_id_supplier { get; set; }
        public int n_id_client { get; set; }
        public int n_id_user { get; set; }
        public int n_table_type { get; set; }
    }
}