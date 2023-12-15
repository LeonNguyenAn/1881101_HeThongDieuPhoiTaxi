using AppDatXe.BUS;
using AppDatXe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDatXe.GUI
{
    public partial class MH_DangKy : Form
    {
        DangKyTaiKhoanBUS taiKhoanBUS = new DangKyTaiKhoanBUS();

        public MH_DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoan taiKhoan = LayThongTinDangKy();
            var kq = taiKhoanBUS.Them(taiKhoan);

            if (kq > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công !!!");
                Close();
            }
            else
            {
                string thongbao = "";
                switch (kq)
                {
                    case -1:
                        thongbao = "Phải nhập họ tên";
                        break;
                    case -2:
                        thongbao = "Phải nhập số điện thoại";
                        break;
                }

                MessageBox.Show(thongbao);
            }
        }

        private DangKyTaiKhoan LayThongTinDangKy()
        {
            DangKyTaiKhoan kq = new DangKyTaiKhoan();
            kq.HoTen = txtHoTen.Text;
            kq.GioiTinh = cbGioiTinh.Text;
            kq.Email = txtEmail.Text;
            kq.SDT = txtSDT.Text;
            kq.NgaySinh = dtNgaySinh.Value.ToShortDateString();
            kq.DiaChi = txtDiaChi.Text;
            return kq;
        }

        private void MH_DangKy_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;
        }
    }
}
