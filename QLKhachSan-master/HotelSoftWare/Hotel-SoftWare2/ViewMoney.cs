using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SoftWare2
{
    public partial class ViewMoney : Form
    {
        htEntities context = new htEntities();
        public ViewMoney()
        {
            InitializeComponent();
        }

        private void showMoney(DataGridView dgv)
        {
            dgv.DataSource = context.ViewDoanhThuTheoSoTienNhap(dtpNgayVao.Value, dtpNgaydi.Value, textBox1.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            showMoney(dgvXemTienKhiNhap);
        }
    }
}
