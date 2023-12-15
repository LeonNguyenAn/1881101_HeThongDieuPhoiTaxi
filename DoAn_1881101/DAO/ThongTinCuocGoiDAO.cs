using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_1881101.DTO;

namespace DoAn_1881101.DAO
{
    public class ThongTinCuocGoiDAO : Db
    {
        public int Them(ThongTinCuocGoi cuocGoi)
        {
            string sql = string.Format("Insert Into ThongTinCuocGoi(SDT, TenKH, DiaChiDon, LoaiXe, SoNha, Duong, Phuong, Quan, ThanhPho) " +
                                        "Values('{0}', N'{1}', N'{2}', '{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}')",
                                        cuocGoi.SDT, cuocGoi.TenKH, cuocGoi.DiaChiDon, cuocGoi.LoaiXe, cuocGoi.SoNha, cuocGoi.Duong, cuocGoi.Phuong, cuocGoi.Quan, cuocGoi.ThanhPho);
            
            return ThucThi(sql);
        }

        public DataTable LayDsCuocGoiGanNhat(string sdt)
        {
            string sql = string.Format("Select top 5 * from ThongTinCuocGoi Where sdt like '{0}%' order by ThoiGian DESC", sdt);
            
            return LayDuLieu(sql);
        }
    }
}
