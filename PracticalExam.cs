using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01
{
    internal class PracticalExam : Exam
    {
        public override void ShowExam()
        {

            Console.WriteLine("<<<<<<< The Practical Exam >>>>>>>>\n");
            for(int i = 0; i < question.Length; i++)
            {
                
                var q = question[i];
                q.Show();

                Console.WriteLine($"The correct answer is: {q.correctAnswer.AnsText}\n");
                
            }
        }

        
    }
}
