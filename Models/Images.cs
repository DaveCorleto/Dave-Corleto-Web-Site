namespace Dave_Corleto_Web_Site.Models
{
    public class Images
    {
        public int Id { get; set; }
        public int BandId { get; set; }  // Cambiato per seguire le convenzioni di denominazione
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }

        // Costruttore senza parametri
        public Images() { }

        // Costruttore con parametri
        public Images(int id, int bandId, string title, string description, string path)
        {
            Id = id;                      // Corretto l'uso delle variabili
            BandId = bandId;              // Corretto l'uso delle variabili
            Title = title;
            Description = description;
            Path = path;
        }
    }

}
