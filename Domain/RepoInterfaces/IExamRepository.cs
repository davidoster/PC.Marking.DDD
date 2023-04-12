using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces {
    public interface IExamRepository : IGenericRepository<Exam> {
 
       


        // these are commands.
        Task<Exam> MarkExamAuto(Exam exam);
        Task<Exam> SendExam(Exam exam);
        
    }
}
