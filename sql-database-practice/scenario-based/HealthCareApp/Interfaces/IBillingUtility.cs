using HealthCareApp.Models;

namespace HealthCareApp.Interfaces;

public interface IBillingUtility
{
    void GenerateBill(Bill bill);
    void RecordPayment(PaymentTransaction transaction);
    List<Bill> GetUnpaidBills();
}
