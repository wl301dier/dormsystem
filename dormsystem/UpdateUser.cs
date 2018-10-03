using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dormsystem
{
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string username = txtbusername.Text.Trim();
            string password = txtbpassword.Text.Trim();
            string reset = txtbreset.Text.Trim();
            string state = cbstate.Text;
            if (password != reset)
            {
                MessageBox.Show("密码不一致，请重新输入密码");
                return;
            }
            string sql = string.Format("update userinfo set password = '{0}', userstate = '{1}'where username = '{2}'",
                                        password, state, username);
            int res = DB.ExecuteSQL(sql);
            if (res != -1)
            {
                MessageBox.Show("修改用户成功！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                MessageBox.Show("修改用户失败");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
