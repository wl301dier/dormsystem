namespace dormsystem
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.msmain = new System.Windows.Forms.MenuStrip();
            this.tsmiuser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiadduser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiuserlist = new System.Windows.Forms.ToolStripMenuItem();
            this.房间管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiaddroom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiroomlist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmistudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiaddstudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmistudentlist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiwindow = new System.Windows.Forms.ToolStripMenuItem();
            this.adduser = new System.Windows.Forms.ToolStripMenuItem();
            this.userlist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiexit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiabout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnadduser = new System.Windows.Forms.ToolStripButton();
            this.tsbtnuserlist = new System.Windows.Forms.ToolStripButton();
            this.tsbtnaddroom = new System.Windows.Forms.ToolStripButton();
            this.tsbtnroomlist = new System.Windows.Forms.ToolStripButton();
            this.tsbtnaddstudent = new System.Windows.Forms.ToolStripButton();
            this.tsbtnstudentlist = new System.Windows.Forms.ToolStripButton();
            this.tsbtnexit = new System.Windows.Forms.ToolStripButton();
            this.mainList = new System.Windows.Forms.ListView();
            this.tsmidropuser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiupdateuser = new System.Windows.Forms.ToolStripMenuItem();
            this.msmain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmain
            // 
            this.msmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiuser,
            this.房间管理ToolStripMenuItem,
            this.tsmistudent,
            this.tsmiwindow,
            this.tsmisystem});
            this.msmain.Location = new System.Drawing.Point(0, 0);
            this.msmain.MdiWindowListItem = this.tsmiwindow;
            this.msmain.Name = "msmain";
            this.msmain.Size = new System.Drawing.Size(666, 28);
            this.msmain.TabIndex = 0;
            this.msmain.Text = "menuStrip1";
            // 
            // tsmiuser
            // 
            this.tsmiuser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiadduser,
            this.tsmiuserlist,
            this.tsmidropuser,
            this.tsmiupdateuser});
            this.tsmiuser.Name = "tsmiuser";
            this.tsmiuser.Size = new System.Drawing.Size(81, 24);
            this.tsmiuser.Text = "用户管理";
            // 
            // tsmiadduser
            // 
            this.tsmiadduser.Name = "tsmiadduser";
            this.tsmiadduser.Size = new System.Drawing.Size(168, 24);
            this.tsmiadduser.Text = "添加系统用户";
            this.tsmiadduser.Click += new System.EventHandler(this.tsmiadduser_Click);
            // 
            // tsmiuserlist
            // 
            this.tsmiuserlist.Name = "tsmiuserlist";
            this.tsmiuserlist.Size = new System.Drawing.Size(168, 24);
            this.tsmiuserlist.Text = "用户信息列表";
            this.tsmiuserlist.Click += new System.EventHandler(this.tsmiuserlist_Click);
            // 
            // 房间管理ToolStripMenuItem
            // 
            this.房间管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiaddroom,
            this.tsmiroomlist});
            this.房间管理ToolStripMenuItem.Name = "房间管理ToolStripMenuItem";
            this.房间管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.房间管理ToolStripMenuItem.Text = "房间管理";
            // 
            // tsmiaddroom
            // 
            this.tsmiaddroom.Name = "tsmiaddroom";
            this.tsmiaddroom.Size = new System.Drawing.Size(168, 24);
            this.tsmiaddroom.Text = "添加新房间";
            // 
            // tsmiroomlist
            // 
            this.tsmiroomlist.Name = "tsmiroomlist";
            this.tsmiroomlist.Size = new System.Drawing.Size(168, 24);
            this.tsmiroomlist.Text = "房间信息列表";
            // 
            // tsmistudent
            // 
            this.tsmistudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiaddstudent,
            this.tsmistudentlist});
            this.tsmistudent.Name = "tsmistudent";
            this.tsmistudent.Size = new System.Drawing.Size(111, 24);
            this.tsmistudent.Text = "住宿学生管理";
            // 
            // tsmiaddstudent
            // 
            this.tsmiaddstudent.Name = "tsmiaddstudent";
            this.tsmiaddstudent.Size = new System.Drawing.Size(168, 24);
            this.tsmiaddstudent.Text = "添加住宿学生";
            // 
            // tsmistudentlist
            // 
            this.tsmistudentlist.Name = "tsmistudentlist";
            this.tsmistudentlist.Size = new System.Drawing.Size(168, 24);
            this.tsmistudentlist.Text = "住宿学生列表";
            // 
            // tsmiwindow
            // 
            this.tsmiwindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adduser,
            this.userlist});
            this.tsmiwindow.Name = "tsmiwindow";
            this.tsmiwindow.Size = new System.Drawing.Size(51, 24);
            this.tsmiwindow.Text = "窗口";
            // 
            // adduser
            // 
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(138, 24);
            this.adduser.Text = "添加用户";
            // 
            // userlist
            // 
            this.userlist.Name = "userlist";
            this.userlist.Size = new System.Drawing.Size(138, 24);
            this.userlist.Text = "用户列表";
            // 
            // tsmisystem
            // 
            this.tsmisystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiexit,
            this.tsmiabout});
            this.tsmisystem.Name = "tsmisystem";
            this.tsmisystem.Size = new System.Drawing.Size(51, 24);
            this.tsmisystem.Text = "系统";
            // 
            // tsmiexit
            // 
            this.tsmiexit.Name = "tsmiexit";
            this.tsmiexit.Size = new System.Drawing.Size(138, 24);
            this.tsmiexit.Text = "退出系统";
            this.tsmiexit.Click += new System.EventHandler(this.tsmiexit_Click);
            // 
            // tsmiabout
            // 
            this.tsmiabout.Name = "tsmiabout";
            this.tsmiabout.Size = new System.Drawing.Size(138, 24);
            this.tsmiabout.Text = "关于";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnadduser,
            this.tsbtnuserlist,
            this.tsbtnaddroom,
            this.tsbtnroomlist,
            this.tsbtnaddstudent,
            this.tsbtnstudentlist,
            this.tsbtnexit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(666, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnadduser
            // 
            this.tsbtnadduser.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnadduser.Image")));
            this.tsbtnadduser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnadduser.Name = "tsbtnadduser";
            this.tsbtnadduser.Size = new System.Drawing.Size(119, 24);
            this.tsbtnadduser.Text = "添加系统用户";
            this.tsbtnadduser.Click += new System.EventHandler(this.tsbtnadduser_Click);
            // 
            // tsbtnuserlist
            // 
            this.tsbtnuserlist.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnuserlist.Image")));
            this.tsbtnuserlist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnuserlist.Name = "tsbtnuserlist";
            this.tsbtnuserlist.Size = new System.Drawing.Size(89, 24);
            this.tsbtnuserlist.Text = "用户列表";
            this.tsbtnuserlist.Click += new System.EventHandler(this.tsbtnuserlist_Click);
            // 
            // tsbtnaddroom
            // 
            this.tsbtnaddroom.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnaddroom.Image")));
            this.tsbtnaddroom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnaddroom.Name = "tsbtnaddroom";
            this.tsbtnaddroom.Size = new System.Drawing.Size(89, 24);
            this.tsbtnaddroom.Text = "添加房间";
            // 
            // tsbtnroomlist
            // 
            this.tsbtnroomlist.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnroomlist.Image")));
            this.tsbtnroomlist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnroomlist.Name = "tsbtnroomlist";
            this.tsbtnroomlist.Size = new System.Drawing.Size(89, 24);
            this.tsbtnroomlist.Text = "房间列表";
            // 
            // tsbtnaddstudent
            // 
            this.tsbtnaddstudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnaddstudent.Image")));
            this.tsbtnaddstudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnaddstudent.Name = "tsbtnaddstudent";
            this.tsbtnaddstudent.Size = new System.Drawing.Size(89, 24);
            this.tsbtnaddstudent.Text = "添加学生";
            // 
            // tsbtnstudentlist
            // 
            this.tsbtnstudentlist.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnstudentlist.Image")));
            this.tsbtnstudentlist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnstudentlist.Name = "tsbtnstudentlist";
            this.tsbtnstudentlist.Size = new System.Drawing.Size(89, 24);
            this.tsbtnstudentlist.Text = "学生列表";
            // 
            // tsbtnexit
            // 
            this.tsbtnexit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnexit.Image")));
            this.tsbtnexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnexit.Name = "tsbtnexit";
            this.tsbtnexit.Size = new System.Drawing.Size(89, 24);
            this.tsbtnexit.Text = "退出系统";
            // 
            // mainList
            // 
            this.mainList.FullRowSelect = true;
            this.mainList.Location = new System.Drawing.Point(0, 58);
            this.mainList.Name = "mainList";
            this.mainList.Size = new System.Drawing.Size(666, 305);
            this.mainList.TabIndex = 4;
            this.mainList.UseCompatibleStateImageBehavior = false;
            this.mainList.View = System.Windows.Forms.View.Details;
            // 
            // tsmidropuser
            // 
            this.tsmidropuser.Name = "tsmidropuser";
            this.tsmidropuser.Size = new System.Drawing.Size(168, 24);
            this.tsmidropuser.Text = "删除系统用户";
            this.tsmidropuser.Click += new System.EventHandler(this.tsmidropuser_Click);
            // 
            // tsmiupdateuser
            // 
            this.tsmiupdateuser.Name = "tsmiupdateuser";
            this.tsmiupdateuser.Size = new System.Drawing.Size(168, 24);
            this.tsmiupdateuser.Text = "修改系统用户";
            this.tsmiupdateuser.Click += new System.EventHandler(this.tsmiupdateuser_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 375);
            this.Controls.Add(this.mainList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msmain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msmain;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宿舍管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.msmain.ResumeLayout(false);
            this.msmain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msmain;
        private System.Windows.Forms.ToolStripMenuItem tsmiuser;
        private System.Windows.Forms.ToolStripMenuItem tsmiadduser;
        private System.Windows.Forms.ToolStripMenuItem tsmiuserlist;
        private System.Windows.Forms.ToolStripMenuItem 房间管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiaddroom;
        private System.Windows.Forms.ToolStripMenuItem tsmiroomlist;
        private System.Windows.Forms.ToolStripMenuItem tsmistudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiaddstudent;
        private System.Windows.Forms.ToolStripMenuItem tsmistudentlist;
        private System.Windows.Forms.ToolStripMenuItem tsmiwindow;
        private System.Windows.Forms.ToolStripMenuItem tsmisystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiexit;
        private System.Windows.Forms.ToolStripMenuItem tsmiabout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnadduser;
        private System.Windows.Forms.ToolStripButton tsbtnuserlist;
        private System.Windows.Forms.ToolStripButton tsbtnaddroom;
        private System.Windows.Forms.ToolStripButton tsbtnroomlist;
        private System.Windows.Forms.ToolStripButton tsbtnaddstudent;
        private System.Windows.Forms.ToolStripButton tsbtnstudentlist;
        private System.Windows.Forms.ToolStripButton tsbtnexit;
        private System.Windows.Forms.ToolStripMenuItem adduser;
        private System.Windows.Forms.ToolStripMenuItem userlist;
        private System.Windows.Forms.ListView mainList;
        private System.Windows.Forms.ToolStripMenuItem tsmidropuser;
        private System.Windows.Forms.ToolStripMenuItem tsmiupdateuser;
    }
}

