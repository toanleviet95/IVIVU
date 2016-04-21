namespace QuanLyKhachSan
{
    partial class frmTraCuuKhachSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuKhachSan));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.cmbSoSao = new System.Windows.Forms.ComboBox();
            this.cmbThanhPho = new System.Windows.Forms.ComboBox();
            this.cmbGia = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgvKhachSan = new System.Windows.Forms.DataGridView();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picThoat = new System.Windows.Forms.PictureBox();
            this.picTheme = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(404, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(205, 32);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Tra cứu khách sạn";
            // 
            // cmbSoSao
            // 
            this.cmbSoSao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoSao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSoSao.FormattingEnabled = true;
            this.cmbSoSao.Location = new System.Drawing.Point(273, 54);
            this.cmbSoSao.Name = "cmbSoSao";
            this.cmbSoSao.Size = new System.Drawing.Size(121, 29);
            this.cmbSoSao.TabIndex = 4;
            this.cmbSoSao.TabStop = false;
            // 
            // cmbThanhPho
            // 
            this.cmbThanhPho.DropDownHeight = 130;
            this.cmbThanhPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThanhPho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbThanhPho.FormattingEnabled = true;
            this.cmbThanhPho.IntegralHeight = false;
            this.cmbThanhPho.Location = new System.Drawing.Point(400, 54);
            this.cmbThanhPho.Name = "cmbThanhPho";
            this.cmbThanhPho.Size = new System.Drawing.Size(209, 29);
            this.cmbThanhPho.TabIndex = 5;
            this.cmbThanhPho.TabStop = false;
            // 
            // cmbGia
            // 
            this.cmbGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGia.FormattingEnabled = true;
            this.cmbGia.Location = new System.Drawing.Point(615, 54);
            this.cmbGia.Name = "cmbGia";
            this.cmbGia.Size = new System.Drawing.Size(121, 29);
            this.cmbGia.TabIndex = 6;
            this.cmbGia.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(400, 102);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(209, 37);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtgvKhachSan
            // 
            this.dtgvKhachSan.AllowUserToAddRows = false;
            this.dtgvKhachSan.AllowUserToDeleteRows = false;
            this.dtgvKhachSan.AllowUserToResizeColumns = false;
            this.dtgvKhachSan.AllowUserToResizeRows = false;
            this.dtgvKhachSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhachSan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvKhachSan.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKhachSan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKhachSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachSan.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvKhachSan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvKhachSan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvKhachSan.Location = new System.Drawing.Point(12, 155);
            this.dtgvKhachSan.MultiSelect = false;
            this.dtgvKhachSan.Name = "dtgvKhachSan";
            this.dtgvKhachSan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKhachSan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvKhachSan.RowHeadersVisible = false;
            this.dtgvKhachSan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.dtgvKhachSan.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvKhachSan.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(69)))), ((int)(((byte)(39)))));
            this.dtgvKhachSan.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvKhachSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKhachSan.Size = new System.Drawing.Size(959, 407);
            this.dtgvKhachSan.TabIndex = 8;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::QuanLyKhachSan.Properties.Resources.Logo_IVIVU_Ellipse;
            this.picLogo.Location = new System.Drawing.Point(13, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(77, 62);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // picThoat
            // 
            this.picThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picThoat.Image = global::QuanLyKhachSan.Properties.Resources.Thoat;
            this.picThoat.Location = new System.Drawing.Point(918, 9);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(54, 62);
            this.picThoat.TabIndex = 2;
            this.picThoat.TabStop = false;
            this.picThoat.Click += new System.EventHandler(this.picThoat_Click);
            // 
            // picTheme
            // 
            this.picTheme.Image = global::QuanLyKhachSan.Properties.Resources.Theme;
            this.picTheme.Location = new System.Drawing.Point(199, 570);
            this.picTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTheme.Name = "picTheme";
            this.picTheme.Size = new System.Drawing.Size(592, 110);
            this.picTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTheme.TabIndex = 0;
            this.picTheme.TabStop = false;
            // 
            // frmTraCuuKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(69)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(984, 693);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.dtgvKhachSan);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cmbGia);
            this.Controls.Add(this.cmbThanhPho);
            this.Controls.Add(this.cmbSoSao);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.picTheme);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTraCuuKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTraCuuKhachSan";
            this.Load += new System.EventHandler(this.frmTraCuuKhachSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTheme;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.PictureBox picThoat;
        private System.Windows.Forms.ComboBox cmbSoSao;
        private System.Windows.Forms.ComboBox cmbThanhPho;
        private System.Windows.Forms.ComboBox cmbGia;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvKhachSan;
        private System.Windows.Forms.PictureBox picLogo;
    }
}