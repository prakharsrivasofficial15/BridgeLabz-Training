using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using HealthCareApp.Utilities;

namespace HealthCareApp.Menus;

public class AppointmentMenu : IMenu
{
    private readonly IAppointmentUtility _utility;

    public AppointmentMenu()
    {
        _utility = new AppointmentUtility();
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n--- APPOINTMENT MANAGEMENT ---");
            Console.WriteLine("1. Book Appointment");
            Console.WriteLine("2. View Appointments by Date");
            Console.WriteLine("3. Cancel Appointment");
            Console.WriteLine("0. Back");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Book();
                    break;
                case "2":
                    ViewByDate();
                    break;
                case "3":
                    Cancel();
                    break;
                case "0":
                    return;
            }
        }
    }

    private void Book()
    {
        Appointment a = new Appointment();

        Console.Write("Patient ID: ");
        a.PatientId = int.Parse(Console.ReadLine());

        Console.Write("Doctor ID: ");
        a.DoctorId = int.Parse(Console.ReadLine());

        Console.Write("Date (yyyy-mm-dd): ");
        a.AppointmentDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Time (HH:mm): ");
        a.AppointmentTime = TimeSpan.Parse(Console.ReadLine());

        _utility.BookAppointment(a);
        Console.WriteLine("Appointment booked successfully.");
    }

    private void ViewByDate()
    {
        Console.Write("Enter Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        var list = _utility.GetAppointmentsByDate(date);

        foreach (var a in list)
        {
            Console.WriteLine($"{a.Id} | Patient:{a.PatientId} | Doctor:{a.DoctorId} | {a.Status}");
        }
    }

    private void Cancel()
    {
        Console.Write("Enter Appointment ID: ");
        int id = int.Parse(Console.ReadLine());

        _utility.CancelAppointment(id);
        Console.WriteLine("Appointment cancelled.");
    }
}
