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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int res = 0;
            string sql;
            string name = tbstdname.Text.Trim();
            string sex = cbstdsex.Text.Trim();
            string age = tbstdage.Text.Trim();
            string classname = cbstdclassname.Text.Trim();
            int roomid = (int)cbstdroomid.SelectedValue;
            string sno = tbstdphone.Text.Trim();
            string phone = tbstdphone.Text.Trim();
            string address = tbstdaddress.Text.Trim();
            
            //创建连接，并打开连接
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =.;user id = sa; password = 123456; initial catalog = dormitory";//连接字符串
            conn.Open();
            
            //检查学生名字是否已存在
            sql = string.Format("select count(*) from studentinfo where name='{0}'", name);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            try
            {
                res = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                conn.Close();
                return;
            }
            if (res > 0)
            {
                MessageBox.Show("学生 '" +  name + "' 已存在！");
                conn.Close();
                return;
            }
            
            //检查房间号是否已存在
            sql = string.Format("select count(*) from roominfo where roomid='{0}'", roomid);
            cmd.CommandText = sql;
            try
            {
                res = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                conn.Close();
                return;
            }
            if (res == 0)
            {
                MessageBox.Show("房间号 '" + roomid + "' 不存在");
                conn.Close();
                return;
            }

            //添加学生信息
            sql = string.Format("insert into studentinfo(name,sex,age,classname,roomid,sno,phone,address) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", name, sex, age, classname, roomid, sno, phone, address);
            cmd.CommandText = sql;
            try
            {
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                conn.Close();
                return;
            }
            conn.Close();
            if (res > 0)
            {
                MessageBox.Show("添加学生信息成功！");
                this.DialogResult = DialogResult.Cancel;
            }
            else 
            {
                MessageBox.Show("添加学生信息失败！");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
