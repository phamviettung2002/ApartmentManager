
namespace QLDC.PL
{
    partial class FormRPXemHoaDonDV
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
            this.RPXemHoaDonDV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPXemHoaDonDV
            // 
            this.RPXemHoaDonDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPXemHoaDonDV.Location = new System.Drawing.Point(0, 0);
            this.RPXemHoaDonDV.Name = "RPXemHoaDonDV";
            this.RPXemHoaDonDV.ServerReport.BearerToken = null;
            this.RPXemHoaDonDV.Size = new System.Drawing.Size(628, 549);
            this.RPXemHoaDonDV.TabIndex = 0;
            this.RPXemHoaDonDV.Load += new System.EventHandler(this.RPXemHoaDonDV_Load);
            // 
            // FormRPXemHoaDonDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 549);
            this.Controls.Add(this.RPXemHoaDonDV);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormRPXemHoaDonDV";
            this.Text = "XEM HÓA ĐƠN DỊCH VỤ";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RPXemHoaDonDV;
    }
}