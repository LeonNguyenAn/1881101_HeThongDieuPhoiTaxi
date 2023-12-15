namespace AppDatXe.GUI
{
    partial class MH_DangKy
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
            btnDangKy = new Button();
            lbDiaChi = new Label();
            txtDiaChi = new TextBox();
            lbNgaySinh = new Label();
            lbSDT = new Label();
            lbEmail = new Label();
            label3 = new Label();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            lbGioiTinh = new Label();
            txtHoTen = new TextBox();
            lbHoTen = new Label();
            cbGioiTinh = new ComboBox();
            dtNgaySinh = new DateTimePicker();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(255, 255, 128);
            btnDangKy.Dock = DockStyle.Bottom;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.Brown;
            btnDangKy.Location = new Point(0, 578);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(526, 66);
            btnDangKy.TabIndex = 27;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(35, 482);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(87, 32);
            lbDiaChi.TabIndex = 26;
            lbDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(211, 479);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(290, 39);
            txtDiaChi.TabIndex = 25;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Location = new Point(35, 404);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(121, 32);
            lbNgaySinh.TabIndex = 24;
            lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Location = new Point(35, 326);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(156, 32);
            lbSDT.TabIndex = 23;
            lbSDT.Text = "Số điện thoại";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(35, 248);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 32);
            lbEmail.TabIndex = 22;
            lbEmail.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(7, 5);
            label3.Name = "label3";
            label3.Size = new Size(374, 50);
            label3.TabIndex = 21;
            label3.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(211, 323);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(290, 39);
            txtSDT.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(211, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 39);
            txtEmail.TabIndex = 18;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Location = new Point(35, 170);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(105, 32);
            lbGioiTinh.TabIndex = 16;
            lbGioiTinh.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(211, 89);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(290, 39);
            txtHoTen.TabIndex = 15;
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Location = new Point(35, 92);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(90, 32);
            lbHoTen.TabIndex = 14;
            lbHoTen.Text = "Họ Tên";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cbGioiTinh.Location = new Point(211, 167);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(290, 40);
            cbGioiTinh.TabIndex = 28;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Format = DateTimePickerFormat.Short;
            dtNgaySinh.Location = new Point(211, 397);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(290, 39);
            dtNgaySinh.TabIndex = 29;
            // 
            // MH_DangKy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 644);
            Controls.Add(dtNgaySinh);
            Controls.Add(cbGioiTinh);
            Controls.Add(btnDangKy);
            Controls.Add(lbDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(lbNgaySinh);
            Controls.Add(lbSDT);
            Controls.Add(lbEmail);
            Controls.Add(label3);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(lbGioiTinh);
            Controls.Add(txtHoTen);
            Controls.Add(lbHoTen);
            Name = "MH_DangKy";
            Text = "MH_DangKy";
            Load += MH_DangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangKy;
        private Label lbDiaChi;
        private TextBox txtDiaChi;
        private Label lbNgaySinh;
        private Label lbSDT;
        private Label lbEmail;
        private Label label3;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private Label lbGioiTinh;
        private TextBox txtHoTen;
        private Label lbHoTen;
        private ComboBox cbGioiTinh;
        private DateTimePicker dtNgaySinh;
    }
}