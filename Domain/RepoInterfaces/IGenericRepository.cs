using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces {
    public interface IGenericRepository<T> where T : class {
        // these are queries.
        Task<T> GetById(int Id);
        Task<List<T>> GetAll();
        Task<List<T>> GetUnmarkedList();
        Task<List<T>> GetMarkedList();
        Task Save();
    }
}
