
namespace QLDC.PL
{
    partial class FormRPNhanVien
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
            this.RPNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPNhanVien
            // 
            this.RPNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPNhanVien.Location = new System.Drawing.Point(0, 0);
            this.RPNhanVien.Name = "RPNhanVien";
            this.RPNhanVien.ServerReport.BearerToken = null;
            this.RPNhanVien.Size = new System.Drawing.Size(728, 557);
            this.RPNhanVien.TabIndex = 0;
            this.RPNhanVien.Load += new System.EventHandler(this.RPNhanViên_Load);
            // 
            // FormRPNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 557);
            this.Controls.Add(this.RPNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormRPNhanVien";
            this.Text = "NHÂN VIÊN";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RPNhanVien;
    }
}