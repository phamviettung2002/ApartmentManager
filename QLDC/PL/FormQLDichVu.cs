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
    public partial class FormQLDichVu : Form
    {
        public FormQLDichVu()
        {
            InitializeComponent();

            dGViewDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGViewDV.MultiSelect = false;
            dGViewDV.ReadOnly = true;
            btnLuu.Enabled = false;
        }

        private DichVuDTO BuildDTO()
        {
            return new DichVuDTO(
                txtMaDV.Text,
                txtTenDV.Text,
                Convert.ToInt32(txtDonGiaDV.Text),
                0);
        }

        private void EmptyFields()
        {
            txtMaDV.Text = "DV";
            txtTenDV.Text = "";
            txtDonGiaDV.Text = "";
        }
        private bool checktextboxnull()
        {
            if (string.IsNullOrEmpty(txtMaDV.Text) || string.IsNullOrEmpty(txtTenDV.Text) || string.IsNullOrEmpty(txtDonGiaDV.Text))
            {
                return true;
            }
            return false;
        }
        private void FormQLDichVu_Load(object sender, EventArgs e)
        {
            dGViewDV.DataSource = DichVuBLL.GetAllDichVu();
            dGViewDV.Columns[dGViewDV.ColumnCount - 1].Visible = false;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            
            if (checktextboxnull())
            {
                MessageBox.Show("Dữ liệu chưa được nhập đầy đủ");
                return;
            }
            if (DichVuBLL.CheckMaDV(txtMaDV.Text))
            {
                MessageBox.Show($"Mã Dịch Vụ {txtMaDV.Text} đã tồn tại");
                txtMaDV.Text = "DV";
                return;
            }
            DichVuDTO dv = BuildDTO();
            try
            {
                DichVuBLL.AddDichVu(dv);
                MessageBox.Show($"Thêm dịch vụ {dv.MaDV} thành công.");
                dGViewDV.DataSource = DichVuBLL.GetAllDichVu();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (dGViewDV.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewCellCollection cells = dGViewDV.SelectedRows[0].Cells;
            txtMaDV.Text = cells[0].Value.ToString();
            txtTenDV.Text = cells[1].Value.ToString();
            txtDonGiaDV.Text = cells[2].Value.ToString();
            txtMaDV.Enabled = false;
            btnLuu.Enabled = true;
            btnThemDV.Enabled = false;
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            string maDV = dGViewDV.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                DichVuBLL.DeleteDichVu(maDV);
                MessageBox.Show($"Xóa dịch vụ {maDV} thành công");
                dGViewDV.DataSource = DichVuBLL.GetAllDichVu();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }
        private void btnTimkiemDV_Click(object sender, EventArgs e)
        {
            string tenDV = txttimkiemDV.Text;
            dGViewDV.DataSource = DichVuBLL.SearchDichVu(tenDV);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DichVuDTO dv = BuildDTO();
            try
            {
                DichVuBLL.UpdateDichVu(dv.MaDV, dv);
                MessageBox.Show($"Sửa dịch vụ {dv.MaDV} thành công");
                dGViewDV.DataSource = DichVuBLL.GetAllDichVu();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
            btnLuu.Enabled = false;
            txtMaDV.Enabled = true;
            btnThemDV.Enabled = true;
        }
        private void txtMaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
