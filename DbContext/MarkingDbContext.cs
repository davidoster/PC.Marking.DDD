using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;

namespace ApplicationDbContext {
    public class MarkingDbContext : DbContext {
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }

        public DbSet<AwardedAnswer> AwardedAnswers { get; set; }
        public MarkingDbContext(DbContextOptions options) :
        base(options) 
        {

        }
    }
}
