using AppDatXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatXe.DAO
{
    public class DangKyTaiKhoanDAO : Db
    {
        public int Them(DangKyTaiKhoan taiKhoan)
        {
            string sql = string.Format("Insert Into KhachHang(HoTen, GioiTinh, Email, SDT, NgaySinh, DiaChi) " +
                                        "Values(N'{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}')",
                                        taiKhoan.HoTen, taiKhoan.GioiTinh, taiKhoan.Email, taiKhoan.SDT, taiKhoan.NgaySinh, taiKhoan.DiaChi);

            return ThucThi(sql);
        }
    }
}
