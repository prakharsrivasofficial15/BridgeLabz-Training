namespace HealthCareApp.Exceptions;

public class DatabaseOperationException : HealthClinicException
{
    public DatabaseOperationException(string message)
        : base(message)
    {
    }
}
