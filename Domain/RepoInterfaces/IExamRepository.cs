using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces {
    public interface IExamRepository : IGenericRepository<Exam> {
        Task<List<Exam>> GetUnmarkedList();
        Task<List<Exam>> GetMarkedList();



        // these are commands.

        
    }
}
