using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDC.DTO;
using QLDC.BLL;

namespace QLDC.PL
{
    public partial class FormThongTinCaNhan : Form
    {
        public FormThongTinCaNhan()
        {
            InitializeComponent();

            txtMaDc.Enabled = false;
            txtTenDC.Enabled = false;
            radNam.Enabled = false;
            radNu.Enabled = false;
            dtPickerNgaySinhDC.Enabled = false;
            txtQueQuanDC.Enabled = false;
            txtMaCH.Enabled = false;
            txtTangCH.Enabled = false;
            txtGiaCH.Enabled = false;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.MultiSelect = false;
            dgvDichVu.ReadOnly = true;
        }

        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            string maDC = FormMain.TK.MaTK;
            DanCuDTO dc = DanCuBLL.LoadDC(maDC);
            CanHoDTO ch = CanHoBLL.LoadCanHo(dc.MaCH);

            txtMaDc.Text = dc.MaDC;
            txtTenDC.Text = dc.TenDC;
            if (dc.GioiTinh.ToLower().Trim() == "nam")
            {
                radNam.Checked = true;
            }
            else { radNu.Checked = true; }
            dtPickerNgaySinhDC.Value = dc.NgaySinh;
            txtQueQuanDC.Text = dc.QueQuan;

            txtMaCH.Text = ch.MaCH;
            txtTangCH.Text = Convert.ToString(ch.TangLau);
            txtGiaCH.Text = Convert.ToString(ch.GiaCH);

            dgvDichVu.DataSource = DichVuBLL.GetByMaDC(maDC);
            dgvDichVu.Columns[dgvDichVu.ColumnCount - 1].Visible = false;
        }

        private void btnXuatHDDV_Click(object sender, EventArgs e)
        {
            string maDC = FormMain.TK.MaTK;
            DanCuDTO dc = DanCuBLL.LoadDC(maDC);
            FormRPXemHoaDonDV rpHDDV = new FormRPXemHoaDonDV(maDC, dc.TenDC, dc.MaCH);
            rpHDDV.ShowDialog();
        }
    }
}
