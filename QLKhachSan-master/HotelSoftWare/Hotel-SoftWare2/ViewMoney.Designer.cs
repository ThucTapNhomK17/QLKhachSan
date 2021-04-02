namespace Hotel_SoftWare2
{
    partial class ViewMoney
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvXemTienKhiNhap = new System.Windows.Forms.DataGridView();
            this.dtpNgaydi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVao = new System.Windows.Forms.DateTimePicker();
            this.labeldenNgay = new System.Windows.Forms.Label();
            this.labeltuNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemTienKhiNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(54, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvXemTienKhiNhap
            // 
            this.dgvXemTienKhiNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemTienKhiNhap.Location = new System.Drawing.Point(310, 39);
            this.dgvXemTienKhiNhap.Name = "dgvXemTienKhiNhap";
            this.dgvXemTienKhiNhap.Size = new System.Drawing.Size(422, 319);
            this.dgvXemTienKhiNhap.TabIndex = 1;
            // 
            // dtpNgaydi
            // 
            this.dtpNgaydi.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaydi.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaydi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaydi.Location = new System.Drawing.Point(157, 103);
            this.dtpNgaydi.Name = "dtpNgaydi";
            this.dtpNgaydi.Size = new System.Drawing.Size(104, 24);
            this.dtpNgaydi.TabIndex = 31;
            this.dtpNgaydi.ValueChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayVao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgayVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVao.Location = new System.Drawing.Point(157, 39);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(103, 24);
            this.dtpNgayVao.TabIndex = 30;
            this.dtpNgayVao.ValueChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labeldenNgay
            // 
            this.labeldenNgay.AutoSize = true;
            this.labeldenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldenNgay.ForeColor = System.Drawing.Color.White;
            this.labeldenNgay.Location = new System.Drawing.Point(49, 103);
            this.labeldenNgay.Name = "labeldenNgay";
            this.labeldenNgay.Size = new System.Drawing.Size(79, 20);
            this.labeldenNgay.TabIndex = 29;
            this.labeldenNgay.Text = "Đến Ngày";
            // 
            // labeltuNgay
            // 
            this.labeltuNgay.AutoSize = true;
            this.labeltuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltuNgay.ForeColor = System.Drawing.Color.White;
            this.labeltuNgay.Location = new System.Drawing.Point(49, 39);
            this.labeltuNgay.Name = "labeltuNgay";
            this.labeltuNgay.Size = new System.Drawing.Size(67, 20);
            this.labeltuNgay.TabIndex = 28;
            this.labeltuNgay.Text = "Từ Ngày\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 40);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nhập số tiền (xem phòng nào \r\ncó doanh thu tổng > số tiền nhập)";
            // 
            // ViewMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(761, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaydi);
            this.Controls.Add(this.dtpNgayVao);
            this.Controls.Add(this.labeldenNgay);
            this.Controls.Add(this.labeltuNgay);
            this.Controls.Add(this.dgvXemTienKhiNhap);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(300, 37);
            this.Name = "ViewMoney";
            this.Text = "ViewMoney";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemTienKhiNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvXemTienKhiNhap;
        private System.Windows.Forms.DateTimePicker dtpNgaydi;
        private System.Windows.Forms.DateTimePicker dtpNgayVao;
        private System.Windows.Forms.Label labeldenNgay;
        private System.Windows.Forms.Label labeltuNgay;
        private System.Windows.Forms.Label label1;
    }
}