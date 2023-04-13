using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using RepoInterfaces;

namespace Infrastructure {
    public class ExamRepository : IExamRepository {
        public Task Delete(int Id) {
            throw new NotImplementedException();
        }

        public Task<List<Exam>> GetAll() {
            throw new NotImplementedException();
        }

        public Task<Exam> GetById(int Id) {
            throw new NotImplementedException();
        }

        public Task<List<Exam>> GetMarkedList() {
            throw new NotImplementedException();
        }

        public Task<List<Exam>> GetUnmarkedList() {
            throw new NotImplementedException();
        }

        public Task<Exam> Insert() {
            throw new NotImplementedException();
        }

        public Task Save() {
            throw new NotImplementedException();
        }

        public Task<Exam> Update(Exam entity) {
            throw new NotImplementedException();
        }
    }
}
