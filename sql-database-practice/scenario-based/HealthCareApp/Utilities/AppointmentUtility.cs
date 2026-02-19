using HealthCareApp.Data;
using HealthCareApp.Exceptions;
using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthCareApp.Utilities;

public class AppointmentUtility : IAppointmentUtility
{
    public void BookAppointment(Appointment appointment)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Appointment_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_id", appointment.PatientId);
            cmd.Parameters.AddWithValue("@d_id", appointment.DoctorId);
            cmd.Parameters.AddWithValue("@appointmentDate", appointment.AppointmentDate);
            cmd.Parameters.AddWithValue("@appointmentTime", appointment.AppointmentTime);
            cmd.Parameters.AddWithValue("@appointmentStatus", "SCHEDULED");

            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627) // Unique constraint violation
                throw new BusinessRuleException("Doctor already booked at this time.");

            throw new DatabaseOperationException("Failed to book appointment.");
        }
    }

    public void UpdateAppointment(Appointment appointment)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Appointment_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@appointment_id", appointment.Id);
            cmd.Parameters.AddWithValue("@appointmentDate", appointment.AppointmentDate);
            cmd.Parameters.AddWithValue("@appointmentTime", appointment.AppointmentTime);
            cmd.Parameters.AddWithValue("@appointmentStatus", appointment.Status);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to update appointment.");
        }
    }

    public void CancelAppointment(int id)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Appointment_Cancel", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@appointment_id", id);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to cancel appointment.");
        }
    }

    public List<Appointment> GetAppointmentsByDate(DateTime date)
    {
        List<Appointment> list = new();

        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Appointment WHERE appointmentDate=@date",
            conn);

        cmd.Parameters.AddWithValue("@date", date.Date);

        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Appointment
            {
                Id = (int)reader["appointment_id"],
                PatientId = (int)reader["p_id"],
                DoctorId = (int)reader["d_id"],
                AppointmentDate = (DateTime)reader["appointmentDate"],
                AppointmentTime = (TimeSpan)reader["appointmentTime"],
                Status = reader["appointmentStatus"].ToString()
            });
        }

        return list;
    }
}
