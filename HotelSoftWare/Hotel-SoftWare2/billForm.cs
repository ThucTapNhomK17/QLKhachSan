using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Hotel_SoftWare2
{
    public partial class billForm : Form
    {
        ReportDataSource rs = new ReportDataSource();
        ReportDataSource rs2 = new ReportDataSource();
        public static string idBill, Date, maKH, hoten, soCMND, diaChi, sdt, nvLap, tienPhong, tienDV, tongTien, ghiChu, httt;
        //public static DataGridView dgvDV, dgvTP;
        public billForm()
        {
            InitializeComponent();
        }

        //private void FillComboboxMPT()
        //{
        //    htEntities context = new htEntities();
        //    var getIdMptList = from PhieuThuePhong in context.PhieuThuePhongs
        //                       select PhieuThuePhong;
        //    comboBoxMaPT.DataSource = getIdMptList.ToList();
        //    comboBoxMaPT.DisplayMember = "MaPhieuThuePhong";
            //comboBoxMaPT.ValueMember = "MaSD";
            //    comboBoxMaPT.Items.Add("select one");
            //    foreach (var item in getIdMptList)
            //    {
            //        comboBoxMaPT.Items.Add(Contains(item));
            //    }
            //}
        //}

        private void FillComboboxHTTT()
        {
            htEntities context = new htEntities();
            comboBoxHTTT.DataSource = context.getHTTT();
        }

        private void textBoxSoDT_Enter(object sender, EventArgs e)
        {
            if(textBoxMaPhong.Text=="Nhập mã phòng")
            {
                textBoxMaPhong.Text = "";
                textBoxMaPhong.ForeColor = Color.Black;
            }
        }

        private void dgvListBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvListBill.Rows[e.RowIndex];
            labelIdHD.Text = row.Cells[0].Value.ToString();
            textBoxMaPhieuThue.Text = row.Cells[7].Value.ToString();
            comboBoxHTTT.Text = row.Cells[4].Value.ToString();
            tabControlBill.SelectedTab = tabPageTaoHoaDon;
            btncreateBill.Text = "In Hóa Đơn";
        }

        private void textBoxMaPhong_Leave(object sender, EventArgs e)
        {
            if (textBoxMaPhong.Text == "")
            {
                textBoxMaPhong.Text = "Nhập mã phòng";
                textBoxMaPhong.ForeColor = Color.DarkGray;
            }
        }

        private void comboBoxHTTT_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxHTTT.Text == "Thẻ")
            {
                labelMaHTTT.Text = "MHTTT01";
            }
            else
            {
                labelMaHTTT.Text = "MHTTT02";
            }
        }

        //private Tuple<string,string,string,string,string,string> para(KhachHang model, NhanVien model2)
        //{
        //    htEntities context = new htEntities();

        //    SqlParameter[] idparam = {
        //                               new SqlParameter{ ParameterName = "@maphieuthue", Value = textBoxMaPhieuThue.Text },
        //                               new SqlParameter{ ParameterName = "@MaKH", Value = model.MaKH },
        //                               new SqlParameter{ ParameterName = "@tenkh", Value = model.TenKH },
        //                               new SqlParameter{ ParameterName = "@soCMND", Value = model.SoCMND },
        //                               new SqlParameter{ ParameterName = "@diachi", Value = model.DiaChi },
        //                               new SqlParameter{ ParameterName = "@sdt", Value = model.SDT },
        //                               new SqlParameter{ ParameterName = "@tennv", Value = model2.HoTen },
        //                              };
        //    idparam[1].Direction = idparam[2].Direction = idparam[3].Direction
        //       = idparam[4].Direction = idparam[5].Direction = idparam[6].Direction = System.Data.ParameterDirection.Output;
        //    context.Database.ExecuteSqlCommand("getCusFrPhieuThue1 @maphieuthue, @MaKH, @tenkh, @soCMND, @diachi, @sdt, @tennv", idparam);
        //    labelmaKH.Text = idparam[1].Value.ToString();
        //    labeltenKH.Text = idparam[2].Value.ToString();
        //    labelsoCMND.Text = idparam[3].Value.ToString();
        //    labelDiaChi.Text = idparam[4].Value.ToString();
        //    labelSDT.Text = idparam[5].Value.ToString();
        //    labelnvLap.Text = idparam[6].Value.ToString();
        //    return Tuple.Create(labelmaKH.Text, labeltenKH.Text, labelsoCMND.Text, labelDiaChi.Text, labelSDT.Text, labelnvLap.Text);
        //}

        private void textBoxMaPhieuThue_TextChanged(object sender, EventArgs e)
        {
            showtienphongDetail(dgvTienPhongDetail);
            showtienDvDetail(dgvTienDvDetail);
            showTien();
            showInforCus();
        }

        private void showInforCus()
        {
            htEntities context = new htEntities();

            ObjectParameter MaKH = new ObjectParameter("MaKH", typeof(string));
            ObjectParameter tenkh = new ObjectParameter("tenkh", typeof(string));
            ObjectParameter soCMND = new ObjectParameter("soCMND", typeof(string));
            ObjectParameter diachi = new ObjectParameter("diachi", typeof(string));
            ObjectParameter sdt = new ObjectParameter("sdt", typeof(string));
            ObjectParameter tennv = new ObjectParameter("tennv", typeof(string));

            context.getCusFrPhieuThue3(textBoxMaPhieuThue.Text, MaKH, tenkh, soCMND, diachi, sdt, tennv);

            labelmaKH.Text = MaKH.Value.ToString();
            labeltenKH.Text = tenkh.Value.ToString();
            labelsoCMND.Text = soCMND.Value.ToString();
            labelDiaChi.Text = diachi.Value.ToString();
            labelSDT.Text = sdt.Value.ToString();
            
            labelnvLap.Text = tennv.Value.ToString();
            if(labelnvLap.Text == "")
            {
                labelnvLap.Text = "Nhân viên đã nghỉ";
            }
        }
        private void billForm_Load(object sender, EventArgs e)
        {
            //FillComboboxMPT();
            FillComboboxHTTT();
            showListBill(dgvListBill);
            implementID();
        }

        private void showtienphongDetail(DataGridView dgv)
        {
            htEntities context = new htEntities();
            dgv.DataSource = context.tienphongDetail(textBoxMaPhieuThue.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void showtienDvDetail(DataGridView dgv)
        {
            htEntities context = new htEntities();
            dgv.DataSource = context.tienDvDetail(textBoxMaPhieuThue.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            htEntities context = new htEntities();
            if(textBoxMaPhong.Text != "Nhập mã phòng")
            {
                textBoxMaPhieuThue.Text = context.getIdPTFromMaPhong(textBoxMaPhong.Text).FirstOrDefault().ToString();
                btncreateBill.Text = "Tạo Hóa Đơn";
            }
            else 
            {
                MessageBox.Show("Bạn chưa nhập mã phòng");
            }
            implementID();
        }

        private void showTien()
        {
            int sumtienDV = 0, sumtienPhong = 0, i;
            for (i = 0; i < dgvTienDvDetail.Rows.Count; i++)
            {
                sumtienDV += Convert.ToInt32(dgvTienDvDetail.Rows[i].Cells[4].Value);
            }

            for (i = 0; i < dgvTienPhongDetail.Rows.Count; i++)
            {
                sumtienPhong += Convert.ToInt32(dgvTienPhongDetail.Rows[i].Cells[4].Value);
            }

            labelTDV.Text = sumtienDV.ToString();
            labelTP.Text = sumtienPhong.ToString();
            labeltongT.Text = (sumtienDV + sumtienPhong).ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maphieuthue = "";
            for (int i = 0; i< dgvListBill.Rows.Count; i++)
            {
                maphieuthue = dgvListBill.Rows[i].Cells[7].Value.ToString();
            }
           
            htEntities context = new htEntities();
            if(btncreateBill.Text == "Tạo Hóa Đơn")
            {
                if (textBoxMaPhieuThue.Text != maphieuthue)
                {
                    context.creatBill(labelIdHD.Text, Convert.ToInt32(labelTP.Text), Convert.ToInt32(labelTDV.Text), Convert.ToInt32(labeltongT.Text), dateTimePickerNgayTT.Value, textBoxghiChu.Text, textBoxMaPhieuThue.Text, labelMaHTTT.Text);
                    try
                    {
                        DialogResult result = MessageBox.Show("Tạo hóa đơn thành công, bạn có muốn in hóa đơn hay không?", "Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            passData();
                            showTableinReport();
                            showListBill(dgvListBill);
                            //ExportBill asd = new ExportBill();
                            //asd.Show();
                        }
                        else if (result == DialogResult.No)
                        {

                        }
                        comboBoxHTTT.Text = "";
                        //btncreateBill.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("phiếu thuê phòng này đã được tạo hóa đơn!!!");
                }
            }
            else if(btncreateBill.Text == "In Hóa Đơn")
            {
                passData();
                showTableinReport();
            }
        }

        private void showListBill(DataGridView dgv)
        {
            htEntities context = new htEntities();
            dgv.DataSource = context.getlistBill();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void implementID()
        {
            int count = 0;
            //count = dgvListBill.Rows.Count;
            //string chuoi = "";
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(dgvListBill.Rows[count - 1].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            //if (chuoi2 + 1 < 10)
            //    labelIdHD.Text = "MHD0" + (chuoi2 + 1).ToString();
            //else
            //    labelIdHD.Text = "MHD" + (chuoi2 + 1).ToString();

            count = dgvListBill.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count >= 1)
            {
                chuoi = Convert.ToString(dgvListBill.Rows[count - 1].Cells[0].Value);
            }
            else
            {
                labelIdHD.Text = "MHD00";
                chuoi = labelIdHD.Text;
            }
            chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            if (chuoi2 + 1 < 10)
            {
                labelIdHD.Text = "MHD0" + (chuoi2 + 1).ToString();
            }
            else
            {
                labelIdHD.Text = "MHD" + (chuoi2 + 1).ToString();
            }
        }

        private void passData()
        {
            idBill = labelIdHD.Text;
            Date = dateTimePickerNgayTT.Text;
            maKH = labelmaKH.Text;
            hoten = labeltenKH.Text;
            soCMND = labelsoCMND.Text;
            diaChi = labelDiaChi.Text;
            sdt = labelSDT.Text;
            nvLap = labelnvLap.Text;
            tienPhong = labelTP.Text;
            tienDV = labelTDV.Text;
            tongTien = labeltongT.Text;
            ghiChu = textBoxghiChu.Text;
            httt = comboBoxHTTT.Text;
            //dgvDV = dgvTienDvDetail;
            //dgvTP = dgvTienPhongDetail;
        }

        private void showTableinReport()
        {
            int i;
            List<ChiTietTienPhong> tp = new List<ChiTietTienPhong>();
            List<ChiTietTienDV> tdv = new List<ChiTietTienDV>();
            //tp.Clear();
            for (i = 0; i < dgvTienPhongDetail.Rows.Count; i++)
            {
                ChiTietTienPhong cttp = new ChiTietTienPhong
                {
                    tenphong = dgvTienPhongDetail.Rows[i].Cells[0].Value.ToString(),
                    ngayvao = dgvTienPhongDetail.Rows[i].Cells[1].Value.ToString(),
                    ngayra = dgvTienPhongDetail.Rows[i].Cells[2].Value.ToString(),
                    songayo = dgvTienPhongDetail.Rows[i].Cells[3].Value.ToString(),
                    tienphong = dgvTienPhongDetail.Rows[i].Cells[4].Value.ToString()
                };
                tp.Add(cttp);
            }

            for (i = 0; i < dgvTienDvDetail.Rows.Count; i++)
            {
                ChiTietTienDV cttdv = new ChiTietTienDV
                {
                    tenphong = dgvTienDvDetail.Rows[i].Cells[0].Value.ToString(),
                    tendv = dgvTienDvDetail.Rows[i].Cells[1].Value.ToString(),
                    ngaysd = dgvTienDvDetail.Rows[i].Cells[2].Value.ToString(),
                    soluong = dgvTienDvDetail.Rows[i].Cells[3].Value.ToString(),
                    tienDV = dgvTienDvDetail.Rows[i].Cells[4].Value.ToString()
                };
                tdv.Add(cttdv);
            }

            rs.Name = "DataSet1"; rs2.Name = "DataSet2";
            rs.Value = tp; rs2.Value = tdv;
            ExportBill eb = new ExportBill();
            eb.reportViewer1.LocalReport.DataSources.Clear();
            eb.reportViewer1.LocalReport.DataSources.Add(rs);
            eb.reportViewer1.LocalReport.DataSources.Add(rs2);
            //eb.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportBill.rdlc";
            eb.ShowDialog();
        }
    }

    public class ChiTietTienPhong
    {
        public string tenphong { get; set; }
        public string ngayvao { get; set; }
        public string ngayra { get; set; }
        public string songayo { get; set; }
        public string tienphong { get; set; }
    }

    public class ChiTietTienDV
    {
        public string tenphong { get; set; }
        public string tendv { get; set; }
        public string ngaysd { get; set; }
        public string soluong { get; set; }
        public string tienDV { get; set; }
    }
}
