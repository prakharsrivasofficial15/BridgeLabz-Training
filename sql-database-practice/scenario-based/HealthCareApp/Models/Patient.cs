namespace HealthCareApp.Models;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public string Contact { get; set; }
    public string Address { get; set; }
    public string BloodGroup { get; set; }
}
