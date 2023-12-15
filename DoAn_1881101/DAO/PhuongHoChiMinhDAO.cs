using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_1881101.DAO
{
    public class PhuongHoChiMinhDAO : Db
    {
        public DataTable LayDanhSach(string str)
        {
            string sql = string.Format(str);

            return LayDuLieu(sql);
        }
    }
}
