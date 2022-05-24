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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (judgeLogin())
            {
                MainPage main = new MainPage(AccountText.Text);
                main.Show();
                this.Visible=false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误!", "登录失败", MessageBoxButtons.OK);
            }
        }

        private bool judgeLogin()
        {
            String account = AccountText.Text;
            String password = PasswordText.Text;
            using (var db = new PoemContext())
            {
                foreach (var info in db.UserInfos)
                {
                    if (info.account == account && info.password == password) return true;
                }
            }
            return false;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            RegisterPage register = new RegisterPage();
            register.Show();
        }
    }
}
