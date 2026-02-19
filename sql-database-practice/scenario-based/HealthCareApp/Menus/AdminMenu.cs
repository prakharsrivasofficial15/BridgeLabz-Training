using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using HealthCareApp.Utilities;

namespace HealthCareApp.Menus;

public class AdminMenu : IMenu
{
    private readonly IAdminUtility _utility;

    public AdminMenu()
    {
        _utility = new AdminUtility();
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n--- ADMIN PANEL ---");
            Console.WriteLine("1. Add Specialty");
            Console.WriteLine("2. View Specialties");
            Console.WriteLine("3. View Audit Logs");
            Console.WriteLine("4. Revenue Report");
            Console.WriteLine("0. Back");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddSpecialty();
                    break;
                case "2":
                    ViewSpecialties();
                    break;
                case "3":
                    ViewAudit();
                    break;
                case "4":
                    RevenueReport();
                    break;
                case "0":
                    return;
            }
        }
    }

    private void AddSpecialty()
    {
        Specialty s = new Specialty();

        Console.Write("Specialty Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Description: ");
        s.Description = Console.ReadLine();

        _utility.AddSpecialty(s);
        Console.WriteLine("Specialty added.");
    }

    private void ViewSpecialties()
    {
        var list = _utility.GetAllSpecialties();

        foreach (var s in list)
        {
            Console.WriteLine($"{s.Id} | {s.Name}");
        }
    }

    private void ViewAudit()
    {
        var logs = _utility.GetAuditLogs();

        foreach (var log in logs)
        {
            Console.WriteLine($"{log.Timestamp} | {log.TableName} | {log.ActionType}");
        }
    }

    private void RevenueReport()
    {
        Console.Write("Start Date (yyyy-mm-dd): ");
        DateTime start = DateTime.Parse(Console.ReadLine());

        Console.Write("End Date (yyyy-mm-dd): ");
        DateTime end = DateTime.Parse(Console.ReadLine());

        decimal revenue = _utility.GetRevenueByDateRange(start, end);

        Console.WriteLine($"Total Revenue: {revenue}");
    }
}
