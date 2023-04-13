using Domain;
using RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure {
    public class QuestionRepository : IQuestionRepository {
        public Task Delete(int Id) {
            throw new NotImplementedException();
        }

        public Task<List<Question>> GetAll() {
            throw new NotImplementedException();
        }

        public Task<Question> GetById(int Id) {
            throw new NotImplementedException();
        }

        public Task<Question> Insert() {
            throw new NotImplementedException();
        }

        public Task Save() {
            throw new NotImplementedException();
        }

        public Task<Question> Update(Question entity) {
            throw new NotImplementedException();
        }
    }
}
