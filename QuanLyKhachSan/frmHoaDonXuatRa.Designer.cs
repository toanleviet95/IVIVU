namespace QuanLyKhachSan
{
    partial class frmHoaDonXuatRa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonXuatRa));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picThoat = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.crystalReportViewerHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptHoaDon1 = new QuanLyKhachSan.rptHoaDon();
            this.rptHoaDon2 = new QuanLyKhachSan.rptHoaDon();
            this.rptHoaDon3 = new QuanLyKhachSan.rptHoaDon();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::QuanLyKhachSan.Properties.Resources.Logo_IVIVU_Ellipse;
            this.picLogo.Location = new System.Drawing.Point(10, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(77, 62);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // picThoat
            // 
            this.picThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picThoat.Image = global::QuanLyKhachSan.Properties.Resources.Thoat;
            this.picThoat.Location = new System.Drawing.Point(915, 9);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(54, 62);
            this.picThoat.TabIndex = 11;
            this.picThoat.TabStop = false;
            this.picThoat.Click += new System.EventHandler(this.picThoat_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(370, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(282, 32);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "Hóa đơn của khách hàng";
            // 
            // crystalReportViewerHoaDon
            // 
            this.crystalReportViewerHoaDon.ActiveViewIndex = 0;
            this.crystalReportViewerHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerHoaDon.Location = new System.Drawing.Point(10, 94);
            this.crystalReportViewerHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crystalReportViewerHoaDon.Name = "crystalReportViewerHoaDon";
            this.crystalReportViewerHoaDon.ReportSource = this.rptHoaDon1;
            this.crystalReportViewerHoaDon.ShowCloseButton = false;
            this.crystalReportViewerHoaDon.Size = new System.Drawing.Size(959, 483);
            this.crystalReportViewerHoaDon.TabIndex = 0;
            this.crystalReportViewerHoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewerHoaDon.ToolPanelWidth = 300;
            // 
            // frmHoaDonXuatRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(981, 591);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.crystalReportViewerHoaDon);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoaDonXuatRa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn xuất ra";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerHoaDon;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picThoat;
        private System.Windows.Forms.Label lblTieuDe;
        private rptHoaDon rptHoaDon1;
        private rptHoaDon rptHoaDon2;
        private rptHoaDon rptHoaDon3;
    }
}