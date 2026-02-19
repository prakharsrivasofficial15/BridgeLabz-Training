namespace HealthCareApp.Models;

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int SpecialityId { get; set; }
    public string Contact { get; set; }
    public decimal ConsultationFee { get; set; }
    public bool IsAvailable { get; set; }
}
