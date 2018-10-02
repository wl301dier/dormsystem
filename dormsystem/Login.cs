using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dormsystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            int count = 0;
            string username = txtusername.Text;//用户名
            string password = txtpassword.Text;//密码

            //从userinfo表中,验证用户名和密码信息是否正确
            string sql = string.Format("select count(*) from userinfo " + 
                "where username = '{0}' and password = '{1}'" , 
                username, password) ;
            count = DB.ExecuteScalar(sql);

            //判断
            if (count > 0)//如果结果>0，则认为用户名和密码正确
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("登录成功，欢迎访问宿舍管理系统\n\tDevelop by 王亮");
            }
            else //登录错误
            {
                MessageBox.Show("用户名或密码输入错误！");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //取消登录，退出系统
            this.DialogResult = DialogResult.Cancel;
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
