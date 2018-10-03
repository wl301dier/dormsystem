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

        private void showRoom()
        {
            int id = 0;
            string sql = "select * from roominfo";
            SqlConnection conn = DB.CreateConnection();//创建连接
            SqlDataReader dr = DB.GetDataReader(sql, conn);//查询并获取结果
            this.mainList.Columns.Add("ID");
            this.mainList.Columns.Add("房间号");
            this.mainList.Columns.Add("房间状态");
            this.mainList.Items.Clear();
            while (dr.Read()) 
            {
                id++;
                string roomno = dr["roomno"].ToString();//读房间号
                string roomstate = dr["roomstate"].ToString();//读房间状态
                //添加到ListView中
                ListViewItem lvi = new ListViewItem(id.ToString());
                lvi.SubItems.Add(roomno);
                lvi.SubItems.Add(roomstate);
                this.mainList.Items.Add(lvi);
            }
            dr.Close();
            DB.DestoryConnection(conn);//销毁这个连接
        }

        private void tsmiuserlist_Click(object sender, EventArgs e)
        {
            this.showUser();
        } 
        
        private void tsmiroomlist_Click(object sender, EventArgs e)
        {
            this.showRoom();
        }

        private void tsbtnuserlist_Click(object sender, EventArgs e)
        {
            this.showUser();
        }
        
        private void tsbtnroomlist_Click(object sender, EventArgs e)
        {
            this.showRoom();
        }

        private void tsmiadduser_Click(object sender, EventArgs e)
        {
            //打开添加用户窗体
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
            this.showUser();
        }
        
        private void tsmiaddroom_Click(object sender, EventArgs e)
        {
            //打开添加房间窗体
            AddRoom addroom = new AddRoom();
            addroom.ShowDialog();
            this.showRoom();
        }

        private void tsbtnadduser_Click(object sender, EventArgs e)
        {
            //打开添加用户窗体
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
            this.showUser();
        }  
        
        private void tsbtnaddroom_Click(object sender, EventArgs e)
        {
            //打开添加房间窗体
            AddRoom addroom = new AddRoom();
            addroom.ShowDialog();
            this.showRoom();
        }

        private void tsmidropuser_Click(object sender, EventArgs e)
        {

            if (mainList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选中要删除的用户！");
                return;
            }

            string username = mainList.SelectedItems[0].SubItems[1].Text.Trim();
            string msg = "确定要删除 '" + username + "' 吗？";
            if((int)MessageBox.Show(msg,"删除确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)!=1)
            {
               
                return;
            } 
            string sql = string.Format("delete from userinfo where username = '{0}'", username
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
            this.showUser();
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
            this.showUser();
        }

        private void tsmideleteroom_Click(object sender, EventArgs e)
        {
            if (mainList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选中要删除的房间！");
                return;
            }

            string roomno = mainList.SelectedItems[0].SubItems[1].Text.Trim();
            string msg = "确定要删除 '" + roomno + "' 吗？";
            if ((int)MessageBox.Show(msg, "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
            {

                return;
            }
            string sql = string.Format("delete from roominfo where roomno = '{0}'", roomno
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
            this.showRoom();
        }

        private void tsmiupdateroom_Click(object sender, EventArgs e)
        {
            if (mainList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选中要更新的房间！");
                return;
            }
            else 
            {
                string roomno = mainList.SelectedItems[0].SubItems[1].Text;
                string roomstate = mainList.SelectedItems[0].SubItems[2].Text;
                UpdateRoom updateroom = new UpdateRoom();
                updateroom.tbupdateroom.Text = roomno;
                updateroom.cbupdatestate.Text = roomstate;
                updateroom.ShowDialog();
                this.showRoom();
            }
        }

        

       

        

       


       


       
    }
}
