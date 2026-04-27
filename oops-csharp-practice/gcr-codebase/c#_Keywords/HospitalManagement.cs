using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.c__Keywords
{
    internal class Patient
    {
        public static string HospitalName = "City Care Hospital";
        private static int totalPatients = 0;

        public string Name;
        public int Age;
        public string Ailment;
        public readonly string PatientID;

        public Patient(string name, int age, string ailment, string patientId)
        {
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
            this.PatientID = patientId;
            totalPatients++;
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients: {totalPatients}");
        }

        public static void DisplayPatientDetails(object obj)
        {
            if (obj is Patient p)
            {
                Console.WriteLine($"{p.Name} - {p.PatientID} - {p.Age} - {p.Ailment}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient("Ravi", 45, "Fever", "PT001");
            Patient p2 = new Patient("Anita", 30, "Cold", "PT002");

            Console.WriteLine(Patient.HospitalName);
            Patient.DisplayPatientDetails(p1);
            Patient.DisplayPatientDetails(p2);
            Patient.GetTotalPatients();

            Console.ReadLine();
        }
    }
}

