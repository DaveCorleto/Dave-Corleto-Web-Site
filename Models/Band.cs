using System.Reflection.Metadata;

namespace Dave_Corleto_Web_Site.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Components { get; set; }
        public string Biography { get; set; }
        public string Instagram { get; set; }
        public string TikTok { get; set; }
        public string YouTube { get; set; }
        public string SoundCloud { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<byte[]> Images { get; set; }

        public Band()
        {
            Components = new List<string>();
            Images = new List<byte[]>();
        }

        public Band(string name, List<string> components, string biography, string instagram = null, string tiktok = null, string youtube = null, string soundcloud = null, string phone = null, string email = null, List<byte[]> images = null)
        {
            Name = name;
            Components = components ?? new List<string>();
            Biography = biography;
            Instagram = instagram;
            TikTok = tiktok;
            YouTube = youtube;
            SoundCloud = soundcloud;
            Phone = phone;
            Email = email;
            Images = images ?? new List<byte[]>();
        }
    }
}
