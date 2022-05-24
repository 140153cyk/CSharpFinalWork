using ImportData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic
{
    public partial class MainPage : Form
    {
        private string account;
        private Poem recommend;
        public MainPage( string account)
        {
            this.account = account;
            GetRecommend();
            InitializeComponent();
            GetStyles();
        }
        public void GetStyles()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.WindowState = FormWindowState.Maximized;
            AbilityPanel.FillColor = Color.FromArgb(100, 255, 255, 255);
            RecPanel.FillColor= Color.FromArgb(100, 255, 255, 255);
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {
            PoemSquare square = new PoemSquare(account, this);
            this.Visible = false;
            square.Show();
        }

        private void GetRecommend()
        {
            
            using(var db=new PoemContext())
            {
                UserInfo info = db.UserInfos.FirstOrDefault(userinfo => userinfo.account == account);
                if (info.lastLoginMonth == DateTime.Now.Month && info.lastLoginDate == DateTime.Now.Day) return;
                info.lastLoginMonth = DateTime.Now.Month;
                info.lastLoginDate = DateTime.Now.Day;
                db.SaveChanges();
                
                Dictionary<string, double> Commons = new Dictionary<string, double>();
                foreach(var collect in db.Collects.Where(c => c.account == account))
                {
                    foreach(var neighborCollect in db.Collects.Where(nc => nc.PoemId == collect.PoemId))
                    {
                        int neiCollectNum = db.Collects.Where(ncn => ncn.account == neighborCollect.account).Count();
                        if (Commons.TryGetValue(neighborCollect.account, out double pre))
                        {
                            Commons.Add(neighborCollect.account, pre + 1/neiCollectNum);
                        }
                        else Commons.Add(neighborCollect.account, 1/neiCollectNum);
                    }
                }

                List<string> neibors = Commons.Keys.OrderBy(n => Commons[n]).ToList();
                int i = 0;
                while (recommend == null&&i<neibors.Count)
                {
                    recommend = db.Poems.Where(poem =>
                    db.finisheds.FirstOrDefault(finish => finish.PoemId == poem.id) != null)
                        .FirstOrDefault(poem=> 
                            db.Collects.FirstOrDefault(collect => collect.account == neibors[i] && collect.PoemId == poem.id)!=null
                        );
                }
                if (recommend == null)
                {
                    recommend = db.Poems.Where(poem =>
                    db.finisheds.FirstOrDefault(finish => finish.PoemId == poem.id) != null)
                        .FirstOrDefault();
                }
                
            }
            
        }
    }
}
