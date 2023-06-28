using Microsoft.Reporting.WinForms;
using QLDC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDC.PL
{
    public partial class FormRPNhanVien : Form
    {
        public FormRPNhanVien()
        {
            InitializeComponent();
        }
        private void RPNhanViên_Load(object sender, EventArgs e)
        {
            this.RPNhanVien.LocalReport.ReportEmbeddedResource = "QLDC.PL.RPNhanVien.rdlc";
            this.RPNhanVien.LocalReport.DataSources.Add(new ReportDataSource("NhanVienALL", NhanVienBLL.All()));
            this.RPNhanVien.RefreshReport();
        }
    }
}
