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
    public partial class FormQLCanHo : Form
    {
        public FormQLCanHo()
        {
            InitializeComponent();

            dGViewCanHo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGViewCanHo.MultiSelect = false;
            dGViewCanHo.ReadOnly = true;
            btnLuu.Enabled = false;
        }

        private CanHoDTO BuildDTO()
        {
            return new CanHoDTO(
                txtMaCH.Text,
                Convert.ToInt32(txtTangCH.Text),
                Convert.ToInt32(txtGiaCH.Text),
                0);
        }
        private bool checktextboxnull()
        {
            if (string.IsNullOrEmpty(txtMaCH.Text) || string.IsNullOrEmpty(txtTangCH.Text) || string.IsNullOrEmpty(txtGiaCH.Text))
            {
                return true;
            }
            return false;
        }
        private void EmptyFields()
        {
            txtMaCH.Text = "CH";
            txtTangCH.Text = "";
            txtGiaCH.Text = "";
        }

        private void FormCanHo_Load(object sender, EventArgs e)
        {
            dGViewCanHo.DataSource = CanHoBLL.GetAllCanHo();
            dGViewCanHo.Columns[3].Visible = false;
        }

        private void btnThemCanHo_Click(object sender, EventArgs e)
        {
            if(checktextboxnull())
            {
                MessageBox.Show("Dữ liệu chưa được nhập đầy đủ");
                return;
            }
            if (CanHoBLL.CheckMaCH(txtMaCH.Text))
            {
                MessageBox.Show($"Mã Căn Hộ {txtMaCH.Text} đã tồn tại");
                txtMaCH.Text = "CH";
                return;
            }
            CanHoDTO ch = BuildDTO();
            try
            {
                CanHoBLL.AddCanHo(ch);
                MessageBox.Show($"Thêm căn hộ {ch.MaCH} thành công.");
                dGViewCanHo.DataSource = CanHoBLL.GetAllCanHo();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }

        private void btnSuaCH_Click(object sender, EventArgs e)
        {
            if (dGViewCanHo.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewCellCollection cell = dGViewCanHo.SelectedRows[0].Cells;
            txtMaCH.Text = cell[0].Value.ToString();
            txtTangCH.Text = cell[1].Value.ToString();
            txtGiaCH.Text = cell[2].Value.ToString();
            txtMaCH.Enabled = false;
            btnLuu.Enabled = true;
            btnThemCanHo.Enabled = false;
        }

        private void btnXoaCH_Click(object sender, EventArgs e)
        {
            string maCH = dGViewCanHo.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                CanHoBLL.DeleteCanHo(maCH);
                MessageBox.Show($"Xóa căn hộ {maCH} thành công");
                dGViewCanHo.DataSource = CanHoBLL.GetAllCanHo();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }

        private void btnTimkiemCH_Click(object sender, EventArgs e)
        {
            string maCH = txttimkiemCH.Text;
            dGViewCanHo.DataSource = CanHoBLL.SearchCanHo(maCH);
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            CanHoDTO ch = BuildDTO();
            try
            {
                CanHoBLL.UpdateCanHo(ch.MaCH, ch);
                MessageBox.Show($"Sửa căn hộ {ch.MaCH} thành công");
                dGViewCanHo.DataSource = CanHoBLL.GetAllCanHo();
                EmptyFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
            txtMaCH.Enabled = true;
            btnLuu.Enabled = false;
            btnThemCanHo.Enabled = true;
        }

        private void txtMaCH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
