using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhaHang.GUI
{
    public partial class fEmployee : Form
    {
        DataAccess da = new DataAccess();
        NhanVien nv;
        NhanVienBLL bllNhanVien = new NhanVienBLL();
        ChucVuBLL bllChucVu = new ChucVuBLL();
        string flag = "";

        public fEmployee()
        {
            InitializeComponent();
        }

        void GetDataNhanVien()
        {
            nv = new NhanVien();
            nv.MaNhanVien = txt_MaNhanVien.Text;
            nv.TenNhanVien = txt_TenNhanVien.Text;
            if(rb_Nam.Checked)
            {
                nv.GioiTinh = rb_Nam.Text;
            }
            if(rb_Nu.Checked)
            {
                nv.GioiTinh = rb_Nu.Text;
            }
            nv.NgaySinh = dt_NgaySinh.Value;
            nv.DiaChi = txt_DiaChi.Text;
            nv.SDT = txt_SDT.Text;
            nv.MaChucVu = cmb_MaChucVu.SelectedValue.ToString();
        }

        void LockControl()
        {
            txt_MaNhanVien.Enabled = false;
            txt_TenNhanVien.Enabled = false;
            rb_Nam.Enabled = false;
            rb_Nu.Enabled = false;
            dt_NgaySinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_SDT.Enabled = false;
            cmb_MaChucVu .Enabled = false;
        }

        void UnlockControl()
        {
            txt_TenNhanVien.Enabled = true;
            rb_Nam.Enabled = true;
            rb_Nu.Enabled = true;
            dt_NgaySinh.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_SDT.Enabled = true;
            cmb_MaChucVu.Enabled = true;
        }
        
        void ClearText()
        {
            txt_TenNhanVien.Text = "";
            rb_Nam.Checked = true;
            dt_NgaySinh.Text = DateTime.Now.ToString();
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            cmb_MaChucVu.Text = "";
        }

        void AutoID()
        {
            string lastID = bllNhanVien.GetMaNhanVien();
            int number;

            if(int.TryParse(lastID.Substring(2), out number))
            {
                int newNumber = number + 1;
                string newID = "NV" + newNumber.ToString("D4");
                txt_MaNhanVien.Text = newID;
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        bool CheckNhap()
        {
            if(string.IsNullOrWhiteSpace(txt_TenNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNhanVien.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txt_DiaChi.Text)) {
                MessageBox.Show("Bạn chưa nhập địa chỉ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txt_SDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SDT.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(cmb_MaChucVu.Text))
            {
                MessageBox.Show("Bạn chưa chọn chức vụ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_MaChucVu.Focus();
                return false;
            }
            return true;
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = bllNhanVien.GetDSNhanVien();
            dgv_NhanVien.ReadOnly = true;

            cmb_MaChucVu.DataSource = bllChucVu.GetDSChucVu();
            cmb_MaChucVu.DisplayMember = "TenChucVu";
            cmb_MaChucVu.ValueMember = "MaChucVu";

            txt_TimKiem.Text = "";
            rb_Nam.Checked = true;
            rb_TenNhanVien.Checked = true;
            LockControl();
        }


        private void dgv_NhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_MaNhanVien.Text = dgv_NhanVien.Rows[row].Cells["MaNhanVien"].Value.ToString();
            txt_TenNhanVien.Text = dgv_NhanVien.Rows[row].Cells["TenNhanVien"].Value.ToString();
            if (dgv_NhanVien.Rows[row].Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                rb_Nam.Checked = true;
            }
            else
                rb_Nu.Checked = true;
            dt_NgaySinh.Text = dgv_NhanVien.Rows[row].Cells["NgaySinh"].Value.ToString();
            txt_DiaChi.Text = dgv_NhanVien.Rows[row].Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = dgv_NhanVien.Rows[row].Cells["SDT"].Value.ToString();
            cmb_MaChucVu.Text = dgv_NhanVien.Rows[row].Cells["TenChucVu"].Value.ToString();

            LockControl();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            fMain fMain = new fMain();
            fMain.Show();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearText();
            AutoID();
            txt_TenNhanVien.Focus();
            flag = "Add";
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txt_TenNhanVien.Focus();
            flag = "Edit";
        }

        private void btb_XoaBot_Click(object sender, EventArgs e)
        {
            GetDataNhanVien();
            if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bllNhanVien.Delete(nv);

                fEmployee_Load(sender, e);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(rb_TenNhanVien.Checked == true)
            {
                dgv_NhanVien.DataSource = bllNhanVien.SearchByTenNhanVien(txt_TimKiem.Text);
            }
            if(rb_MaChucVu.Checked == true)
            {
                dgv_NhanVien.DataSource = bllNhanVien.SearchByTenChucVu(txt_TimKiem.Text);
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
            for (int k = 1; k < dgv_NhanVien.Columns.Count + 1; k++)
            {
                xlWorkSheet.Cells[1, k] = dgv_NhanVien.Columns[k - 1].HeaderText;
            }
            for (i = 0; i <= dgv_NhanVien.RowCount - 1; i++)
            {
                for (j = 0; j <= dgv_NhanVien.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgv_NhanVien[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "Excel Files (*.xls)|*.xls;";
            if (sdlg.ShowDialog() == DialogResult.OK)
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
                    GetDataNhanVien();
                    bllNhanVien.Insert(nv);
                    MessageBox.Show("Thêm nhân viên thành công!!", "Thông báo");
                    dgv_NhanVien.DataSource = bllNhanVien.GetDSNhanVien();
                }
                if(flag == "Edit")
                {
                    GetDataNhanVien();
                    bllNhanVien.Update(nv);
                    MessageBox.Show("Cập nhật nhân viên thành công!!", "Thông báo");
                    dgv_NhanVien.DataSource = bllNhanVien.GetDSNhanVien();
                }
            }

            fEmployee_Load(sender, e);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            fEmployee_Load(sender, e);
        }
    }
}
