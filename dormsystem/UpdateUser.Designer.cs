namespace dormsystem
{
    partial class UpdateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbusername = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbresetpassword = new System.Windows.Forms.Label();
            this.lbstate = new System.Windows.Forms.Label();
            this.txtbusername = new System.Windows.Forms.TextBox();
            this.txtbpassword = new System.Windows.Forms.TextBox();
            this.txtbreset = new System.Windows.Forms.TextBox();
            this.cbstate = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(32, 55);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(52, 15);
            this.lbusername.TabIndex = 0;
            this.lbusername.Text = "用户名";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(35, 108);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(37, 15);
            this.lbpassword.TabIndex = 1;
            this.lbpassword.Text = "密码";
            // 
            // lbresetpassword
            // 
            this.lbresetpassword.AutoSize = true;
            this.lbresetpassword.Location = new System.Drawing.Point(35, 156);
            this.lbresetpassword.Name = "lbresetpassword";
            this.lbresetpassword.Size = new System.Drawing.Size(67, 15);
            this.lbresetpassword.TabIndex = 2;
            this.lbresetpassword.Text = "确认密码";
            // 
            // lbstate
            // 
            this.lbstate.AutoSize = true;
            this.lbstate.Location = new System.Drawing.Point(35, 206);
            this.lbstate.Name = "lbstate";
            this.lbstate.Size = new System.Drawing.Size(37, 15);
            this.lbstate.TabIndex = 3;
            this.lbstate.Text = "状态";
            // 
            // txtbusername
            // 
            this.txtbusername.Location = new System.Drawing.Point(174, 55);
            this.txtbusername.Name = "txtbusername";
            this.txtbusername.ReadOnly = true;
            this.txtbusername.Size = new System.Drawing.Size(121, 25);
            this.txtbusername.TabIndex = 4;
            // 
            // txtbpassword
            // 
            this.txtbpassword.Location = new System.Drawing.Point(174, 98);
            this.txtbpassword.Name = "txtbpassword";
            this.txtbpassword.Size = new System.Drawing.Size(121, 25);
            this.txtbpassword.TabIndex = 4;
            // 
            // txtbreset
            // 
            this.txtbreset.Location = new System.Drawing.Point(174, 153);
            this.txtbreset.Name = "txtbreset";
            this.txtbreset.Size = new System.Drawing.Size(121, 25);
            this.txtbreset.TabIndex = 4;
            // 
            // cbstate
            // 
            this.cbstate.FormattingEnabled = true;
            this.cbstate.Items.AddRange(new object[] {
            "正常",
            "维护"});
            this.cbstate.Location = new System.Drawing.Point(174, 197);
            this.cbstate.Name = "cbstate";
            this.cbstate.Size = new System.Drawing.Size(121, 23);
            this.cbstate.TabIndex = 5;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(99, 261);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(220, 261);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 326);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cbstate);
            this.Controls.Add(this.txtbreset);
            this.Controls.Add(this.txtbpassword);
            this.Controls.Add(this.txtbusername);
            this.Controls.Add(this.lbstate);
            this.Controls.Add(this.lbresetpassword);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbusername);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbresetpassword;
        private System.Windows.Forms.Label lbstate;
        private System.Windows.Forms.TextBox txtbreset;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.TextBox txtbusername;
        public System.Windows.Forms.TextBox txtbpassword;
        public System.Windows.Forms.ComboBox cbstate;
    }
}