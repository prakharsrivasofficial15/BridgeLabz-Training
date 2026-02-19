using HealthCareApp.Interfaces;
using HealthCareApp.Models;
using HealthCareApp.Utilities;

namespace HealthCareApp.Menus;

public class PatientMenu : IMenu
{
    private readonly IPatientUtility _patientUtility;

    public PatientMenu()
    {
        _patientUtility = new PatientUtility();
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n--- PATIENT MANAGEMENT ---");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View All Patients");
            Console.WriteLine("3. Delete Patient");
            Console.WriteLine("0. Back");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddPatient();
                    break;
                case "2":
                    ViewPatients();
                    break;
                case "3":
                    DeletePatient();
                    break;
                case "0":
                    return;
            }
        }
    }

    private void AddPatient()
    {
        Patient p = new Patient();

        Console.Write("Name: ");
        p.Name = Console.ReadLine();

        Console.Write("DOB (yyyy-mm-dd): ");
        p.DOB = DateTime.Parse(Console.ReadLine());

        Console.Write("Contact: ");
        p.Contact = Console.ReadLine();

        Console.Write("Address: ");
        p.Address = Console.ReadLine();

        Console.Write("Blood Group: ");
        p.BloodGroup = Console.ReadLine();

        _patientUtility.AddPatient(p);
        Console.WriteLine("Patient added successfully.");
    }

    private void ViewPatients()
    {
        var patients = _patientUtility.GetAllPatients();

        foreach (var p in patients)
        {
            Console.WriteLine($"{p.Id} | {p.Name} | {p.Contact}");
        }
    }

    private void DeletePatient()
    {
        Console.Write("Enter Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        _patientUtility.DeletePatient(id);
        Console.WriteLine("Patient deactivated.");
    }
}
