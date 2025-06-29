using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01
{
    internal class MCQQuestion : Question
    {
        public override void Show()
        {
            Console.WriteLine($"{Header}:  {Body} ,       ({Mark} mark)");

            for (int j = 0; j < AnswerList.Length; j++)
            {
                Console.WriteLine($"{j + 1} {AnswerList[j].AnsText}");
            }
        }
    }
}
