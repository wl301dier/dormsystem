using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dormsystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //先显示登录窗口，登录成功后在显示主窗体
            Login frmLogin = new Login();
            //以模态对话框的形式打开登录窗体
            if (frmLogin.ShowDialog() == DialogResult.OK)//判断登录窗体是否返回OK
            {
                //启动主窗体
                Application.Run(new main());
            }
            
        }
    }
}
