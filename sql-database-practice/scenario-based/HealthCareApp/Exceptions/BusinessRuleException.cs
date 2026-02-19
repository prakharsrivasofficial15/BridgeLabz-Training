namespace HealthCareApp.Exceptions;

public class BusinessRuleException : HealthClinicException
{
    public BusinessRuleException(string message)
        : base(message)
    {
    }
}
