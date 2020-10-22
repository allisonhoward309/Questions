using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Studio6
{
    class Quiz
    {
        public List<Questions> Classes { get; set; }
        public Quiz(List<Questions> classes)
        {
            Classes = classes;
        }
        public List<Questions> AddQuestion(Questions input)
        {
            Classes.Add(input);
            return Classes;
        }

        public void RunTest()
         {
            for (int i =0; i<Classes.Count; i++)
            {
                Classes[i].PrintQuestion();
                Classes[i].PrintPossibleAnswers();
                Classes[i].MatchAnswer();
            }
        }
    public void GradeQuiz(){

}
    }
}
