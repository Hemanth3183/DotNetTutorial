using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HelloWorld.Data
{
    public class DataContextDapper
    {
        private string _connectionString = "Server=localhost;Database=DotNetCourse;TrustServerCertificate=true;Trusted_Connection=true;";

        public IEnumerable<T> LoadData<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Query<T>(sql);                                  // Actual statement which returns the result of the SQL statement.
        }

        public T LoadDataSingle<T>(string sql)                                  // Not assigning a type, makes the input dynamic.
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.QuerySingle<T>(sql);                                  // Actual statement which returns the result of the SQL statement.
        }

        public bool TestSQL(string sql)                                  // Insert statement to return status code of statement.
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return (dbConnection.Execute(sql) > 0);                                  // Actual statement which returns the result of the SQL statement.
        }

        public int ExecuteSQL(string sql)                                  // Insert statement to return number of rows.
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Execute(sql);                                  // Actual statement which returns the result of the SQL statement.
        }
            
    }
}