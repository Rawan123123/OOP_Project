using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01
{
    internal abstract class Question
    {
        public string Header {  get; set; }
        public string Body { get; set; }
        public double Mark {  get; set; }
        public Answer userAnswer { get; set; } //{2,"qrw"}
        public Answer[] AnswerList {  get; set; }//[ {1,"ewe"} , {2,"qrw"} , {"3,"rrr"} ]
        public Answer correctAnswer {  get; set; } //{3,"qqq"}

        public abstract void Show();

    }
}
