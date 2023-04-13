using Domain;

namespace Application {
    public interface IQuestionMarkingBase {
         Task<Question> QuestionMarkingService(Question question);
    }
}