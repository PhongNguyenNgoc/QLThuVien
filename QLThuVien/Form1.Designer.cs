namespace QLThuVien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogIN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSupport = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(179, 195);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(220, 26);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(179, 261);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(220, 26);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogIN
            // 
            this.btnLogIN.Location = new System.Drawing.Point(260, 321);
            this.btnLogIN.Name = "btnLogIN";
            this.btnLogIN.Size = new System.Drawing.Size(139, 47);
            this.btnLogIN.TabIndex = 4;
            this.btnLogIN.Text = "Đăng nhập";
            this.btnLogIN.UseVisualStyleBackColor = true;
            this.btnLogIN.Click += new System.EventHandler(this.btnLogIN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // lbSupport
            // 
            this.lbSupport.AutoSize = true;
            this.lbSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupport.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbSupport.Location = new System.Drawing.Point(12, 334);
            this.lbSupport.Name = "lbSupport";
            this.lbSupport.Size = new System.Drawing.Size(206, 22);
            this.lbSupport.TabIndex = 8;
            this.lbSupport.Text = "Không đăng nhập được?";
            this.lbSupport.Click += new System.EventHandler(this.lbSupport_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.Red;
            this.lbExit.Location = new System.Drawing.Point(401, 9);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(37, 36);
            this.lbExit.TabIndex = 9;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 405);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbSupport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogIN);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSupport;
        private System.Windows.Forms.Label lbExit;
    }
}

