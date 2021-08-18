using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using API.Persistent;
using Dapper;
using examen_api.Application.Abstract;
using examen_api.Application.Contracts.Response.Empleado;

namespace examen_api.Infrastructure.Repository
{
    public class Empleado : IEmpleado
    {
        private readonly DataContext _dataContext;
        public Empleado(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<EmpleadoResponse>> GetAllEmpleados()
        {
             using (var cn = _dataContext.GetDbConnection())
            {
                return await cn.QueryAsync<EmpleadoResponse>("[dbo].[USP_LISTADO_EMPLEADOS]", commandType: CommandType.StoredProcedure);
            }
        }
    }
}