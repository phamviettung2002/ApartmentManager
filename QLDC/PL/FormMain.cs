using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDC.PL;
using QLDC.DTO;

namespace QLDC.PL
{
    public partial class FormMain : Form
    {
        public static TaiKhoanDTO TK = new TaiKhoanDTO();

        public FormMain()
        {
            InitializeComponent();

            menuItemDanCu.Enabled = false;
            menuItemQuanLy.Enabled = false;
            menuItemLogout.Enabled = false;
            menuTextBox.Visible = false;
            menuTextBox.Enabled = false;
            this.MaximizeBox = false;
        }

        private void CloseChildForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }

        private void menuItemLoginSignup_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.LoginOK += loginOKHandler;
            this.Controls.Add(dn);
        }

        private void loginOKHandler(object sender, LoginOKEventArgs e)
        {
            TK.MaTK = e.MaTK;
            TK.MatKhau = e.MK;
            menuItemLogout.Enabled = true;
            menuItemLoginSignup.Enabled = false;
            menuTextBox.Visible = true;
            if (TK.MaTK.StartsWith("NV"))
            {
                menuItemQuanLy.Enabled = true;
            }
            else { menuItemDanCu.Enabled = true; }
            menuTextBox.Text = $"Xin chào, {TK.MaTK}";
        }

        private void menuItemLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                CloseChildForms();
                TK = new TaiKhoanDTO();
                menuItemLogout.Enabled = false;
                menuItemLoginSignup.Enabled = true;
                menuTextBox.Visible = false;
                menuItemQuanLy.Enabled = false;
                menuItemDanCu.Enabled = false;
            }
        }

        private void OpenChildForm(Form frm)
        {
            CloseChildForms();
            frm.MdiParent = this;
            frm.Show();
        }

        private void XEMTTCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormThongTinCaNhan());
        }

        private void menuItemDichVu_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormDangKyDichVu());
        }

        private void QLDANCUToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormQLDanCu());
        }

        private void QLCANHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormQLCanHo());
        }

        private void QLDICHVUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormQLDichVu());
        }

        private void QLNHANVIENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormQLNhanVien());
        }

        private void QLDC_DVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormQLDC_DV());
        }

        private void menuItemAdvSearchDCDV_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormTKNangCaoDC_DV());
        }

        private void menuItemAdvSearchCH_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            OpenChildForm(new FormTKNangCaoCanHo());
        }
    }
}
