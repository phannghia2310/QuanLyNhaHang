using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.DataLayer
{
    internal class SqlHelper
    {
        public static string MaChucVu;
        public static string ConnectionString = @"Data Source=PHANNGHIA0411\PHANNGHIA;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public static SqlConnection cnn;
    }
}
