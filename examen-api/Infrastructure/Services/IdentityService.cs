using System.Data;
using System.Net;
using System.Threading.Tasks;
using API.Application.Abstract;
using API.Application.Constants;
using API.Application.Contracts.Request.IdentityService;
using API.Application.Contracts.Response.IdentityService;
using API.Application.Errors;
using API.Persistent;
using Dapper;
using Microsoft.Extensions.Configuration;
using morcom_api.Application.Abstract;

namespace API.Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly DataContext _dataContext;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IConfiguration _configuration;
        private readonly IUserAccessor _userAccessor;
        public IdentityService(DataContext dataContext, IJwtGenerator jwtGenerator, IConfiguration configuration, IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
            _configuration = configuration;
            _jwtGenerator = jwtGenerator;
            _dataContext = dataContext;
        }

        public Task<UserResponse> GetCurrentUser()
        {
            throw new System.NotImplementedException();
        }

        public async Task<UserResponse> Login(LoginUserRequest request)
        {
            using (var connection = _dataContext.GetDbConnection())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@P_USUARIO", request.usuario, dbType: DbType.String);
                dp.Add("@P_CLAVE", request.clave, dbType: DbType.String);

                var userResponse = await connection.QueryFirstOrDefaultAsync<UserResponse>("[dbo].[USP_LOGIN]", dp, commandType: CommandType.StoredProcedure);

                if (userResponse == null)
                    throw new RestException(HttpStatusCode.NotFound, GlobalConstants.NOT_FOUND);

                userResponse.token = _jwtGenerator.createToken(userResponse);

                return userResponse;
            }
        }
    }
}