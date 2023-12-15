using AppDatXe.DAO;
using AppDatXe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatXe.BUS
{
    public class DangKyTaiKhoanBUS
    {
        DangKyTaiKhoanDAO taiKhoanDAO = new DangKyTaiKhoanDAO();
        public int Them(DangKyTaiKhoan taiKhoan)
        {
            if (string.IsNullOrEmpty(taiKhoan.HoTen)) return -1;
            if (string.IsNullOrEmpty(taiKhoan.SDT)) return -2;
            return taiKhoanDAO.Them(taiKhoan);
        }
    }
}
