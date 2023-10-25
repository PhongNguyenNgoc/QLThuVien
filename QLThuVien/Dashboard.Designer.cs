namespace QLThuVien
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSáchMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lichSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.sinhViênToolStripMenuItem,
            this.mượnSáchToolStripMenuItem,
            this.trảSáchToolStripMenuItem,
            this.lichSuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1036, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSáchMớiToolStripMenuItem,
            this.xemSáchToolStripMenuItem});
            this.sáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sáchToolStripMenuItem.Image")));
            this.sáchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(102, 54);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // thêmSáchMớiToolStripMenuItem
            // 
            this.thêmSáchMớiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmSáchMớiToolStripMenuItem.Image")));
            this.thêmSáchMớiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thêmSáchMớiToolStripMenuItem.Name = "thêmSáchMớiToolStripMenuItem";
            this.thêmSáchMớiToolStripMenuItem.Size = new System.Drawing.Size(216, 56);
            this.thêmSáchMớiToolStripMenuItem.Text = "Thêm Sách Mới";
            this.thêmSáchMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmSáchMớiToolStripMenuItem_Click);
            // 
            // xemSáchToolStripMenuItem
            // 
            this.xemSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xemSáchToolStripMenuItem.Image")));
            this.xemSáchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xemSáchToolStripMenuItem.Name = "xemSáchToolStripMenuItem";
            this.xemSáchToolStripMenuItem.Size = new System.Drawing.Size(216, 56);
            this.xemSáchToolStripMenuItem.Text = "Xem Sách ";
            this.xemSáchToolStripMenuItem.Click += new System.EventHandler(this.xemSáchToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSinhViênToolStripMenuItem,
            this.xemThôngTinSinhViênToolStripMenuItem});
            this.sinhViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sinhViênToolStripMenuItem.Image")));
            this.sinhViênToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(132, 54);
            this.sinhViênToolStripMenuItem.Text = "Sinh Viên";
            // 
            // thêmSinhViênToolStripMenuItem
            // 
            this.thêmSinhViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmSinhViênToolStripMenuItem.Image")));
            this.thêmSinhViênToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thêmSinhViênToolStripMenuItem.Name = "thêmSinhViênToolStripMenuItem";
            this.thêmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(279, 56);
            this.thêmSinhViênToolStripMenuItem.Text = "Thêm Sinh Viên";
            this.thêmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thêmSinhViênToolStripMenuItem_Click);
            // 
            // xemThôngTinSinhViênToolStripMenuItem
            // 
            this.xemThôngTinSinhViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xemThôngTinSinhViênToolStripMenuItem.Image")));
            this.xemThôngTinSinhViênToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xemThôngTinSinhViênToolStripMenuItem.Name = "xemThôngTinSinhViênToolStripMenuItem";
            this.xemThôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(279, 56);
            this.xemThôngTinSinhViênToolStripMenuItem.Text = "Xem Thông Tin Sinh Viên";
            this.xemThôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinSinhViênToolStripMenuItem_Click);
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mượnSáchToolStripMenuItem.Image")));
            this.mượnSáchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(145, 54);
            this.mượnSáchToolStripMenuItem.Text = "Mượn Sách";
            this.mượnSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnSáchToolStripMenuItem_Click);
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trảSáchToolStripMenuItem.Image")));
            this.trảSáchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(126, 54);
            this.trảSáchToolStripMenuItem.Text = "Trả Sách";
            this.trảSáchToolStripMenuItem.Click += new System.EventHandler(this.trảSáchToolStripMenuItem_Click);
            // 
            // lichSuToolStripMenuItem
            // 
            this.lichSuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lichSuToolStripMenuItem.Image")));
            this.lichSuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lichSuToolStripMenuItem.Name = "lichSuToolStripMenuItem";
            this.lichSuToolStripMenuItem.Size = new System.Drawing.Size(118, 54);
            this.lichSuToolStripMenuItem.Text = "Lịch Sử";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 54);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoatToolStripMenuItem.Image")));
            this.thoatToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(109, 54);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Digital", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "HH:MM:SS PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Digital", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "nn Month 2023";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Quản Lý Thư Viện - Trang Chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSáchMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lichSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}