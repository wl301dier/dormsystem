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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

       

        private void btnadd_Click(object sender, EventArgs e)
        {
            int count = 0;
            string sql;
            string username = tbusername.Text.Trim();
            string password = tbpassword.Text.Trim();
            string reset = tbreset.Text.Trim();
            string state = cbstate.Text.Trim();
            if(password != reset)
            {
                MessageBox.Show("密码不一致，请重新输入密码");
                return;
            }

            sql = string.Format("select count(*) from userinfo where username = '{0}' ", username);
            count = DB.ExecuteScalar(sql);
            //判断
            if (count > 0)//如果结果>0，则认为用户已存在
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("用户已存在!");
                return;
            }

            sql = string.Format("insert into userinfo values('{0}','{1}','{2}')", 
                username, password, state);
                int res = DB.ExecuteSQL(sql);
                if (res != -1)
                {
                    MessageBox.Show("添加用户成功！");
                    this.DialogResult = DialogResult.Cancel;
                }
                else 
                {
                    MessageBox.Show("添加用户失败");
                }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
