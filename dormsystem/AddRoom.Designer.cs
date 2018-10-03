namespace dormsystem
{
    partial class AddRoom
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
            this.roomno = new System.Windows.Forms.Label();
            this.tbroomno = new System.Windows.Forms.TextBox();
            this.roomstate = new System.Windows.Forms.Label();
            this.cbroomstate = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomno
            // 
            this.roomno.AutoSize = true;
            this.roomno.Location = new System.Drawing.Point(115, 96);
            this.roomno.Name = "roomno";
            this.roomno.Size = new System.Drawing.Size(52, 15);
            this.roomno.TabIndex = 0;
            this.roomno.Text = "房间号";
            // 
            // tbroomno
            // 
            this.tbroomno.Location = new System.Drawing.Point(248, 86);
            this.tbroomno.Name = "tbroomno";
            this.tbroomno.Size = new System.Drawing.Size(149, 25);
            this.tbroomno.TabIndex = 1;
            // 
            // roomstate
            // 
            this.roomstate.AutoSize = true;
            this.roomstate.Location = new System.Drawing.Point(112, 136);
            this.roomstate.Name = "roomstate";
            this.roomstate.Size = new System.Drawing.Size(67, 15);
            this.roomstate.TabIndex = 2;
            this.roomstate.Text = "房间状态";
            // 
            // cbroomstate
            // 
            this.cbroomstate.FormattingEnabled = true;
            this.cbroomstate.Items.AddRange(new object[] {
            "正常",
            "维修"});
            this.cbroomstate.Location = new System.Drawing.Point(248, 128);
            this.cbroomstate.Name = "cbroomstate";
            this.cbroomstate.Size = new System.Drawing.Size(149, 23);
            this.cbroomstate.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(171, 230);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(322, 230);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 314);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbroomstate);
            this.Controls.Add(this.roomstate);
            this.Controls.Add(this.tbroomno);
            this.Controls.Add(this.roomno);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomno;
        private System.Windows.Forms.TextBox tbroomno;
        private System.Windows.Forms.Label roomstate;
        private System.Windows.Forms.ComboBox cbroomstate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
    }
}