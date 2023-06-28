using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLDC.BLL;
using QLDC.DTO;

namespace QLDC.PL
{
    public partial class FormRPTheoDoiDC_DV : Form
    {
        public FormRPTheoDoiDC_DV()
        {
            InitializeComponent();
        }

        private void RPTheoDoiDC_DV_Load(object sender, EventArgs e)
        {
            this.RPTheoDoiDC_DV.LocalReport.ReportEmbeddedResource = "QLDC.PL.RPTheoDoiDC_CHGroup.rdlc";
            this.RPTheoDoiDC_DV.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.RPTheoDoiDC_DV.LocalReport.DataSources.Add(new ReportDataSource("TheoDoiDV_DCGroup", DichVuBLL.GetAllDichVu()));
            this.RPTheoDoiDC_DV.RefreshReport();

        }
        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            string strMaDV = e.Parameters["paMaDV"].Values[0];
            List<DanCuDTO> lstdc = DanCuBLL.GetDanCuWithMaDV(strMaDV);
            e.DataSources.Add(new ReportDataSource("TheoDoiDanCu_CanHo",lstdc));
        }

    }
}
