namespace Hotel_SoftWare2
{
    partial class LoaiPhongForm
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
            this.labelTim = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.textBoxMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.textBoxTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.textBoxSoNguoiMax = new System.Windows.Forms.TextBox();
            this.labelTenloaiPhong = new System.Windows.Forms.Label();
            this.labelMaloai = new System.Windows.Forms.Label();
            this.labelSoNguoiMax = new System.Windows.Forms.Label();
            this.labelGhiChu = new System.Windows.Forms.Label();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTim
            // 
            this.labelTim.AutoSize = true;
            this.labelTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTim.ForeColor = System.Drawing.Color.Transparent;
            this.labelTim.Location = new System.Drawing.Point(39, 106);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(90, 24);
            this.labelTim.TabIndex = 64;
            this.labelTim.Text = "Tìm Kiếm";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(205, 117);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(200, 24);
            this.textBoxTimKiem.TabIndex = 63;
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
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
            this.iconButtonSave.Location = new System.Drawing.Point(534, 117);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Rotation = 0D;
            this.iconButtonSave.Size = new System.Drawing.Size(119, 40);
            this.iconButtonSave.TabIndex = 62;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // textBoxMaLoaiPhong
            // 
            this.textBoxMaLoaiPhong.Location = new System.Drawing.Point(205, 21);
            this.textBoxMaLoaiPhong.Multiline = true;
            this.textBoxMaLoaiPhong.Name = "textBoxMaLoaiPhong";
            this.textBoxMaLoaiPhong.Size = new System.Drawing.Size(200, 24);
            this.textBoxMaLoaiPhong.TabIndex = 58;
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Location = new System.Drawing.Point(657, 63);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(254, 24);
            this.textBoxGhiChu.TabIndex = 59;
            // 
            // textBoxTenLoaiPhong
            // 
            this.textBoxTenLoaiPhong.Location = new System.Drawing.Point(205, 63);
            this.textBoxTenLoaiPhong.Multiline = true;
            this.textBoxTenLoaiPhong.Name = "textBoxTenLoaiPhong";
            this.textBoxTenLoaiPhong.Size = new System.Drawing.Size(200, 24);
            this.textBoxTenLoaiPhong.TabIndex = 61;
            // 
            // textBoxSoNguoiMax
            // 
            this.textBoxSoNguoiMax.Location = new System.Drawing.Point(657, 21);
            this.textBoxSoNguoiMax.Multiline = true;
            this.textBoxSoNguoiMax.Name = "textBoxSoNguoiMax";
            this.textBoxSoNguoiMax.Size = new System.Drawing.Size(71, 24);
            this.textBoxSoNguoiMax.TabIndex = 60;
            // 
            // labelTenloaiPhong
            // 
            this.labelTenloaiPhong.AutoSize = true;
            this.labelTenloaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenloaiPhong.ForeColor = System.Drawing.Color.Transparent;
            this.labelTenloaiPhong.Location = new System.Drawing.Point(39, 58);
            this.labelTenloaiPhong.Name = "labelTenloaiPhong";
            this.labelTenloaiPhong.Size = new System.Drawing.Size(145, 24);
            this.labelTenloaiPhong.TabIndex = 57;
            this.labelTenloaiPhong.Text = "Tên Loại Phòng";
            // 
            // labelMaloai
            // 
            this.labelMaloai.AutoSize = true;
            this.labelMaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaloai.ForeColor = System.Drawing.Color.Transparent;
            this.labelMaloai.Location = new System.Drawing.Point(39, 21);
            this.labelMaloai.Name = "labelMaloai";
            this.labelMaloai.Size = new System.Drawing.Size(137, 24);
            this.labelMaloai.TabIndex = 54;
            this.labelMaloai.Text = "Mã Loại Phòng";
            // 
            // labelSoNguoiMax
            // 
            this.labelSoNguoiMax.AutoSize = true;
            this.labelSoNguoiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoNguoiMax.ForeColor = System.Drawing.Color.Transparent;
            this.labelSoNguoiMax.Location = new System.Drawing.Point(530, 21);
            this.labelSoNguoiMax.Name = "labelSoNguoiMax";
            this.labelSoNguoiMax.Size = new System.Drawing.Size(89, 24);
            this.labelSoNguoiMax.TabIndex = 56;
            this.labelSoNguoiMax.Text = "Số Người";
            // 
            // labelGhiChu
            // 
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGhiChu.ForeColor = System.Drawing.Color.Transparent;
            this.labelGhiChu.Location = new System.Drawing.Point(530, 63);
            this.labelGhiChu.Name = "labelGhiChu";
            this.labelGhiChu.Size = new System.Drawing.Size(79, 24);
            this.labelGhiChu.TabIndex = 55;
            this.labelGhiChu.Text = "Ghi Chú";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnX.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnX.IconColor = System.Drawing.Color.White;
            this.btnX.IconSize = 30;
            this.btnX.Location = new System.Drawing.Point(19, 485);
            this.btnX.Name = "btnX";
            this.btnX.Rotation = 0D;
            this.btnX.Size = new System.Drawing.Size(119, 42);
            this.btnX.TabIndex = 53;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.White;
            this.btnTimKiem.IconSize = 30;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(19, 416);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Rotation = 0D;
            this.btnTimKiem.Size = new System.Drawing.Size(119, 40);
            this.btnTimKiem.TabIndex = 52;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(19, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Rotation = 0D;
            this.btnXoa.Size = new System.Drawing.Size(119, 40);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(19, 289);
            this.btnSua.Name = "btnSua";
            this.btnSua.Rotation = 0D;
            this.btnSua.Size = new System.Drawing.Size(119, 40);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(19, 232);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0D;
            this.btnThem.Size = new System.Drawing.Size(119, 40);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(161, 179);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.Size = new System.Drawing.Size(760, 400);
            this.dgvLoaiPhong.TabIndex = 48;
            this.dgvLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeRoom_CellClick);
            // 
            // LoaiPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.textBoxMaLoaiPhong);
            this.Controls.Add(this.textBoxGhiChu);
            this.Controls.Add(this.textBoxTenLoaiPhong);
            this.Controls.Add(this.textBoxSoNguoiMax);
            this.Controls.Add(this.labelTenloaiPhong);
            this.Controls.Add(this.labelMaloai);
            this.Controls.Add(this.labelSoNguoiMax);
            this.Controls.Add(this.labelGhiChu);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLoaiPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaiPhongForm";
            this.Text = "LoaiPhongForm";
            this.Load += new System.EventHandler(this.LoaiPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxMaLoaiPhong;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.TextBox textBoxTenLoaiPhong;
        private System.Windows.Forms.TextBox textBoxSoNguoiMax;
        private System.Windows.Forms.Label labelTenloaiPhong;
        private System.Windows.Forms.Label labelMaloai;
        private System.Windows.Forms.Label labelSoNguoiMax;
        private System.Windows.Forms.Label labelGhiChu;
        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
    }
}