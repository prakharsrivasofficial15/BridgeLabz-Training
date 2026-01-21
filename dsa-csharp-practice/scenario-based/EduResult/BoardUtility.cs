using BridgelabzTraining.senario_based.Smart_Home_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class BoardUtility : IBoard
    {
        //store all districts
        List<District> districtList = new List<District>();
        List<StudentMarks> mergedSortedStudents = new List<StudentMarks>();

        //add a new district
        public void AddDistrict(District districtObj)
        {
            districtList.Add(districtObj);
        }
        // add student to a specific district
        public void AdddistrictStudents(int districtId, StudentMarks studentObj)
        {
            foreach (District dist in districtList)
            {
                if (dist.districtCode == districtId)
                {
                    dist.studentList.Add(studentObj);
                    Console.WriteLine("Student Added.");
                    return;
                }
            }
        }

        public void MergeDistrict()
        {
            mergedSortedStudents.Clear();

            foreach (District dist in districtList)
            {
                District tempDistrict = new District(dist.districtCode, dist.studentList);
                tempDistrict.SortQuick(tempDistrict.studentList);
                mergedSortedStudents.AddRange(tempDistrict.studentList);
            }

            Console.WriteLine("District result merged to be sorted.");
        }

        public void MergeSort()
        {
            MergeSort(mergedSortedStudents, 0, mergedSortedStudents.Count - 1);
            Console.WriteLine("Sorted the list of student ");
        }
        // Merge sort
        public void MergeSort(List<StudentMarks> list, int start, int end)
        {
            if (start < end)
            {
                int middle = start + (end - start) / 2;
                MergeSort(list, start, middle);
                MergeSort(list, middle + 1, end);
                SortingList(list, start, middle, end);
            }
        }

        private void SortingList(List<StudentMarks> list, int start, int middle, int end)
        {
            StudentMarks[] leftPart = list.GetRange(start, middle - start + 1).ToArray();
            StudentMarks[] rightPart = list.GetRange(middle + 1, end - middle).ToArray();

            int i = 0, j = 0, k = start;

            while (i < leftPart.Length && j < rightPart.Length)
            {
                if (leftPart[i].GetMarks() >= rightPart[j].GetMarks())
                    list[k++] = leftPart[i++];
                else
                    list[k++] = rightPart[j++];
            }

            while (i < leftPart.Length) list[k++] = leftPart[i++];
            while (j < rightPart.Length) list[k++] = rightPart[j++];
        }

        public void DisplayTopTen()
        {
            int limit = Math.Min(10, mergedSortedStudents.Count);
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(mergedSortedStudents[i]);
            }
        }
    }
}
