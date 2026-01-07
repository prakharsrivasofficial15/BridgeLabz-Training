using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Hospital_Patient_Management
{
    public class OutPatient : Patient, IMedicalRecord
    {
        private decimal _consultationFee;

        public OutPatient(int patientId, string name, int age, decimal consultationationFee)
            : base(patientId, name, age)
        {
            _consultationFee = consultationationFee;
        }

        public override decimal CalculateBill()
        {
            return _consultationFee;
        }

        public void AddRecord(string diagnosis)
        {
            AddMedicalHistory(diagnosis);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical History (Out-Patient):");
            ShowMedicalHistory();
        }
    }

}
