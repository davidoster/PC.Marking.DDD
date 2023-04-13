using Domain;

namespace Application {
    public class ExamMarkingBase : IExamMarkingBase {
        private readonly ISectionMarkingBase _sectionMarking;
        public ExamMarkingBase(ISectionMarkingBase sectionMarkingBase) => _sectionMarking = sectionMarkingBase;

        public async Task<Exam> ExamAutoMarkingService(Exam exam) {
            
            foreach(Section section in exam.Sections) {
               await _sectionMarking.SectionMarkingService(section);
                if(exam.OverallExamScore <= exam.MaximumScore) {
                    exam.OverallExamScore += section.AwardedSectionMarks;

                } else {
                    throw new Exception("your code sux");
                }
            }
            exam.MarkingState = MarkingState.AutoMarked;
            return exam;
        }
    }
}