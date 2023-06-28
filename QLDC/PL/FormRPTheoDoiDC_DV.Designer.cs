
namespace QLDC.PL
{
    partial class FormRPTheoDoiDC_DV
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
            this.RPTheoDoiDC_DV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPTheoDoiDC_DV
            // 
            this.RPTheoDoiDC_DV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPTheoDoiDC_DV.Location = new System.Drawing.Point(0, 0);
            this.RPTheoDoiDC_DV.Name = "RPTheoDoiDC_DV";
            this.RPTheoDoiDC_DV.ServerReport.BearerToken = null;
            this.RPTheoDoiDC_DV.Size = new System.Drawing.Size(818, 749);
            this.RPTheoDoiDC_DV.TabIndex = 0;
            this.RPTheoDoiDC_DV.Load += new System.EventHandler(this.RPTheoDoiDC_DV_Load);
            // 
            // FormRPTheoDoiDC_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 749);
            this.Controls.Add(this.RPTheoDoiDC_DV);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormRPTheoDoiDC_DV";
            this.Text = "THEO DÕI DÂN CƯ DỊCH VỤ";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RPTheoDoiDC_DV;
    }
}