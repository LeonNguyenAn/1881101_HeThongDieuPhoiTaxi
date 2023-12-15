using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_1881101.DAO
{
    public class ThanhPhoDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = string.Format("Select * from ThanhPho");

            return LayDuLieu(sql);
        }
    }
}
