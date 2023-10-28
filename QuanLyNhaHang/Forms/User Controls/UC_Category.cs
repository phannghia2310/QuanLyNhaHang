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

namespace QuanLyNhaHang.GUI.User_Controls
{
    public partial class UC_Category : UserControl
    {
        DataAccess da = new DataAccess();
        DanhMuc dm;
        DanhMucBLL bllDanhMuc = new DanhMucBLL();
        string flag = "";

        public UC_Category()
        {
            InitializeComponent();
        }

        void GetDataDanhMuc()
        {
            dm = new DanhMuc();
            dm.MaDanhMuc = txt_MaDanhMuc.Text;
            dm.TenDanhMuc = txt_TenDanhMuc.Text;
        }

        void LockControl()
        {
            txt_MaDanhMuc.Enabled = false;
            txt_TenDanhMuc.Enabled = false;
        }

        void UnlockControl()
        {
            txt_TenDanhMuc.Enabled = true;
        }

        void ClearText()
        {
            txt_TenDanhMuc.Text = "";
        }

        void AutoID()
        {
            string lastID = bllDanhMuc.GetMaDanhMuc();
            int number;

            if(int.TryParse(lastID.Substring(2), out number))
            {
                int newNumber = number + 1;
                string newID = "DM" + newNumber.ToString("D2");
                txt_MaDanhMuc.Text = newID;
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        bool CheckNhap()
        {
            if(string.IsNullOrWhiteSpace(txt_TenDanhMuc.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenDanhMuc.Focus();
                return false;
            }
            if(flag == "Add")
            {
                if (da.CheckKey("SELECT TenDanhMuc FROM DanhMuc WHERE TenDanhMuc='" + txt_TenDanhMuc.Text + "'"))
                {
                    MessageBox.Show("Danh muc có tên " + txt_TenDanhMuc.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenDanhMuc.Focus();
                    return false;
                }
            }
            return true;
        }

        private void UC_Category_Load(object sender, EventArgs e)
        {
            dgv_DanhMuc.DataSource = bllDanhMuc.GetDSDanhMuc();
            dgv_DanhMuc.ReadOnly = true;

            txt_TimKiem.Text = "";
            rb_TenDanhMuc.Checked = true;
            LockControl();
        }

        private void dgv_DanhMuc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_MaDanhMuc.Text = dgv_DanhMuc.Rows[row].Cells["MaDanhMuc"].Value.ToString();
            txt_TenDanhMuc.Text = dgv_DanhMuc.Rows[row].Cells["TenDanhMuc"].Value.ToString();

            LockControl();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearText();
            AutoID();
            txt_TenDanhMuc.Focus();
            flag = "Add";
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txt_TenDanhMuc.Focus();
            flag = "Edit";
        }

        private void btb_XoaBot_Click(object sender, EventArgs e)
        {
            GetDataDanhMuc();
            if (MessageBox.Show("Bạn có chắc chắn xóa danh mục này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bllDanhMuc.Delete(dm);

                UC_Category_Load(sender, e);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(rb_TenDanhMuc.Checked == true)
            {
                dgv_DanhMuc.DataSource = bllDanhMuc.SearchByTenDanhMuc(txt_TimKiem.Text);
            }
        }

        private void btn_ChapNhan_Click(object sender, EventArgs e)
        {
            if(CheckNhap())
            {
                if(flag == "Add")
                {
                    GetDataDanhMuc();
                    bllDanhMuc.Insert(dm);
                    MessageBox.Show("Thêm danh mục thành công!!", "Thông báo");
                    dgv_DanhMuc.DataSource = bllDanhMuc.GetDSDanhMuc();
                }
                if(flag == "Edit")
                {
                    GetDataDanhMuc();
                    bllDanhMuc.Update(dm);
                    MessageBox.Show("Cập nhật danh mục thành công!!", "Thông báo");
                    dgv_DanhMuc.DataSource = bllDanhMuc.GetDSDanhMuc();
                }
            }

            UC_Category_Load(sender, e);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            UC_Category_Load(sender, e);
        }
    }
}
