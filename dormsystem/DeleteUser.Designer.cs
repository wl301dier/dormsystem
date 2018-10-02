namespace dormsystem
{
    partial class DeleteUser
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
            this.txtbusername = new System.Windows.Forms.TextBox();
            this.btndrop = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(94, 68);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(52, 15);
            this.lbusername.TabIndex = 0;
            this.lbusername.Text = "用户名";
            // 
            // txtbusername
            // 
            this.txtbusername.Location = new System.Drawing.Point(190, 65);
            this.txtbusername.Name = "txtbusername";
            this.txtbusername.Size = new System.Drawing.Size(158, 25);
            this.txtbusername.TabIndex = 2;
            // 
            // btndrop
            // 
            this.btndrop.Location = new System.Drawing.Point(116, 142);
            this.btndrop.Name = "btndrop";
            this.btndrop.Size = new System.Drawing.Size(75, 23);
            this.btndrop.TabIndex = 3;
            this.btndrop.Text = "删除";
            this.btndrop.UseVisualStyleBackColor = true;
            this.btndrop.Click += new System.EventHandler(this.btndrop_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(273, 142);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // DropUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 313);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndrop);
            this.Controls.Add(this.txtbusername);
            this.Controls.Add(this.lbusername);
            this.Name = "DropUser";
            this.Text = "删除用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.TextBox txtbusername;
        private System.Windows.Forms.Button btndrop;
        private System.Windows.Forms.Button btncancel;
    }
}