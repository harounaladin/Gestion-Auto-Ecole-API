namespace GestionAutoEcole.Infrastructure.Models
{
    public class LegalFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
        public int ProgressStatus { get; set; }
        public string UrlPdf { get; set; }


    }
}
