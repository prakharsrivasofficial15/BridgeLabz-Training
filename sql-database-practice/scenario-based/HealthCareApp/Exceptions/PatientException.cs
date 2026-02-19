namespace HealthCareApp.Exceptions;

public class PatientException : HealthClinicException
{
    public PatientException(string message) : base(message) { }
}
