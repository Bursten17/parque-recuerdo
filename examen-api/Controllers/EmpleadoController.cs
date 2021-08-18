using System.Threading.Tasks;
using API.Application.Constants;
using examen_api.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace examen_api.Controllers
{
    [ApiController]
    [Route(GlobalConstants.ROUTE_PREFIX)]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleado _empleado;
        public EmpleadoController(IEmpleado empleado)
        {
            _empleado = empleado;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllEmpleados()
        {
            // await _validatorAccess.ValidateOperationUserByIdRole(TypeOperations.EditRoledOperation);
            var response = await _empleado.GetAllEmpleados();

            return Ok(response);
        }
    }
}