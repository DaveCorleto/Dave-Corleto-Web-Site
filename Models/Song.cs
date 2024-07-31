namespace Dave_Corleto_Web_Site.Models
{
    public class Song
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public bool IsCover { get; set; }
        public string OriginalArtist { get; set; }
        public TimeOnly Duration { get; set; }  

        public Song() { }

        public Song(int id, int bandId, int albumId, string title, bool isCover, string originalArtist, TimeOnly duration)
        {
            Id = id;
            BandId = bandId;
            AlbumId = albumId;
            Title = title;
            IsCover = isCover;
            OriginalArtist = originalArtist;
            Duration = duration;
        }
    }
}
