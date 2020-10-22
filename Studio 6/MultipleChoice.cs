using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio6
{
    public class MultipleChoice : Questions
    {
        List<string> PossibleAnswers;
        string Answer;

        public MultipleChoice(List<string> possibleAnswers, string answer, string question): base(question)
        {
            Answer = answer;
            PossibleAnswers = possibleAnswers;
        }
        public override void PrintPossibleAnswers()
        {
            Console.WriteLine("Select the number of the choise that best answers the question.");
            Dictionary<int, string> choices = new Dictionary<int, string> { };
            for (int i = 0; i < this.PossibleAnswers.Count(); i++)
            {
                choices.Add(i + 1, this.PossibleAnswers[i]);
            }
            foreach (KeyValuePair<int, string> q in choices)
            {
                Console.WriteLine(q.Key + ": " + q.Value);
            }
        }

        public override void MatchAnswer()
        {
            Console.WriteLine("Enter True or False.");
            string input = Console.ReadLine();
            if (input == Answer)
            {
                Points += 1;
            }
        }
    }
}
