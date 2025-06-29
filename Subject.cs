using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01
{
    internal class Subject
    {
        public int SubID {  get; set; }
        public string SubName {  get; set; }
        Exam exam {  get; set; }

        public void ShowExam()
        {
            exam.ShowExam();
        }

        public void CreateExam(bool isFinal)
        {
            if(isFinal == true)
                exam = new FinalExam();

            else
                exam = new PracticalExam();


            exam.question = new Question[isFinal ? 3 : 2];

            Answer a1 = new Answer() { AnsId = 1, AnsText = "c#" };
            Answer a2 = new Answer() { AnsId = 2, AnsText = "HTML" };
            Answer a3 = new Answer() { AnsId = 3, AnsText = "OOP" };

            MCQQuestion q1 = new MCQQuestion()
            {
                Header = "OOP language",
                Body = "what is the object orianted programming?",
                Mark = 5,
                AnswerList = new Answer[]{ a1, a2, a3 },
                correctAnswer = a3
            };

            Answer a11 = new Answer() { AnsId = 1, AnsText = "baisics" };
            Answer a22 = new Answer() { AnsId = 2, AnsText = "Technology" };
            Answer a33 = new Answer() { AnsId = 3, AnsText = "python" };

             MCQQuestion q2 = new MCQQuestion ()
            {
                Header = "CS start",
                Body = "what is the main thing to learn first?",
                Mark = 3,
                AnswerList = new Answer[] { a11, a22, a33 },
                correctAnswer = a11
            };

            if (isFinal)
            {
                Answer a111 = new Answer() { AnsId = 1, AnsText = "True" };
                Answer a222 = new Answer() { AnsId = 2, AnsText = "False" };


                TrueFalseQuestion q3 = new TrueFalseQuestion()
                {
                    Header = "CS start",
                    Body = "is learning oop is important?",
                    Mark = 3,
                    AnswerList = new Answer[] { a111, a222 },
                    correctAnswer = a111
                };
                exam.question[0] = q1;
                exam.question[1] = q2;
                exam.question[2] = q3;
            }
            else
            {
                exam.question[0] = q1;
                exam.question[1] = q2;
            }

            

            


        }
    }
}
