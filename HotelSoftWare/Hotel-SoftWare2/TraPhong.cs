using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SoftWare2
{
    public partial class TraPhong : Form
    {
        htEntities context = new htEntities();
        public TraPhong()
        {
            InitializeComponent();
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {
            
            comboBoxMKH.DisplayMember = "MaKH";
            comboBoxMKH.DataSource = context.getallCus();
            textBoxtenKH.DataBindings.Add("Text", comboBoxMKH.DataSource, "TenKH");
            textBoxDiaChi.DataBindings.Clear();
            textBoxDiaChi.DataBindings.Add("Text", comboBoxMKH.DataSource, "DiaChi");
            textBoxsdt.DataBindings.Clear();
            textBoxsdt.DataBindings.Add("Text", comboBoxMKH.DataSource, "SDT");
            textBoxCMND.DataBindings.Clear();
            textBoxCMND.DataBindings.Add("Text", comboBoxMKH.DataSource, "SoCMND");
            showFreeRoom(dgvfreeRoom);
        }

        private void comboBoxMKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPhongThue(dgvRentedRoom);

        }

        private void showPhongThue(DataGridView dgv)
        {
            dgv.DataSource = context.Phong_Thue(comboBoxMKH.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void dgvRentedRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvRentedRoom.Rows[e.RowIndex];
            textBoxMaPhong.DataBindings.Clear();
            textBoxMaPhong.Text = row.Cells[0].Value.ToString();
            textBoxMaCTPT.Text = row.Cells[3].Value.ToString();
        }
        private void showFreeRoom(DataGridView dgv)
        {

            dgv.DataSource = context.getFreeRoom();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void iconButtontraPhong_Click(object sender, EventArgs e)
        {
            context.changeStatusRoom(textBoxMaPhong.Text);
            context.updateNgayRa(textBoxMaCTPT.Text, ngayra.Value);
            context.SaveChanges();
            showPhongThue(dgvRentedRoom);
            showFreeRoom(dgvfreeRoom); 
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
