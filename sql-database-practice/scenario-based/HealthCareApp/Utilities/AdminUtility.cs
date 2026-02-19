using HealthCareApp.Data;
using HealthCareApp.Exceptions;
using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthCareApp.Utilities;

public class AdminUtility : IAdminUtility
{
    public void AddSpecialty(Specialty specialty)
    {
        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "INSERT INTO Speciality (speciality_name, description) VALUES (@name,@desc)", conn);

        cmd.Parameters.AddWithValue("@name", specialty.Name);
        cmd.Parameters.AddWithValue("@desc", specialty.Description ?? (object)DBNull.Value);

        cmd.ExecuteNonQuery();
    }

    public List<Specialty> GetAllSpecialties()
    {
        List<Specialty> list = new();

        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand("SELECT * FROM Speciality", conn);
        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Specialty
            {
                Id = (int)reader["speciality_id"],
                Name = reader["speciality_name"].ToString(),
                Description = reader["description"]?.ToString()
            });
        }

        return list;
    }

    public List<AuditLog> GetAuditLogs()
    {
        List<AuditLog> logs = new();

        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand("SELECT * FROM Audit_Log ORDER BY action_timestamp DESC", conn);
        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            logs.Add(new AuditLog
            {
                Id = (int)reader["log_id"],
                UserId = (int)reader["user_id"],
                ActionType = reader["action_type"].ToString(),
                TableName = reader["table_name"].ToString(),
                RecordId = (int)reader["record_id"],
                Timestamp = (DateTime)reader["action_timestamp"]
            });
        }

        return logs;
    }

    public decimal GetRevenueByDateRange(DateTime start, DateTime end)
    {
        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "SELECT SUM(totalAmt) FROM Billing WHERE bill_dateTime BETWEEN @start AND @end AND paymentStatus='PAID'",
            conn);

        cmd.Parameters.AddWithValue("@start", start);
        cmd.Parameters.AddWithValue("@end", end);

        object result = cmd.ExecuteScalar();

        return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
    }
}
