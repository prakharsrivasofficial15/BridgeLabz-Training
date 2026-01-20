using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    class DataScientist : JobRole
    {
        public int MLScore { get; set; }

        public DataScientist(string name, int exp, int score) : base(name, exp)
        {
            MLScore = score;
        }

        public override bool IsQualified()
        {
            return Experience >= 1 && MLScore >= 75;
        }

        public override void Display()
        {
            Console.WriteLine($"[DS] {CandidateName}, Exp: {Experience}, Score: {MLScore}");
        }
    }
}
