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

namespace QLDC.PL
{
    public partial class FormTKNangCaoDC_DV : Form
    {
        public FormTKNangCaoDC_DV()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DanCuBLL.GetDanCuWithNoDichVu();
            dataGridView2.Columns[dataGridView2.ColumnCount - 1].Visible = false;
        }
    }
}
