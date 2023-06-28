
namespace QLDC.PL
{
    partial class FormQLNhanVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttimkiemNV = new System.Windows.Forms.TextBox();
            this.dGViewNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimkiemNV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.MaskedTextBox();
            this.radNamNV = new System.Windows.Forms.RadioButton();
            this.radNuNV = new System.Windows.Forms.RadioButton();
            this.dtPickerNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaCVNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoaiNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRPNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã nhân viên";
            // 
            // txttimkiemNV
            // 
            this.txttimkiemNV.Location = new System.Drawing.Point(573, 31);
            this.txttimkiemNV.Name = "txttimkiemNV";
            this.txttimkiemNV.Size = new System.Drawing.Size(397, 29);
            this.txttimkiemNV.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txttimkiemNV, "Tìm Kiếm Theo Tên Nhân Viên");
            // 
            // dGViewNhanVien
            // 
            this.dGViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dGViewNhanVien.Location = new System.Drawing.Point(430, 82);
            this.dGViewNhanVien.Name = "dGViewNhanVien";
            this.dGViewNhanVien.RowHeadersWidth = 51;
            this.dGViewNhanVien.RowTemplate.Height = 24;
            this.dGViewNhanVien.Size = new System.Drawing.Size(551, 418);
            this.dGViewNhanVien.TabIndex = 5;
            this.dGViewNhanVien.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 141;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 146;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 108;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 112;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.DataPropertyName = "DienThoai";
            this.Column5.HeaderText = "Điện Thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 118;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.DataPropertyName = "ChucVu";
            this.Column6.HeaderText = "Chức Vụ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btnTimkiemNV
            // 
            this.btnTimkiemNV.BackgroundImage = global::QLDC.Properties.Resources.icons8_search_96;
            this.btnTimkiemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimkiemNV.Location = new System.Drawing.Point(492, 26);
            this.btnTimkiemNV.Name = "btnTimkiemNV";
            this.btnTimkiemNV.Size = new System.Drawing.Size(61, 36);
            this.btnTimkiemNV.TabIndex = 2;
            this.btnTimkiemNV.UseVisualStyleBackColor = true;
            this.btnTimkiemNV.Click += new System.EventHandler(this.btnTimkiemNV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.radNamNV);
            this.panel1.Controls.Add(this.radNuNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtPickerNgaySinhNV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnThemNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaCVNV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDienThoaiNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 474);
            this.panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::QLDC.Properties.Resources.icons8_save_96;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(262, 410);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 40);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(155, 76);
            this.txtMaNV.Mask = "LL000";
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(255, 29);
            this.txtMaNV.TabIndex = 0;
            this.txtMaNV.Text = "NV";
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // radNamNV
            // 
            this.radNamNV.AutoSize = true;
            this.radNamNV.Location = new System.Drawing.Point(166, 173);
            this.radNamNV.Name = "radNamNV";
            this.radNamNV.Size = new System.Drawing.Size(63, 25);
            this.radNamNV.TabIndex = 2;
            this.radNamNV.TabStop = true;
            this.radNamNV.Text = "Nam";
            this.radNamNV.UseVisualStyleBackColor = true;
            // 
            // radNuNV
            // 
            this.radNuNV.AutoSize = true;
            this.radNuNV.Location = new System.Drawing.Point(296, 173);
            this.radNuNV.Name = "radNuNV";
            this.radNuNV.Size = new System.Drawing.Size(51, 25);
            this.radNuNV.TabIndex = 3;
            this.radNuNV.TabStop = true;
            this.radNuNV.Text = "Nữ";
            this.radNuNV.UseVisualStyleBackColor = true;
            // 
            // dtPickerNgaySinhNV
            // 
            this.dtPickerNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerNgaySinhNV.Location = new System.Drawing.Point(156, 219);
            this.dtPickerNgaySinhNV.Name = "dtPickerNgaySinhNV";
            this.dtPickerNgaySinhNV.Size = new System.Drawing.Size(254, 29);
            this.dtPickerNgaySinhNV.TabIndex = 4;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackgroundImage = global::QLDC.Properties.Resources.icons8_add_96;
            this.btnThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Location = new System.Drawing.Point(33, 410);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(61, 40);
            this.btnThemNV.TabIndex = 7;
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Giới tính";
            // 
            // txtMaCVNV
            // 
            this.txtMaCVNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCVNV.Location = new System.Drawing.Point(156, 318);
            this.txtMaCVNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCVNV.Name = "txtMaCVNV";
            this.txtMaCVNV.Size = new System.Drawing.Size(254, 29);
            this.txtMaCVNV.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ngày sinh";
            // 
            // txtDienThoaiNV
            // 
            this.txtDienThoaiNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoaiNV.Location = new System.Drawing.Point(156, 267);
            this.txtDienThoaiNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienThoaiNV.Name = "txtDienThoaiNV";
            this.txtDienThoaiNV.Size = new System.Drawing.Size(254, 29);
            this.txtDienThoaiNV.TabIndex = 5;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(156, 124);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(254, 29);
            this.txtTenNV.TabIndex = 1;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackgroundImage = global::QLDC.Properties.Resources.icons8_edit_96;
            this.btnSuaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.Location = new System.Drawing.Point(673, 511);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(61, 40);
            this.btnSuaNV.TabIndex = 4;
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackgroundImage = global::QLDC.Properties.Resources.icons8_delete_96;
            this.btnXoaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Location = new System.Drawing.Point(839, 511);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(61, 40);
            this.btnXoaNV.TabIndex = 5;
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnRPNV
            // 
            this.btnRPNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRPNV.Location = new System.Drawing.Point(13, 493);
            this.btnRPNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnRPNV.Name = "btnRPNV";
            this.btnRPNV.Size = new System.Drawing.Size(275, 47);
            this.btnRPNV.TabIndex = 1;
            this.btnRPNV.Text = "Xuất báo cáo danh sách nhân viên";
            this.btnRPNV.UseVisualStyleBackColor = true;
            this.btnRPNV.Click += new System.EventHandler(this.btnRPNV_Click);
            // 
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnRPNV);
            this.Controls.Add(this.txttimkiemNV);
            this.Controls.Add(this.dGViewNhanVien);
            this.Controls.Add(this.btnTimkiemNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnXoaNV);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormQLNhanVien";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FormQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttimkiemNV;
        private System.Windows.Forms.DataGridView dGViewNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimkiemNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtPickerNgaySinhNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaCVNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienThoaiNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.RadioButton radNamNV;
        private System.Windows.Forms.RadioButton radNuNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox txtMaNV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnRPNV;
    }
}