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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int count = 0;
            string roomno = tbroomno.Text.Trim();
            string roomstate = cbroomstate.Text.Trim();
            string sql = string.Format( "insert into roominfo(roomno,roomstate) values('{0}','{1}')",roomno,roomstate);
            string sqlb = string.Format("select count(*) from roominfo where roomno='{0}'", roomno);
            count = DB.ExecuteScalar(sqlb);
            //判断
            if (count > 0)//如果结果>0，则认为房间已存在
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("房间已存在!");
                return;
            }
            
            int res = DB.ExecuteSQL(sql);
            if (res != -1)
            {
                MessageBox.Show("添加房间成功！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                MessageBox.Show("添加房间失败");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
