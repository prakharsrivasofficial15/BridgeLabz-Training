using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario
{
    internal class EduQuiz
    {
        static void Main(string[] args)
        {
            string[] correctAnswers = {"A", "B", "C", "D", "A", "C", "B", "D", "A", "C"};

            string[] studentAnswers = new string[10];

            Console.WriteLine("Enter answers for 10 questions:");

            for (int i = 0; i < studentAnswers.Length; i++)
            {
                Console.Write("Question " + (i + 1) + ": ");
                studentAnswers[i] = Console.ReadLine();
            }

            int score = CalculateScore(correctAnswers, studentAnswers);
            DisplayResult(correctAnswers, studentAnswers, score);
        }

        // Calculates total score
        static int CalculateScore(string[] correct, string[] student)
        {
            int score = 0;

            for (int i = 0; i < correct.Length; i++)
            {
                if (student[i].Equals(correct[i], StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }
            return score;
        }

        // Displays feedback, percentage, and result
        static void DisplayResult(string[] correct, string[] student, int score)
        {
            Console.WriteLine("Feedback");

            for (int i = 0; i < correct.Length; i++)
            {
                if (student[i].Equals(correct[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Question " + (i + 1) + ": Correct");
                }
                else
                {
                    Console.WriteLine("Question " + (i + 1) + ": Incorrect (Correct Answer: " + correct[i] + ")");
                }
            }

            double percentage = (score / 10.0) * 100;

            Console.WriteLine("\nScore: " + score + "/10");
            Console.WriteLine("Percentage: " + percentage + "%");

            if (percentage >= 50)
            {
                Console.WriteLine("Result: PASS");
            }
            else
            {
                Console.WriteLine("Result: FAIL");
            }
        }
    }
}
