using DoAn_1881101.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_1881101.BUS
{
    public class DuongBUS
    {
        DuongDAO duongDAO = new DuongDAO();
        public DataTable LayDanhSach()
        {
            return duongDAO.LayDanhSach();
        }
    }
}
