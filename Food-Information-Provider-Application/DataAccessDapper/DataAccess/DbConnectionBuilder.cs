using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessDapper.DataAccess
{
    internal class DbConnectionBuilder
    {
        internal static IDbConnection GetConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
    }
}
