using System.Collections.Generic;
using System.Threading.Tasks;
using API.Application.Abstract;
using morcom_api.Application.Contracts.Request.Rol;
using morcom_api.Application.Contracts.Response.Rol;

namespace morcom_api.Application.Abstract
{
    public interface IRole : IRepository
    {
        Task<IEnumerable<RoleResponse>> GetAllRole();
        Task<IEnumerable<RoleResponse>> GetAllRoleActive();//PROXIMAMENTE SE PASARA A UN QUERY DINAMICO
        Task<RoleResponse> GetRoleById(int n_id_role);
        Task<bool> CreateValidateNameIfExists(string s_name);
        Task<bool> UpdateValidateNameIfExists(string s_name, int n_id_role);
    }
}