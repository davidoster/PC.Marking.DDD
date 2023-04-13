using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDbContext;
using Domain;
using Microsoft.EntityFrameworkCore;
using RepoInterfaces;

namespace Infrastructure {
    public class ExamRepository : IExamRepository {

        private readonly MarkingDbContext _context;
        public ExamRepository(MarkingDbContext context)
        {
            _context = context;
        }
        public async Task Delete(int Id) {

             _context.Exams.Remove(await GetById(Id));
            await Save();
        }

        public async Task<List<Exam>> GetAll() {

            return await _context.Exams.ToListAsync();
        }

        public async Task<Exam> GetById(int Id) {

           return await _context.Exams.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<List<Exam>> GetMarkedList() {

            return await _context.Exams.Where(x => x.MarkingState == MarkingState.AutoMarked).ToListAsync();
        }

        public async Task<List<Exam>> GetUnmarkedList() {

            return await _context.Exams.Where(x => x.MarkingState == MarkingState.UnMarked).ToListAsync();
        }

        public async Task<Exam> Insert(Exam exam) {

            await _context.Exams.AddAsync(exam);
            await Save();
            return exam;
        }

        public async Task Save() {
            
            await _context.SaveChangesAsync();

        }

        public async Task<Exam> Update(Exam entity) {
           
            _context.Exams.Update(entity);
            await Save();
            return entity;

        }
    }
}
