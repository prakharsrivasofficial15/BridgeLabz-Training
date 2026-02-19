using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using HealthCareApp.Utilities;

namespace HealthCareApp.Menus;

public class VisitMenu : IMenu
{
    private readonly IVisitUtility _utility;

    public VisitMenu()
    {
        _utility = new VisitUtility();
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n--- VISIT MANAGEMENT ---");
            Console.WriteLine("1. Add Visit Record");
            Console.WriteLine("2. View Patient Visit History");
            Console.WriteLine("0. Back");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddVisit();
                    break;
                case "2":
                    ViewHistory();
                    break;
                case "0":
                    return;
            }
        }
    }

    private void AddVisit()
    {
        Visit v = new Visit();

        Console.Write("Patient ID: ");
        v.PatientId = int.Parse(Console.ReadLine());

        Console.Write("Appointment ID: ");
        v.AppointmentId = int.Parse(Console.ReadLine());

        Console.Write("Doctor ID: ");
        v.DoctorId = int.Parse(Console.ReadLine());

        Console.Write("Diagnosis: ");
        v.Diagnosis = Console.ReadLine();

        Console.Write("Notes: ");
        v.Notes = Console.ReadLine();

        _utility.AddVisit(v);

        Console.WriteLine("Visit recorded. Appointment marked COMPLETED automatically.");
    }

    private void ViewHistory()
    {
        Console.Write("Enter Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        var visits = _utility.GetVisitsByPatient(id);

        foreach (var v in visits)
        {
            Console.WriteLine($"{v.Id} | {v.VisitDateTime} | {v.Diagnosis}");
        }
    }
}
