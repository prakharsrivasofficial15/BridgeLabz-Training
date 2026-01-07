using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Hospital_Patient_Management
{
    public class InPatient : Patient, IMedicalRecord
    {
        private int _daysAdmitted;
        private decimal _dailyCharge;

        public InPatient(int patientId, string name, int age, int daysAdmitted, decimal dailyCharge)
            : base(patientId, name, age)
        {
            _daysAdmitted = daysAdmitted;
            _dailyCharge = dailyCharge;
        }

        public override decimal CalculateBill()
        {
            return _daysAdmitted * _dailyCharge;
        }

        public void AddRecord(string diagnosis)
        {
            AddMedicalHistory(diagnosis);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical History (In-Patient):");
            ShowMedicalHistory();
        }
    }

}
