using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    class ResumeProcessor
    {
        public static void ProcessResume<T>(T role) where T : JobRole
        {
            role.Display();
            System.Console.WriteLine(role.IsQualified() ? "Result: Passed Screening" : "Result: Failed Screening");
        }
    }
}
