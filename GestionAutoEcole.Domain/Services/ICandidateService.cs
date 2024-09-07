using GestionAutoEcole.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GestionAutoEcole.Domain.Services
{
    public interface ICandidateService
    {
        Task<List<Candidate>> GetAllCandidate();
        Task<Candidate?> GetCandidateById(int id);
        Task addCandidate(Candidate candidate);
        Task UpdateCandidate(Candidate candidate);
        Task DeleteCandidate(int id);
    }
}
