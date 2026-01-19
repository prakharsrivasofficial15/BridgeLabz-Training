using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor
{
    class ExamServiceUtilityImpl : IExamService
    {
        // Stores student details
        private Student student;

        // Stack to track visited questions
        private QuestionStack navStack = new QuestionStack();

        // Stores student answers
        private AnswerMap answers = new AnswerMap();

        // Stores correct answers
        private AnswerMap correctAnswers = new AnswerMap();

        // Scoring logic
        private ScoringFunction scorer = new ScoringFunction();

        // Constructor to initialize correct answers
        public ExamServiceUtilityImpl()
        {
            correctAnswers.Put(1, "A");
            correctAnswers.Put(2, "B");
            correctAnswers.Put(3, "C");
        }

        // Add student
        public void AddStudent()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            student = new ExamStudent(id, name);
        }

        // Visit a question
        public void VisitQuestion(int qId)
        {
            navStack.Push(qId);
            Console.WriteLine("Visited question: " + qId);
        }

        // Save answer
        public void AnswerQuestion(int qId, string answer)
        {
            answers.Put(qId, answer);
            Console.WriteLine("Answer saved");
        }

        // Submit exam and calculate score
        public void SubmitExam()
        {
            int score = scorer.Evaluate(answers, correctAnswers);
            Console.WriteLine($"Exam submitted. Score: {score}");
        }
    }
}
