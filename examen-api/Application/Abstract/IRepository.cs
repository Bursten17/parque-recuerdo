using System.Threading.Tasks;
using morcom_api.Application.Contracts.Request.Generic;

namespace API.Application.Abstract
{
    public interface IRepository
    {
        Task<int> Add<T>(T entity) where T : class;
        Task<bool> Delete(int id);
        Task<bool> Update<U, T>(U id, T entity) where T : class;
        Task<bool> UpdateState(int id, int n_state);
    }
}