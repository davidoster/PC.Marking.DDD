using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Exam: GenericExam
    {
        List<Question> Questions; // Q1
        List<PossibleAnswers> Answers;  // Q1.PossibleAnswers[0] = "sdfsdfsdf", Q1.PossibleAnswers[1] = "sdfsdfsdf"
        List<SubmittedAnswers> SubmittedAnswers;
    }
}
