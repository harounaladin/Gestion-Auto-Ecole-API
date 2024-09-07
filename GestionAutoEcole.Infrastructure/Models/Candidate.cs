namespace GestionAutoEcole.Infrastructure.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? UrlPhoto { get; set; }
        public string PhoneNumber { get; set; }
        public string? Adress { get; set; }
        public DateTime DateBirth { get; set; }

    }
}
