using HealthCareApp.Data;
using HealthCareApp.Exceptions;
using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthCareApp.Utilities;

public class DoctorUtility : IDoctorUtility
{
    public void AddDoctor(Doctor doctor)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Doctor_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@d_name", doctor.Name);
            cmd.Parameters.AddWithValue("@speciality_id", doctor.SpecialityId);
            cmd.Parameters.AddWithValue("@d_contact", doctor.Contact);
            cmd.Parameters.AddWithValue("@d_consultationFee", doctor.ConsultationFee);
            cmd.Parameters.AddWithValue("@d_isAvailable", doctor.IsAvailable);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to insert doctor.");
        }
    }

    public void UpdateDoctor(Doctor doctor)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Doctor_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@d_id", doctor.Id);
            cmd.Parameters.AddWithValue("@d_name", doctor.Name);
            cmd.Parameters.AddWithValue("@speciality_id", doctor.SpecialityId);
            cmd.Parameters.AddWithValue("@d_contact", doctor.Contact);
            cmd.Parameters.AddWithValue("@d_consultationFee", doctor.ConsultationFee);
            cmd.Parameters.AddWithValue("@d_isAvailable", doctor.IsAvailable);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to update doctor.");
        }
    }

    public void DeactivateDoctor(int id)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Doctor_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@d_id", id);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to deactivate doctor.");
        }
    }

    public Doctor GetDoctorById(int id)
    {
        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Doctor WHERE d_id=@id AND is_Active=1", conn);

        cmd.Parameters.AddWithValue("@id", id);

        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            return new Doctor
            {
                Id = (int)reader["d_id"],
                Name = reader["d_name"].ToString(),
                SpecialityId = (int)reader["speciality_id"],
                Contact = reader["d_contact"].ToString(),
                ConsultationFee = (decimal)reader["d_consultationFee"],
                IsAvailable = (bool)reader["d_isAvailable"]
            };
        }

        throw new NotFoundException("Doctor not found.");
    }

    public List<Doctor> GetAllDoctors()
    {
        List<Doctor> doctors = new();

        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Doctor WHERE is_Active=1", conn);

        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            doctors.Add(new Doctor
            {
                Id = (int)reader["d_id"],
                Name = reader["d_name"].ToString(),
                SpecialityId = (int)reader["speciality_id"],
                Contact = reader["d_contact"].ToString(),
                ConsultationFee = (decimal)reader["d_consultationFee"],
                IsAvailable = (bool)reader["d_isAvailable"]
            });
        }

        return doctors;
    }
}
