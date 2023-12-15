using AppTaiXe.BUS;
using AppTaiXe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTaiXe.GUI
{
    public partial class MH_DangKy : Form
    {
        DangKyTaiXeBUS taiXeBUS = new DangKyTaiXeBUS();

        public MH_DangKy()
        {
            InitializeComponent();
        }

        private void MH_DangKy_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;
            cbPhuongTien.SelectedIndex = 0;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKyTaiXe taiXe = LayThongTinDangKy();
            var kq = taiXeBUS.Them(taiXe);

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
                        thongbao = "Phải nhập CCCD";
                        break;
                    case -3:
                        thongbao = "Phải nhập ngày tháng năm sinh";
                        break;
                    case -4:
                        thongbao = "Phải nhập địa chỉ";
                        break;
                    case -5:
                        thongbao = "Phải nhập Email";
                        break;
                    case -6:
                        thongbao = "Phải nhập bằng lái";
                        break;
                    case -7:
                        thongbao = "Phải nhập số điện thoại";
                        break;
                    case -8:
                        thongbao = "Phải nhập biển số xe";
                        break;
                }

                MessageBox.Show(thongbao);
            }

        }
        private DangKyTaiXe LayThongTinDangKy()
        {
            DangKyTaiXe kq = new DangKyTaiXe();
            kq.HoTen = txtHoTen.Text;
            kq.CCCD = txtCCCD.Text;       
            kq.NgaySinh = dtNgaySinh.Value.ToShortDateString();
            kq.GioiTinh = cbGioiTinh.Text;
            kq.DiaChi = txtDiaChi.Text;
            kq.Email = txtEmail.Text;
            kq.BangLai = txtBangLai.Text;
            kq.SDT = txtSDT.Text;
            kq.PhuongTien = cbPhuongTien.Text;
            kq.BienSoXe = txtBienSo.Text;
            
            return kq;
        }
    }
}
