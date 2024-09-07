using GestionAutoEcole.Domain.Services;
using GestionAutoEcole.Infrastructure;
using GestionAutoEcole.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionAutoEcole.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            this.candidateService = candidateService;
        }
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetAll()
        {
            return await candidateService.GetAllCandidate();
        }

        // GET: api/candidate/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetById(int id)
        {
            var candidate = await candidateService.GetCandidateById(id);
            if (candidate == null)
            {
                return NotFound();
            }
            return Ok(candidate);
        }

        // POST: api/candidate
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Candidate candidate)
        {
            if (candidate == null)
            {
                return BadRequest();
            }

            await candidateService.addCandidate(candidate);

            return CreatedAtAction(nameof(GetById), new { id = candidate.Id }, candidate);
        }

        // PUT: api/candidate/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] Candidate candidate)
        {
            if (id != candidate.Id)
            {
                return BadRequest("Candidate ID mismatch");
            }

            await candidateService.UpdateCandidate(candidate);

            return NoContent();
        }

        // DELETE: api/candidate/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingCandidate = await candidateService.GetCandidateById(id);
            if (existingCandidate == null)
            {
                return NotFound();
            }

            await candidateService.DeleteCandidate(id);

            return NoContent();
        }


    }
}
