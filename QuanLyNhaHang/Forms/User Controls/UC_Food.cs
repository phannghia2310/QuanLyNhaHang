using QuanLyNhaHang.BusinessLayer;
using QuanLyNhaHang.DataLayer;
using QuanLyNhaHang.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            ma.Anh = lb_FileAnh.Text;
            ma.MaDanhMuc = cmb_MaDanhMuc.SelectedValue.ToString();
        }

        void LockCotrol()
        {
            txt_MaMonAn.Enabled = false;
            txt_TenMonAn.Enabled = false;
            txt_DonGia.Enabled = false;
            txt_DVT.Enabled = false;
            cmb_MaDanhMuc.Enabled = false;
            btn_LoadImage.Enabled = false;
        }

        void UnlockControl()
        {
            txt_TenMonAn.Enabled = true;
            txt_DonGia.Enabled = true;
            txt_DVT.Enabled = true;
            cmb_MaDanhMuc.Enabled = true;
            btn_LoadImage.Enabled = true;
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

        string UnsigedTextAndRemoveSpaces(string text)
        {
            text = text.ToLower();

            text = text.Replace(" ", "");
            text = text.Replace("á", "a");
            text = text.Replace("à", "a");
            text = text.Replace("ả", "a");
            text = text.Replace("ã", "a");
            text = text.Replace("â", "a");
            text = text.Replace("ấ", "a");
            text = text.Replace("ầ", "a");
            text = text.Replace("ẩ", "a");
            text = text.Replace("ẫ", "a");
            text = text.Replace("ậ", "a");
            text = text.Replace("ă", "a");
            text = text.Replace("ắ", "a");
            text = text.Replace("ằ", "a");
            text = text.Replace("ẳ", "a");
            text = text.Replace("ẵ", "a");
            text = text.Replace("ặ", "a");
            text = text.Replace("é", "e");
            text = text.Replace("è", "e");
            text = text.Replace("ẻ", "e");
            text = text.Replace("ẽ", "e");
            text = text.Replace("ẹ", "e");
            text = text.Replace("ê", "e");
            text = text.Replace("ế", "e");
            text = text.Replace("ề", "e");
            text = text.Replace("ể", "e");
            text = text.Replace("ễ", "e");
            text = text.Replace("ệ", "e");
            text = text.Replace("í", "i");
            text = text.Replace("ì", "i");
            text = text.Replace("ỉ", "i");
            text = text.Replace("ĩ", "i");
            text = text.Replace("ị", "i");
            text = text.Replace("ô", "o");
            text = text.Replace("ố", "o");
            text = text.Replace("ồ", "o");
            text = text.Replace("ổ", "o");
            text = text.Replace("ỗ", "o");
            text = text.Replace("ộ", "o");
            text = text.Replace("ò", "o");
            text = text.Replace("ỏ", "o");
            text = text.Replace("õ", "o");
            text = text.Replace("ọ", "o");
            text = text.Replace("ơ", "o");
            text = text.Replace("ớ", "o");
            text = text.Replace("ờ", "o");
            text = text.Replace("ở", "o");
            text = text.Replace("ỡ", "o");
            text = text.Replace("ợ", "o");
            text = text.Replace("ú", "u");
            text = text.Replace("ù", "u");
            text = text.Replace("ủ", "u");
            text = text.Replace("ũ", "u");
            text = text.Replace("ụ", "u");
            text = text.Replace("ư", "u");
            text = text.Replace("ứ", "u");
            text = text.Replace("ừ", "u");
            text = text.Replace("ử", "u");
            text = text.Replace("ữ", "u");
            text = text.Replace("ự", "u");
            text = text.Replace("ý", "y");
            text = text.Replace("ỳ", "y");
            text = text.Replace("ỷ", "y");
            text = text.Replace("ỹ", "y");
            text = text.Replace("ỵ", "y");

            string newText = text;
            return newText;
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
            if (pb_AnhMonAn.Image == null)
            {
                lb_FileAnh.Text = "Chưa có ảnh";
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
            lb_FileAnh.Text = dgv_MonAn.Rows[row].Cells["Anh"].Value.ToString();
            cmb_MaDanhMuc.Text = dgv_MonAn.Rows[row].Cells["TenDanhMuc"].Value.ToString();

            if(lb_FileAnh.Text == "Chưa có ảnh" || !File.Exists(@"C:\Users\phank\OneDrive\Documents\CODEWORK\VS-Code\PTTKHDT\QuanLyNhaHang\QuanLyNhaHang\Resources\" + lb_FileAnh.Text))
            {
                pb_AnhMonAn.Image = null;
            }
            else
            {
                pb_AnhMonAn.Image = Image.FromFile(@"C:\Users\phank\OneDrive\Documents\CODEWORK\VS-Code\PTTKHDT\QuanLyNhaHang\QuanLyNhaHang\Resources\" + lb_FileAnh.Text);
            }

            LockCotrol();
        }

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFile.Title = "Chọn ảnh";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string selectedImageFile = openFile.FileName;
                string name = UnsigedTextAndRemoveSpaces(txt_TenMonAn.Text);
                lb_FileAnh.Text = name + ".jpg";
                pb_AnhMonAn.Image = Image.FromFile(selectedImageFile);
            }
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

                    string savePath = @"C:\Users\phank\OneDrive\Documents\CODEWORK\VS-Code\PTTKHDT\QuanLyNhaHang\QuanLyNhaHang\Resources\";
                    string fileName = lb_FileAnh.Text;
                    string filePath = Path.Combine(savePath, fileName);
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    pb_AnhMonAn.Image.Save(filePath);

                    dgv_MonAn.DataSource = bllMonAn.GetDsMonAn();
                }
                if(flag == "Edit")
                {
                    GetDataMonAn();
                    bllMonAn.Update(ma);
                    MessageBox.Show("Cập nhật món ăn thành công!!", "Thông báo");

                    string savePath = @"C:\Users\phank\OneDrive\Documents\CODEWORK\VS-Code\PTTKHDT\QuanLyNhaHang\QuanLyNhaHang\Resources\";
                    string fileName = lb_FileAnh.Text;
                    string filePath = Path.Combine(savePath, fileName);
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    pb_AnhMonAn.Image.Save(filePath);

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
