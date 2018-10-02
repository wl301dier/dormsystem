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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btndrop_Click(object sender, EventArgs e)
        {
            string username = txtbusername.Text;
            string sql = string.Format("delete from userinfo where username = '{0}'",username
                );
            int res = DB.ExecuteSQL(sql);
            if (res != -1)
            {
                MessageBox.Show("删除用户成功！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                MessageBox.Show("删除用户失败");
            }
        }



       
    }
}
