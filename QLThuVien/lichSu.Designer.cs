namespace QLThuVien
{
    partial class lichSu
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
            this.dataTra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataMuon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTra
            // 
            this.dataTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTra.Location = new System.Drawing.Point(19, 363);
            this.dataTra.Name = "dataTra";
            this.dataTra.RowTemplate.Height = 24;
            this.dataTra.Size = new System.Drawing.Size(894, 220);
            this.dataTra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SDK_JP_Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sách Đã Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SDK_JP_Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sách Đã Trả";
            // 
            // dataMuon
            // 
            this.dataMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMuon.Location = new System.Drawing.Point(19, 63);
            this.dataMuon.Name = "dataMuon";
            this.dataMuon.RowTemplate.Height = 24;
            this.dataMuon.Size = new System.Drawing.Size(894, 220);
            this.dataMuon.TabIndex = 4;
            // 
            // lichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 618);
            this.Controls.Add(this.dataMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTra);
            this.Name = "lichSu";
            this.Text = "lichSu";
            this.Load += new System.EventHandler(this.lichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataMuon;
    }
}