using GestionAutoEcole.Infrastructure.Enums;

namespace GestionAutoEcole.Infrastructure.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ExamType Type { get; set; }
        public string Date { get; set; }
        public Candidate Students  { get; set; }
        public Employee Employer { get; set; }


    }
}
