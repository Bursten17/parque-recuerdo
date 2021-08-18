using System.Threading.Tasks;
using API.Application.Abstract;
using API.Application.Constants;
using API.Application.Contracts.Request.IdentityService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route(GlobalConstants.ROUTE_PREFIX)]
    public class AuthController : ControllerBase
    {
        private readonly IIdentityService _identityService;
        public AuthController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login([FromBody] LoginUserRequest request)
        {
            var response = await _identityService.Login(request);
            return Ok(response);
        }
    }  
}