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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string name = tbname.Text.Trim();
            string sex = cbsex.Text.Trim();
            string age = tbage.Text.Trim();
            string classname = cbclassname.Text.Trim();
            int roomid = (int)cbroomid.SelectedValue;
            string sno = tbsno.Text.Trim();
            string phone = tbphone.Text.Trim();
            string address = tbaddr.Text.Trim();
            string sql = string.Format("update studentinfo set address = '{0}', phone = '{1}', sno = '{2}', roomid = '{3}', classname = '{4}', age = '{5}', sex = '{6}'where name = '{7}'",
                                        address, phone, sno, roomid, classname, age, sex, name);
            int result = -1;
            //连接dormitory数据库
            SqlConnection conn = new SqlConnection();//建立连接对象
            conn.ConnectionString = "data source =.;user id = sa; password = 123456; initial catalog = dormitory";//连接字符串
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败！");
            }

            SqlCommand cmd = new SqlCommand(sql, conn);//建立命令对象
            try
            {
                result = (int)cmd.ExecuteNonQuery();//执行SQL语句
            }
            catch (Exception ex)
            {
                result = -1;
                MessageBox.Show("更新异常！");
                conn.Close();
                return;
            }
            conn.Close();

            if (result > 0)
            {
                MessageBox.Show("修改学生信息成功！");
                this.DialogResult = DialogResult.Cancel;
            }
            else 
            {
                MessageBox.Show("修改学生信息失败！");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

     }
}
