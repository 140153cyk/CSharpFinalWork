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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string account = AccountText.Text;
            string password = PasswordText.Text;
            string confirm = ConfrimPas.Text;
            if (password != confirm)
            {
                MessageBox.Show("两次输入密码不同", "注册失败", MessageBoxButtons.OK);
                return;
            }
            using(var db=new PoemContext())
            {

                if (db.UserInfos.Where(info => info.account == account).FirstOrDefault() != null)
                {
                    MessageBox.Show("已存在相同账号", "注册失败", MessageBoxButtons.OK);
                    return;
                }
                db.UserInfos.Add(new UserInfo(account, password));
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
