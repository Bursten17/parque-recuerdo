using System.Threading.Tasks;
using API.Application.Contracts.Response.IdentityService;

namespace morcom_api.Application.Abstract
{
    public interface IJwtGenerator
    {
        string createToken(UserResponse data);
    }
}