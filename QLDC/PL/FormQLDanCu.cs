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
    public partial class FormQLDanCu : Form
    {
        public FormQLDanCu()
        {
            InitializeComponent();

            dGViewDanCu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGViewDanCu.MultiSelect = false;
            dGViewDanCu.ReadOnly = true;
            btnLuu.Enabled = false;
        }

        private DanCuDTO BuildDTO()
        {
            return new DanCuDTO(
                txtMaDc.Text,
                txtTenDC.Text,
                radNamDC.Checked ? "Nam" : "Nữ",
                dtPickerNgaySinhDC.Value,
                txtQueQuanDC.Text,
                txtMaCHDC.Text,
                0);
        }
        private bool checktextboxnull()
        {
            if (string.IsNullOrEmpty(txtMaDc.Text) || string.IsNullOrEmpty(txtTenDC.Text) || string.IsNullOrEmpty(txtQueQuanDC.Text)||
                string.IsNullOrEmpty(txtMaCHDC.Text))
            {
                return true;
            }
            return false;
        }
        private void EmptyFields()
        {
            txtMaDc.Text = "DC";
            txtTenDC.Text = "";
            radNamDC.Checked = true;
            radNuDC.Checked = false;
            dtPickerNgaySinhDC.Value = DateTime.Now;
            txtQueQuanDC.Text = "";
            txtMaCHDC.Text = "";
        }

        private void FormQLDanCu_Load(object sender, EventArgs e)
        {
            dGViewDanCu.DataSource = DanCuBLL.GetAllDanCu();
            dGViewDanCu.Columns[dGViewDanCu.ColumnCount - 1].Visible = false;
        }

        private void btnThemDC_Click(object sender, EventArgs e)
        {
            if (checktextboxnull())
            {
                MessageBox.Show($"Dữ liệu chưa được nhập đầy đủ");
            }
            else
            {
                if(DanCuBLL.CheckMaDC(txtMaDc.Text))
                {
                    MessageBox.Show($"Mã dân cu {txtMaDc.Text} đã tồn tại");
                    txtMaDc.Text = "DC";
                    return;
                }    
                DanCuDTO dc = BuildDTO();
                try
                {
                    DanCuBLL.AddDanCu(dc);
                    MessageBox.Show($"Thêm dân cư {dc.MaDC} thành công.");
                    dGViewDanCu.DataSource = DanCuBLL.GetAllDanCu();
                    EmptyFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Lỗi");
                }
            }
        }
        private void btnSuaDC_Click(object sender, EventArgs e)
        {
            if (dGViewDanCu.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewCellCollection cells = dGViewDanCu.SelectedRows[0].Cells;
            txtMaDc.Text = cells[0].Value.ToString();
            txtTenDC.Text = cells[1].Value.ToString();
            if (cells[2].Value.ToString().ToLower() == "nam")
            {
                radNamDC.Checked = true;
            }
            else { radNuDC.Checked = true; }
            dtPickerNgaySinhDC.Value = DateTime.Parse(cells[3].Value.ToString());
            txtQueQuanDC.Text = cells[4].Value.ToString();
            txtMaCHDC.Text = cells[5].Value.ToString();
            btnLuu.Enabled = true;
            txtMaDc.Enabled = false;
            btnThemDC.Enabled = false;
        }

        private void btnXoaDC_Click(object sender, EventArgs e)
        {
            string maDC = dGViewDanCu.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                DanCuBLL.DeleteDanCu(maDC);
                MessageBox.Show($"Xóa dân cư {maDC} thành công");
                dGViewDanCu.DataSource = DanCuBLL.GetAllDanCu();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }

        private void btnTimkiemDC_Click(object sender, EventArgs e)
        {
            string tenDC = txttimkiemDC.Text;
            dGViewDanCu.DataSource = DanCuBLL.SearchDC(tenDC);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanCuDTO dc = BuildDTO();
            try
            {
                DanCuBLL.UpdateDC(dc.MaDC, dc);
                MessageBox.Show($"Sửa dân cư {dc.MaDC} thành công");
                dGViewDanCu.DataSource = DanCuBLL.GetAllDanCu();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
            txtMaDc.Enabled = true;
            btnLuu.Enabled = false;
            btnThemDC.Enabled = true;
        }

        private void txtMaDc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar=Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void txtMaCHDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
