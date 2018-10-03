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
    public partial class UpdateRoom : Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string roomno = tbupdateroom.Text.Trim();
            string roomstate = cbupdatestate.Text.Trim();
            string sql = string.Format("update roominfo set roomstate = '{0}'where roomno = '{1}'",
                                        roomstate,roomno);
            int res = DB.ExecuteSQL(sql);
            if (res != -1)
            {
                MessageBox.Show("修改房间成功！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                MessageBox.Show("修改房间失败");
            }
        }

    }
}
