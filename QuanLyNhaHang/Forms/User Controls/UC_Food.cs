using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhaHang.GUI.User_Controls
{
    public partial class UC_Food : UserControl
    {
        DataAccess da = new DataAccess();
        MonAn ma;
        MonAnBLL bllMonAn = new MonAnBLL();
        DanhMucBLL bllDanhMuc = new DanhMucBLL();
        string flag = "";

        public UC_Food()
        {
            InitializeComponent();
        }

        void GetDataMonAn()
        {
            ma = new MonAn();
            ma.MaMonAn = txt_MaMonAn.Text;
            ma.TenMonAn = txt_TenMonAn.Text;
            ma.DonGia = Convert.ToInt32(txt_DonGia.Text);
            ma.DVT = txt_DVT.Text;
            ma.MaDanhMuc = cmb_MaDanhMuc.SelectedValue.ToString();
        }

        void LockCotrol()
        {
            txt_MaMonAn.Enabled = false;
            txt_TenMonAn.Enabled = false;
            txt_DonGia.Enabled = false;
            txt_DVT.Enabled = false;
            cmb_MaDanhMuc.Enabled = false;
        }

        void UnlockControl()
        {
            txt_TenMonAn.Enabled = true;
            txt_DonGia.Enabled = true;
            txt_DVT.Enabled = true;
            cmb_MaDanhMuc.Enabled = true;
        }

        void ClearText()
        {
            txt_TenMonAn.Text = "";
            txt_DonGia.Text = "";
            txt_DVT.Text = "";
            cmb_MaDanhMuc.Text = "";
        }

        void AutoID()
        {
            string lastID = bllMonAn.GetMaMonAn();
            int number;

            if(int.TryParse(lastID.Substring(2), out number))
            {
                int newNumber = number + 1;
                string newID = "MA" + newNumber.ToString("D4");
                txt_MaMonAn.Text = newID;
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        bool CheckNhap()
        {
            if(string.IsNullOrWhiteSpace(txt_TenMonAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenMonAn.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txt_DonGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DonGia.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txt_DVT.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DVT.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(cmb_MaDanhMuc.Text))
            {
                MessageBox.Show("Bạn chưa chọn mã danh mục!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_MaDanhMuc.Focus();
                return false;
            }
            if(flag == "Add")
            {
                if (da.CheckKey("SELECT TenMonAn FROM MonAn WHERE TenMonAn=N'" + txt_TenMonAn.Text + "'"))
                {
                    MessageBox.Show("Món ăn " + txt_TenMonAn.Text + " đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenMonAn.Focus();
                    return false;
                }
            }
            return true;
        }

        private void UC_Food_Load(object sender, EventArgs e)
        {
            dgv_MonAn.DataSource = bllMonAn.GetDsMonAn();
            dgv_MonAn.ReadOnly = true;

            cmb_MaDanhMuc.DataSource = bllDanhMuc.GetDSDanhMuc();
            cmb_MaDanhMuc.DisplayMember = "TenDanhMuc";
            cmb_MaDanhMuc.ValueMember = "MaDanhMuc";

            txt_TimKiem.Text = "";
            rb_TenMonAn.Checked = true;
            LockCotrol();
        }

        private void dgv_MonAn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_MaMonAn.Text = dgv_MonAn.Rows[row].Cells["MaMonAn"].Value.ToString();
            txt_TenMonAn.Text = dgv_MonAn.Rows[row].Cells["TenMonAn"].Value.ToString();
            txt_DonGia.Text = dgv_MonAn.Rows[row].Cells["DonGia"].Value.ToString();
            txt_DVT.Text = dgv_MonAn.Rows[row].Cells["DVT"].Value.ToString();
            cmb_MaDanhMuc.Text = dgv_MonAn.Rows[row].Cells["TenDanhMuc"].Value.ToString();

            LockCotrol();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearText();
            AutoID();
            txt_TenMonAn.Focus();
            flag = "Add";
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txt_TenMonAn.Focus();
            flag = "Edit";
        }

        private void btb_XoaBot_Click(object sender, EventArgs e)
        {
            GetDataMonAn();
            if (MessageBox.Show("Bạn có chắc chắn xóa món ăn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bllMonAn.Delete(ma);

                UC_Food_Load(sender, e);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(rb_TenMonAn.Checked == true)
            {
                dgv_MonAn.DataSource = bllMonAn.SearchByTenMonAn(txt_TimKiem.Text);
            }
            if(rb_TenDanhMuc.Checked == true)
            {
                dgv_MonAn.DataSource = bllMonAn.SearchByTenDanhMuc(txt_TimKiem.Text);
            }
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int i = 0;
            int j = 0;
            for(int k = 1; k < dgv_MonAn.Columns.Count + 1; k++)
            {
                xlWorkSheet.Cells[1, k] = dgv_MonAn.Columns[k - 1].HeaderText;
            }
            for(i = 0; i <= dgv_MonAn.RowCount - 1; i ++)
            {
                for(j = 0; j <= dgv_MonAn.ColumnCount - 1; j ++)
                {
                    DataGridViewCell cell = dgv_MonAn[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "Excel Files (*.xls)|*.xls;";
            if(sdlg.ShowDialog() == DialogResult.OK)
            {
                string filename = sdlg.FileName;

                xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                MessageBox.Show("Xuất file thành công!");
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
            }
        }

        private void btn_ChapNhan_Click(object sender, EventArgs e)
        {
            if(CheckNhap())
            {
                if(flag == "Add")
                {
                    GetDataMonAn();
                    bllMonAn.Insert(ma);
                    MessageBox.Show("Thêm món ăn thành công!!", "Thông báo");
                    dgv_MonAn.DataSource = bllMonAn.GetDsMonAn();
                }
                if(flag == "Edit")
                {
                    GetDataMonAn();
                    bllMonAn.Update(ma);
                    MessageBox.Show("Cập nhật món ăn thành công!!", "Thông báo");
                    dgv_MonAn.DataSource = bllMonAn.GetDsMonAn();
                }
            }

            UC_Food_Load(sender, e);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            UC_Food_Load(sender, e);
        }
    }
}
