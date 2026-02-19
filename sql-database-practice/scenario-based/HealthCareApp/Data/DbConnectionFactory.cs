using Microsoft.Data.SqlClient;

namespace HealthCareApp.Data;

public static class DbConnectionFactory
{
    public static SqlConnection CreateConnection()
    {
        return new SqlConnection(DbConfig.ConnectionString);
    }
}
