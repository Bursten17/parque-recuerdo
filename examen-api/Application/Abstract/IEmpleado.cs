using System.Collections.Generic;
using System.Threading.Tasks;
using examen_api.Application.Contracts.Response.Empleado;

namespace examen_api.Application.Abstract
{
    public interface IEmpleado
    {
        Task<IEnumerable<EmpleadoResponse>> GetAllEmpleados();
    }
}