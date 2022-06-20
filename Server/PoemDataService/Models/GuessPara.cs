using System.ComponentModel.DataAnnotations;

namespace PoemDataService.Models
{
    public class GuessPara
    {
        public GuessPara()
        {
        }

        [Key]
        public int id { get; set; }
        public int paraId { get; set; }

        public int paraNum { get; set; }



        public GuessPara(int id,int num)
        {
            this.paraId = id;
            this.paraNum = num;
        }
    }
}