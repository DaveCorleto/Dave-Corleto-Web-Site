namespace Dave_Corleto_Web_Site.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public string Title { get; set; }

        public DateTime  ReleaseDate { get; set; }

        public Album () { }
        public Album (int id, int bandId, string title, DateTime releaseDate)
        {
            Id = id;
            BandId = bandId;
            Title = title;
            ReleaseDate = releaseDate;
        }
    }
}
