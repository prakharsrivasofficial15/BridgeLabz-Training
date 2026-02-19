namespace HealthCareApp.Models;

public class Visit
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int AppointmentId { get; set; }
    public int DoctorId { get; set; }
    public DateTime VisitDateTime { get; set; }
    public string Diagnosis { get; set; }
    public string Notes { get; set; }
}
