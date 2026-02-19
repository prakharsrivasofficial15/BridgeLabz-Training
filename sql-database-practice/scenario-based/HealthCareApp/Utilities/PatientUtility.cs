using HealthCareApp.Data;
using HealthCareApp.Exceptions;
using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthCareApp.Utilities;

public class PatientUtility : IPatientUtility
{
    public void AddPatient(Patient patient)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Patient_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_name", patient.Name);
            cmd.Parameters.AddWithValue("@p_dob", patient.DOB);
            cmd.Parameters.AddWithValue("@p_contact", patient.Contact);
            cmd.Parameters.AddWithValue("@p_address", patient.Address);
            cmd.Parameters.AddWithValue("@p_bloodgroup", patient.BloodGroup);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public void UpdatePatient(Patient patient)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Patient_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_id", patient.Id);
            cmd.Parameters.AddWithValue("@p_name", patient.Name);
            cmd.Parameters.AddWithValue("@p_dob", patient.DOB);
            cmd.Parameters.AddWithValue("@p_contact", patient.Contact);
            cmd.Parameters.AddWithValue("@p_address", patient.Address);
            cmd.Parameters.AddWithValue("@p_bloodgroup", patient.BloodGroup);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to update patient.");
        }
    }

    public void DeletePatient(int id)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Patient_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to delete patient.");
        }
    }

    public Patient GetPatientById(int id)
    {
        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE p_id=@id AND is_active=1", conn);
        cmd.Parameters.AddWithValue("@id", id);

        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            return new Patient
            {
                Id = (int)reader["p_id"],
                Name = reader["p_name"].ToString(),
                DOB = (DateTime)reader["p_dob"],
                Contact = reader["p_contact"].ToString(),
                Address = reader["p_address"].ToString(),
                BloodGroup = reader["p_bloodgroup"].ToString()
            };
        }

        throw new NotFoundException("Patient not found.");
    }

    public List<Patient> GetAllPatients()
    {
        List<Patient> patients = new();

        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE is_active=1", conn);
        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            patients.Add(new Patient
            {
                Id = (int)reader["p_id"],
                Name = reader["p_name"].ToString(),
                DOB = (DateTime)reader["p_dob"],
                Contact = reader["p_contact"].ToString(),
                Address = reader["p_address"].ToString(),
                BloodGroup = reader["p_bloodgroup"].ToString()
            });
        }

        return patients;
    }
}
