using Domain;
using RepoInterfaces;

namespace Application {
    public class QuestionMarkingBase {
        private readonly IQuestionRepository _questionRepository;
        public QuestionMarkingBase(IQuestionRepository questionRepository) =>  _questionRepository = questionRepository;

        public async Task<Question> QuestionMarkingService(Question question) {
            
            
            return question;
        }
    }
}