using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DataLayer
{
    internal class SqlHelper
    {
        public static string MaChucVu;
        public static string ConnectionString = @"Data Source=PHANNGHIA0411\PHANNGHIA;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public static SqlConnection cnn;
    }
}
