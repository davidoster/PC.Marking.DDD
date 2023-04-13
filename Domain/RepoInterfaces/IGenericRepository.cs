using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces {
    public interface IGenericRepository<T> where T : class {
        // these are queries.
        Task<List<T>> GetAll();

        Task Save();


        // CRUD Operation
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task Delete(int Id);
        Task<T> GetById(int Id);
    }
}
