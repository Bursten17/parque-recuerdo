namespace morcom_api.Application.Contracts.Request.Phone
{
    public class PhoneRequestUpdate: PhoneRequestCreate
    {
        public int n_id_phone { get; set; }
        public int observant { get; set; }
    }
}