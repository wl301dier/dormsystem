namespace dormsystem
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbreset = new System.Windows.Forms.TextBox();
            this.cbstate = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "状态";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(183, 44);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(136, 25);
            this.tbusername.TabIndex = 4;
            this.tbusername.Text = "输入用户名";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(183, 105);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(136, 25);
            this.tbpassword.TabIndex = 5;
            this.tbpassword.Text = "输入密码";
            // 
            // tbreset
            // 
            this.tbreset.Location = new System.Drawing.Point(183, 167);
            this.tbreset.Name = "tbreset";
            this.tbreset.Size = new System.Drawing.Size(136, 25);
            this.tbreset.TabIndex = 6;
            this.tbreset.Text = "重新输入密码";
            // 
            // cbstate
            // 
            this.cbstate.FormattingEnabled = true;
            this.cbstate.Items.AddRange(new object[] {
            "正常",
            "维护"});
            this.cbstate.Location = new System.Drawing.Point(183, 225);
            this.cbstate.Name = "cbstate";
            this.cbstate.Size = new System.Drawing.Size(136, 23);
            this.cbstate.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(110, 279);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(244, 279);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 333);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbstate);
            this.Controls.Add(this.tbreset);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "添加用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbreset;
        private System.Windows.Forms.ComboBox cbstate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
    }
}