using HealthCareApp.Data;
using HealthCareApp.Exceptions;
using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HealthCareApp.Utilities;

public class BillingUtility : IBillingUtility
{
    public void GenerateBill(Bill bill)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Bill_Generate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_id", bill.PatientId);
            cmd.Parameters.AddWithValue("@d_id", bill.DoctorId);
            cmd.Parameters.AddWithValue("@record_id", bill.RecordId);
            cmd.Parameters.AddWithValue("@d_consultationFee", bill.ConsultationFee);
            cmd.Parameters.AddWithValue("@additionalCharge", bill.AdditionalCharge);
            cmd.Parameters.AddWithValue("@paymentStatus", "UNPAID");

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to generate bill.");
        }
    }

    public void RecordPayment(PaymentTransaction transaction)
    {
        try
        {
            using SqlConnection conn = DbConnectionFactory.CreateConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("usp_Transaction_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bill_id", transaction.BillId);
            cmd.Parameters.AddWithValue("@t_mode", transaction.Mode);
            cmd.Parameters.AddWithValue("@amount_Paid", transaction.AmountPaid);

            cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            throw new DatabaseOperationException("Failed to record payment.");
        }
    }

    public List<Bill> GetUnpaidBills()
    {
        List<Bill> bills = new();

        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Billing WHERE paymentStatus='UNPAID'",
            conn);

        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            bills.Add(new Bill
            {
                Id = (int)reader["bill_id"],
                PatientId = (int)reader["p_id"],
                DoctorId = (int)reader["d_id"],
                RecordId = (int)reader["record_id"],
                ConsultationFee = (decimal)reader["d_consultationFee"],
                AdditionalCharge = (decimal)reader["additionalCharge"],
                TotalAmount = (decimal)reader["totalAmt"],
                PaymentStatus = reader["paymentStatus"].ToString()
            });
        }

        return bills;
    }
}
