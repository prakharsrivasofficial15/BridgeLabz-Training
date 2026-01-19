using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor
{
    interface IExamService
    {
        void AddStudent();
        void VisitQuestion(int qId);
        void AnswerQuestion(int qId, string answer);
        void SubmitExam();
    }
}
