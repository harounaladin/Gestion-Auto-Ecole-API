using GestionAutoEcole.Infrastructure.Enums;

namespace GestionAutoEcole.Infrastructure.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ExamType Type { get; set; }
        public string Supervisor { get; set; }
        public Candidate Candidates { get; set; }


    }
}
