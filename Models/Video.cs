namespace Dave_Corleto_Web_Site.Models
{
    using System;

    public class Video
    {
        public int Id { get; set; }
        public int BandId { get; set; } 
        public string Title { get; set; }
        public byte[] CoverImg { get; set; }
        public string YouTubeUrl { get; set; }
        public DateTime PublishedDate { get; set; }

        // Costruttore senza parametri
        public Video() { }

        // Costruttore con parametri
        public Video(int id, int bandId, string title, byte[] coverImg, string youTubeUrl, DateTime publishedDate)
        {
            Id = id;              // Corretto il nome del parametro
            BandId = bandId;      // Corretto il nome del parametro
            Title = title;
            CoverImg = coverImg;
            YouTubeUrl = youTubeUrl;
            PublishedDate = publishedDate;
        }
    }

}
