using HealthCareApp.Data;
using HealthCareApp.Exceptions;
using Microsoft.Data.SqlClient;

namespace HealthCareApp.Security;

public class AuthService
{
    public User Login()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();

        using SqlConnection conn = DbConnectionFactory.CreateConnection();
        conn.Open();

        using SqlCommand cmd = new SqlCommand(
            "SELECT user_id, user_role FROM Users WHERE username=@u AND is_active=1",
            conn);

        cmd.Parameters.AddWithValue("@u", username);

        using SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.Read())
            throw new UnauthorizedAppException("Invalid user.");

        int userId = (int)reader["user_id"];
        string roleString = reader["user_role"].ToString();

        reader.Close();

        SetSessionUser(conn, userId);

        return new User
        {
            Id = userId,
            Username = username,
            Role = Enum.Parse<UserRole>(roleString)
        };
    }

    private void SetSessionUser(SqlConnection conn, int userId)
    {
        using SqlCommand cmd = new SqlCommand(
            "EXEC sp_set_session_context @key=N'user_id', @value=@uid", conn);

        cmd.Parameters.AddWithValue("@uid", userId);
        cmd.ExecuteNonQuery();
    }
}
