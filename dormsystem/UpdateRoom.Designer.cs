namespace dormsystem
{
    partial class UpdateRoom
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
            this.tbupdateroom = new System.Windows.Forms.TextBox();
            this.cbupdatestate = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "状态";
            // 
            // tbupdateroom
            // 
            this.tbupdateroom.Location = new System.Drawing.Point(197, 71);
            this.tbupdateroom.Name = "tbupdateroom";
            this.tbupdateroom.Size = new System.Drawing.Size(166, 25);
            this.tbupdateroom.TabIndex = 1;
            // 
            // cbupdatestate
            // 
            this.cbupdatestate.FormattingEnabled = true;
            this.cbupdatestate.Items.AddRange(new object[] {
            "正常",
            "维修"});
            this.cbupdatestate.Location = new System.Drawing.Point(197, 118);
            this.cbupdatestate.Name = "cbupdatestate";
            this.cbupdatestate.Size = new System.Drawing.Size(166, 23);
            this.cbupdatestate.TabIndex = 2;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(127, 184);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(288, 184);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 345);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cbupdatestate);
            this.Controls.Add(this.tbupdateroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateRoom";
            this.Text = "UpdateRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.TextBox tbupdateroom;
        public System.Windows.Forms.ComboBox cbupdatestate;
    }
}