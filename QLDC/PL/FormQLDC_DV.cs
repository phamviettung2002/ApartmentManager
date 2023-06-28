using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDC.BLL;
using QLDC.DTO;

namespace QLDC.PL
{
    public partial class FormQLDC_DV : Form
    {
        public FormQLDC_DV()
        {
            InitializeComponent();

            dGViewDVDC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGViewDVDC.MultiSelect = false;
            dGViewDVDC.ReadOnly = true;
        }

        private void FormQLDC_DV_Load(object sender, EventArgs e)
        {
            dGViewDVDC.DataSource = DanCu_DichVuBLL.GetAllDC_DV();
            dGViewDVDC.Columns[dGViewDVDC.Columns.Count - 1].Visible = false;
            txttimkiemDC_DV.Enabled = false;
        }

        private void btnTimkiemDC_DV_Click(object sender, EventArgs e)
        {
            if(radTKMaDC.Checked==true)
            {
                string maDC = txttimkiemDC_DV.Text;
                dGViewDVDC.DataSource = DanCu_DichVuBLL.SearchDC_DV(maDC);
            }
            else
            {
                string madv = txttimkiemDC_DV.Text;
                dGViewDVDC.DataSource = DanCu_DichVuBLL.SearchDV(madv);
            }
           
        }
        private void radTKMaDC_CheckedChanged(object sender, EventArgs e)
        {
            if (txttimkiemDC_DV.Enabled == false)
            {
                txttimkiemDC_DV.Enabled = true;
            }
        }

        private void radTKMaDV_CheckedChanged(object sender, EventArgs e)
        {
            if (txttimkiemDC_DV.Enabled == false)
            {
                txttimkiemDC_DV.Enabled = true;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGViewDVDC.DataSource = DanCu_DichVuBLL.GetAllDC_DV();
            txttimkiemDC_DV.Clear();
            txttimkiemDC_DV.Enabled = false;
        }

        private void btnReportDCDV_Click(object sender, EventArgs e)
        {
            FormRPTheoDoiDC_DV rpDCDV = new FormRPTheoDoiDC_DV();
            rpDCDV.ShowDialog();
        }
    }
}
