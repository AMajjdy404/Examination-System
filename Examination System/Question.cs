using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    abstract class Question
    {
        public abstract string Header { get; set; }
        public string Body { get; set; }

        public int Mark { get; set; }

        public Answer[] AnswersList { get; set; }

        public Answer UserAnswer { get; set; }
        public Answer RightAnswer { get; set; }

        public abstract void AddQuestion();
    }
}
