using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Hospital_Patient_Management
{
    public abstract class Patient
    {
        private int _patientId;
        private string _name;
        private int _age;

        private string[] _medicalHistory = new string[5];
        private int _recordCount = 0;

        public int PatientId
        {
            get { return _patientId; }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Patient ID must be positive.");
                _patientId = value;
            }
        }

        public string Name
        {
            get { return _name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Age must be valid.");
                _age = value;
            }
        }

        protected Patient(int patientId, string name, int age)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
        }

        public abstract decimal CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("ID: " + PatientId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

        protected void AddMedicalHistory(string diagnosis)
        {
            if (_recordCount < _medicalHistory.Length)
            {
                _medicalHistory[_recordCount] = diagnosis;
                _recordCount++;
            }
        }

        protected void ShowMedicalHistory()
        {
            if (_recordCount == 0)
            {
                Console.WriteLine("No medical records available.");
                return;
            }

            for (int i = 0; i < _recordCount; i++)
            {
                Console.WriteLine("- " + _medicalHistory[i]);
            }
        }
    }
}
