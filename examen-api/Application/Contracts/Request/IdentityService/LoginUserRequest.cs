namespace API.Application.Contracts.Request.IdentityService
{
    public class LoginUserRequest
    {
        public string usuario { get; set; }
        public string clave { get; set; }
    }
}