using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ETRProj
{
    public partial class DashboardController : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");
        public DashboardController()
        {
            InitializeComponent();
            CountCust();
            Countmedicine();
            countStaff();
            Sum();
            Orders();

        }


        private void Sum()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(billAmount) from Bill", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Total.Text = "Php " + dt.Rows[0][0].ToString();
            con.Close();

        }

        private void Orders()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Bill", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotalOrders.Text = dt.Rows[0][0].ToString();
            con.Close();
        }





        private void CountCust()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Customers", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            customer.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void Countmedicine()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Inventory ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            medicine.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void countStaff()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Pharmacist ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Pharmacist.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            CountCust();
            Countmedicine();
            countStaff();
            Sum();
            Orders();
        }
    }
}
