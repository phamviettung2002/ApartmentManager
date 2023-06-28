
namespace QLDC.PL
{
    partial class FormDangKyDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDVCaNhan = new System.Windows.Forms.DataGridView();
            this.MaDV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGìa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtTenDC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuyDichVu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVCaNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.dgvDichVu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 553);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH TẤT CẢ CÁC DỊCH VỤ";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(12, 432);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(125, 42);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.DonGia});
            this.dgvDichVu.Location = new System.Drawing.Point(-5, 78);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(505, 314);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.TabStop = false;
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã dịch vụ";
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 143;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.Name = "TenDV";
            this.TenDV.Width = 200;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Căn Hộ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Chủ Căn Hộ";
            // 
            // dgvDVCaNhan
            // 
            this.dgvDVCaNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVCaNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV2,
            this.TenDV2,
            this.DonGìa});
            this.dgvDVCaNhan.Location = new System.Drawing.Point(498, 202);
            this.dgvDVCaNhan.Name = "dgvDVCaNhan";
            this.dgvDVCaNhan.RowHeadersWidth = 51;
            this.dgvDVCaNhan.RowTemplate.Height = 24;
            this.dgvDVCaNhan.Size = new System.Drawing.Size(498, 272);
            this.dgvDVCaNhan.TabIndex = 5;
            this.dgvDVCaNhan.TabStop = false;
            // 
            // MaDV2
            // 
            this.MaDV2.DataPropertyName = "MaDV";
            this.MaDV2.HeaderText = "Mã dịch vụ";
            this.MaDV2.Name = "MaDV2";
            this.MaDV2.Width = 143;
            // 
            // TenDV2
            // 
            this.TenDV2.DataPropertyName = "TenDV";
            this.TenDV2.HeaderText = "Tên dịch vụ";
            this.TenDV2.Name = "TenDV2";
            this.TenDV2.Width = 200;
            // 
            // DonGìa
            // 
            this.DonGìa.DataPropertyName = "DonGia";
            this.DonGìa.HeaderText = "Đơn giá";
            this.DonGìa.Name = "DonGìa";
            this.DonGìa.Width = 120;
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(700, 48);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(237, 29);
            this.txtMaCH.TabIndex = 6;
            // 
            // txtTenDC
            // 
            this.txtTenDC.Location = new System.Drawing.Point(700, 115);
            this.txtTenDC.Name = "txtTenDC";
            this.txtTenDC.Size = new System.Drawing.Size(237, 29);
            this.txtTenDC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "DỊCH VỤ CĂN HỘ ĐĂNG KÝ";
            // 
            // btnHuyDichVu
            // 
            this.btnHuyDichVu.Location = new System.Drawing.Point(506, 499);
            this.btnHuyDichVu.Name = "btnHuyDichVu";
            this.btnHuyDichVu.Size = new System.Drawing.Size(125, 42);
            this.btnHuyDichVu.TabIndex = 0;
            this.btnHuyDichVu.Text = "Hủy dịch vụ";
            this.btnHuyDichVu.UseVisualStyleBackColor = true;
            this.btnHuyDichVu.Click += new System.EventHandler(this.btnHuyDichVu_Click);
            // 
            // FormDangKyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 553);
            this.Controls.Add(this.btnHuyDichVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenDC);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.dgvDVCaNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormDangKyDichVu";
            this.Text = "ĐĂNG KÝ DỊCH VỤ";
            this.Load += new System.EventHandler(this.FormDangKyDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVCaNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDVCaNhan;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.TextBox txtTenDC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuyDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGìa;
    }
}