namespace QuanLyKhachSan
{
    partial class frmThongKePhongTrong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKePhongTrong));
            this.picThoat = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTieuChi = new System.Windows.Forms.ComboBox();
            this.cmbThuTu = new System.Windows.Forms.ComboBox();
            this.dtgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.picTheme = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhongTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // picThoat
            // 
            this.picThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picThoat.Image = global::QuanLyKhachSan.Properties.Resources.Thoat;
            this.picThoat.Location = new System.Drawing.Point(918, 12);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(54, 62);
            this.picThoat.TabIndex = 11;
            this.picThoat.TabStop = false;
            this.picThoat.Click += new System.EventHandler(this.picThoat_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::QuanLyKhachSan.Properties.Resources.Logo_IVIVU_Ellipse;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(77, 62);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(340, 12);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(258, 32);
            this.lblTieuDe.TabIndex = 12;
            this.lblTieuDe.Text = "Thống kê phòng trống";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.Location = new System.Drawing.Point(234, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sắp xếp theo:";
            // 
            // cmbTieuChi
            // 
            this.cmbTieuChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTieuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTieuChi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTieuChi.FormattingEnabled = true;
            this.cmbTieuChi.Items.AddRange(new object[] {
            "Thành phố",
            "Số sao"});
            this.cmbTieuChi.Location = new System.Drawing.Point(402, 55);
            this.cmbTieuChi.Name = "cmbTieuChi";
            this.cmbTieuChi.Size = new System.Drawing.Size(121, 29);
            this.cmbTieuChi.TabIndex = 14;
            this.cmbTieuChi.TabStop = false;
            this.cmbTieuChi.SelectedIndexChanged += new System.EventHandler(this.cmbTieuChi_SelectedIndexChanged);
            // 
            // cmbThuTu
            // 
            this.cmbThuTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThuTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbThuTu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbThuTu.FormattingEnabled = true;
            this.cmbThuTu.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
            this.cmbThuTu.Location = new System.Drawing.Point(551, 55);
            this.cmbThuTu.Name = "cmbThuTu";
            this.cmbThuTu.Size = new System.Drawing.Size(121, 29);
            this.cmbThuTu.TabIndex = 15;
            this.cmbThuTu.TabStop = false;
            this.cmbThuTu.SelectedIndexChanged += new System.EventHandler(this.cmbThuTu_SelectedIndexChanged);
            // 
            // dtgvPhongTrong
            // 
            this.dtgvPhongTrong.AllowUserToAddRows = false;
            this.dtgvPhongTrong.AllowUserToDeleteRows = false;
            this.dtgvPhongTrong.AllowUserToResizeColumns = false;
            this.dtgvPhongTrong.AllowUserToResizeRows = false;
            this.dtgvPhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhongTrong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvPhongTrong.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPhongTrong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPhongTrong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPhongTrong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvPhongTrong.Location = new System.Drawing.Point(12, 103);
            this.dtgvPhongTrong.MultiSelect = false;
            this.dtgvPhongTrong.Name = "dtgvPhongTrong";
            this.dtgvPhongTrong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPhongTrong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvPhongTrong.RowHeadersVisible = false;
            this.dtgvPhongTrong.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.dtgvPhongTrong.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvPhongTrong.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(69)))), ((int)(((byte)(39)))));
            this.dtgvPhongTrong.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhongTrong.Size = new System.Drawing.Size(959, 407);
            this.dtgvPhongTrong.TabIndex = 16;
            // 
            // picTheme
            // 
            this.picTheme.Image = global::QuanLyKhachSan.Properties.Resources.Theme;
            this.picTheme.Location = new System.Drawing.Point(197, 518);
            this.picTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTheme.Name = "picTheme";
            this.picTheme.Size = new System.Drawing.Size(592, 110);
            this.picTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTheme.TabIndex = 17;
            this.picTheme.TabStop = false;
            // 
            // frmThongKePhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(182)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(984, 634);
            this.Controls.Add(this.picTheme);
            this.Controls.Add(this.dtgvPhongTrong);
            this.Controls.Add(this.cmbThuTu);
            this.Controls.Add(this.cmbTieuChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.picLogo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKePhongTrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhongTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picThoat;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTieuChi;
        private System.Windows.Forms.ComboBox cmbThuTu;
        private System.Windows.Forms.DataGridView dtgvPhongTrong;
        private System.Windows.Forms.PictureBox picTheme;
    }
}