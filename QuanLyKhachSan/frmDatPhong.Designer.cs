namespace QuanLyKhachSan
{
    partial class frmDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatPhong));
            this.cmbKhachSan = new System.Windows.Forms.ComboBox();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblDatPhong = new System.Windows.Forms.Label();
            this.dtgvDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.btnTimPhong = new System.Windows.Forms.Button();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picThoat = new System.Windows.Forms.PictureBox();
            this.picTheme = new System.Windows.Forms.PictureBox();
            this.lblKhachSan = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKhachSan
            // 
            this.cmbKhachSan.DropDownHeight = 110;
            this.cmbKhachSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhachSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKhachSan.FormattingEnabled = true;
            this.cmbKhachSan.IntegralHeight = false;
            this.cmbKhachSan.Location = new System.Drawing.Point(188, 150);
            this.cmbKhachSan.Name = "cmbKhachSan";
            this.cmbKhachSan.Size = new System.Drawing.Size(185, 29);
            this.cmbKhachSan.TabIndex = 4;
            this.cmbKhachSan.SelectedValueChanged += new System.EventHandler(this.cmbKhachSan_SelectedValueChanged);
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.DropDownHeight = 110;
            this.cmbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.IntegralHeight = false;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(379, 150);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(185, 29);
            this.cmbLoaiPhong.TabIndex = 5;
            // 
            // lblDatPhong
            // 
            this.lblDatPhong.AutoSize = true;
            this.lblDatPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatPhong.Location = new System.Drawing.Point(384, 9);
            this.lblDatPhong.Name = "lblDatPhong";
            this.lblDatPhong.Size = new System.Drawing.Size(129, 32);
            this.lblDatPhong.TabIndex = 2;
            this.lblDatPhong.Text = "Đặt phòng";
            // 
            // dtgvDanhSachPhong
            // 
            this.dtgvDanhSachPhong.AllowUserToAddRows = false;
            this.dtgvDanhSachPhong.AllowUserToDeleteRows = false;
            this.dtgvDanhSachPhong.AllowUserToResizeColumns = false;
            this.dtgvDanhSachPhong.AllowUserToResizeRows = false;
            this.dtgvDanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDanhSachPhong.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhong.Location = new System.Drawing.Point(12, 205);
            this.dtgvDanhSachPhong.MultiSelect = false;
            this.dtgvDanhSachPhong.Name = "dtgvDanhSachPhong";
            this.dtgvDanhSachPhong.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhSachPhong.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvDanhSachPhong.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDanhSachPhong.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvDanhSachPhong.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.dtgvDanhSachPhong.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvDanhSachPhong.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(187)))), ((int)(((byte)(30)))));
            this.dtgvDanhSachPhong.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvDanhSachPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachPhong.Size = new System.Drawing.Size(883, 260);
            this.dtgvDanhSachPhong.TabIndex = 3;
            // 
            // btnTimPhong
            // 
            this.btnTimPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimPhong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTimPhong.Location = new System.Drawing.Point(570, 150);
            this.btnTimPhong.Name = "btnTimPhong";
            this.btnTimPhong.Size = new System.Drawing.Size(123, 29);
            this.btnTimPhong.TabIndex = 4;
            this.btnTimPhong.Text = "Tìm phòng";
            this.btnTimPhong.UseVisualStyleBackColor = true;
            this.btnTimPhong.Click += new System.EventHandler(this.btnTimPhong_Click);
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(188, 83);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(185, 29);
            this.dtpBatDau.TabIndex = 6;
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(379, 83);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(185, 29);
            this.dtpKetThuc.TabIndex = 7;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDatPhong.Location = new System.Drawing.Point(570, 83);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(123, 29);
            this.btnDatPhong.TabIndex = 8;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // lblBatDau
            // 
            this.lblBatDau.AutoSize = true;
            this.lblBatDau.Location = new System.Drawing.Point(252, 59);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(62, 21);
            this.lblBatDau.TabIndex = 9;
            this.lblBatDau.Text = "Bắt đầu";
            // 
            // lblKetThuc
            // 
            this.lblKetThuc.AutoSize = true;
            this.lblKetThuc.Location = new System.Drawing.Point(433, 59);
            this.lblKetThuc.Name = "lblKetThuc";
            this.lblKetThuc.Size = new System.Drawing.Size(66, 21);
            this.lblKetThuc.TabIndex = 10;
            this.lblKetThuc.Text = "Kết thúc";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::QuanLyKhachSan.Properties.Resources.Logo_IVIVU_Ellipse;
            this.picLogo.Location = new System.Drawing.Point(12, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(77, 62);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // picThoat
            // 
            this.picThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picThoat.Image = global::QuanLyKhachSan.Properties.Resources.Thoat;
            this.picThoat.Location = new System.Drawing.Point(841, 9);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(54, 62);
            this.picThoat.TabIndex = 12;
            this.picThoat.TabStop = false;
            this.picThoat.Click += new System.EventHandler(this.picThoat_Click);
            // 
            // picTheme
            // 
            this.picTheme.Image = global::QuanLyKhachSan.Properties.Resources.Theme;
            this.picTheme.Location = new System.Drawing.Point(158, 473);
            this.picTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTheme.Name = "picTheme";
            this.picTheme.Size = new System.Drawing.Size(592, 110);
            this.picTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTheme.TabIndex = 13;
            this.picTheme.TabStop = false;
            // 
            // lblKhachSan
            // 
            this.lblKhachSan.AutoSize = true;
            this.lblKhachSan.Location = new System.Drawing.Point(243, 126);
            this.lblKhachSan.Name = "lblKhachSan";
            this.lblKhachSan.Size = new System.Drawing.Size(80, 21);
            this.lblKhachSan.TabIndex = 14;
            this.lblKhachSan.Text = "Khách sạn";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(433, 125);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(88, 21);
            this.lblLoaiPhong.TabIndex = 15;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(187)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(907, 595);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.lblKhachSan);
            this.Controls.Add(this.picTheme);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblKetThuc);
            this.Controls.Add(this.lblBatDau);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.dtpKetThuc);
            this.Controls.Add(this.dtpBatDau);
            this.Controls.Add(this.btnTimPhong);
            this.Controls.Add(this.dtgvDanhSachPhong);
            this.Controls.Add(this.lblDatPhong);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.cmbKhachSan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhachSan;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.Label lblDatPhong;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhong;
        private System.Windows.Forms.Button btnTimPhong;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picThoat;
        private System.Windows.Forms.PictureBox picTheme;
        private System.Windows.Forms.Label lblKhachSan;
        private System.Windows.Forms.Label lblLoaiPhong;
    }
}