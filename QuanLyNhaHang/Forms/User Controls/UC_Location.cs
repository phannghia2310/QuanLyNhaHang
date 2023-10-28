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

namespace QuanLyNhaHang.Forms.User_Controls
{
    public partial class UC_Location : UserControl
    {
        DataAccess da = new DataAccess();
        KhuVuc kv;
        KhuVucBLL bllKhuVuc = new KhuVucBLL();
        string flag = "";

        public UC_Location()
        {
            InitializeComponent();
        }

        void GetDataKhuVuc()
        {
            kv = new KhuVuc();
            kv.MaKhuVuc = txt_MaKhuVuc.Text;
            kv.TenKhuVuc = txt_TenKhuVuc.Text;
        }

        void LockControl()
        {
            txt_MaKhuVuc.Enabled = false;
            txt_TenKhuVuc.Enabled = false;
        }

        void UnlockControl()
        {
            txt_TenKhuVuc.Enabled = true;
        }

        void ClearText()
        {
            txt_TenKhuVuc.Text = "";
        }

        void AutoID()
        {
            string lastID = bllKhuVuc.GetMaKhuVuc();
            int number;

            if(int.TryParse(lastID.Substring(2), out number))
            {
                int newNumber = number + 1;
                string newID = "KV" + newNumber.ToString("D2");
                txt_MaKhuVuc.Text = newID;
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        bool CheckNhap()
        {
            if(string.IsNullOrWhiteSpace(txt_TenKhuVuc.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khu vực!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenKhuVuc.Focus();
                return false;
            }
            if(flag == "Add")
            {
                if(da.CheckKey("SELECT TenKhuVuc FROM KhuVuc WHERE TenKhuVuc=N'" + txt_TenKhuVuc.Text + "'"))
                {
                    MessageBox.Show("Khu vực " + txt_TenKhuVuc.Text + " đã tồn tại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenKhuVuc.Focus();
                    return false;
                }
            }
            return true;
        }

        private void UC_Location_Load(object sender, EventArgs e)
        {
            dgv_KhuVuc.DataSource = bllKhuVuc.GetDSKhuVuc();
            dgv_KhuVuc.ReadOnly = true;

            txt_TimKiem.Text = "";
            rb_TenKhuVuc.Checked = true;
            LockControl();
        }

        private void dgv_KhuVuc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_MaKhuVuc.Text = dgv_KhuVuc.Rows[row].Cells["MaKhuVuc"].Value.ToString();
            txt_TenKhuVuc.Text = dgv_KhuVuc.Rows[row].Cells["TenKhuVuc"].Value.ToString();

            LockControl();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearText();
            AutoID();
            txt_TenKhuVuc.Focus();
            flag = "Add";
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txt_TenKhuVuc.Focus();
            flag = "Edit";
        }

        private void btb_XoaBot_Click(object sender, EventArgs e)
        {
            GetDataKhuVuc();
            if (MessageBox.Show("Bạn có chắc chắn xóa khu vực này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bllKhuVuc.Delete(kv);

                UC_Location_Load(sender, e);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(rb_TenKhuVuc.Checked == true)
            {
                dgv_KhuVuc.DataSource = bllKhuVuc.SearchByTenKhuVuc(txt_TimKiem.Text);
            }
        }

        private void btn_ChapNhan_Click(object sender, EventArgs e)
        {
            if(CheckNhap())
            {
                if(flag == "Add")
                {
                    GetDataKhuVuc();
                    bllKhuVuc.Insert(kv);
                    MessageBox.Show("Thêm khu vực mới thành công!!", "Thông báo");
                    dgv_KhuVuc.DataSource = bllKhuVuc.GetDSKhuVuc();
                }
                if(flag == "Edit")
                {
                    GetDataKhuVuc();
                    bllKhuVuc.Update(kv);
                    MessageBox.Show("Cập nhật khu vực thành công!!", "Thông báo");
                    dgv_KhuVuc.DataSource = bllKhuVuc.GetDSKhuVuc();
                }
            }

            UC_Location_Load(sender, e);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            UC_Location_Load(sender, e);
        }
    }
}
