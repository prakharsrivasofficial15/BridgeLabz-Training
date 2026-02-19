namespace HealthCareApp.Models;

public class PaymentTransaction
{
    public int Id { get; set; }
    public int BillId { get; set; }
    public string Mode { get; set; }
    public decimal AmountPaid { get; set; }
}
