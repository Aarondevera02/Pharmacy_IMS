using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ETRProj
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void InventorybtnStaff_Click(object sender, EventArgs e)
        {
            inventoryProd1.Show();
            ordersController1.Hide();
            accountMGT1.Hide();
            ordersController1.BringToFront();
        }

        private void OrdersBtnStaff_Click(object sender, EventArgs e)
        {
            inventoryProd1.Hide();
            ordersController1.Show();
            accountMGT1.Hide();
            ordersController1.BringToFront();
        }

        private void AccountmgtBtn_Click(object sender, EventArgs e)
        {
            inventoryProd1.Hide();
            ordersController1.Hide();
            accountMGT1.Show();
            accountMGT1.BringToFront();
        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

   
    }
}
