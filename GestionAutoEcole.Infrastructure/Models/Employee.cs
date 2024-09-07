namespace GestionAutoEcole.Infrastructure.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string? UrlPhoto { get; set; }
        public DateTime DateBirth { get; set; }
        public int Salaire { get; set; }
        public string status { get; set; }
        public int NumberOfCandidate { get; set; }
    }
}
