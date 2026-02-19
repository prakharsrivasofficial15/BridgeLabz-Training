using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using HealthCareApp.Utilities;

namespace HealthCareApp.Menus;

public class BillingMenu : IMenu
{
    private readonly IBillingUtility _utility;

    public BillingMenu()
    {
        _utility = new BillingUtility();
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n--- BILLING MANAGEMENT ---");
            Console.WriteLine("1. Generate Bill");
            Console.WriteLine("2. Record Payment");
            Console.WriteLine("3. View Unpaid Bills");
            Console.WriteLine("0. Back");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GenerateBill();
                    break;
                case "2":
                    RecordPayment();
                    break;
                case "3":
                    ViewUnpaid();
                    break;
                case "0":
                    return;
            }
        }
    }

    private void GenerateBill()
    {
        Bill b = new Bill();

        Console.Write("Patient ID: ");
        b.PatientId = int.Parse(Console.ReadLine());

        Console.Write("Doctor ID: ");
        b.DoctorId = int.Parse(Console.ReadLine());

        Console.Write("Record ID: ");
        b.RecordId = int.Parse(Console.ReadLine());

        Console.Write("Consultation Fee: ");
        b.ConsultationFee = decimal.Parse(Console.ReadLine());

        Console.Write("Additional Charge: ");
        b.AdditionalCharge = decimal.Parse(Console.ReadLine());

        _utility.GenerateBill(b);
        Console.WriteLine("Bill generated successfully.");
    }

    private void RecordPayment()
    {
        PaymentTransaction t = new PaymentTransaction();

        Console.Write("Bill ID: ");
        t.BillId = int.Parse(Console.ReadLine());

        Console.Write("Payment Mode (CARD/ONLINE/CASH): ");
        t.Mode = Console.ReadLine();

        Console.Write("Amount Paid: ");
        t.AmountPaid = decimal.Parse(Console.ReadLine());

        _utility.RecordPayment(t);
        Console.WriteLine("Payment recorded. Status auto-updated if fully paid.");
    }

    private void ViewUnpaid()
    {
        var bills = _utility.GetUnpaidBills();

        foreach (var b in bills)
        {
            Console.WriteLine($"{b.Id} | Patient:{b.PatientId} | Total:{b.TotalAmount}");
        }
    }
}
