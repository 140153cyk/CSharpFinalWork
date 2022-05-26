
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PoemDataService.Models
{
   public class PoemContext:DbContext
    {
        public PoemContext(DbContextOptions<PoemContext> options)
            : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表

        }
        public DbSet<Poem> Poems { get; set; }//所有诗词
        public DbSet<Paragraph> Paragraphs { get; set; }//诗词的所有诗句

        public DbSet<UserInfo> UserInfos { get; set; }//用户账号，密码

        public DbSet<Collect> Collects { get; set; }//用户收藏诗词

        public DbSet<Finished> Finisheds { get; set; }//用户读过的诗词

        public DbSet<Recommend> Recommends { get; set; }//向用户推荐的诗词

     
    }
}
