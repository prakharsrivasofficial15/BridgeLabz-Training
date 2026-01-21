using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class StudentMarks
    {
        protected string studentFullName;
        protected double studentScore;

        //constructor
        public StudentMarks(string fullName, double score)
        {
            this.studentFullName = fullName;
            this.studentScore = score;
        }

        // Returns student name
        public string GetStudentName() { return studentFullName; }
        // Returns student marks
        public double GetMarks() { return studentScore; }

        //Displays student details
        public override string ToString()
        {
            return "Name: " + studentFullName + "\nMarks: " + studentScore;
        }
    }
}
