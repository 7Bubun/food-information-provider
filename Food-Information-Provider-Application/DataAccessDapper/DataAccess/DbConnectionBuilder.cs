using Microsoft.Data.Sqlite;
using System.Data;

namespace DataAccessDapper.DataAccess
{
    internal class DbConnectionBuilder
    {
        //TODO connection string file -> env. variables on Azure
        internal static IDbConnection GetConnection()
        {
            string connectionString = @"";
            return new SqliteConnection(connectionString);
        }
    }
}