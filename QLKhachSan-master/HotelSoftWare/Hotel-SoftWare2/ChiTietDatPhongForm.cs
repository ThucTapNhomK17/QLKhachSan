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
    public partial class ChiTietDatPhongForm : Form
    {
        private static string maphongSua;
        htEntities context = new htEntities();
        public ChiTietDatPhongForm()
        {
            InitializeComponent();
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    context.changeStatusRoom(textBoxMaPhong.Text);
        //    //  try
        //    //  {
        //    MessageBox.Show("Xoa phong nay?");
        //    context.SaveChanges();
        //    showFreeRoom(dgvFreeRoom);

        //    //  }
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //}
        //}


        private void showFreeRoom(DataGridView dgv)
        {

            dgv.DataSource = context.getFreeRoom();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void showCTPT(DataGridView dgv)
        {
            dgv.DataSource = context.getAll_CTPT();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void ChiTietDatPhongForm_Load(object sender, EventArgs e)
        {
            if(DatPhongForm.status == true)
            {
                labelIdPT.Text = DatPhongForm.mapt;
            }
            else
            {
                labelIdPT.Text = "...";

            }
            showFreeRoom(dgvFreeRoom);
            showCTPT(dgvDSCTPT);
            lockText();
            btnSua.Enabled = false;
            implementID();
        }

        private void dgvDSCTPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSCTPT.Rows[e.RowIndex];
                lableIdCTPT.Text = row.Cells[0].Value.ToString();
                dtpNgayVao.Text = row.Cells[1].Value.ToString();

                textBoxSoNguoi.Text = row.Cells[3].Value.ToString();
                comboBoxhtt.Text = row.Cells[2].Value.ToString();
                textBoxMaPhong.Text = row.Cells[4].Value.ToString();
                labelIdPT.Text = row.Cells[5].Value.ToString();
                maphongSua = row.Cells[4].Value.ToString();
            }
            catch
            {

            }


        }

        private void lockText()
        {
            textBoxSoNguoi.Enabled = comboBoxhtt.Enabled = dtpNgayVao.Enabled = textBoxMaPhong.Enabled = false;
        }

        private void unlockText()
        {
            textBoxSoNguoi.Enabled = comboBoxhtt.Enabled = dtpNgayVao.Enabled = textBoxMaPhong.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
        }

        bool status;
        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxhtt.Text == "Online")
            {
                comboBoxhtt.Text = "True";
            }
            else comboBoxhtt.Text = "False";
            context.changeStatusRoom(textBoxMaPhong.Text);
            if (status == true)
            {
                context.add_CTPT(lableIdCTPT.Text, dtpNgayVao.Value, Convert.ToBoolean(comboBoxhtt.Text), Convert.ToByte(textBoxSoNguoi.Text), textBoxMaPhong.Text, labelIdPT.Text);
                try
                {
                    MessageBox.Show("Them ctpt thanh cong");
                    context.SaveChanges();
                    showFreeRoom(dgvFreeRoom);
                    showCTPT(dgvDSCTPT);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                context.update_CTPT(lableIdCTPT.Text, dtpNgayVao.Value, Convert.ToBoolean(comboBoxhtt.Text), Convert.ToByte(textBoxSoNguoi.Text), textBoxMaPhong.Text, labelIdPT.Text);
                context.changeStatusRoom(maphongSua);
                try
                {
                    MessageBox.Show("cap nhat chi tiet phieu thue thanh cong");
                    context.SaveChanges();
                    showCTPT(dgvDSCTPT);
                    showFreeRoom(dgvFreeRoom);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            implementID();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = true;
            unlockText();

        }

        private void implementID()
        {
            int count = 0;
            //count = dgvDSCTPT.Rows.Count;
            //string chuoi = "";
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(dgvDSCTPT.Rows[count - 1].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi.Remove(0, 5));
            //if (chuoi2 + 1 < 10)
            //    lableIdCTPT.Text = "MCTPT0" + (chuoi2 + 1).ToString();
            //else
            //    lableIdCTPT.Text = "MCTPT" + (chuoi2 + 1).ToString();

            count = dgvDSCTPT.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count >= 1)
            {
                chuoi = Convert.ToString(dgvDSCTPT.Rows[count - 1].Cells[0].Value);
            }
            else
            {
                lableIdCTPT.Text = "MCTPT00";
                chuoi = lableIdCTPT.Text;
            }
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 5));
            if (chuoi2 + 1 < 10)
            {
                lableIdCTPT.Text = "MCTPT0" + (chuoi2 + 1).ToString();
            }
            else
            {
                lableIdCTPT.Text = "MCTPT" + (chuoi2 + 1).ToString();
            }
        }

        private void clearText()
        {
            lableIdCTPT.Text = dtpNgayVao.Text = textBoxSoNguoi.Text = textBoxMaPhong.Text = comboBoxhtt.Text = "";
        }

        private void dgvFreeRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvFreeRoom.Rows[e.RowIndex];
                textBoxMaPhong.Text = row.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showCTPT_Search(dgvDSCTPT);
        }

        private void showCTPT_Search(DataGridView dgv)
        {
            if (textBoxMptSearchMaPT.Text == "" && textBoxsearchMaCTPT.Text == "" && textBoxsearchMaPhong.Text == "")
            {
                showCTPT(dgvDSCTPT);
            }
            else
            {
                if (textBoxsearchMaCTPT.Text == "" && textBoxsearchMaPhong.Text == "")
                { dgv.DataSource = context.getCTPT_FrIdPT(textBoxMptSearchMaPT.Text); }
                if (textBoxMptSearchMaPT.Text == "" && textBoxsearchMaPhong.Text == "")
                { dgv.DataSource = context.Search_MaCtpt(textBoxsearchMaCTPT.Text); }
                if (textBoxMptSearchMaPT.Text == "" && textBoxsearchMaCTPT.Text == "")
                { dgv.DataSource = context.Search_MaPhong(textBoxsearchMaPhong.Text); }

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


        private void iconButtonhuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy phòng thành công");
            context.delCTPT(lableIdCTPT.Text);
            context.changeStatusRoom(textBoxMaPhong.Text);
            context.SaveChanges();
            showFreeRoom(dgvFreeRoom);
            showCTPT(dgvDSCTPT);
        }
    }
}
