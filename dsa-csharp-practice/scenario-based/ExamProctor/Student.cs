using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor
{
    abstract class Student
    {
        protected int studentId;
        protected string studentName;

        // Constructor to initialize student details
        public Student(int id, string studentName)
        {
            studentId = id;
            this.studentName = studentName;
        }

        public int GetId() => studentId;

        //returns student details as a string
        public override string ToString()
        {
            return $"Name: {studentName} | ID: {studentId}";
        }
    }
}
