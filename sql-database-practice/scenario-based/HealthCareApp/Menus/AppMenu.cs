using HealthCareApp.Interfaces;
using HealthCareApp.Security;

namespace HealthCareApp.Menus;

public class AppMenu : IMenu
{
    private readonly User _user;

    public AppMenu(User user)
    {
        _user = user;
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine($"\n==== HEALTHCARE SYSTEM ({_user.Role}) ====");

            // ROLE-BASED MENU DISPLAY
            if (_user.Role == UserRole.RECEPTIONIST)
            {
                Console.WriteLine("1. Patient Management");
                Console.WriteLine("2. Appointment");
                Console.WriteLine("3. Billing");
            }
            else if (_user.Role == UserRole.DOCTOR)
            {
                Console.WriteLine("4. Visit");
            }
            else if (_user.Role == UserRole.ADMIN)
            {
                Console.WriteLine("5. Admin Panel");
            }

            Console.WriteLine("0. Exit");
            Console.Write("Select option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1" when _user.Role == UserRole.RECEPTIONIST:
                    new PatientMenu().Show();
                    break;

                case "2" when _user.Role == UserRole.RECEPTIONIST:
                    new AppointmentMenu().Show();
                    break;

                case "3" when _user.Role == UserRole.RECEPTIONIST:
                    new BillingMenu().Show();
                    break;

                case "4" when _user.Role == UserRole.DOCTOR:
                    new VisitMenu().Show();
                    break;

                case "5" when _user.Role == UserRole.ADMIN:
                    new AdminMenu().Show();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Unauthorized or Invalid option.");
                    break;
            }
        }
    }
}
