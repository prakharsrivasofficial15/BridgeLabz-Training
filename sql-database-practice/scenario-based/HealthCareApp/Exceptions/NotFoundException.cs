namespace HealthCareApp.Exceptions;

public class NotFoundException : HealthClinicException
{
    public NotFoundException(string message)
        : base(message)
    {
    }
}
