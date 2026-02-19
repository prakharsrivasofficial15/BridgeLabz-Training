namespace HealthCareApp.Exceptions;

public class UnauthorizedAppException : HealthClinicException
{
    public UnauthorizedAppException(string message)
        : base(message)
    {
    }
}
