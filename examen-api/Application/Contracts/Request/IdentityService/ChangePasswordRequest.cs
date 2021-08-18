namespace morcom_api.Application.Contracts.Request.IdentityService
{
    public class ChangePasswordRequest
    {
        public string s_new_password { get; set; }
        public string s_new_password_confirm { get; set; }
    }
}