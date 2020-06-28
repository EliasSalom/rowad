using System;
using System.Collections.Generic;
using System.Text;
using rowad.Model;

namespace rowad.ViewModel
{
    class QuestionView
    {
        public List<QuizMod> QuizMods { get; set; }
        public QuestionView()
        {
            QuizMods = new QuizMod().GetQuizMods();
        }
    }
}
