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
    public partial class FormDangKyDichVu : Form
    {
        string maDC = FormMain.TK.MaTK;

        public FormDangKyDichVu()
        {
            InitializeComponent();

            txtMaCH.Enabled = false;
            txtTenDC.Enabled = false;

            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.MultiSelect = false;
            dgvDichVu.ReadOnly = true;

            dgvDVCaNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDVCaNhan.MultiSelect = false;
            dgvDVCaNhan.ReadOnly = true;
        }

        private void FormDangKyDichVu_Load(object sender, EventArgs e)
        {
            dgvDichVu.DataSource = DichVuBLL.GetAllDichVu();
            dgvDVCaNhan.DataSource = DichVuBLL.GetByMaDC(maDC);

            dgvDichVu.Columns[dgvDichVu.ColumnCount - 1].Visible = false;
            dgvDVCaNhan.Columns[dgvDVCaNhan.ColumnCount - 1].Visible = false;

            DanCuDTO dc = DanCuBLL.LoadDC(maDC);
            txtMaCH.Text = dc.MaCH;
            txtTenDC.Text = dc.TenDC;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string maDV = dgvDichVu.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                DanCu_DichVuBLL.AddDC_DV(new DanCu_DichVuDTO(maDC, maDV, 0));
                dgvDVCaNhan.DataSource = DichVuBLL.GetByMaDC(maDC);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }

        private void btnHuyDichVu_Click(object sender, EventArgs e)
        {
            string maDV = dgvDVCaNhan.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                DanCu_DichVuBLL.DeleteDC_DV(maDC, maDV);
                dgvDVCaNhan.DataSource = DichVuBLL.GetByMaDC(maDC);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }
    }
}
