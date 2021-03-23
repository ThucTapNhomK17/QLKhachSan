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
    public partial class ServiceRoomForm : Form
    {
        htEntities DVRoom = new htEntities();
        public ServiceRoomForm()
        {
            InitializeComponent();
        }

        private void ShowDVRoom(DataGridView dgv)
        {
            dgv.DataSource = DVRoom.DsSDDV();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ServiceRoomForm_Load(object sender, EventArgs e)
        {
            ShowDVRoom(dvgPhieuSDDV);
            comboPhongsdDV();
            ComboboxTendv();
            serviceRoomID();
            lockText();
        }

        private void serviceRoomID()
        {
            int count = 0;
            count = dvgPhieuSDDV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count >= 1)
            {
                chuoi = Convert.ToString(dvgPhieuSDDV.Rows[count - 1].Cells[0].Value);
            }
            else
            {
                labelIdSD.Text = "MSD00";
                chuoi = labelIdSD.Text;
            }
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
             if (chuoi2 + 1 < 10)
            { 
                labelIdSD.Text = "MSD0" + (chuoi2 + 1).ToString();
            }
            else
            {
                labelIdSD.Text = "MSD" + (chuoi2 + 1).ToString();
            }
        }

        private void comboPhongsdDV()
        {
            comboBoxPhongsdDV.DataSource = DVRoom.DSTenPhongSDDV();
        }

        private void dgvPhieuSDDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = iconButtonXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dvgPhieuSDDV.Rows[e.RowIndex];
                labelIdSD.Text = row.Cells[0].Value.ToString();
                dateTimePickerNgayTT.Text = row.Cells[1].Value.ToString();
                textBoxSL.Text = row.Cells[2].Value.ToString();
                textBoxGiaTien.Text = row.Cells[3].Value.ToString();
                textBoxMaDV.Text = row.Cells[4].Value.ToString();
                lableIdCTPT.Text = row.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void lockText()
        {
            textBoxMaDV.Enabled = comboBoxTen.Enabled = textBoxGiaTien.Enabled = textBoxSL.Enabled = false;
            btnSua.Enabled = iconButtonXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxMaDV.Enabled = comboBoxTen.Enabled = textBoxGiaTien.Enabled = textBoxSL.Enabled = true;
        }

        bool status;
        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                DVRoom.addServiceRoom(labelIdSD.Text, Convert.ToDateTime(dateTimePickerNgayTT.Value), Convert.ToByte(textBoxSL.Text), Convert.ToInt32(textBoxGiaTien.Text), textBoxMaDV.Text, lableIdCTPT.Text);
                try
                {
                    MessageBox.Show("Thêm thông tin phiếu sử dụng dịch vụ thành công ");
                    DVRoom.SaveChanges();
                    ShowDVRoom(dvgPhieuSDDV);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DVRoom.UpdateServiceRoom(labelIdSD.Text, Convert.ToDateTime(dateTimePickerNgayTT.Value), Convert.ToByte(textBoxSL.Text), Convert.ToInt32(textBoxGiaTien.Text), textBoxMaDV.Text, lableIdCTPT.Text);
                try
                {
                    MessageBox.Show("Cập nhật thông tin phiếu sử dụng dịch vụ thành công!");
                    DVRoom.SaveChanges();
                    ShowDVRoom(dvgPhieuSDDV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
            serviceRoomID();
        }
        private void clearText()
        {
            dateTimePickerNgayTT.CustomFormat = labelIdSD.Text = lableIdCTPT.Text = textBoxMaDV.Text = textBoxGiaTien.Text = comboBoxTen.Text = textBoxSL.Text = "";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa phiếu sử dụng dịch vụ này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DVRoom.delServiceRoom(labelIdSD.Text);
                try
                {
                    MessageBox.Show("Xóa phiếu sử dụng dịch vụ thành công");
                    DVRoom.SaveChanges();
                    ShowDVRoom(dvgPhieuSDDV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                iconButtonXoa.Enabled = false;
                labelIdSD.Text = "";
            }
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            serviceRoomID();
            status = true;
            unlockText();
            btnSua.Enabled = textBoxMaDV.Enabled = false;
        }

        private void showGiaTien()
        {
            if (textBoxSL.Text == "" || textBoxMaDV.Text == "")
            {
                textBoxGiaTien.Text = "";
            }
            else
            {
                textBoxGiaTien.Text = DVRoom.GiaTienDV(textBoxMaDV.Text, Convert.ToByte(textBoxSL.Text)).FirstOrDefault().ToString();
            }

        }

        private void textBoxSL_TextChanged(object sender, EventArgs e)
        {
            showGiaTien();
        }

        private void comboBoxPhongsdDV_TextChanged(object sender, EventArgs e)
        {
            htEntities DVRoom = new htEntities();
            lableIdCTPT.Text = DVRoom.TKidCTPTofRoom(comboBoxPhongsdDV.Text).FirstOrDefault().ToString();
        }

        private void comboBoxTenDV_TextChanged(object sender, EventArgs e)
        {
            textBoxMaDV.Text = DVRoom.getMaDVtoTenDV(comboBoxTen.Text).FirstOrDefault();

        }

        private void ComboboxTendv()
        {
            var getTenDVList = from DichVu in DVRoom.DichVus
                               select DichVu;
            comboBoxTen.DataSource = getTenDVList.ToList();
            comboBoxTen.DisplayMember = "TenDV";
        }

        private void textBoxMaDV_TextChanged(object sender, EventArgs e)
        {
            showGiaTien();
        }
    }
}
