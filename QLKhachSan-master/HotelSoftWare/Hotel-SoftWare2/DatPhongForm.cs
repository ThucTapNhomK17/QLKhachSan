using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hotel_SoftWare2
{
    public partial class DatPhongForm : Form
    {
        public static string mapt;
        public static bool status;
        htEntities context = new htEntities();
        public DatPhongForm()
        {
            InitializeComponent();
        }

        private void DatPhongForm_Load(object sender, EventArgs e)
        {
            LockText();
            textBoxMaNV.Text = context.getIdEmpFrAcc(LoginForm.username, LoginForm.password).FirstOrDefault();
            showDsPhieuThue(dgvDSphieuThue);
            implementID();
            // textBoxMaKH.Text = listCustomer.maKH;
            mapt = lableIdPT.Text;

            comboBoxMKH.DisplayMember = "MaKH";
            comboBoxMKH.DataSource = context.getallCus();
            textBoxtenKH.DataBindings.Clear();
            textBoxtenKH.DataBindings.Add("Text", comboBoxMKH.DataSource, "TenKH");
            textBoxDiaChi.DataBindings.Clear();
            textBoxDiaChi.DataBindings.Add("Text", comboBoxMKH.DataSource, "DiaChi");
            textBoxsdt.DataBindings.Clear();
            textBoxsdt.DataBindings.Add("Text", comboBoxMKH.DataSource, "SDT");
            textBoxCMND.DataBindings.Clear();
            textBoxCMND.DataBindings.Add("Text", comboBoxMKH.DataSource, "SoCMND");
        }

        private void showDsPhieuThue(DataGridView dgv)
        {
            dgv.DataSource = context.getPhieuThue2();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void implementID()
        {
            int count = 0;
            //count = dgvDSphieuThue.Rows.Count;
            //string chuoi = "";
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(dgvDSphieuThue.Rows[count - 1].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi.Remove(0, 4));
            //if (chuoi2 + 1 < 10)
            //    lableIdPT.Text = "MPTP0" + (chuoi2 + 1).ToString();
            //else
            //    lableIdPT.Text = "MPTP" + (chuoi2 + 1).ToString();

            count = dgvDSphieuThue.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count >= 1)
            {
                chuoi = Convert.ToString(dgvDSphieuThue.Rows[count - 1].Cells[0].Value);
            }
            else
            {
                lableIdPT.Text = "MPTP00";
                chuoi = lableIdPT.Text;
            }
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 4));
            if (chuoi2 + 1 < 10)
            {
                lableIdPT.Text = "MPTP0" + (chuoi2 + 1).ToString();
            }
            else
            {
                lableIdPT.Text = "MPTP" + (chuoi2 + 1).ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormPhieuThue.Controls.Add(childForm);
            panelChildFormPhieuThue.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void showCus(DataGridView dgv)
        {
            dgv.DataSource = context.getallCus();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btntiep_Click(object sender, EventArgs e)
        {
            status = true;
            htEntities context = new htEntities();
            context.addPhieuThuePhong(lableIdPT.Text, textBoxNote.Text, comboBoxMKH.Text, textBoxMaNV.Text);
            try
            {
                DialogResult result = MessageBox.Show("Thêm phiếu thuê phòng thành công !!! Bạn có muốn thêm phòng cho khách hàng luôn?", "Thông báo", MessageBoxButtons.YesNo);
                context.SaveChanges();
                if (result == DialogResult.Yes)
                {
                    openChildForm(new ChiTietDatPhongForm());
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            openChildForm(new ChiTietDatPhongForm());
        }

        private void LockText()
        {
            textBoxtenKH.Enabled = textBoxCMND.Enabled = textBoxDiaChi.Enabled = textBoxsdt.Enabled = textBoxMaNV.Enabled = false;
        }
    }
}
