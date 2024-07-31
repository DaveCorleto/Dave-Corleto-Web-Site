namespace Dave_Corleto_Web_Site.Models
{
    public class Live
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }

        //Costruttore vuoto 

        public Live () { }

        public Live (int id, int band_id, string location, DateTime date)
        {
            Id = id;
            BandId = band_id;
            Location = location;
            Date = date;
        }
    }
}
