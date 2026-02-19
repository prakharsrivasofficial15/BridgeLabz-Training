namespace HealthCareApp.Exceptions;

public class AppointmentException : HealthClinicException
{
    public AppointmentException(string message) : base(message) { }
}
