using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Hospital_Patient_Management
{
    public class HospitalProcessor
    {
        public static void ProcessPatients(Patient[] patients)
        {
            for (int i = 0; i < patients.Length; i++)
            {
                Patient patient = patients[i];

                patient.GetPatientDetails();

                decimal billAmount = patient.CalculateBill();
                Console.WriteLine("Bill Amount: " + billAmount);

                if (patient is IMedicalRecord)
                {
                    IMedicalRecord medicalRecord = (IMedicalRecord)patient;
                    medicalRecord.ViewRecords();
                }

            }
        }
    }

}
