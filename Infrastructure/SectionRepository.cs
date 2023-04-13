using Domain;
using RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure {
    public class SectionRepository : ISectionRepository {
        public Task Delete(int Id) {
            throw new NotImplementedException();
        }

        public Task<List<Section>> GetAll() {
            throw new NotImplementedException();
        }

        public Task<Section> GetById(int Id) {
            throw new NotImplementedException();
        }

        public Task<Section> Insert() {
            throw new NotImplementedException();
        }

        public Task Save() {
            throw new NotImplementedException();
        }

        public Task<Section> Update(Section entity) {
            throw new NotImplementedException();
        }
    }
}
