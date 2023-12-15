using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DoAn_1881101.DAO;
using DoAn_1881101.BUS;
using DoAn_1881101.DTO;

namespace DoAn_1881101
{
    public partial class frmThongTinCuocGoi : Form
    {
        ThongTinCuocGoiBUS cuocGoiBUS = new ThongTinCuocGoiBUS();
        ThanhPhoBUS thanhPhoBUS = new ThanhPhoBUS();
        QuanHoChiMinhBUS quanHoChiMinhBUS = new QuanHoChiMinhBUS();
        PhuongHoChiMinhBUS phuongHoChiMinhBUS = new PhuongHoChiMinhBUS();
        DuongBUS duongBUS = new DuongBUS();

        public frmThongTinCuocGoi()
        {
            InitializeComponent();
        }

        public void PhuongHoChiMinh(string str)
        {
            var PhuongDataTable = phuongHoChiMinhBUS.LayDanhSach(str);
            cbPhuong.DataSource = PhuongDataTable;
            cbPhuong.DisplayMember = "Ten";
        }

        private void ThongTinCuocGoi_Load(object sender, EventArgs e)
        {
            var ThanhPhoDataTable = thanhPhoBUS.LayDanhSach();
            cbThanhPho.DataSource = ThanhPhoDataTable;
            cbThanhPho.DisplayMember = "Ten";

            if (cbThanhPho.SelectedIndex == 0)
            {
                var QuanDataTable = quanHoChiMinhBUS.LayDanhSach();
                cbQuan.DataSource = QuanDataTable;
                cbQuan.DisplayMember = "Ten";           
            }

            var DuongDataTable = duongBUS.LayDanhSach();
            cbDuong.DataSource = DuongDataTable;
            cbDuong.DisplayMember = "Ten";
        }

        private void btn_DieuPhoi_Click(object sender, EventArgs e)
        {
            ThongTinCuocGoi cuocGoi = LayThongTinCuocGoi();

            var kq = cuocGoiBUS.Them(cuocGoi);

            if (kq > 0)
            {
                MessageBox.Show("Thêm cuốc gọi thành công !!!");
            }
            else
            {
                string thongbao = "";
                switch (kq)
                {
                    case -1:
                        thongbao = "Phải nhập số điện thoại";
                        break;
                    case -2:
                        thongbao = "Phải nhập địa chỉ đón";
                        break;
                }

                MessageBox.Show(thongbao);
            }
        }

        private ThongTinCuocGoi LayThongTinCuocGoi()
        {
            ThongTinCuocGoi kq = new ThongTinCuocGoi();
            kq.TenKH = txtTenKhachHang.Text;
            kq.SDT = txtSoDienThoai.Text;
            kq.SoNha = txtSoNha.Text;
            kq.Duong = cbDuong.Text;
            kq.Quan = cbQuan.Text;
            kq.Phuong = cbPhuong.Text;
            kq.ThanhPho = cbThanhPho.Text;

            var loaixe = this.grLoaiXe.Controls.OfType<RadioButton>()
                        .FirstOrDefault(n => n.Checked);
            kq.LoaiXe = int.Parse(loaixe.Tag.ToString());

            return kq;
        }

        private void cbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQuan.SelectedIndex == 0)
            {
                string str = "Select * from PhuongThanhPhoThuDuc";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 1)
            {
                string str = "Select * from PhuongQuan1";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 2)
            {
                string str = "Select * from PhuongQuan3";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 3)
            {
                string str = "Select * from PhuongQuan4";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 4)
            {
                string str = "Select * from PhuongQuan5";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 5)
            {
                string str = "Select * from PhuongQuan6";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 6)
            {
                string str = "Select * from PhuongQuan7";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 7)
            {
                string str = "Select * from PhuongQuan8";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 8)
            {
                string str = "Select * from PhuongQuan10";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 9)
            {
                string str = "Select * from PhuongQuan11";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 10)
            {
                string str = "Select * from PhuongQuan12";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 11)
            {
                string str = "Select * from PhuongQuanBinhTan";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 12)
            {
                string str = "Select * from PhuongQuanBinhThanh";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 13)
            {
                string str = "Select * from PhuongQuanGoVap";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 14)
            {
                string str = "Select * from PhuongQuanPhuNhuan";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 15)
            {
                string str = "Select * from PhuongQuanTanBinh";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 16)
            {
                string str = "Select * from PhuongQuanTanPhu";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 17)
            {
                string str = "Select * from XaHuyenBinhChanh";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 18)
            {
                string str = "Select * from XaHuyenCanGio";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 19)
            {
                string str = "Select * from XaHuyenCuChi";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 20)
            {
                string str = "Select * from XaHuyenHocMon";
                PhuongHoChiMinh(str);
            }
            else if (cbQuan.SelectedIndex == 21)
            {
                string str = "Select * from XaHuyenNhaBe";
                PhuongHoChiMinh(str);
            }
        }

        private void cbThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            var dataTable = cuocGoiBUS.LayDsCuocGoiGanNhat(txtSoDienThoai.Text);

            int stt = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(stt++.ToString());
                item.SubItems.Add(row["ThoiGian"].ToString());
                item.SubItems.Add(row["DiaChiDon"].ToString());
                item.SubItems.Add(row["LoaiXe"].ToString());
                item.SubItems.Add(row["TinhTrang"].ToString());

                lv_CuocGoi.Items.Add(item);
            }
        }
    }
}
