using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01
{
    internal abstract class Exam 
    {
        public TimeOnly TimeDuration {  get; set; }
        public int NoOfQuestion { get; set; }
        public Question[] question {get;set;}
        public abstract void ShowExam();
     
    }
}

//  [ { header = "dfdf" , body = "dfdf" , mark = 3 ,{2,"qrw"}, {{1,"ewe"} , {2,"qrw"} , {"3,"rrr"}} , {3,"qqq"} } ,

//    { header = "ggg" , body = "erer" , mark = 1 ,{ 1,"ewe"}, {{ 1,"ewe"} , { 2,"qrw"} , { "3,"rrr"}} , {4,"qqq"}

//  ]