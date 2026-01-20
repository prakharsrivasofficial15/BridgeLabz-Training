using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    abstract class JobRole
    {
        public string CandidateName { get; set; }
        public int Experience { get; set; }

        protected JobRole(string name, int experience)
        {
            CandidateName = name;
            Experience = experience;
        }

        public abstract bool IsQualified();
        public abstract void Display();
    }
}
