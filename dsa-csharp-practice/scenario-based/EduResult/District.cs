using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class District
    {
        public int districtCode;
        public List<StudentMarks> studentList = new List<StudentMarks>();

        //constructor to initialize district
        public District(int code, List<StudentMarks> students)
        {
            this.districtCode = code;
            this.studentList = students;
        }

        public void SortQuick(List<StudentMarks> studentData)
        {
            if (studentList == null || studentList.Count <= 1)
                return;

            SortQuick(studentList, 0, studentList.Count - 1);
        }
        //quick sort
        public void SortQuick(List<StudentMarks> list, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(list, start, end);
                SortQuick(list, start, pivotIndex - 1);
                SortQuick(list, pivotIndex + 1, end);
            }
        }

        private int Partition(List<StudentMarks> list, int start, int end)
        {
            double pivotValue = list[end].GetMarks();
            int smallerIndex = start - 1;

            for (int current = start; current < end; current++)
            {
                if (list[current].GetMarks() >= pivotValue)
                {
                    smallerIndex++;
                    Swap(list, smallerIndex, current);
                }
            }

            Swap(list, smallerIndex + 1, end);
            return smallerIndex + 1;
        }

        private static void Swap(List<StudentMarks> list, int first, int second)
        {
            StudentMarks temp = list[first];
            list[first] = list[second];
            list[second] = temp;
        }

        public void Display()
        {
            foreach (StudentMarks student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
