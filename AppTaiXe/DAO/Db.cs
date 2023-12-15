using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTaiXe.DAO
{
    public class Db
    {
        static string duong_dan = @"Data Source=LEON-NGUYEN;Initial Catalog=DoAn_1881101;Integrated Security=True";
        public int ThucThi(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            ket_noi.Open();
            var kq = lenh.ExecuteNonQuery();
            ket_noi.Close();

            return kq;
        }
    }
}
