namespace HealthCareApp.Exceptions;

public class DoctorException : HealthClinicException
{
    public DoctorException(string message) : base(message) { }
}
