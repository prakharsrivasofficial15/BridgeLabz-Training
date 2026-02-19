namespace HealthCareApp.Models;

public class Bill
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public int RecordId { get; set; }
    public decimal ConsultationFee { get; set; }
    public decimal AdditionalCharge { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentStatus { get; set; }
}
