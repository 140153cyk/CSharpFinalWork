namespace PoemDataService.Models
{
    public class Recommend
    {
        public Recommend()
        {
        }

        public int id { get; set; }
        public string account { get; set; }
        public int PoemId { get; set; }

        public Recommend(string account, int poemId)
        {
            this.account = account;
            PoemId = poemId;
        }
    }
}
