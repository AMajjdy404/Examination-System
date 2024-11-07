using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam ExamOfSubject { get; set; }

        public void CreateExam()
        {
            bool flag;
            int num;
            do
            {
                Console.WriteLine("Press 1 for Final Exam | 2 for Practical Exam");
                flag = int.TryParse(Console.ReadLine(), out num);
            } while (!flag || num > 2 || num <= 0);

            int time;

            do
            {
                Console.WriteLine("Please Enter Time Of Exam in Minutes - Range between (15-180) Minutes ");
                flag = int.TryParse(Console.ReadLine(), out time);
            } while (!flag || time > 180 || time < 15);


            int numOfQuestions;
            do
            {
                Console.WriteLine("Please Enter Number of Questions - Range between (2-20) Question ");
                flag = int.TryParse(Console.ReadLine(), out numOfQuestions);
            } while (!flag || numOfQuestions > 20 || numOfQuestions < 2);


            if (num == 1) // Final Exam
            {
                ExamOfSubject = new FinalExam(time, numOfQuestions);
                ExamOfSubject.CreateListOfQuestions();

            }
            else if (num == 2) // Practical Exam
            {
                ExamOfSubject = new PracticalExam(time, numOfQuestions);
                ExamOfSubject.CreateListOfQuestions();
            }



        }
    }
}
