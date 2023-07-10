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
using System.Data.SqlClient;
using System.Configuration;

namespace ETRProj
{
    public partial class Admin : Form
    {
       
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");
        string backupDBFilePath = ConfigurationManager.AppSettings["backupDBFilePath"];
        public Admin()
        {
            InitializeComponent();
           
        }

     
  





        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            dashboardController1.Show();
            categoryController1.Hide();
            manufacturerControler1.Hide();
            /* inventoryController1.Hide();*/
            addPharmacist1.Hide();
            customerController1.Hide();
            inventoryProd1.Hide();
            accountMGT1.Hide();
            dashboardController1.BringToFront();

        }

        private void Categorybtn_Click(object sender, EventArgs e)
        {
            dashboardController1.Hide();
            categoryController1.Show();
            manufacturerControler1.Hide();
            /*inventoryController1.Hide();*/
            addPharmacist1.Hide();
            customerController1.Hide();
            inventoryProd1.Hide();
            accountMGT1.Hide();
            categoryController1.BringToFront();

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            dashboardController1.Hide();
            categoryController1.Hide();
            manufacturerControler1.Show();
            /*inventoryController1.Hide();*/
            addPharmacist1.Hide();
            customerController1.Hide();
            inventoryProd1.Hide();
            accountMGT1.Hide();
            manufacturerControler1.BringToFront();


        }

        private void Inventorybtn_Click(object sender, EventArgs e)
        {
            dashboardController1.Hide();
            categoryController1.Hide();
            manufacturerControler1.Hide();
            /*inventoryController1.Show();*/
            addPharmacist1.Hide();
            customerController1.Hide();
            inventoryProd1.Show();
            accountMGT1.Hide();
            inventoryProd1.Show();


        }

        private void AddPharmacistbtn_Click(object sender, EventArgs e)
        {
            dashboardController1.Hide();
            categoryController1.Hide();
            manufacturerControler1.Hide();
            /*inventoryController1.Hide();*/
            addPharmacist1.Show();
            customerController1.Hide();
            inventoryProd1.Hide();
            accountMGT1.Hide();
            addPharmacist1.BringToFront();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            dashboardController1.Hide();
            categoryController1.Hide();
            manufacturerControler1.Hide();
            /*inventoryController1.Hide();*/
            addPharmacist1.Hide();
            customerController1.Hide();
            inventoryProd1.Hide();
            accountMGT1.Show();
            accountMGT1.BringToFront();

        }

        private void Custbtn_Click(object sender, EventArgs e)
        {
            dashboardController1.Hide();
            categoryController1.Hide();
            manufacturerControler1.Hide();
            /* inventoryController1.Hide();*/
            addPharmacist1.Hide();
            customerController1.Show();
            inventoryProd1.Hide();
            accountMGT1.Hide();
            customerController1.BringToFront();

        }

        private void Signoutbtn_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            this.Hide();
        }

        private void dashboardController1_Load(object sender, EventArgs e)
        {

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

        //backupdatabase

        private void BackupDatabase_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to create database backup?", "Database Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string fileName = "MyDatabase_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";
                string backupQuery = $"BACKUP DATABASE PharmaIMS-ETR TO DISK = '{backupDBFilePath}\\{fileName}'";


                SqlCommand command = new SqlCommand(backupQuery, con);
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"{fileName} created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
