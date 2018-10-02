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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void tsmiexit_Click(object sender, EventArgs e)
        {
            this.Close();//使用菜单退出系统
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //退出系统时，显示询问对话框
            if (MessageBox.Show("您是否要退出系统?", "退出系统", MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }
        private void showUser() 
        {
            int id = 0;
            string sql = "select * from userinfo";
            SqlConnection conn = DB.CreateConnection();//创建连接
            SqlDataReader dr = DB.GetDataReader(sql, conn);//查询并获取结果

            //遍历dr对象，将所有的数据添加到ListView控件中，首先设置表头
            this.mainList.Columns.Add("ID");
            this.mainList.Columns.Add("用户名");
            this.mainList.Columns.Add("密码");
            this.mainList.Columns.Add("状态");
            this.mainList.Items.Clear();
            while (dr.Read())
            {
                id++;
                string username = dr["username"].ToString();//读用户名
                string password = dr["password"].ToString();//读密码
                string state = dr["userstate"].ToString();//读用户状态
                //添加到ListView中
                ListViewItem lvi = new ListViewItem(id.ToString());
                lvi.SubItems.Add(username);
                lvi.SubItems.Add(password);
                lvi.SubItems.Add(state);
                this.mainList.Items.Add(lvi);
            }
            dr.Close();
            DB.DestoryConnection(conn);//销毁这个连接
        }
        private void tsmiuserlist_Click(object sender, EventArgs e)
        {
            this.showUser();
        }

        private void tsbtnuserlist_Click(object sender, EventArgs e)
        {
            this.showUser();
        }

        private void tsmiadduser_Click(object sender, EventArgs e)
        {
            //打开添加用户窗体
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
        }

        private void tsbtnadduser_Click(object sender, EventArgs e)
        {
            //打开添加用户窗体
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
        }

        private void tsmidropuser_Click(object sender, EventArgs e)
        {
            //打开添加用户窗体
            DeleteUser dropuser = new DeleteUser();
            dropuser.ShowDialog();
        }

        private void tsmiupdateuser_Click(object sender, EventArgs e)
        {
            if (mainList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选中要更新的用户！");
                return;
            }
            else 
            {
                string username = mainList.SelectedItems[0].SubItems[1].Text;
                string password = mainList.SelectedItems[0].SubItems[2].Text;
                string state = mainList.SelectedItems[0].SubItems[3].Text;
                UpdateUser updateuser = new UpdateUser();
                updateuser.txtbusername.Text = username;
                updateuser.txtbpassword.Text = password;
                updateuser.cbstate.Text = state;
                updateuser.ShowDialog();
            }
            
        }

       
    }
}
