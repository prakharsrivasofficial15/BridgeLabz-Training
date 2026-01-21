using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class BoardMenu
    {
        IBoard boardService = new BoardUtility();
        int currentDistrictId = 0;

        public void Start()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("WELCOME TO THE RESULT FUNCTION");
                Console.WriteLine("1. Add District");
                Console.WriteLine("2. Add Student in a District");
                Console.WriteLine("3. Merge the result of all the district");
                Console.WriteLine("4. Sort for the top ten");
                Console.WriteLine("5. Display the Top Ten");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        List<StudentMarks> students = new List<StudentMarks>();
                        boardService.AddDistrict(new District(currentDistrictId++, students));
                        Console.WriteLine("District Added.");
                        break;

                    case 2:
                        Console.WriteLine("Enter The District Id:");
                        int districtId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter name:");
                        string studentName = Console.ReadLine();

                        Console.WriteLine("Enter marks:");
                        double studentMarks = Convert.ToDouble(Console.ReadLine());

                        boardService.AdddistrictStudents(districtId, new StudentMarks(studentName, studentMarks));
                        break;

                    case 3:
                        boardService.MergeDistrict();
                        break;

                    case 4:
                        boardService.MergeSort();
                        break;

                    case 5:
                        boardService.DisplayTopTen();
                        break;

                    default:
                        isRunning = false;     // Exit
                        break;
                }
            }
        }
    }
}
