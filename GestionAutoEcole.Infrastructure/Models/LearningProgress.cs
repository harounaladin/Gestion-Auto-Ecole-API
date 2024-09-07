using GestionAutoEcole.Infrastructure.Enums;

namespace GestionAutoEcole.Infrastructure.Models
{
    public class LearningProgress
    {
        public int Id { get; set; }
        public LearningType Type { get; set; }
        public string Description { get; set; }
        public string ProgressStatus { get; set; }
        public Employee Instructor { get; set; }
        public Candidate User { get; set; }

    }
}
