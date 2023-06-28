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
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();

            dGViewNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGViewNhanVien.MultiSelect = false;
            dGViewNhanVien.ReadOnly = true;
            btnLuu.Enabled = false;
        }

        private NhanVienDTO BuildDTO()
        {
            return new NhanVienDTO(
                txtMaNV.Text,
                txtTenNV.Text,
                radNamNV.Checked ? "Nam" : "Nữ",
                dtPickerNgaySinhNV.Value,
                txtDienThoaiNV.Text,
                txtMaCVNV.Text,
                0);
        }

        private void EmptyFields()
        {
            txtMaNV.Text = "NV";
            txtTenNV.Text = "";
            radNamNV.Checked = true;
            radNuNV.Checked = false;
            dtPickerNgaySinhNV.Value = DateTime.Now;
            txtDienThoaiNV.Text = "";
            txtMaCVNV.Text = "";
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            dGViewNhanVien.DataSource = NhanVienBLL.All();
            dGViewNhanVien.Columns[dGViewNhanVien.ColumnCount - 1].Visible = false;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string maNV = dGViewNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                NhanVienBLL.Delete(maNV);
                MessageBox.Show($"Xóa nhân viên {maNV} thành công");
                dGViewNhanVien.DataSource = NhanVienBLL.All();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }
        private bool checktextboxnull()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtDienThoaiNV.Text)
                || string.IsNullOrEmpty(txtMaCVNV.Text))
            {
                return true;
            }
            return false;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (checktextboxnull())
            {
                MessageBox.Show("Dữ liệu chưa được nhập đầy đủ");
                return;
            }
            if (NhanVienBLL.CheckMaNV(txtMaNV.Text))
            {
                MessageBox.Show($"Mã Nhân Viên {txtMaNV.Text} đã tồn tại");
                txtMaNV.Text = "NV";
                return;
            }
            NhanVienDTO nv = BuildDTO();
            try
            {
                NhanVienBLL.Insert(nv);
                MessageBox.Show($"Thêm nhân viên {nv.MaNV} thành công.");
                dGViewNhanVien.DataSource = NhanVienBLL.All();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (dGViewNhanVien.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewCellCollection cells = dGViewNhanVien.SelectedRows[0].Cells;
            txtMaNV.Text = cells[0].Value.ToString();
            txtTenNV.Text = cells[1].Value.ToString();
            if (cells[2].Value.ToString().ToLower() == "nam")
            {
                radNamNV.Checked = true;
            }
            else { radNuNV.Checked = true; }
            dtPickerNgaySinhNV.Value = DateTime.Parse(cells[3].Value.ToString());
            txtDienThoaiNV.Text = cells[4].Value.ToString();
            txtMaCVNV.Text = cells[5].Value.ToString();
            txtMaNV.Enabled = false;
            btnLuu.Enabled = true;
            btnThemNV.Enabled = false;
        }

        private void btnTimkiemNV_Click(object sender, EventArgs e)
        {
            string tenNV = txttimkiemNV.Text;
            dGViewNhanVien.DataSource = NhanVienBLL.SearchByName(tenNV);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = BuildDTO();
            try
            {
                NhanVienBLL.Update(nv.MaNV, nv);
                MessageBox.Show($"Sửa nhân viên {nv.MaNV} thành công");
                dGViewNhanVien.DataSource = NhanVienBLL.All();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
            txtMaNV.Enabled = true;
            btnLuu.Enabled = false;
            btnThemNV.Enabled = true;
        }
        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void btnRPNV_Click(object sender, EventArgs e)
        {
            FormRPNhanVien rpNV = new FormRPNhanVien();
            rpNV.ShowDialog();
        }
    }
}
