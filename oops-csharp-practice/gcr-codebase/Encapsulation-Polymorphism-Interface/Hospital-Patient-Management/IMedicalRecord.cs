using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Hospital_Patient_Management
{
    public interface IMedicalRecord
    {
        void AddRecord(string diagnosis);
        void ViewRecords();
    }
}
