using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Threading.Tasks;
using API.Application.Constants;
using API.Application.Errors;
using API.Persistent;
using AutoMapper;
using Dapper;
using morcom_api.Application.Abstract;
using morcom_api.Application.Contracts.Request.Rol;
using morcom_api.Application.Contracts.Response.Rol;

namespace morcom_api.Infrastructure.Repository
{
    public class Role : IRole
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        private readonly IUserAccessor _userAccessor;
        public Role(DataContext dataContext, IMapper mapper, IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<RoleResponse>> GetAllRole()
        {
            using (var cn = _dataContext.GetDbConnection())
            {
                return await cn.QueryAsync<RoleResponse>("Public.USP_TB_ROLE_GET_ALL", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<RoleResponse>> GetAllRoleActive()
        {
            using (var cn = _dataContext.GetDbConnection())
            {
                return await cn.QueryAsync<RoleResponse>("Public.USP_TB_ROLE_ACTIVE_GET_ALL", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<RoleResponse> GetRoleById(int n_id_role)
        {
            using (var connection = _dataContext.GetDbConnection())
            {
                DynamicParameters dp = new DynamicParameters();

                dp.Add("p_n_id_role", n_id_role, dbType: DbType.Int32);

                var response = await connection.QueryFirstOrDefaultAsync<RoleResponse>("Public.USP_TB_ROLE_GET_BY_ID", dp, commandType: CommandType.StoredProcedure);

                if (response == null)
                    throw new RestException(HttpStatusCode.NotFound, GlobalConstants.NOT_FOUND);

                return response;
            }
        }

        public async Task<int> Add<T>(T entity) where T : class
        {
            var mapping = _mapper.Map<RoleRequest>(entity);

            DynamicParameters dp = new DynamicParameters();

            dp.Add("p_s_name", mapping.s_name, dbType: DbType.String);
            dp.Add("p_n_state", mapping.n_state, dbType: DbType.Int32);
            dp.Add("p_s_description", mapping.s_description, dbType: DbType.String);
            dp.Add("p_n_user_creator", Convert.ToInt32(_userAccessor.GetCurrentUserName()), dbType: DbType.Int32);

            int affectsrows = await _dataContext.TransactionCreate("Public.USP_TB_ROLE_CREATE", dp);

            if (affectsrows < 1)
                throw new RestException(HttpStatusCode.BadRequest, GlobalConstants.ERROR_SAVING_CHANGES);

            return affectsrows;
        }

        public async Task<bool> Update<U, T>(U id, T entity) where T : class
        {
            var n_id_role = _mapper.Map<int>(id);
            var mapping = _mapper.Map<RoleRequest>(entity);

            DynamicParameters dp = new DynamicParameters();

            dp.Add("p_n_id_role", n_id_role, dbType: DbType.Int32);
            dp.Add("p_s_name", mapping.s_name, dbType: DbType.String);
            dp.Add("p_n_state", mapping.n_state, dbType: DbType.Int32);
            dp.Add("p_s_description", mapping.s_description, dbType: DbType.String);
            dp.Add("p_n_user_update", Convert.ToInt32(_userAccessor.GetCurrentUserName()), dbType: DbType.Int32);

            var response = await _dataContext.TransactionUpdateDelete("USP_TB_ROLE_UPDATE_BY_ID", dp);

            if (!response)
                throw new RestException(HttpStatusCode.BadRequest, GlobalConstants.ERROR_SAVING_CHANGES);

            return response;
        }

        public async Task<bool> UpdateState(int id, int n_state)
        {
            DynamicParameters dp = new DynamicParameters();

            dp.Add("p_n_id_role", id, dbType: DbType.Int32);
            dp.Add("p_n_state", n_state, dbType: DbType.Int32);
            dp.Add("p_n_user_update", Convert.ToInt32(_userAccessor.GetCurrentUserName()), dbType: DbType.Int32);

            var response = await _dataContext.TransactionUpdateDelete("USP_TB_ROLE_UPDATE_STATE_BY_ID", dp);

            if (!response)
                throw new RestException(HttpStatusCode.BadRequest, GlobalConstants.ERROR_SAVING_CHANGES);

            return response;
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> CreateValidateNameIfExists(string s_name)
        {
            using (var cn = _dataContext.GetDbConnection())
            {
                DynamicParameters dp = new DynamicParameters();

                dp.Add("p_s_name", s_name, dbType: DbType.String);

                var response = await cn.ExecuteScalarAsync<bool>("Public.USP_TB_ROLE_CREATE_VALIDATE_NAME_IF_EXISTS", dp, commandType: CommandType.StoredProcedure);

                if (response)
                    throw new RestException(HttpStatusCode.NotFound, GlobalConstants.ERROR_NAME_ALREADY_EXISTS);

                return response;
            }
        }

        public async Task<bool> UpdateValidateNameIfExists(string s_name, int n_id_role)
        {
            using (var cn = _dataContext.GetDbConnection())
            {
                DynamicParameters dp = new DynamicParameters();

                dp.Add("p_s_name", s_name, dbType: DbType.String);
                dp.Add("p_n_id_role", n_id_role, dbType: DbType.Int32);

                var response = await cn.ExecuteScalarAsync<bool>("Public.USP_TB_ROLE_UPDATE_VALIDATE_NAME_IF_EXISTS", dp, commandType: CommandType.StoredProcedure);

                if (response)
                    throw new RestException(HttpStatusCode.NotFound, GlobalConstants.ERROR_NAME_ALREADY_EXISTS);

                return response;
            }
        }
    }
}