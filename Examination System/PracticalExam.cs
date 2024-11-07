using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int NumOfQuestions) : base(timeOfExam, NumOfQuestions)
        {

        }
        public override void CreateListOfQuestions()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                bool flag;
                int num;
                do
                {
                    Console.WriteLine($"Please Choose the type of Question Number ({i + 1}) : Press 1 for MCQ Question");
                    flag = int.TryParse(Console.ReadLine(), out num);
                } while (!flag || num > 1 || num <= 0);
                if (num == 1) // MCQ Question
                {
                    Questions[i] = new McqQuestion();
                    Questions[i].AddQuestion();

                }
              
            }

        }

        public override void ShowExam()
        {
            // Start Exam
            Console.Clear();
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i].ToString());

                bool flag;
                int userAnswer;
                do
                {
                    Console.WriteLine("Please Enter Your Answer of this Question (1 | 2 | 3) : ");
                    flag = int.TryParse(Console.ReadLine(), out userAnswer);
                } while (!flag && (userAnswer <= Questions.Length));

                Questions[i].UserAnswer = Questions[i].AnswersList[userAnswer - 1];

            }

            // Show Result
            Console.Clear();
            
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i].ToString());
                Console.WriteLine();

                Console.WriteLine($"The Right Answer is : {Questions[i].RightAnswer}");
              

            }
            

        }
    }
}
