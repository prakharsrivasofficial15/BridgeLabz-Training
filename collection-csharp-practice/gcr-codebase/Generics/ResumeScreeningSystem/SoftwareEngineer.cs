using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    class SoftwareEngineer : JobRole
    {
        public int CodingScore { get; set; }

        public SoftwareEngineer(string name, int exp, int score) : base(name, exp)
        {
            CodingScore = score;
        }

        public override bool IsQualified()
        {
            return Experience >= 2 && CodingScore >= 70;
        }

        public override void Display()
        {
            Console.WriteLine($"[SE] {CandidateName}, Exp: {Experience}, Score: {CodingScore}");
        }
    }
}
