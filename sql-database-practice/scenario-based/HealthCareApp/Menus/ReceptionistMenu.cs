using HealthCareApp.Interfaces;

namespace HealthCareApp.Menus;

public class ReceptionistMenu : IMenu
{
    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n--- RECEPTIONIST PANEL ---");
            Console.WriteLine("1. Patient Management");
            Console.WriteLine("2. Appointment Management");
            Console.WriteLine("3. Billing");
            Console.WriteLine("0. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new PatientMenu().Show();
                    break;
                case "2":
                    new AppointmentMenu().Show();
                    break;
                case "3":
                    new BillingMenu().Show();
                    break;
                case "0":
                    return;
            }
        }
    }
}
