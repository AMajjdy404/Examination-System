using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
           Subject subject = new Subject();
            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want to Start the Exam ? (Press 'y' for Yes | 'n' for No)");
            string choice = Console.ReadLine();

            if (choice == "y")
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject.ExamOfSubject.ShowExam();
                Console.WriteLine($"The Elapsed Time => {sw.Elapsed}");
            }
            else Console.WriteLine("Good Luck Next Time :)");

        }
    }
}
