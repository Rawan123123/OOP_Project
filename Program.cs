using System;
using Exam_01;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject() { SubID = 1 , SubName = "Programming"};

            Console.WriteLine("Do you need to create final exam? (yes/no)");
           
            string ans;
            while(true)
            {
                ans = Console.ReadLine();
                if(ans.ToUpper() != "YES" &&  ans.ToUpper() != "NO")
                {
                    Console.Write("enter valid option (yes/no): ");
                    continue;
                }
                break;

            }
            bool isFinal = ans.Trim().ToUpper() == "YES";

            subject.CreateExam(isFinal);

            Console.WriteLine($"\nSubject: {subject.SubName} (ID: {subject.SubID})\n");
            subject.ShowExam();




        }
    }
}