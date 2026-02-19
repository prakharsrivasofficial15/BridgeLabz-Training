namespace HealthCareApp.Exceptions;

public class HealthClinicException : Exception
{
    public HealthClinicException(string message)
        : base(message)
    {
    }
}
