using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Object_Modeling.self
{
    internal class Patient
    {
        public string Name;
        public Patient(string name) { Name = name; }
    }

    class Doctor
    {
        public string Name;

        public Doctor(string name)
        {
            Name = name;
        }

        public void Consult(Patient patient)
        {
            Console.WriteLine("Dr. " + Name + " is consulting " + patient.Name);
        }
    }

    class Hospital
    {
        public string Name;
        public Hospital(string name) { Name = name; }
    }
}
