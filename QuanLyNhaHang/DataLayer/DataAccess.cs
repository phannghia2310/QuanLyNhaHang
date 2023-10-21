using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.DataLayer
{
    internal class DataAccess
    {
        public static string strConnection = @"Data Source=PHANNGHIA0411\PHANNGHIA;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd;

        public DataAccess()
        {
            cnn = new SqlConnection(strConnection);
        }

        public void Open()
        {
            if(cnn.State == System.Data.ConnectionState.Open)
            {
                cnn.Open();
            }
        }

        public void Close()
        {
            if(cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.Close();
            }
        }

        public DataTable GetDataTable(string select)
        {
            DataTable dt = new DataTable();
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(select, cnn);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public bool CheckKey(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else return false;
        }

        public void ExecuteNonQuery(string query)
        {
            try
            {
                Open();
                cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
