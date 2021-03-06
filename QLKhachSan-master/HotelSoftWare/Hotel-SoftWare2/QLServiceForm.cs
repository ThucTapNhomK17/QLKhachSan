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
    public partial class QLServiceForm : Form
    {
        htEntities ser = new htEntities();
        public QLServiceForm()
        {
            InitializeComponent();
        }

        private void ShowSer(DataGridView dgv)
        {
            dgv.DataSource = ser.DSDichVu();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            serviceID();
            unlockText();
            status = true;
            clearText();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLServiceForm_Load(object sender, EventArgs e)
        {
            ShowSer(dgvServices);
            SerCombobox();
            lockText();
        }

        private void serviceID()
        {
            //int count = 0;
            //count = dgvServices.Rows.Count;
            //string chuoi = "";
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(dgvServices.Rows[count - 1].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            //if (chuoi2 + 1 < 10)
            //    tbMa.Text = "MDV0" + (chuoi2 + 1).ToString();
            //else
            //    tbMa.Text = "MDV" + (chuoi2 + 1).ToString();

            int count = 0;
            count = dgvServices.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count >= 1)
            {
                chuoi = Convert.ToString(dgvServices.Rows[count - 1].Cells[0].Value);
            }
            else
            {
                tbMa.Text = "MDV00";
                chuoi = tbMa.Text;
            }
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            if (chuoi2 + 1 < 10)
            {
                tbMa.Text = "MDV0" + (chuoi2 + 1).ToString();
            }
            else
            {
                tbMa.Text = "MDV" + (chuoi2 + 1).ToString();
            }
        }

        bool status;

        private void clearText()
        {
            tbTen.Text = tbGia.Text = comboBox1.Text = textBoxTimKiem.Text = "";
        }

        private void iconButtonSave_Click_1(object sender, EventArgs e)
        {
            if (status == true)
            {
                ser.addSer(tbMa.Text, tbTen.Text, Convert.ToInt32(tbGia.Text), comboBox1.Text);
                try
                {
                    MessageBox.Show("Thêm Dịch Vụ Thành Công");
                    ser.SaveChanges();
                    ShowSer(dgvServices);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                ser.updateSer(tbMa.Text, tbTen.Text, Convert.ToInt32(tbGia.Text), comboBox1.Text);
                try
                {
                    MessageBox.Show("Cập Nhật Dịch Vụ Thành Công!");
                    ser.SaveChanges();
                    ShowSer(dgvServices);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
            serviceID();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
            tbMa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Dịch Vụ Này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ser.delSer(tbMa.Text);
                try
                {
                    MessageBox.Show("Xóa Dịch Vụ Thành Công");
                    ser.SaveChanges();
                    ShowSer(dgvServices);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                btnXoa.Enabled = false;
                tbMa.Text = "";
            }
        }
        private void lockText()
        {
            tbMa.Enabled = tbTen.Enabled = tbGia.Enabled = comboBox1.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnTimKiem.Enabled = false;
        }

        private void unlockText()
        {
            tbTen.Enabled = tbGia.Enabled = comboBox1.Enabled = true;
        }


        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvServices.Rows[e.RowIndex];
                tbMa.Text = row.Cells[0].Value.ToString();
                tbTen.Text = row.Cells[1].Value.ToString();
                tbGia.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvServices.DataSource = ser.TKService(textBoxTimKiem.Text);
            if (textBoxTimKiem.Text == "")
            {
                dgvServices.DataSource = ser.DSDichVu();
            }
            clearText();
            btnTimKiem.Enabled = false;
        }
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        private void SerCombobox()
        {
            var getIdMdvList = from LoaiDichVu in ser.LoaiDichVus
                               select LoaiDichVu;
            comboBox1.DataSource = getIdMdvList.ToList();
            comboBox1.DisplayMember = "MaLoaiDV";
        }
    }
}
