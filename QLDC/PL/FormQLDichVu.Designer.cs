
namespace QLDC.PL
{
    partial class FormQLDichVu
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
            this.btnThemDV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGiaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txttimkiemDV = new System.Windows.Forms.TextBox();
            this.dGViewDV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimkiemDV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaDV = new System.Windows.Forms.MaskedTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewDV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackgroundImage = global::QLDC.Properties.Resources.icons8_add_96;
            this.btnThemDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.Location = new System.Drawing.Point(61, 297);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(55, 40);
            this.btnThemDV.TabIndex = 3;
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // txtDonGiaDV
            // 
            this.txtDonGiaDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaDV.Location = new System.Drawing.Point(150, 197);
            this.txtDonGiaDV.Margin = new System.Windows.Forms.Padding(7);
            this.txtDonGiaDV.Name = "txtDonGiaDV";
            this.txtDonGiaDV.Size = new System.Drawing.Size(253, 29);
            this.txtDonGiaDV.TabIndex = 2;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(150, 141);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(7);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(253, 29);
            this.txtTenDV.TabIndex = 1;
            // 
            // txttimkiemDV
            // 
            this.txttimkiemDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemDV.Location = new System.Drawing.Point(585, 25);
            this.txttimkiemDV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txttimkiemDV.Name = "txttimkiemDV";
            this.txttimkiemDV.Size = new System.Drawing.Size(382, 29);
            this.txttimkiemDV.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txttimkiemDV, "Tìm Kiếm Theo Tên Dịch Vụ");
            // 
            // dGViewDV
            // 
            this.dGViewDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dGViewDV.Location = new System.Drawing.Point(431, 86);
            this.dGViewDV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dGViewDV.Name = "dGViewDV";
            this.dGViewDV.RowHeadersWidth = 51;
            this.dGViewDV.RowTemplate.Height = 24;
            this.dGViewDV.Size = new System.Drawing.Size(556, 418);
            this.dGViewDV.TabIndex = 5;
            this.dGViewDV.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "MaDV";
            this.Column1.HeaderText = "Mã Dịch Vụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 126;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenDV";
            this.Column2.HeaderText = "Tên Dịch Vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 99;
            // 
            // btnTimkiemDV
            // 
            this.btnTimkiemDV.BackgroundImage = global::QLDC.Properties.Resources.icons8_search_96;
            this.btnTimkiemDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimkiemDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemDV.Location = new System.Drawing.Point(504, 18);
            this.btnTimkiemDV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTimkiemDV.Name = "btnTimkiemDV";
            this.btnTimkiemDV.Size = new System.Drawing.Size(55, 40);
            this.btnTimkiemDV.TabIndex = 1;
            this.btnTimkiemDV.UseVisualStyleBackColor = true;
            this.btnTimkiemDV.Click += new System.EventHandler(this.btnTimkiemDV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaDV);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDonGiaDV);
            this.panel1.Controls.Add(this.btnThemDV);
            this.panel1.Controls.Add(this.txtTenDV);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 502);
            this.panel1.TabIndex = 0;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(150, 84);
            this.txtMaDV.Mask = "LL000";
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(253, 29);
            this.txtMaDV.TabIndex = 0;
            this.txtMaDV.Text = "DV";
            this.txtMaDV.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMaDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDV_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::QLDC.Properties.Resources.icons8_save_96;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Location = new System.Drawing.Point(273, 297);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(55, 40);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Dịch Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Đơn Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã Dịch Vụ";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackgroundImage = global::QLDC.Properties.Resources.icons8_delete_96;
            this.btnXoaDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.Location = new System.Drawing.Point(759, 506);
            this.btnXoaDV.Margin = new System.Windows.Forms.Padding(7);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(55, 40);
            this.btnXoaDV.TabIndex = 4;
            this.btnXoaDV.UseVisualStyleBackColor = true;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BackgroundImage = global::QLDC.Properties.Resources.icons8_edit_96;
            this.btnSuaDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.Location = new System.Drawing.Point(572, 506);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(7);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(55, 40);
            this.btnSuaDV.TabIndex = 3;
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // FormQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.txttimkiemDV);
            this.Controls.Add(this.dGViewDV);
            this.Controls.Add(this.btnTimkiemDV);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormQLDichVu";
            this.Text = "DỊCH VỤ";
            this.Load += new System.EventHandler(this.FormQLDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewDV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGiaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txttimkiemDV;
        private System.Windows.Forms.DataGridView dGViewDV;
        private System.Windows.Forms.Button btnTimkiemDV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MaskedTextBox txtMaDV;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}