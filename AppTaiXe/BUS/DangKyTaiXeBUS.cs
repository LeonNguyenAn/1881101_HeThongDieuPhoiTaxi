using AppTaiXe.DAO;
using AppTaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTaiXe.BUS
{
    public class DangKyTaiXeBUS
    {
        DangKyTaiXeDAO taiXeDAO = new DangKyTaiXeDAO();
        public int Them(DangKyTaiXe taiXe)
        {
            if (string.IsNullOrEmpty(taiXe.HoTen)) return -1;
            if (string.IsNullOrEmpty(taiXe.CCCD)) return -2;
            if (string.IsNullOrEmpty(taiXe.DiaChi)) return -4;
            if (string.IsNullOrEmpty(taiXe.Email)) return -5;
            if (string.IsNullOrEmpty(taiXe.BangLai)) return -6;
            if (string.IsNullOrEmpty(taiXe.SDT)) return -7;
            if (string.IsNullOrEmpty(taiXe.BienSoXe)) return -8;

            return taiXeDAO.Them(taiXe);
        }
    }
}
