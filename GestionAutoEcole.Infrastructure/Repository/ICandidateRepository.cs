using GestionAutoEcole.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAutoEcole.Infrastructure.Repository
{
    public interface ICandidateRepository
    {
        Task<List<Candidate>> GetAllCandidateAsync();
        Task<Candidate?> GetCandidateByIdAsync(int id);
        Task AddCandidateAsync(Candidate candidate);
        Task UpdateCandidateAsync(Candidate candidate);
        Task DeleteCandidateAsync(int id);
    }
}
