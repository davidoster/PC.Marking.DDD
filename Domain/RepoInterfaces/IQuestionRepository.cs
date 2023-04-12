using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces {
    public interface IQuestionRepository : IGenericRepository<Question> {
        Task<Question> MarkAQuestionAuto(Question question);
    }
}
