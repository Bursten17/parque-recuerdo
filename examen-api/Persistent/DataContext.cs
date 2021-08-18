using System.Data;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;
using Microsoft.Data.SqlClient;

namespace API.Persistent
{
    public class DataContext
    {
        private readonly string _connectionString;
        public DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetDbConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task<int> TransactionCreate(string nameProcedure, object parameters)
        {
            using (var connection = GetDbConnection())
            {
                using (TransactionScope ambientTransaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    int id = await connection.ExecuteScalarAsync<int>(nameProcedure, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 60);

                    if (id < 1)
                    {
                        ambientTransaction.Dispose();
                        connection.Dispose();
                        connection.Close();
                        return id;
                    }

                    ambientTransaction.Complete();
                    connection.Dispose();
                    connection.Close();
                    return id;
                }
            }
        }

        public async Task<bool> TransactionUpdateDelete(string nameProcedure, object parameters)
        {
            using (var connection = GetDbConnection())
            {
                using (TransactionScope ambientTransaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    int affectsrows = await connection.ExecuteScalarAsync<int>(nameProcedure, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 15);

                    if (affectsrows < 1)
                    {
                        ambientTransaction.Dispose();
                        connection.Close();
                        return false;
                    }

                    ambientTransaction.Complete();
                    connection.Close();
                    return true;
                }
            }
        }
    }
}