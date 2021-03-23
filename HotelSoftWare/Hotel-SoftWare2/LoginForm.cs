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
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;

namespace Hotel_SoftWare2
{
    public partial class LoginForm : Form
    {
        public List<NhanVien> getPass()
        {
            htEntities context = new htEntities();
            return context.NhanViens.ToList();
        }

        Thread th;
        public static string username;
        public static string password;
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Encrypt enc = new Encrypt();
            htEntities context = new htEntities();
            List<NhanVien> list = getPass();
            username = textBoxUserName.Text;
            password = enc.MaHoa(textBoxPassWord.Text);

            var check = list.Where(item => item.TenTk != null && item.TenTk.Equals(username)).ToList();
            if (check.Count > 0)
            {
                if (check[0].MatKhau.Equals(password))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Close();
                    th = new Thread(openMainForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoản này");
            }
        }
        private void openMainForm(object obj)
        {
            Application.Run(new MainForm());
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "UserName")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.LightGray;
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.Text = "UserName";
                textBoxUserName.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPassWord_Enter(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text == "PassWord")
            {
                textBoxPassWord.Text = "";
                textBoxPassWord.ForeColor = Color.LightGray;
                textBoxPassWord.UseSystemPasswordChar = true;
            }
            
            
        }

        private void textBoxPassWord_Leave(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text == "") 
            {
                textBoxPassWord.Text = "PassWord";
                textBoxPassWord.ForeColor = Color.DimGray;
                textBoxPassWord.UseSystemPasswordChar = false;
            }
        }

        //public List<Table> LoadTableList()
        //{
        //    List<Table> tableList = new List<Table>();

        //    DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

        //    foreach (DataRow item in data.Rows)
        //    {
        //        Table table = new Table(item);
        //        tableList.Add(table);
        //    }

        //    return tableList;
        //}
    }
}
