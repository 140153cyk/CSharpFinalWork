using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
   public class PoemContext:DbContext
    {
        public PoemContext() : base("PoemBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PoemContext>());
        }
        public DbSet<Poem> Poems { get; set; }//所有诗词
        public DbSet<Paragraph> Paragraphs { get; set; }//诗词的所有诗句

        public DbSet<UserInfo> UserInfos { get; set; }//用户账号，密码，登录时间

        public DbSet<Collect> Collects { get; set; }//用户收藏诗词

        public DbSet<Finished> Finisheds { get; set; }//用户读过的诗词

        public DbSet<Recommend> Recommends { get; set; }
    }
}
