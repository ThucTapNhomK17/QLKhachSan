using System.Drawing;

namespace Hotel_SoftWare2
{
    partial class ServiceRoomForm
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
            this.lableIdCTPT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPhongsdDV = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayTT = new System.Windows.Forms.DateTimePicker();
            this.labelngaySD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaDV = new System.Windows.Forms.TextBox();
            this.comboBoxTen = new System.Windows.Forms.ComboBox();
            this.labelidDV = new System.Windows.Forms.Label();
            this.textBoxGiaTien = new System.Windows.Forms.TextBox();
            this.labelGiaTien = new System.Windows.Forms.Label();
            this.labelIdSD = new System.Windows.Forms.Label();
            this.labelMaHD = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.labelsoluong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgPhieuSDDV = new System.Windows.Forms.DataGridView();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPhieuSDDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lableIdCTPT
            // 
            this.lableIdCTPT.AutoSize = true;
            this.lableIdCTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIdCTPT.ForeColor = System.Drawing.Color.White;
            this.lableIdCTPT.Location = new System.Drawing.Point(140, 114);
            this.lableIdCTPT.Name = "lableIdCTPT";
            this.lableIdCTPT.Size = new System.Drawing.Size(25, 24);
            this.lableIdCTPT.TabIndex = 104;
            this.lableIdCTPT.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Mã CTPT";
            // 
            // comboBoxPhongsdDV
            // 
            this.comboBoxPhongsdDV.FormattingEnabled = true;
            this.comboBoxPhongsdDV.Location = new System.Drawing.Point(144, 75);
            this.comboBoxPhongsdDV.Name = "comboBoxPhongsdDV";
            this.comboBoxPhongsdDV.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPhongsdDV.TabIndex = 93;
            this.comboBoxPhongsdDV.TextChanged += new System.EventHandler(this.comboBoxPhongsdDV_TextChanged);
            // 
            // dateTimePickerNgayTT
            // 
            this.dateTimePickerNgayTT.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayTT.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerNgayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayTT.Location = new System.Drawing.Point(415, 26);
            this.dateTimePickerNgayTT.Name = "dateTimePickerNgayTT";
            this.dateTimePickerNgayTT.Size = new System.Drawing.Size(128, 24);
            this.dateTimePickerNgayTT.TabIndex = 102;
            // 
            // labelngaySD
            // 
            this.labelngaySD.AutoSize = true;
            this.labelngaySD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelngaySD.ForeColor = System.Drawing.Color.White;
            this.labelngaySD.Location = new System.Drawing.Point(296, 33);
            this.labelngaySD.Name = "labelngaySD";
            this.labelngaySD.Size = new System.Drawing.Size(96, 17);
            this.labelngaySD.TabIndex = 101;
            this.labelngaySD.Text = "Ngày sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tên dịch vụ";
            // 
            // textBoxMaDV
            // 
            this.textBoxMaDV.Location = new System.Drawing.Point(123, 116);
            this.textBoxMaDV.Multiline = true;
            this.textBoxMaDV.Name = "textBoxMaDV";
            this.textBoxMaDV.Size = new System.Drawing.Size(107, 24);
            this.textBoxMaDV.TabIndex = 73;
            this.textBoxMaDV.TextChanged += new System.EventHandler(this.textBoxMaDV_TextChanged);
            // 
            // comboBoxTen
            // 
            this.comboBoxTen.FormattingEnabled = true;
            this.comboBoxTen.Location = new System.Drawing.Point(123, 50);
            this.comboBoxTen.Name = "comboBoxTen";
            this.comboBoxTen.Size = new System.Drawing.Size(137, 28);
            this.comboBoxTen.TabIndex = 72;
            this.comboBoxTen.TextChanged += new System.EventHandler(this.comboBoxTenDV_TextChanged);
            // 
            // labelidDV
            // 
            this.labelidDV.AutoSize = true;
            this.labelidDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidDV.ForeColor = System.Drawing.Color.White;
            this.labelidDV.Location = new System.Drawing.Point(18, 116);
            this.labelidDV.Name = "labelidDV";
            this.labelidDV.Size = new System.Drawing.Size(84, 20);
            this.labelidDV.TabIndex = 71;
            this.labelidDV.Text = "Mã dịch vụ";
            // 
            // textBoxGiaTien
            // 
            this.textBoxGiaTien.Location = new System.Drawing.Point(123, 244);
            this.textBoxGiaTien.Multiline = true;
            this.textBoxGiaTien.Name = "textBoxGiaTien";
            this.textBoxGiaTien.Size = new System.Drawing.Size(107, 24);
            this.textBoxGiaTien.TabIndex = 70;
            // 
            // labelGiaTien
            // 
            this.labelGiaTien.AutoSize = true;
            this.labelGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaTien.ForeColor = System.Drawing.Color.White;
            this.labelGiaTien.Location = new System.Drawing.Point(38, 244);
            this.labelGiaTien.Name = "labelGiaTien";
            this.labelGiaTien.Size = new System.Drawing.Size(64, 20);
            this.labelGiaTien.TabIndex = 69;
            this.labelGiaTien.Text = "Giá tiền";
            // 
            // labelIdSD
            // 
            this.labelIdSD.AutoSize = true;
            this.labelIdSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdSD.ForeColor = System.Drawing.Color.White;
            this.labelIdSD.Location = new System.Drawing.Point(140, 19);
            this.labelIdSD.Name = "labelIdSD";
            this.labelIdSD.Size = new System.Drawing.Size(25, 24);
            this.labelIdSD.TabIndex = 99;
            this.labelIdSD.Text = "...";
            // 
            // labelMaHD
            // 
            this.labelMaHD.AutoSize = true;
            this.labelMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaHD.ForeColor = System.Drawing.Color.White;
            this.labelMaHD.Location = new System.Drawing.Point(20, 23);
            this.labelMaHD.Name = "labelMaHD";
            this.labelMaHD.Size = new System.Drawing.Size(96, 20);
            this.labelMaHD.TabIndex = 98;
            this.labelMaHD.Text = "Mã sử dụng ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(368, 539);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxSL
            // 
            this.textBoxSL.Location = new System.Drawing.Point(123, 174);
            this.textBoxSL.Multiline = true;
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(107, 24);
            this.textBoxSL.TabIndex = 68;
            this.textBoxSL.TextChanged += new System.EventHandler(this.textBoxSL_TextChanged);
            // 
            // iconButtonXoa
            // 
            this.iconButtonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoa.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.iconButtonXoa.IconColor = System.Drawing.Color.White;
            this.iconButtonXoa.IconSize = 30;
            this.iconButtonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.Location = new System.Drawing.Point(772, 98);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Rotation = 0D;
            this.iconButtonXoa.Size = new System.Drawing.Size(90, 40);
            this.iconButtonXoa.TabIndex = 94;
            this.iconButtonXoa.Text = "Xóa";
            this.iconButtonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoa.UseVisualStyleBackColor = false;
            this.iconButtonXoa.Click += new System.EventHandler(this.iconButtonXoa_Click);
            // 
            // labelsoluong
            // 
            this.labelsoluong.AutoSize = true;
            this.labelsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsoluong.ForeColor = System.Drawing.Color.White;
            this.labelsoluong.Location = new System.Drawing.Point(24, 174);
            this.labelsoluong.Name = "labelsoluong";
            this.labelsoluong.Size = new System.Drawing.Size(78, 20);
            this.labelsoluong.TabIndex = 67;
            this.labelsoluong.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Chọn phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxMaDV);
            this.groupBox2.Controls.Add(this.comboBoxTen);
            this.groupBox2.Controls.Add(this.labelidDV);
            this.groupBox2.Controls.Add(this.textBoxGiaTien);
            this.groupBox2.Controls.Add(this.labelGiaTien);
            this.groupBox2.Controls.Add(this.textBoxSL);
            this.groupBox2.Controls.Add(this.labelsoluong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(649, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 346);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch Vụ";
            // 
            // dvgPhieuSDDV
            // 
            this.dvgPhieuSDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPhieuSDDV.DefaultCellStyle.ForeColor = Color.Black;
            this.dvgPhieuSDDV.Location = new System.Drawing.Point(8, 42);
            this.dvgPhieuSDDV.Name = "dvgPhieuSDDV";
            this.dvgPhieuSDDV.Size = new System.Drawing.Size(591, 283);
            this.dvgPhieuSDDV.TabIndex = 0;
            this.dvgPhieuSDDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuSDDV_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(649, 98);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.TabIndex = 90;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // iconButtonThem
            // 
            this.iconButtonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThem.IconColor = System.Drawing.Color.White;
            this.iconButtonThem.IconSize = 30;
            this.iconButtonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThem.Location = new System.Drawing.Point(524, 98);
            this.iconButtonThem.Name = "iconButtonThem";
            this.iconButtonThem.Rotation = 0D;
            this.iconButtonThem.Size = new System.Drawing.Size(90, 40);
            this.iconButtonThem.TabIndex = 91;
            this.iconButtonThem.Text = "Thêm";
            this.iconButtonThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThem.UseVisualStyleBackColor = false;
            this.iconButtonThem.Click += new System.EventHandler(this.iconButtonThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.dvgPhieuSDDV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 346);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sử dụng dịch vụ";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnX.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnX.IconColor = System.Drawing.Color.White;
            this.btnX.IconSize = 30;
            this.btnX.Location = new System.Drawing.Point(505, 539);
            this.btnX.Name = "btnX";
            this.btnX.Rotation = 0D;
            this.btnX.Size = new System.Drawing.Size(90, 42);
            this.btnX.TabIndex = 92;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // ServiceRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.lableIdCTPT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPhongsdDV);
            this.Controls.Add(this.dateTimePickerNgayTT);
            this.Controls.Add(this.labelngaySD);
            this.Controls.Add(this.labelIdSD);
            this.Controls.Add(this.labelMaHD);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.iconButtonXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.iconButtonThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServiceRoomForm";
            this.Text = "ServiceRoomForm";
            this.Load += new System.EventHandler(this.ServiceRoomForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPhieuSDDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableIdCTPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPhongsdDV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTT;
        private System.Windows.Forms.Label labelngaySD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaDV;
        private System.Windows.Forms.ComboBox comboBoxTen;
        private System.Windows.Forms.Label labelidDV;
        private System.Windows.Forms.TextBox textBoxGiaTien;
        private System.Windows.Forms.Label labelGiaTien;
        private System.Windows.Forms.Label labelIdSD;
        private System.Windows.Forms.Label labelMaHD;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TextBox textBoxSL;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private System.Windows.Forms.Label labelsoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvgPhieuSDDV;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnX;
    }
}