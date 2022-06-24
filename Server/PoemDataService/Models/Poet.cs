namespace PoemDataService.Models
{
    public class Poet
    {
        public Poet()
        {
        }

        public int id { get; set; }

        public string name { get; set; }
        public string introduction { get; set; }
        public string IMGPath { get; set; }//百度百科第一张图片的路径
        


    }
}

