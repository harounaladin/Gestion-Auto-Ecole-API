using GestionAutoEcole.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionAutoEcole.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<LegalFile> LegalFiles { get; set; }
        public DbSet<LearningProgress> Learning_Progresses { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Exam> Exams { get; set; }
    }
}
