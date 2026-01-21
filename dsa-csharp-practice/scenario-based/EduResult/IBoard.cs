using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal interface IBoard
    {
        void AddDistrict(District districtObj);
        void MergeDistrict();
        void MergeSort();
        void AdddistrictStudents(int districtId, StudentMarks studentObj);
        void DisplayTopTen();
    }
}
