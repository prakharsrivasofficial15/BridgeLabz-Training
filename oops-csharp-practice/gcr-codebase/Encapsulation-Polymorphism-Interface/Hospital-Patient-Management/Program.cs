using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Hospital_Patient_Management
{
    class Program
    {
        static void Main()
        {
            Patient[] patients = new Patient[2];

            patients[0] = new InPatient(1, "Alice", 35, 5, 3000);
            patients[1] = new OutPatient(2, "Bob", 28, 800);

            ((IMedicalRecord)patients[0]).AddRecord("Appendicitis");
            ((IMedicalRecord)patients[1]).AddRecord("Seasonal Fever");

            HospitalProcessor.ProcessPatients(patients);
        }
    }

}
