using System.Drawing;

namespace Hotel_SoftWare2
{
    partial class DatPhongForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panelChildFormPhieuThue = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSphieuThue = new System.Windows.Forms.DataGridView();
            this.comboBoxMKH = new System.Windows.Forms.ComboBox();
            this.textBoxtenKH = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxsdt = new System.Windows.Forms.TextBox();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelmpt = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.labelkh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lableIdPT = new System.Windows.Forms.Label();
            this.btntiep = new FontAwesome.Sharp.IconButton();
            this.groupBoxNote = new System.Windows.Forms.GroupBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.panelChildFormPhieuThue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSphieuThue)).BeginInit();
            this.groupBoxNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 18;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(473, 331);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 14);
            this.label30.TabIndex = 43;
            this.label30.Text = "...";
            // 
            // panelChildFormPhieuThue
            // 
            this.panelChildFormPhieuThue.BackColor = System.Drawing.Color.Transparent;
            this.panelChildFormPhieuThue.Controls.Add(this.btnSua);
            this.panelChildFormPhieuThue.Controls.Add(this.groupBox1);
            this.panelChildFormPhieuThue.Controls.Add(this.comboBoxMKH);
            this.panelChildFormPhieuThue.Controls.Add(this.textBoxtenKH);
            this.panelChildFormPhieuThue.Controls.Add(this.textBoxDiaChi);
            this.panelChildFormPhieuThue.Controls.Add(this.textBoxsdt);
            this.panelChildFormPhieuThue.Controls.Add(this.textBoxCMND);
            this.panelChildFormPhieuThue.Controls.Add(this.label5);
            this.panelChildFormPhieuThue.Controls.Add(this.label4);
            this.panelChildFormPhieuThue.Controls.Add(this.label2);
            this.panelChildFormPhieuThue.Controls.Add(this.label1);
            this.panelChildFormPhieuThue.Controls.Add(this.labelmpt);
            this.panelChildFormPhieuThue.Controls.Add(this.textBoxMaNV);
            this.panelChildFormPhieuThue.Controls.Add(this.labelkh);
            this.panelChildFormPhieuThue.Controls.Add(this.label3);
            this.panelChildFormPhieuThue.Controls.Add(this.lableIdPT);
            this.panelChildFormPhieuThue.Controls.Add(this.btntiep);
            this.panelChildFormPhieuThue.Controls.Add(this.groupBoxNote);
            this.panelChildFormPhieuThue.Controls.Add(this.btnThoat);
            this.panelChildFormPhieuThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormPhieuThue.Location = new System.Drawing.Point(0, 0);
            this.panelChildFormPhieuThue.Name = "panelChildFormPhieuThue";
            this.panelChildFormPhieuThue.Size = new System.Drawing.Size(940, 600);
            this.panelChildFormPhieuThue.TabIndex = 81;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSphieuThue);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(358, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 309);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Thuê";
            // 
            // dgvDSphieuThue
            // 
            this.dgvDSphieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSphieuThue.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSphieuThue.Location = new System.Drawing.Point(6, 25);
            this.dgvDSphieuThue.Name = "dgvDSphieuThue";
            this.dgvDSphieuThue.Size = new System.Drawing.Size(558, 278);
            this.dgvDSphieuThue.TabIndex = 0;
            // 
            // comboBoxMKH
            // 
            this.comboBoxMKH.FormattingEnabled = true;
            this.comboBoxMKH.Location = new System.Drawing.Point(153, 71);
            this.comboBoxMKH.Name = "comboBoxMKH";
            this.comboBoxMKH.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMKH.TabIndex = 136;
            // 
            // textBoxtenKH
            // 
            this.textBoxtenKH.Location = new System.Drawing.Point(153, 114);
            this.textBoxtenKH.Multiline = true;
            this.textBoxtenKH.Name = "textBoxtenKH";
            this.textBoxtenKH.Size = new System.Drawing.Size(180, 24);
            this.textBoxtenKH.TabIndex = 135;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(153, 163);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(180, 24);
            this.textBoxDiaChi.TabIndex = 134;
            // 
            // textBoxsdt
            // 
            this.textBoxsdt.Location = new System.Drawing.Point(153, 214);
            this.textBoxsdt.Multiline = true;
            this.textBoxsdt.Name = "textBoxsdt";
            this.textBoxsdt.Size = new System.Drawing.Size(180, 24);
            this.textBoxsdt.TabIndex = 133;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.Location = new System.Drawing.Point(153, 260);
            this.textBoxCMND.Multiline = true;
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(180, 24);
            this.textBoxCMND.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 131;
            this.label5.Text = "Số CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 130;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 129;
            this.label2.Text = "Địa Chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 128;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // labelmpt
            // 
            this.labelmpt.AutoSize = true;
            this.labelmpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmpt.ForeColor = System.Drawing.Color.White;
            this.labelmpt.Location = new System.Drawing.Point(19, 34);
            this.labelmpt.Name = "labelmpt";
            this.labelmpt.Size = new System.Drawing.Size(115, 20);
            this.labelmpt.TabIndex = 123;
            this.labelmpt.Text = "Mã Phiếu Thuê";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(153, 310);
            this.textBoxMaNV.Multiline = true;
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(77, 24);
            this.textBoxMaNV.TabIndex = 127;
            // 
            // labelkh
            // 
            this.labelkh.AutoSize = true;
            this.labelkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkh.ForeColor = System.Drawing.Color.White;
            this.labelkh.Location = new System.Drawing.Point(19, 69);
            this.labelkh.Name = "labelkh";
            this.labelkh.Size = new System.Drawing.Size(123, 20);
            this.labelkh.TabIndex = 124;
            this.labelkh.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 126;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // lableIdPT
            // 
            this.lableIdPT.AutoSize = true;
            this.lableIdPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIdPT.ForeColor = System.Drawing.Color.White;
            this.lableIdPT.Location = new System.Drawing.Point(149, 34);
            this.lableIdPT.Name = "lableIdPT";
            this.lableIdPT.Size = new System.Drawing.Size(25, 24);
            this.lableIdPT.TabIndex = 125;
            this.lableIdPT.Text = "...";
            // 
            // btntiep
            // 
            this.btntiep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btntiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntiep.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btntiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiep.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntiep.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btntiep.IconColor = System.Drawing.Color.White;
            this.btntiep.IconSize = 30;
            this.btntiep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntiep.Location = new System.Drawing.Point(358, 527);
            this.btntiep.Name = "btntiep";
            this.btntiep.Rotation = 0D;
            this.btntiep.Size = new System.Drawing.Size(142, 40);
            this.btntiep.TabIndex = 122;
            this.btntiep.Text = "Đăng Ký";
            this.btntiep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntiep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntiep.UseVisualStyleBackColor = false;
            this.btntiep.Click += new System.EventHandler(this.btntiep_Click);
            // 
            // groupBoxNote
            // 
            this.groupBoxNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.groupBoxNote.Controls.Add(this.textBoxNote);
            this.groupBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNote.ForeColor = System.Drawing.Color.White;
            this.groupBoxNote.Location = new System.Drawing.Point(358, 360);
            this.groupBoxNote.Name = "groupBoxNote";
            this.groupBoxNote.Size = new System.Drawing.Size(566, 143);
            this.groupBoxNote.TabIndex = 121;
            this.groupBoxNote.TabStop = false;
            this.groupBoxNote.Text = "Ghi Chú";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(6, 25);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(558, 141);
            this.textBoxNote.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconSize = 25;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(811, 528);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Rotation = 0D;
            this.btnThoat.Size = new System.Drawing.Size(111, 41);
            this.btnThoat.TabIndex = 120;
            this.btnThoat.Text = "   THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(589, 527);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(101, 40);
            this.btnSua.TabIndex = 137;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DatPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.panelChildFormPhieuThue);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatPhongForm";
            this.Text = "DatPhongForm";
            this.Load += new System.EventHandler(this.DatPhongForm_Load);
            this.panelChildFormPhieuThue.ResumeLayout(false);
            this.panelChildFormPhieuThue.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSphieuThue)).EndInit();
            this.groupBoxNote.ResumeLayout(false);
            this.groupBoxNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panelChildFormPhieuThue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSphieuThue;
        private System.Windows.Forms.ComboBox comboBoxMKH;
        private System.Windows.Forms.TextBox textBoxtenKH;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxsdt;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelmpt;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label labelkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lableIdPT;
        private FontAwesome.Sharp.IconButton btntiep;
        private System.Windows.Forms.GroupBox groupBoxNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnSua;
    }
}