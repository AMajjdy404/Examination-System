using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        public Exam(int _timeOfExam, int _numberOfQuestions)
        {
            TimeOfExam = _timeOfExam;
            NumberOfQuestions = _numberOfQuestions;
            Questions = new Question[NumberOfQuestions];
        }

        public abstract void ShowExam();
       public abstract void CreateListOfQuestions();
    }
}
