using ApplicationDbContext;
using Domain;
using Microsoft.EntityFrameworkCore;
using RepoInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure {
    public class SectionRepository : ISectionRepository {

        private readonly MarkingDbContext _markingDbContext;

        public SectionRepository(MarkingDbContext applicationDbContext)
        {
            _markingDbContext = applicationDbContext;
        }
        public async Task Delete(int Id) {
            _markingDbContext.Sections.Remove(await GetById(Id));
            await Save();
        }

        public async Task<List<Section>> GetAll() {
            return await _markingDbContext.Sections.ToListAsync();
        }

        public async Task<Section> GetById(int Id) {
            return await _markingDbContext.Sections.FirstAsync(x => x.Id == Id);
        }

        public async Task<Section> Insert(Section entity) {
            await _markingDbContext.Sections.AddAsync(entity);
            await Save();
            return entity;
        }

        public async Task Save() {
            await _markingDbContext.SaveChangesAsync();
        }

        public async Task<Section> Update(Section entity) {
            _markingDbContext.Update(entity);
            await Save();
            return entity;
        }
    }
}
