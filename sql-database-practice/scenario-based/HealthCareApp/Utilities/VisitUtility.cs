using HealthCareApp.Data;
using HealthCareApp.Exceptions;
using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthCareApp.Utilities;

public class VisitUtility : IVisitUtility
{
    public void AddVisit(Visit visit)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Record_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_id", visit.PatientId);
            cmd.Parameters.AddWithValue("@appointment_id", visit.AppointmentId);
            cmd.Parameters.AddWithValue("@d_id", visit.DoctorId);
            cmd.Parameters.AddWithValue("@diagnosis", visit.Diagnosis);
            cmd.Parameters.AddWithValue("@notes", visit.Notes ?? (object)DBNull.Value);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to add visit record.");
        }
    }

    public void UpdateVisit(Visit visit)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Record_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@record_id", visit.Id);
            cmd.Parameters.AddWithValue("@diagnosis", visit.Diagnosis);
            cmd.Parameters.AddWithValue("@notes", visit.Notes ?? (object)DBNull.Value);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to update visit.");
        }
    }

    public Visit GetVisitById(int id)
    {
        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Records WHERE record_id=@id", conn);

        cmd.Parameters.AddWithValue("@id", id);

        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            return new Visit
            {
                Id = (int)reader["record_id"],
                PatientId = (int)reader["p_id"],
                AppointmentId = (int)reader["appointment_id"],
                DoctorId = (int)reader["d_id"],
                VisitDateTime = (DateTime)reader["r_dataTime"],
                Diagnosis = reader["diagnosis"].ToString(),
                Notes = reader["notes"]?.ToString()
            };
        }

        throw new NotFoundException("Visit record not found.");
    }

    public List<Visit> GetVisitsByPatient(int patientId)
    {
        List<Visit> visits = new();

        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Records WHERE p_id=@pid ORDER BY r_dataTime DESC",
            conn);

        cmd.Parameters.AddWithValue("@pid", patientId);

        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            visits.Add(new Visit
            {
                Id = (int)reader["record_id"],
                PatientId = (int)reader["p_id"],
                AppointmentId = (int)reader["appointment_id"],
                DoctorId = (int)reader["d_id"],
                VisitDateTime = (DateTime)reader["r_dataTime"],
                Diagnosis = reader["diagnosis"].ToString(),
                Notes = reader["notes"]?.ToString()
            });
        }

        return visits;
    }
}
