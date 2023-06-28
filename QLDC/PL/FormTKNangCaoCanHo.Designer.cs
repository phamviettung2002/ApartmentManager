
namespace QLDC.PL
{
    partial class FormTKNangCaoCanHo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TangLau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.radTKCanHoTrong = new System.Windows.Forms.RadioButton();
            this.radTKCanHoGia = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaMin = new System.Windows.Forms.TextBox();
            this.txtGiaMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH,
            this.TangLau,
            this.GiaCH,
            this.TrangThai});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(519, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaCH
            // 
            this.MaCH.DataPropertyName = "MaCH";
            this.MaCH.HeaderText = "Mã căn hộ";
            this.MaCH.Name = "MaCH";
            // 
            // TangLau
            // 
            this.TangLau.DataPropertyName = "TangLau";
            this.TangLau.HeaderText = "Tầng lầu";
            this.TangLau.Name = "TangLau";
            // 
            // GiaCH
            // 
            this.GiaCH.DataPropertyName = "GiaCH";
            this.GiaCH.HeaderText = "Giá";
            this.GiaCH.Name = "GiaCH";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÌM KIẾM CĂN HỘ";
            // 
            // radTKCanHoTrong
            // 
            this.radTKCanHoTrong.AutoSize = true;
            this.radTKCanHoTrong.Location = new System.Drawing.Point(109, 203);
            this.radTKCanHoTrong.Name = "radTKCanHoTrong";
            this.radTKCanHoTrong.Size = new System.Drawing.Size(217, 25);
            this.radTKCanHoTrong.TabIndex = 3;
            this.radTKCanHoTrong.TabStop = true;
            this.radTKCanHoTrong.Text = "Tìm Kiếm Căn Hộ Trống";
            this.radTKCanHoTrong.UseVisualStyleBackColor = true;
            // 
            // radTKCanHoGia
            // 
            this.radTKCanHoGia.AutoSize = true;
            this.radTKCanHoGia.Location = new System.Drawing.Point(109, 259);
            this.radTKCanHoGia.Name = "radTKCanHoGia";
            this.radTKCanHoGia.Size = new System.Drawing.Size(219, 25);
            this.radTKCanHoGia.TabIndex = 4;
            this.radTKCanHoGia.TabStop = true;
            this.radTKCanHoGia.Text = "Tìm Kiếm Theo Mức Giá";
            this.radTKCanHoGia.UseVisualStyleBackColor = true;
            this.radTKCanHoGia.CheckedChanged += new System.EventHandler(this.radTKCanHoGia_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::QLDC.Properties.Resources.icons8_search_96;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Location = new System.Drawing.Point(109, 140);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 42);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGiaMin);
            this.groupBox1.Controls.Add(this.txtGiaMax);
            this.groupBox1.Location = new System.Drawing.Point(109, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 196);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mức Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max";
            // 
            // txtGiaMin
            // 
            this.txtGiaMin.Location = new System.Drawing.Point(108, 119);
            this.txtGiaMin.Name = "txtGiaMin";
            this.txtGiaMin.Size = new System.Drawing.Size(132, 29);
            this.txtGiaMin.TabIndex = 4;
            // 
            // txtGiaMax
            // 
            this.txtGiaMax.Location = new System.Drawing.Point(108, 57);
            this.txtGiaMax.Name = "txtGiaMax";
            this.txtGiaMax.Size = new System.Drawing.Size(132, 29);
            this.txtGiaMax.TabIndex = 3;
            // 
            // FormTKNangCaoCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.radTKCanHoGia);
            this.Controls.Add(this.radTKCanHoTrong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormTKNangCaoCanHo";
            this.Text = "CĂN HỘ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTKCanHoTrong;
        private System.Windows.Forms.RadioButton radTKCanHoGia;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaMin;
        private System.Windows.Forms.TextBox txtGiaMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TangLau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}