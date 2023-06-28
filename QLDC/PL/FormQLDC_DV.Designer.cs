
namespace QLDC.PL
{
    partial class FormQLDC_DV
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
            this.txttimkiemDC_DV = new System.Windows.Forms.TextBox();
            this.dGViewDVDC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radTKMaDC = new System.Windows.Forms.RadioButton();
            this.radTKMaDV = new System.Windows.Forms.RadioButton();
            this.btnReportDCDV = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTimkiemDC_DV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewDVDC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttimkiemDC_DV
            // 
            this.txttimkiemDC_DV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemDC_DV.Location = new System.Drawing.Point(101, 112);
            this.txttimkiemDC_DV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txttimkiemDC_DV.Name = "txttimkiemDC_DV";
            this.txttimkiemDC_DV.Size = new System.Drawing.Size(309, 29);
            this.txttimkiemDC_DV.TabIndex = 0;
            // 
            // dGViewDVDC
            // 
            this.dGViewDVDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewDVDC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dGViewDVDC.Dock = System.Windows.Forms.DockStyle.Right;
            this.dGViewDVDC.Location = new System.Drawing.Point(510, 0);
            this.dGViewDVDC.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dGViewDVDC.Name = "dGViewDVDC";
            this.dGViewDVDC.RowHeadersWidth = 51;
            this.dGViewDVDC.RowTemplate.Height = 24;
            this.dGViewDVDC.Size = new System.Drawing.Size(472, 553);
            this.dGViewDVDC.TabIndex = 70;
            this.dGViewDVDC.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDC";
            this.Column1.HeaderText = "Mã Dân Cư";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 210;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDV";
            this.Column2.HeaderText = "Mã Dịch Vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 209;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "TÌM KIẾM THEO MÃ DÂN CƯ- MÃ DỊCH VỤ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.radTKMaDC);
            this.panel1.Controls.Add(this.radTKMaDV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttimkiemDC_DV);
            this.panel1.Controls.Add(this.btnTimkiemDC_DV);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 387);
            this.panel1.TabIndex = 0;
            // 
            // radTKMaDC
            // 
            this.radTKMaDC.AutoSize = true;
            this.radTKMaDC.Location = new System.Drawing.Point(101, 179);
            this.radTKMaDC.Name = "radTKMaDC";
            this.radTKMaDC.Size = new System.Drawing.Size(243, 25);
            this.radTKMaDC.TabIndex = 1;
            this.radTKMaDC.TabStop = true;
            this.radTKMaDC.Text = "Tìm kiếm người dân theo mã";
            this.radTKMaDC.UseVisualStyleBackColor = true;
            this.radTKMaDC.CheckedChanged += new System.EventHandler(this.radTKMaDC_CheckedChanged);
            // 
            // radTKMaDV
            // 
            this.radTKMaDV.AutoSize = true;
            this.radTKMaDV.Location = new System.Drawing.Point(101, 234);
            this.radTKMaDV.Name = "radTKMaDV";
            this.radTKMaDV.Size = new System.Drawing.Size(224, 25);
            this.radTKMaDV.TabIndex = 2;
            this.radTKMaDV.TabStop = true;
            this.radTKMaDV.Text = "Tìm kiếm dịch vụ theo mã";
            this.radTKMaDV.UseVisualStyleBackColor = true;
            this.radTKMaDV.CheckedChanged += new System.EventHandler(this.radTKMaDV_CheckedChanged);
            // 
            // btnReportDCDV
            // 
            this.btnReportDCDV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportDCDV.Location = new System.Drawing.Point(149, 442);
            this.btnReportDCDV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReportDCDV.Name = "btnReportDCDV";
            this.btnReportDCDV.Size = new System.Drawing.Size(204, 50);
            this.btnReportDCDV.TabIndex = 1;
            this.btnReportDCDV.Text = "Xuất báo cáo theo dõi dịch vụ theo dân cư";
            this.btnReportDCDV.UseVisualStyleBackColor = true;
            this.btnReportDCDV.Click += new System.EventHandler(this.btnReportDCDV_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::QLDC.Properties.Resources.icons8_refresh_96;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(310, 309);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 46);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTimkiemDC_DV
            // 
            this.btnTimkiemDC_DV.BackgroundImage = global::QLDC.Properties.Resources.icons8_search_96;
            this.btnTimkiemDC_DV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimkiemDC_DV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemDC_DV.Location = new System.Drawing.Point(82, 309);
            this.btnTimkiemDC_DV.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTimkiemDC_DV.Name = "btnTimkiemDC_DV";
            this.btnTimkiemDC_DV.Size = new System.Drawing.Size(86, 46);
            this.btnTimkiemDC_DV.TabIndex = 3;
            this.btnTimkiemDC_DV.UseVisualStyleBackColor = true;
            this.btnTimkiemDC_DV.Click += new System.EventHandler(this.btnTimkiemDC_DV_Click);
            // 
            // FormQLDC_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnReportDCDV);
            this.Controls.Add(this.dGViewDVDC);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormQLDC_DV";
            this.Text = "DÂN CƯ_DỊCH VỤ";
            this.Load += new System.EventHandler(this.FormQLDC_DV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewDVDC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txttimkiemDC_DV;
        private System.Windows.Forms.DataGridView dGViewDVDC;
        private System.Windows.Forms.Button btnTimkiemDC_DV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radTKMaDC;
        private System.Windows.Forms.RadioButton radTKMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReportDCDV;
    }
}