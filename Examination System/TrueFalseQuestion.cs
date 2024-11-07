using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class TrueFalseQuestion : Question
    {
        public override string Header { get; set; } = "T/F Question";

        public override void AddQuestion()
        {
            Console.Clear();

            Console.WriteLine(Header);

            do
            {
                Console.Write("Please Enter Body of the Question : ");
                Body = Console.ReadLine();
            } while (Body == null);

            bool flag;
            int mark;
            do
            {
                Console.Write("Please Enter Mark of the Question (Range between 1-15) : ");
                flag = int.TryParse(Console.ReadLine(), out mark);
            } while (!flag || mark > 15 || mark <= 0);
            Mark = mark;

            AnswersList = new Answer[2];
            AnswersList[0] = new Answer() { Id = 0,Text = "true"};
            AnswersList[1] = new Answer() { Id = 1,Text = "false"};

            int rightAnswer;
            do
            {
                Console.Write("Please Enter the Right Answer of the Question ( 1 for True | 2 for False) : ");
                flag = int.TryParse(Console.ReadLine(), out rightAnswer);
            } while (!flag || rightAnswer > 3 || rightAnswer <= 0);
            RightAnswer = AnswersList[rightAnswer - 1];
        }

        public override string ToString()
        {
            return $"{Header}\n{Body}\t(Mark : {Mark})\n{AnswersList[0]?.ToString()}\t{AnswersList[1]?.ToString()}";
        }
    }
}
