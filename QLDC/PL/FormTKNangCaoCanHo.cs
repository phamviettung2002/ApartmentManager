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
    public partial class FormTKNangCaoCanHo : Form
    {
        public FormTKNangCaoCanHo()
        {
            InitializeComponent();

            groupBox1.Enabled = false;
        }

        private void radTKCanHoGia_CheckedChanged(object sender, EventArgs e)
        {
            if (radTKCanHoGia.Checked)
            {
                groupBox1.Enabled = true;
                return;
            }
            groupBox1.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (radTKCanHoTrong.Checked)
                {
                    dataGridView1.DataSource = CanHoBLL.FindEmptyRooms();
                }
                if (radTKCanHoGia.Checked)
                {
                    int min = Convert.ToInt32(txtGiaMin.Text);
                    int max = Convert.ToInt32(txtGiaMax.Text);
                    dataGridView1.DataSource = CanHoBLL.SearchByGiaMinMax(min, max);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Lỗi");
            }
        }
    }
}
