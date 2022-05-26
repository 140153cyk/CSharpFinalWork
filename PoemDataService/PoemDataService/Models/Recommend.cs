namespace PoemDataService.Models
{
    public class Recommend
    {
        public int id { get; set; }
        public string account { get; set; }
        public int PoemId { get; set; }

        public Poem poem { get; set; }
    }
}
