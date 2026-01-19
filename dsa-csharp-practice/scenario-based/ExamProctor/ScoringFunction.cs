using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor
{
    //calculate exam score
    internal class ScoringFunction
    {
        // Evaluate using correct answers map
        public int Evaluate(AnswerMap studentAnswers, AnswerMap correctAnswers)
        {
            int score = 0;

            // Check each correct answer
            for (int q = 1; q <= 20; q++) 
            {
                string correct = correctAnswers.Get(q);
                string given = studentAnswers.Get(q);

                if (correct != null && given != null && correct == given)
                    score++;
            }

            return score;
        }
    }
}

