using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Hosptital_Management
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public void DisplayDoctor()
        {
            Console.WriteLine($"{DoctorId}. Dr. {Name} - {Specialization}");
        }
    }
}

