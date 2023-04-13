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
    public class QuestionRepository : IQuestionRepository 
    {
        private readonly MarkingDbContext _markingDbContext;
        public QuestionRepository(MarkingDbContext applicationDbContext)
        {
            _markingDbContext = applicationDbContext;
            
        }
        public async Task Delete(int Id) 
        {
            _markingDbContext.Questions.Remove( await GetById(Id));
            await Save();

           
        }

        public async Task<List<Question>> GetAll() {
            return await _markingDbContext.Questions.ToListAsync();
        }

        public async Task<Question> GetById(int Id) {
            return await _markingDbContext.Questions.FirstAsync(q => q.Id == Id);
        }

       

        public async Task<Question> Insert(Question entity)
        {
            await _markingDbContext.Questions.AddAsync(entity);
            await Save();
            return entity;
        }

        public async Task Save() {
           await _markingDbContext.SaveChangesAsync();
        }

        public async Task<Question> Update(Question entity) {
            _markingDbContext.Update(entity);
            await Save();
            return entity;
        }
    }
}
