using GestionAutoEcole.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAutoEcole.Infrastructure.Repository
{
    public class CandidateRepository(ApplicationDbContext applicationDbContext) : ICandidateRepository
    {
        public async Task<List<Candidate>> GetAllCandidateAsync()
        {
            return await applicationDbContext.Candidates.ToListAsync();
        }

        public async Task<Candidate?> GetCandidateByIdAsync(int id)
        {
            return await applicationDbContext.Candidates.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddCandidateAsync(Candidate candidate)
        {
            await applicationDbContext.Candidates.AddAsync(candidate);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateCandidateAsync(Candidate candidate)
        {
            applicationDbContext.Candidates.Update(candidate);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteCandidateAsync(int id)
        {
            var candidate = await applicationDbContext.Candidates.FirstOrDefaultAsync(c => c.Id == id);
            if (candidate != null)
            {
                applicationDbContext.Candidates.Remove(candidate);
                await applicationDbContext.SaveChangesAsync();
            }
        }

    }
}
