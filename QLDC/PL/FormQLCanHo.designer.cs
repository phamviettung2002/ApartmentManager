
namespace QLDC.PL
{
    partial class FormQLCanHo
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
            this.txttimkiemCH = new System.Windows.Forms.TextBox();
            this.dGViewCanHo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimkiemCH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaCH = new System.Windows.Forms.MaskedTextBox();
            this.btnThemCanHo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaCH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTangCH = new System.Windows.Forms.TextBox();
            this.btnXoaCH = new System.Windows.Forms.Button();
            this.btnSuaCH = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewCanHo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttimkiemCH
            // 
            this.txttimkiemCH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemCH.Location = new System.Drawing.Point(585, 25);
            this.txttimkiemCH.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txttimkiemCH.Name = "txttimkiemCH";
            this.txttimkiemCH.Size = new System.Drawing.Size(382, 29);
            this.txttimkiemCH.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txttimkiemCH, "Tìm Kiếm Theo Mã Căn Hộ");
            // 
            // dGViewCanHo
            // 
            this.dGViewCanHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewCanHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dGViewCanHo.Location = new System.Drawing.Point(433, 76);
            this.dGViewCanHo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dGViewCanHo.Name = "dGViewCanHo";
            this.dGViewCanHo.RowHeadersWidth = 51;
            this.dGViewCanHo.RowTemplate.Height = 24;
            this.dGViewCanHo.Size = new System.Drawing.Size(553, 418);
            this.dGViewCanHo.TabIndex = 5;
            this.dGViewCanHo.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaCH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Căn Hộ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 122;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TangLau";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tầng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GiaCH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá Căn Hộ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnTimkiemCH
            // 
            this.btnTimkiemCH.BackgroundImage = global::QLDC.Properties.Resources.icons8_search_96;
            this.btnTimkiemCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimkiemCH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemCH.Location = new System.Drawing.Point(480, 18);
            this.btnTimkiemCH.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTimkiemCH.Name = "btnTimkiemCH";
            this.btnTimkiemCH.Size = new System.Drawing.Size(68, 40);
            this.btnTimkiemCH.TabIndex = 1;
            this.btnTimkiemCH.UseVisualStyleBackColor = true;
            this.btnTimkiemCH.Click += new System.EventHandler(this.btnTimkiemCH_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtMaCH);
            this.panel1.Controls.Add(this.btnThemCanHo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGiaCH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTangCH);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 495);
            this.panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::QLDC.Properties.Resources.icons8_save_96;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(273, 284);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 40);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.Lưu_Click);
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(145, 99);
            this.txtMaCH.Mask = "LL000";
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(253, 29);
            this.txtMaCH.TabIndex = 0;
            this.txtMaCH.Text = "CH";
            this.txtMaCH.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMaCH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaCH_KeyPress);
            // 
            // btnThemCanHo
            // 
            this.btnThemCanHo.BackgroundImage = global::QLDC.Properties.Resources.icons8_add_96;
            this.btnThemCanHo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemCanHo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCanHo.Location = new System.Drawing.Point(55, 284);
            this.btnThemCanHo.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemCanHo.Name = "btnThemCanHo";
            this.btnThemCanHo.Size = new System.Drawing.Size(68, 40);
            this.btnThemCanHo.TabIndex = 3;
            this.btnThemCanHo.UseVisualStyleBackColor = true;
            this.btnThemCanHo.Click += new System.EventHandler(this.btnThemCanHo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "THÔNG TIN CĂN HỘ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã Căn Hộ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tầng";
            // 
            // txtGiaCH
            // 
            this.txtGiaCH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaCH.Location = new System.Drawing.Point(145, 195);
            this.txtGiaCH.Margin = new System.Windows.Forms.Padding(7);
            this.txtGiaCH.Name = "txtGiaCH";
            this.txtGiaCH.Size = new System.Drawing.Size(253, 29);
            this.txtGiaCH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Giá Căn Hộ";
            // 
            // txtTangCH
            // 
            this.txtTangCH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTangCH.Location = new System.Drawing.Point(145, 147);
            this.txtTangCH.Margin = new System.Windows.Forms.Padding(7);
            this.txtTangCH.Name = "txtTangCH";
            this.txtTangCH.Size = new System.Drawing.Size(253, 29);
            this.txtTangCH.TabIndex = 1;
            // 
            // btnXoaCH
            // 
            this.btnXoaCH.BackgroundImage = global::QLDC.Properties.Resources.icons8_delete_96;
            this.btnXoaCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaCH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCH.Location = new System.Drawing.Point(759, 506);
            this.btnXoaCH.Margin = new System.Windows.Forms.Padding(7);
            this.btnXoaCH.Name = "btnXoaCH";
            this.btnXoaCH.Size = new System.Drawing.Size(68, 40);
            this.btnXoaCH.TabIndex = 4;
            this.btnXoaCH.UseVisualStyleBackColor = true;
            this.btnXoaCH.Click += new System.EventHandler(this.btnXoaCH_Click);
            // 
            // btnSuaCH
            // 
            this.btnSuaCH.BackgroundImage = global::QLDC.Properties.Resources.icons8_edit_96;
            this.btnSuaCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaCH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCH.Location = new System.Drawing.Point(572, 506);
            this.btnSuaCH.Margin = new System.Windows.Forms.Padding(7);
            this.btnSuaCH.Name = "btnSuaCH";
            this.btnSuaCH.Size = new System.Drawing.Size(68, 40);
            this.btnSuaCH.TabIndex = 3;
            this.btnSuaCH.UseVisualStyleBackColor = true;
            this.btnSuaCH.Click += new System.EventHandler(this.btnSuaCH_Click);
            // 
            // FormQLCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.txttimkiemCH);
            this.Controls.Add(this.dGViewCanHo);
            this.Controls.Add(this.btnTimkiemCH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoaCH);
            this.Controls.Add(this.btnSuaCH);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormQLCanHo";
            this.Text = "CĂN HỘ";
            this.Load += new System.EventHandler(this.FormCanHo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewCanHo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttimkiemCH;
        private System.Windows.Forms.DataGridView dGViewCanHo;
        private System.Windows.Forms.Button btnTimkiemCH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaCH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTangCH;
        private System.Windows.Forms.Button btnXoaCH;
        private System.Windows.Forms.Button btnSuaCH;
        private System.Windows.Forms.Button btnThemCanHo;
        private System.Windows.Forms.MaskedTextBox txtMaCH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}