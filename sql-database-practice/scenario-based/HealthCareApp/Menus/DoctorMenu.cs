using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using HealthCareApp.Utilities;

namespace HealthCareApp.Menus;

public class DoctorMenu : IMenu
{
    private readonly IDoctorUtility _doctorUtility;

    public DoctorMenu()
    {
        _doctorUtility = new DoctorUtility();
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n--- DOCTOR MANAGEMENT ---");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. View All Doctors");
            Console.WriteLine("3. Deactivate Doctor");
            Console.WriteLine("0. Back");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddDoctor();
                    break;
                case "2":
                    ViewDoctors();
                    break;
                case "3":
                    DeactivateDoctor();
                    break;
                case "0":
                    return;
            }
        }
    }

    private void AddDoctor()
    {
        Doctor d = new Doctor();

        Console.Write("Name: ");
        d.Name = Console.ReadLine();

        Console.Write("Speciality ID: ");
        d.SpecialityId = int.Parse(Console.ReadLine());

        Console.Write("Contact: ");
        d.Contact = Console.ReadLine();

        Console.Write("Consultation Fee: ");
        d.ConsultationFee = decimal.Parse(Console.ReadLine());

        Console.Write("Is Available (true/false): ");
        d.IsAvailable = bool.Parse(Console.ReadLine());

        _doctorUtility.AddDoctor(d);
        Console.WriteLine("Doctor added successfully.");
    }

    private void ViewDoctors()
    {
        var doctors = _doctorUtility.GetAllDoctors();

        foreach (var d in doctors)
        {
            Console.WriteLine($"{d.Id} | {d.Name} | Fee: {d.ConsultationFee}");
        }
    }

    private void DeactivateDoctor()
    {
        Console.Write("Enter Doctor ID: ");
        int id = int.Parse(Console.ReadLine());

        _doctorUtility.DeactivateDoctor(id);
        Console.WriteLine("Doctor deactivated.");
    }
}
