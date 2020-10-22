using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio6
{
    class TrueFalse: Questions
    {
        bool Answer;

        public TrueFalse(bool answer, string question): base(question)
        {
            Answer = answer;
        }

        public override void PrintPossibleAnswers()
        {
            Console.WriteLine("True \nFalse");
        }

        public override void MatchAnswer()
        {
            Console.WriteLine("Enter True or False.");
            string input = Console.ReadLine();
            if (input == "True")
            {
                Points += 1;
            }

        }

    }
}
