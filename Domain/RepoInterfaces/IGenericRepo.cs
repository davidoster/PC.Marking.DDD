using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces {
    internal interface IGenericRepo<T> where T: class {
        Task<IReadOnlyCollection<T>> GetAllReadOnlyAsync();
        Task<T?> GetByIdAsync (Guid id);
        Task InsertAsync (T Entity);
    }
}
