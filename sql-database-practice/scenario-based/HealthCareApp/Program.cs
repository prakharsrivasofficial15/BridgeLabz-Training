using HealthCareApp.Exceptions;
using HealthCareApp.Interfaces;
using HealthCareApp.Menus;
using HealthCareApp.Security;

namespace HealthCareApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "HealthCare Management System";

        try
        {
            AuthService auth = new AuthService();
            User user = auth.Login();

            IMenu menu = new AppMenu(user);
            menu.Show();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Access Denied: {ex.Message}");
        }
    }
}
