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
    public partial class UC_Table : UserControl
    {
        DataAccess da = new DataAccess();
        Ban b;
        BanBLL bllBan = new BanBLL();
        KhuVucBLL bllKhuVuc = new KhuVucBLL();
        string flag = "";

        public UC_Table()
        {
            InitializeComponent();
        }

        void GetDataBan()
        {
            b = new Ban();
            b.MaBan = txt_MaBan.Text;
            b.TenBan = txt_TenBan.Text;
            b.TrangThai = cmb_TrangThai.Text;
            b.MaKhuVuc = cmb_MaKhuVuc.SelectedValue.ToString();
        }

        void LockControl()
        {
            txt_MaBan.Enabled = false;
            txt_TenBan.Enabled = false;
            cmb_TrangThai.Enabled = false;
            cmb_MaKhuVuc.Enabled = false;
        }

        void UnlockControl()
        {
            txt_TenBan.Enabled = true;
            cmb_TrangThai.Enabled = true;
            cmb_MaKhuVuc.Enabled = true;
        }

        void ClearText()
        {
            txt_TenBan.Text = "";
            cmb_TrangThai.SelectedValue = 0;
            cmb_MaKhuVuc.SelectedValue = 0;
        }

        void AutoID()
        {
            string lastID = bllBan.GetMaBan();
            int number;

            if(int.TryParse(lastID.Substring(1), out number))
            {
                int newNumber = number + 1;
                string newID = "B" + newNumber.ToString("D3");
                txt_MaBan.Text = newID;
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        bool CheckNhap()
        {
            if(string.IsNullOrWhiteSpace(txt_TenBan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bàn!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenBan.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(cmb_TrangThai.Text))
            {
                MessageBox.Show("Bạn chưa chọn trạng thái bàn!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_TrangThai.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(cmb_MaKhuVuc.Text))
            {
                MessageBox.Show("Bạn chưa chọn khu vực!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_MaKhuVuc.Focus();
                return false;
            }
            if(flag == "Add")
            {
                if(da.CheckKey("SELECT TenBan FROM Ban WHERE TenBan=N'" + txt_TenBan.Text + "'"))
                {
                    MessageBox.Show("Bàn " + txt_TenBan.Text + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenBan.Focus();
                    return false;
                }
            }
            return true;
        }

        private void UC_Table_Load(object sender, EventArgs e)
        {
            dgv_Ban.DataSource = bllBan.GetDSBan();
            dgv_Ban.ReadOnly = true;

            cmb_MaKhuVuc.DataSource = bllKhuVuc.GetDSKhuVuc();
            cmb_MaKhuVuc.DisplayMember = "TenKhuVuc";
            cmb_MaKhuVuc.ValueMember = "MaKhuVuc";

            txt_TimKiem.Text = "";
            rb_TenBan.Checked = true;
            LockControl();
        }

        private void dgv_Ban_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txt_MaBan.Text = dgv_Ban.Rows[row].Cells["MaBan"].Value.ToString();
            txt_TenBan.Text = dgv_Ban.Rows[row].Cells["TenBan"].Value.ToString();
            cmb_TrangThai.Text = dgv_Ban.Rows[row].Cells["TrangThai"].Value.ToString();
            cmb_MaKhuVuc.Text = dgv_Ban.Rows[row].Cells["TenKhuVuc"].Value.ToString();

            LockControl();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            UnlockControl();
            ClearText();
            AutoID();
            txt_TenBan.Focus();
            flag = "Add";
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            txt_TenBan.Focus();
            flag = "Edit";
        }

        private void btb_XoaBot_Click(object sender, EventArgs e)
        {
            GetDataBan();
            if (MessageBox.Show("Bạn có chắc chắn xóa bàn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                bllBan.Delete(b);

                UC_Table_Load(sender, e);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(rb_TenBan.Checked == true)
            {
                dgv_Ban.DataSource = bllBan.SearchByTenBan(txt_TimKiem.Text);
            }
            if(rb_TenKhuVuc.Checked == true)
            {
                dgv_Ban.DataSource = bllBan.SearchByTenKhuVuc(txt_TimKiem.Text);
            }
            if(rb_TrangThai.Checked == true)
            {
                dgv_Ban.DataSource = bllBan.SearchByTrangThai(txt_TimKiem.Text);
            }
        }

        private void btn_ChapNhan_Click(object sender, EventArgs e)
        {
            if (CheckNhap())
            {
                if (flag == "Add")
                {
                    GetDataBan();
                    bllBan.Insert(b);
                    MessageBox.Show("Thêm bàn thành công!!", "Thông báo");
                    dgv_Ban.DataSource = bllBan.GetDSBan();
                }
                if (flag == "Edit")
                {
                    GetDataBan();
                    bllBan.Update(b);
                    MessageBox.Show("Cập nhật bàn thành công!!", "Thông báo");
                    dgv_Ban.DataSource = bllBan.GetDSBan();
                }
            }

            UC_Table_Load(sender, e);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            UC_Table_Load(sender, e);
        }
    }
}
