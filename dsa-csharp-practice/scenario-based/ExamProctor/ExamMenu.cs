using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor
{
    sealed class ExamMenu
    {
        private IExamService service = new ExamServiceUtilityImpl();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Visit Question");
                Console.WriteLine("3. Answer Question");
                Console.WriteLine("4. Submit Exam");
                Console.WriteLine("5. Exit");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: 
                        service.AddStudent(); 
                        break;

                    case 2:
                        Console.Write("Question ID: ");
                        service.VisitQuestion(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Question ID: ");
                        int q = int.Parse(Console.ReadLine());
                        Console.Write("Answer: ");
                        service.AnswerQuestion(q, Console.ReadLine());
                        break;

                    case 4: 
                        service.SubmitExam(); 
                        break;

                    case 5: 
                        return;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
