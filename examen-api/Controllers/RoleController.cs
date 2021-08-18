using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.Application.Constants;
using Microsoft.AspNetCore.Mvc;
using morcom_api.Application.Abstract;
using morcom_api.Application.Contracts.Request.Generic;
using morcom_api.Application.Contracts.Request.Rol;
using morcom_api.Application.Utils;

namespace morcom_api.Controllers
{
    [ApiController]
    [Route(GlobalConstants.ROUTE_PREFIX)]
    public class RoleController : ControllerBase
    {
        private readonly IRole _role;
        public RoleController(IRole role)
        {
            _role = role;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRole()
        {
            // await _validatorAccess.ValidateOperationUserByIdRole(TypeOperations.EditRoledOperation);
            var response = await _role.GetAllRole();

            return Ok(new ResponseStatus(HttpStatusCode.OK, "OK", response.OrderByDescending(x => x.t_datetime_creation)));
        }

        [HttpGet]
        [Route("active")]
        public async Task<ActionResult> GetAllRoleActive()
        {
            // await _validatorAccess.ValidateOperationUserByIdRole(TypeOperations.EditRoledOperation);
            var responseRole = await _role.GetAllRoleActive();

            return Ok(new ResponseStatus(HttpStatusCode.OK, "OK", responseRole.OrderBy(x => x.n_s_name)));
        }

        [HttpGet]
        [Route("{n_id_role}")]
        public async Task<ActionResult> GetRoleById(int n_id_role)
        {
            // await _validatorAccess.ValidateOperationUserByIdRole(TypeOperations.EditRoledOperation);
            var response = await _role.GetRoleById(n_id_role);

            return Ok(response);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> Add([FromBody] RoleRequest roleRequest)
        {
            // await _validatorAccess.ValidateOperationUserByIdRole(TypeOperations.EditRoledOperation);
            await _role.CreateValidateNameIfExists(roleRequest.s_name);
            await _role.Add(roleRequest);

            return Ok(new ResponseStatus(HttpStatusCode.OK, "OK"));
        }

        [HttpPut]
        [Route("{n_id_role}/update")]
        public async Task<ActionResult> Update([FromRoute] int n_id_role, [FromBody] RoleRequest roleRequest)
        {
            // await _validatorAccess.ValidateOperationUserByIdRole(TypeOperations.GetAllOfficesOperation);
            await _role.GetRoleById(n_id_role);
            await _role.UpdateValidateNameIfExists(roleRequest.s_name, n_id_role);
            await _role.Update(n_id_role, roleRequest);
            return Ok(new ResponseStatus(HttpStatusCode.OK, "OK"));
        }

        [HttpPut]
        [Route("{n_id_role}/update/state")]
        public async Task<ActionResult> UpdateState([FromRoute] int n_id_role, [FromBody] TRequestUpdateState request)
        {
            // await _validatorAccess.ValidateOperationUserByIdRole(TypeOperations.GetAllOfficesOperation);
            await _role.GetRoleById(n_id_role);
            await _role.UpdateState(n_id_role, request.n_state);
            return Ok(new ResponseStatus(HttpStatusCode.OK, "OK"));
        }
    }
}