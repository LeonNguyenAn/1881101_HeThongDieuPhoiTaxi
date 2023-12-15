using AppTaiXe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTaiXe.DAO
{
    public class DangKyTaiXeDAO : Db
    {
        public int Them(DangKyTaiXe taiXe)
        {
            string sql = string.Format("Insert Into TaiXe(HoTen, CCCD, NgaySinh, GioiTinh, DiaChi, Email, BangLai, SDT, PhuongTien, BienSoXe) " +
                                        "Values(N'{0}', '{1}', '{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}', N'{8}', '{9}')",
                                        taiXe.HoTen, taiXe.CCCD, taiXe.NgaySinh, taiXe.GioiTinh, taiXe.DiaChi, taiXe.Email, taiXe.BangLai, taiXe.SDT, taiXe.PhuongTien, taiXe.BienSoXe);

            return ThucThi(sql);
        }
    }
}
