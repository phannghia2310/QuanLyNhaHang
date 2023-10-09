using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.GUI
{
    public partial class fLock : Form
    {
        public fLock()
        {
            InitializeComponent();
        }

        private void fLock_Load(object sender, EventArgs e)
        {
            pn_Lock.BackColor = Color.FromArgb(170, 1, 1, 1);
        }
    }
}
