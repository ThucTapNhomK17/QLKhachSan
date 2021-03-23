using System.Drawing;

namespace Hotel_SoftWare2
{
    partial class ChiTietDatPhongForm
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
            this.iconButtonhuy = new FontAwesome.Sharp.IconButton();
            this.labelIdPT = new System.Windows.Forms.Label();
            this.labelmapt = new System.Windows.Forms.Label();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.labelmp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxsearchMaPhong = new System.Windows.Forms.TextBox();
            this.textBoxsearchMaCTPT = new System.Windows.Forms.TextBox();
            this.textBoxMptSearchMaPT = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dgvDSCTPT = new System.Windows.Forms.DataGridView();
            this.lableIdCTPT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxhtt = new System.Windows.Forms.ComboBox();
            this.labelhtt = new System.Windows.Forms.Label();
            this.textBoxSoNguoi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpNgayVao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTienPhongDetail = new System.Windows.Forms.GroupBox();
            this.dgvFreeRoom = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPT)).BeginInit();
            this.groupBoxTienPhongDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonhuy
            // 
            this.iconButtonhuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonhuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconButtonhuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonhuy.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonhuy.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.iconButtonhuy.IconColor = System.Drawing.Color.White;
            this.iconButtonhuy.IconSize = 30;
            this.iconButtonhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonhuy.Location = new System.Drawing.Point(78, 386);
            this.iconButtonhuy.Name = "iconButtonhuy";
            this.iconButtonhuy.Rotation = 0D;
            this.iconButtonhuy.Size = new System.Drawing.Size(140, 40);
            this.iconButtonhuy.TabIndex = 111;
            this.iconButtonhuy.Text = "Hủy Đặt Phòng";
            this.iconButtonhuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonhuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonhuy.UseVisualStyleBackColor = false;
            this.iconButtonhuy.Click += new System.EventHandler(this.iconButtonhuy_Click);
            // 
            // labelIdPT
            // 
            this.labelIdPT.AutoSize = true;
            this.labelIdPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdPT.ForeColor = System.Drawing.Color.White;
            this.labelIdPT.Location = new System.Drawing.Point(127, 27);
            this.labelIdPT.Name = "labelIdPT";
            this.labelIdPT.Size = new System.Drawing.Size(21, 20);
            this.labelIdPT.TabIndex = 113;
            this.labelIdPT.Text = "...";
            // 
            // labelmapt
            // 
            this.labelmapt.AutoSize = true;
            this.labelmapt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmapt.ForeColor = System.Drawing.Color.White;
            this.labelmapt.Location = new System.Drawing.Point(22, 31);
            this.labelmapt.Name = "labelmapt";
            this.labelmapt.Size = new System.Drawing.Size(54, 20);
            this.labelmapt.TabIndex = 112;
            this.labelmapt.Text = "Mã PT";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(12, 447);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(119, 40);
            this.btnThem.TabIndex = 110;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(153, 447);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(119, 40);
            this.iconButtonSave.TabIndex = 109;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(16, 503);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(119, 40);
            this.btnSua.TabIndex = 108;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.Location = new System.Drawing.Point(131, 263);
            this.textBoxMaPhong.Multiline = true;
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(82, 24);
            this.textBoxMaPhong.TabIndex = 107;
            // 
            // labelmp
            // 
            this.labelmp.AutoSize = true;
            this.labelmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmp.ForeColor = System.Drawing.Color.White;
            this.labelmp.Location = new System.Drawing.Point(19, 265);
            this.labelmp.Name = "labelmp";
            this.labelmp.Size = new System.Drawing.Size(81, 20);
            this.labelmp.TabIndex = 106;
            this.labelmp.Text = "Mã Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxsearchMaPhong);
            this.groupBox1.Controls.Add(this.textBoxsearchMaCTPT);
            this.groupBox1.Controls.Add(this.textBoxMptSearchMaPT);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.dgvDSCTPT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(287, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 309);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chi Tiết Phiếu Thuê";
            // 
            // textBoxsearchMaPhong
            // 
            this.textBoxsearchMaPhong.Location = new System.Drawing.Point(443, 265);
            this.textBoxsearchMaPhong.Multiline = true;
            this.textBoxsearchMaPhong.Name = "textBoxsearchMaPhong";
            this.textBoxsearchMaPhong.Size = new System.Drawing.Size(63, 24);
            this.textBoxsearchMaPhong.TabIndex = 94;
            // 
            // textBoxsearchMaCTPT
            // 
            this.textBoxsearchMaCTPT.Location = new System.Drawing.Point(250, 265);
            this.textBoxsearchMaCTPT.Multiline = true;
            this.textBoxsearchMaCTPT.Name = "textBoxsearchMaCTPT";
            this.textBoxsearchMaCTPT.Size = new System.Drawing.Size(82, 24);
            this.textBoxsearchMaCTPT.TabIndex = 93;
            // 
            // textBoxMptSearchMaPT
            // 
            this.textBoxMptSearchMaPT.Location = new System.Drawing.Point(66, 266);
            this.textBoxMptSearchMaPT.Multiline = true;
            this.textBoxMptSearchMaPT.Name = "textBoxMptSearchMaPT";
            this.textBoxMptSearchMaPT.Size = new System.Drawing.Size(71, 24);
            this.textBoxMptSearchMaPT.TabIndex = 92;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Teal;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 22;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(522, 260);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(112, 43);
            this.iconButton1.TabIndex = 86;
            this.iconButton1.Text = "TÌM KIẾM";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dgvDSCTPT
            // 
            this.dgvDSCTPT.AllowUserToAddRows = false;
            this.dgvDSCTPT.AllowUserToDeleteRows = false;
            this.dgvDSCTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPT.Location = new System.Drawing.Point(10, 25);
            this.dgvDSCTPT.Name = "dgvDSCTPT";
            this.dgvDSCTPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCTPT.Size = new System.Drawing.Size(625, 235);
            this.dgvDSCTPT.TabIndex = 0;
            this.dgvDSCTPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTPT_CellClick);
            this.dgvDSCTPT.DefaultCellStyle.ForeColor = Color.Black;
            // 
            // lableIdCTPT
            // 
            this.lableIdCTPT.AutoSize = true;
            this.lableIdCTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIdCTPT.ForeColor = System.Drawing.Color.White;
            this.lableIdCTPT.Location = new System.Drawing.Point(127, 78);
            this.lableIdCTPT.Name = "lableIdCTPT";
            this.lableIdCTPT.Size = new System.Drawing.Size(21, 20);
            this.lableIdCTPT.TabIndex = 104;
            this.lableIdCTPT.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Mã CTPT";
            // 
            // comboBoxhtt
            // 
            this.comboBoxhtt.FormattingEnabled = true;
            this.comboBoxhtt.Items.AddRange(new object[] {
            "Online",
            "Offline"});
            this.comboBoxhtt.Location = new System.Drawing.Point(153, 172);
            this.comboBoxhtt.Name = "comboBoxhtt";
            this.comboBoxhtt.Size = new System.Drawing.Size(77, 21);
            this.comboBoxhtt.TabIndex = 102;
            // 
            // labelhtt
            // 
            this.labelhtt.AutoSize = true;
            this.labelhtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhtt.ForeColor = System.Drawing.Color.White;
            this.labelhtt.Location = new System.Drawing.Point(14, 170);
            this.labelhtt.Name = "labelhtt";
            this.labelhtt.Size = new System.Drawing.Size(121, 20);
            this.labelhtt.TabIndex = 101;
            this.labelhtt.Text = "Hình Thức Thuê";
            // 
            // textBoxSoNguoi
            // 
            this.textBoxSoNguoi.Location = new System.Drawing.Point(131, 121);
            this.textBoxSoNguoi.Multiline = true;
            this.textBoxSoNguoi.Name = "textBoxSoNguoi";
            this.textBoxSoNguoi.Size = new System.Drawing.Size(99, 24);
            this.textBoxSoNguoi.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(17, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 99;
            this.label15.Text = "Số Người";
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayVao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgayVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVao.Location = new System.Drawing.Point(131, 216);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(133, 24);
            this.dtpNgayVao.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Ngày đến";
            // 
            // groupBoxTienPhongDetail
            // 
            this.groupBoxTienPhongDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTienPhongDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxTienPhongDetail.Controls.Add(this.dgvFreeRoom);
            this.groupBoxTienPhongDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTienPhongDetail.ForeColor = System.Drawing.Color.White;
            this.groupBoxTienPhongDetail.Location = new System.Drawing.Point(287, 342);
            this.groupBoxTienPhongDetail.Name = "groupBoxTienPhongDetail";
            this.groupBoxTienPhongDetail.Size = new System.Drawing.Size(641, 232);
            this.groupBoxTienPhongDetail.TabIndex = 96;
            this.groupBoxTienPhongDetail.TabStop = false;
            this.groupBoxTienPhongDetail.Text = "Phòng Trống";
            // 
            // dgvFreeRoom
            // 
            this.dgvFreeRoom.AllowUserToAddRows = false;
            this.dgvFreeRoom.AllowUserToDeleteRows = false;
            this.dgvFreeRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFreeRoom.Location = new System.Drawing.Point(6, 25);
            this.dgvFreeRoom.Name = "dgvFreeRoom";
            this.dgvFreeRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFreeRoom.Size = new System.Drawing.Size(628, 200);
            this.dgvFreeRoom.TabIndex = 0;
            this.dgvFreeRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFreeRoom_CellClick);
            this.dgvFreeRoom.DefaultCellStyle.ForeColor = Color.Black;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Mã PT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(170, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Mã CTPT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(356, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Mã Phòng";
            // 
            // ChiTietDatPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.iconButtonhuy);
            this.Controls.Add(this.labelIdPT);
            this.Controls.Add(this.labelmapt);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.textBoxMaPhong);
            this.Controls.Add(this.labelmp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lableIdCTPT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxhtt);
            this.Controls.Add(this.labelhtt);
            this.Controls.Add(this.textBoxSoNguoi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpNgayVao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxTienPhongDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiTietDatPhongForm";
            this.Text = "ChiTietDatPhongForm";
            this.Load += new System.EventHandler(this.ChiTietDatPhongForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPT)).EndInit();
            this.groupBoxTienPhongDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonhuy;
        private System.Windows.Forms.Label labelmapt;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.Label labelmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxsearchMaPhong;
        private System.Windows.Forms.TextBox textBoxsearchMaCTPT;
        private System.Windows.Forms.TextBox textBoxMptSearchMaPT;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dgvDSCTPT;
        private System.Windows.Forms.Label lableIdCTPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxhtt;
        private System.Windows.Forms.Label labelhtt;
        private System.Windows.Forms.TextBox textBoxSoNguoi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpNgayVao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTienPhongDetail;
        private System.Windows.Forms.DataGridView dgvFreeRoom;
        public System.Windows.Forms.Label labelIdPT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}