using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01
{
    internal class FinalExam : Exam
    {
        public override void ShowExam()
        {
            //  [ { header = "dfdf" , body = "dfdf" , mark = 3 ,{2,"qrw"}, {{1,"ewe"} , {2,"qrw"} , {"3,"rrr"}} , {3,"qqq"} }
            Console.WriteLine("<<<<<<< The Final Exam >>>>>>>>\n");
            double totalGrade = 0;
            for (int i = 0; i < question.Length; i++)
            {
                var q = question[i];

                Console.WriteLine($"Question {i + 1}:");
                q.Show();

                Console.Write("Enter Your Answer (option number): ");
                int choiseAnswer;

                while (true)
                {
                    string input = Console.ReadLine();
                    Console.WriteLine("");

                    if (!int.TryParse(input, out choiseAnswer))
                    {
                        Console.Write("invalid choice, enter number: ");
                        continue;
                    }
                    else if(choiseAnswer < 1 || choiseAnswer >q.AnswerList.Length)
                    {
                        Console.Write("choise out of range , try again: ");
                        continue;
                    }
                    break;

                }
                q.userAnswer = q.AnswerList[choiseAnswer - 1];

                if (q.userAnswer.AnsId == q.correctAnswer.AnsId)
                    totalGrade += q.Mark;

            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            for(int i=0; i< question.Length; i++)
            {
                var q = question[i];
                Console.WriteLine(
                    $"Q{i + 1} is: {q.Header}\n" +
                    $"your answer is: {q.userAnswer.AnsText}\n" +
                    $"correct answer: {q.correctAnswer.AnsText}");

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~\n");
            }
            Console.WriteLine($"<<<total grade: {totalGrade}>>>");

        }


    }
}
