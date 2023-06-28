using QLDC;
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
    public partial class DangNhap : UserControl
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string maTK = txttaikhoan.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            if (TaiKhoanBLL.Authenticate(maTK, mk))
            {
                MessageBox.Show("Đăng nhập thành công");
                LoginOK.Invoke(this, new LoginOKEventArgs(maTK, mk));
                this.Hide();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string maTK = txttaikhoan.Text;
            string mk = txtMatkhau.Text;

            try
            {
                TaiKhoanBLL.Insert(maTK, mk);
                MessageBox.Show($"Đăng ký thành công tài khoản {maTK}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }

        public event EventHandler<LoginOKEventArgs> LoginOK;
    }
}

public class LoginOKEventArgs : EventArgs
{
    public string MaTK;
    public string MK;

    public LoginOKEventArgs(string maTK, string mk)
    {
        MaTK = maTK;
        MK = mk;
    }
}
