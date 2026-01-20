using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    class Resume<T> where T : JobRole
    {
        private List<T> candidates = new List<T>();

        public void AddResume(T candidate)
        {
            candidates.Add(candidate);
        }

        public void ScreenResumes()
        {
            Console.WriteLine("\nScreening Results");
            foreach (var c in candidates)
            {
                c.Display();
                Console.WriteLine(c.IsQualified() ? "Status: Shortlisted\n" : "Status: Rejected\n");
            }
        }
    }
}