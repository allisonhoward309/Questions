using System;
using System.Collections.Generic;

namespace Studio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string question1 =  "What is your favorite color?";
            List<string> answer1 = new List<string> { "blue", "Green", "Brown" };
            string answer = "blue";
            
            string question2 = "True/False Is the sky purple?";
            bool answer2 = false;
            TrueFalse trueFalse = new TrueFalse(answer2, question2);


            Quiz quiz = new Quiz(new List<Questions>());
            quiz.AddQuestion(trueFalse);

            MultipleChoice multipleChoice = new MultipleChoice(answer1,answer, question1);
            quiz.AddQuestion(multipleChoice);

            //quiz.RunTest();
            string thing = Console.ReadLine();
            Console.WriteLine(thing);
            
        }
    }
}
