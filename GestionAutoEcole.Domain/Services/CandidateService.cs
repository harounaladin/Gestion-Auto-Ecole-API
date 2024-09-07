using GestionAutoEcole.Infrastructure.Models;
using GestionAutoEcole.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAutoEcole.Domain.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<List<Candidate>> GetAllCandidate()
        {
            return await _candidateRepository.GetAllCandidateAsync();
        }

        public async Task<Candidate?> GetCandidateById(int id) 
        {
             return await _candidateRepository.GetCandidateByIdAsync(id);
        }

        public async Task addCandidate(Candidate candidate)
        {
            await _candidateRepository.AddCandidateAsync(candidate);
        }
        public async Task UpdateCandidate(Candidate candidate)
        {
            await _candidateRepository.UpdateCandidateAsync(candidate);
        }
        public async Task DeleteCandidate(int id)
        {
            await _candidateRepository.DeleteCandidateAsync(id);
        }

    }
}
