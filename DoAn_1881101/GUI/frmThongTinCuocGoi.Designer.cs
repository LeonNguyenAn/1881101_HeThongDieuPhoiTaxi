namespace DoAn_1881101
{
    partial class frmThongTinCuocGoi
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
            cbThanhPho = new ComboBox();
            cbQuan = new ComboBox();
            cbPhuong = new ComboBox();
            cbDuong = new ComboBox();
            txtSoNha = new TextBox();
            txtSoDienThoai = new TextBox();
            txtTenKhachHang = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbDiaChiDon = new Label();
            rd4cho = new RadioButton();
            rd7cho = new RadioButton();
            rdVip = new RadioButton();
            rdGiaRe = new RadioButton();
            lv_CuocGoi = new ListView();
            STT = new ColumnHeader();
            ThoiGian = new ColumnHeader();
            DiaChiDon = new ColumnHeader();
            LoaiXe = new ColumnHeader();
            TrangThai = new ColumnHeader();
            label10 = new Label();
            label11 = new Label();
            lv_DiaChi = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btn_DieuPhoi = new Button();
            grLoaiXe = new GroupBox();
            grLoaiXe.SuspendLayout();
            SuspendLayout();
            // 
            // cbThanhPho
            // 
            cbThanhPho.FormattingEnabled = true;
            cbThanhPho.Location = new Point(258, 472);
            cbThanhPho.Margin = new Padding(6);
            cbThanhPho.Name = "cbThanhPho";
            cbThanhPho.Size = new Size(442, 40);
            cbThanhPho.TabIndex = 27;
            cbThanhPho.SelectedIndexChanged += cbThanhPho_SelectedIndexChanged;
            // 
            // cbQuan
            // 
            cbQuan.FormattingEnabled = true;
            cbQuan.Location = new Point(258, 410);
            cbQuan.Margin = new Padding(6);
            cbQuan.Name = "cbQuan";
            cbQuan.Size = new Size(442, 40);
            cbQuan.TabIndex = 26;
            cbQuan.SelectedIndexChanged += cbQuan_SelectedIndexChanged;
            // 
            // cbPhuong
            // 
            cbPhuong.FormattingEnabled = true;
            cbPhuong.Items.AddRange(new object[] { "Phường 1", "Phường 2", "Phường 3", "Phường 4", "Phường 5", "Phường 6", "Phường 7", "Phường 8", "Phường 9", "Phường 10", "Phường 11", "Phường 12", "Phường BTĐ", "Phường BTĐ A", "Phường BTĐ B" });
            cbPhuong.Location = new Point(258, 348);
            cbPhuong.Margin = new Padding(6);
            cbPhuong.Name = "cbPhuong";
            cbPhuong.Size = new Size(442, 40);
            cbPhuong.TabIndex = 25;
            // 
            // cbDuong
            // 
            cbDuong.FormattingEnabled = true;
            cbDuong.Items.AddRange(new object[] { "Hậu Giang", "Đường số 1", "Nguyễn Văn Cừ", "Bà Hom" });
            cbDuong.Location = new Point(258, 286);
            cbDuong.Margin = new Padding(6);
            cbDuong.Name = "cbDuong";
            cbDuong.Size = new Size(442, 40);
            cbDuong.TabIndex = 24;
            // 
            // txtSoNha
            // 
            txtSoNha.Location = new Point(258, 225);
            txtSoNha.Margin = new Padding(6);
            txtSoNha.Name = "txtSoNha";
            txtSoNha.Size = new Size(442, 39);
            txtSoNha.TabIndex = 23;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(258, 163);
            txtSoDienThoai.Margin = new Padding(6);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(442, 39);
            txtSoDienThoai.TabIndex = 22;
            txtSoDienThoai.Leave += txtSoDienThoai_Leave;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(258, 101);
            txtTenKhachHang.Margin = new Padding(6);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(442, 39);
            txtTenKhachHang.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 481);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 32);
            label7.TabIndex = 20;
            label7.Text = "Thành phố";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 419);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 32);
            label6.TabIndex = 19;
            label6.Text = "Quận";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 357);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 32);
            label5.TabIndex = 18;
            label5.Text = "Phường";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 295);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 32);
            label4.TabIndex = 17;
            label4.Text = "Đường";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 233);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 16;
            label3.Text = "Số nhà";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 171);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 32);
            label2.TabIndex = 15;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 109);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 14;
            label1.Text = "Tên khách hàng";
            // 
            // lbDiaChiDon
            // 
            lbDiaChiDon.BackColor = SystemColors.MenuHighlight;
            lbDiaChiDon.Dock = DockStyle.Top;
            lbDiaChiDon.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbDiaChiDon.ForeColor = SystemColors.ButtonHighlight;
            lbDiaChiDon.Location = new Point(0, 0);
            lbDiaChiDon.Margin = new Padding(6, 0, 6, 0);
            lbDiaChiDon.Name = "lbDiaChiDon";
            lbDiaChiDon.Size = new Size(1486, 76);
            lbDiaChiDon.TabIndex = 28;
            lbDiaChiDon.Text = "ĐỊA CHỈ ĐÓN";
            // 
            // rd4cho
            // 
            rd4cho.AutoSize = true;
            rd4cho.Checked = true;
            rd4cho.Location = new Point(37, 44);
            rd4cho.Name = "rd4cho";
            rd4cho.Size = new Size(104, 36);
            rd4cho.TabIndex = 29;
            rd4cho.TabStop = true;
            rd4cho.Tag = "4";
            rd4cho.Text = "4 chỗ";
            rd4cho.UseVisualStyleBackColor = true;
            // 
            // rd7cho
            // 
            rd7cho.AutoSize = true;
            rd7cho.Location = new Point(200, 44);
            rd7cho.Name = "rd7cho";
            rd7cho.Size = new Size(104, 36);
            rd7cho.TabIndex = 30;
            rd7cho.Tag = "7";
            rd7cho.Text = "7 chỗ";
            rd7cho.UseVisualStyleBackColor = true;
            // 
            // rdVip
            // 
            rdVip.AutoSize = true;
            rdVip.Location = new Point(363, 44);
            rdVip.Name = "rdVip";
            rdVip.Size = new Size(79, 36);
            rdVip.TabIndex = 31;
            rdVip.Tag = "1";
            rdVip.Text = "VIP";
            rdVip.UseVisualStyleBackColor = true;
            // 
            // rdGiaRe
            // 
            rdGiaRe.AutoSize = true;
            rdGiaRe.Location = new Point(501, 44);
            rdGiaRe.Name = "rdGiaRe";
            rdGiaRe.Size = new Size(107, 36);
            rdGiaRe.TabIndex = 32;
            rdGiaRe.Tag = "2";
            rdGiaRe.Text = "Giá rẻ";
            rdGiaRe.UseVisualStyleBackColor = true;
            // 
            // lv_CuocGoi
            // 
            lv_CuocGoi.Columns.AddRange(new ColumnHeader[] { STT, ThoiGian, DiaChiDon, LoaiXe, TrangThai });
            lv_CuocGoi.FullRowSelect = true;
            lv_CuocGoi.GridLines = true;
            lv_CuocGoi.Location = new Point(61, 701);
            lv_CuocGoi.MultiSelect = false;
            lv_CuocGoi.Name = "lv_CuocGoi";
            lv_CuocGoi.Size = new Size(1346, 194);
            lv_CuocGoi.TabIndex = 34;
            lv_CuocGoi.UseCompatibleStateImageBehavior = false;
            lv_CuocGoi.View = View.Details;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 100;
            // 
            // ThoiGian
            // 
            ThoiGian.Text = "ThoiGian";
            ThoiGian.TextAlign = HorizontalAlignment.Center;
            ThoiGian.Width = 100;
            // 
            // DiaChiDon
            // 
            DiaChiDon.Text = "DiaChiDon";
            DiaChiDon.TextAlign = HorizontalAlignment.Center;
            DiaChiDon.Width = 350;
            // 
            // LoaiXe
            // 
            LoaiXe.Text = "LoaiXe";
            LoaiXe.TextAlign = HorizontalAlignment.Center;
            LoaiXe.Width = 100;
            // 
            // TrangThai
            // 
            TrangThai.Text = "TrangThai";
            TrangThai.TextAlign = HorizontalAlignment.Center;
            TrangThai.Width = 150;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(61, 666);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(252, 32);
            label10.TabIndex = 35;
            label10.Text = "Các cuộc gọi gần nhất";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(753, 97);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(279, 32);
            label11.TabIndex = 37;
            label11.Text = "Các địa chỉ đi nhiều nhất";
            // 
            // lv_DiaChi
            // 
            lv_DiaChi.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3 });
            lv_DiaChi.FullRowSelect = true;
            lv_DiaChi.GridLines = true;
            lv_DiaChi.Location = new Point(753, 132);
            lv_DiaChi.MultiSelect = false;
            lv_DiaChi.Name = "lv_DiaChi";
            lv_DiaChi.Size = new Size(654, 380);
            lv_DiaChi.TabIndex = 36;
            lv_DiaChi.UseCompatibleStateImageBehavior = false;
            lv_DiaChi.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DiaChiDon";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 500;
            // 
            // btn_DieuPhoi
            // 
            btn_DieuPhoi.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DieuPhoi.ForeColor = SystemColors.HotTrack;
            btn_DieuPhoi.Location = new Point(584, 920);
            btn_DieuPhoi.Name = "btn_DieuPhoi";
            btn_DieuPhoi.Size = new Size(300, 70);
            btn_DieuPhoi.TabIndex = 38;
            btn_DieuPhoi.Text = "ĐIỀU PHỐI";
            btn_DieuPhoi.UseVisualStyleBackColor = true;
            btn_DieuPhoi.Click += btn_DieuPhoi_Click;
            // 
            // grLoaiXe
            // 
            grLoaiXe.Controls.Add(rdGiaRe);
            grLoaiXe.Controls.Add(rdVip);
            grLoaiXe.Controls.Add(rd7cho);
            grLoaiXe.Controls.Add(rd4cho);
            grLoaiXe.Location = new Point(61, 555);
            grLoaiXe.Name = "grLoaiXe";
            grLoaiXe.Size = new Size(639, 93);
            grLoaiXe.TabIndex = 39;
            grLoaiXe.TabStop = false;
            grLoaiXe.Text = "Loại xe";
            // 
            // frmThongTinCuocGoi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 1015);
            Controls.Add(grLoaiXe);
            Controls.Add(btn_DieuPhoi);
            Controls.Add(label11);
            Controls.Add(lv_DiaChi);
            Controls.Add(label10);
            Controls.Add(lv_CuocGoi);
            Controls.Add(lbDiaChiDon);
            Controls.Add(cbThanhPho);
            Controls.Add(cbQuan);
            Controls.Add(cbPhuong);
            Controls.Add(cbDuong);
            Controls.Add(txtSoNha);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenKhachHang);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "frmThongTinCuocGoi";
            Text = "ThongTinCuocGoi";
            Load += ThongTinCuocGoi_Load;
            grLoaiXe.ResumeLayout(false);
            grLoaiXe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbThanhPho;
        private ComboBox cbQuan;
        private ComboBox cbPhuong;
        private ComboBox cbDuong;
        private TextBox txtSoNha;
        private TextBox txtSoDienThoai;
        private TextBox txtTenKhachHang;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbDiaChiDon;
        private RadioButton rd4cho;
        private RadioButton rd7cho;
        private RadioButton rdVip;
        private RadioButton rdGiaRe;
        private ListView lv_CuocGoi;
        private ColumnHeader STT;
        private ColumnHeader ThoiGian;
        private ColumnHeader DiaChiDon;
        private ColumnHeader LoaiXe;
        private ColumnHeader TrangThai;
        private Label label10;
        private Label label11;
        private ListView lv_DiaChi;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private Button btn_DieuPhoi;
        private GroupBox grLoaiXe;
    }
}