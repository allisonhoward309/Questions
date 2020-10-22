using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Studio6
{
   public abstract class Questions
    {
       public string Question { get; set; }
        public int Points { get; set; } = 0;
       
        public Questions(string question)
        {
            Question = question;
        }

        public abstract void MatchAnswer();
        public abstract void PrintPossibleAnswers();
        public void PrintQuestion()
        {
            Console.WriteLine(Question);
        }
       
    }
}
