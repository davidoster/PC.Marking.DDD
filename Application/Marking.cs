using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application {
    public class Marking {
       ExamMarkingBase ExamMarkingBase { get; set; }
       SectionMarkingBase SectionMarkingBase { get; set; }
       QuestionMarkingBase QuestionMarkingBase { get; set; }

        public float MarkingService(Exam exam) 
        {
            exam.Sections.ForEach(section => { section.Questions.ForEach(q => QuestionMarkingBase.QuestionMarkingService(q));});

            exam.Sections.ForEach(section => SectionMarkingBase.SectionMarkingService(section));

            ExamMarkingBase.ExamAutoMarkingService(exam);

            return (float)exam.OverallExamScore;
           
        }
    }
}
