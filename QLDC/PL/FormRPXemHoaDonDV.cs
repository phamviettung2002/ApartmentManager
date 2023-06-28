using Microsoft.Reporting.WinForms;
using QLDC.BLL;
using QLDC.DTO;
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
    public partial class FormRPXemHoaDonDV : Form
    {
        string maDC;
        string tenDC;
        string maCH;

        public FormRPXemHoaDonDV()
        {
            InitializeComponent();
        }

        public FormRPXemHoaDonDV(string maDC, string tenDC, string maCH)
        {
            this.maDC = maDC;
            this.tenDC = tenDC;
            this.maCH = maCH;

            InitializeComponent();
        }

        private void RPXemHoaDonDV_Load(object sender, EventArgs e)
        {
            List<DichVuDTO> ldv = DichVuBLL.GetDichVuWithMaDC(maDC);
            this.RPXemHoaDonDV.LocalReport.ReportEmbeddedResource = "QLDC.PL.RPXemHoaDonDV.rdlc";
            this.RPXemHoaDonDV.LocalReport.DataSources.Add(new ReportDataSource("XemHoaDonDV", ldv));
            this.RPXemHoaDonDV.LocalReport.SetParameters(new ReportParameter("paMaDC", maDC, true));
            this.RPXemHoaDonDV.LocalReport.SetParameters(new ReportParameter("paTenDC", tenDC, true));
            this.RPXemHoaDonDV.LocalReport.SetParameters(new ReportParameter("paMaCH", maCH, true));
            this.RPXemHoaDonDV.RefreshReport();
        }
    }
}

