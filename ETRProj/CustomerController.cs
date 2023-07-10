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
    public partial class CustomerController : UserControl
    {
        public CustomerController()
        {
            InitializeComponent();
            ShowCustomers();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowCustomers()
        {
            con.Open();
            string Query = "Select * from Customers ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            CustDGV.DataSource = data.Tables[0];
            con.Close();
        }

        private void AddBtnCust_Click(object sender, EventArgs e)
        {

            if (Custname.Text == "" || Custage.Text == "" || Custsex.SelectedIndex == -1 || Custnum.Text == "")
            {
                MessageBox.Show("*Required. Please Insert Details.");
            }
            else
            {
                if (MessageBox.Show("Do you want add  this new Customer details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Customers(Custname,Custage,Custsex,Custnum)values(@CA,@CB,@CC,@CD)", con);

                    cmd.Parameters.AddWithValue("@CA", Custname.Text);
                    cmd.Parameters.AddWithValue("@CB", Custage.Text);
                    cmd.Parameters.AddWithValue("@CC", Custsex.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CD", Custnum.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New customer added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    ShowCustomers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Reset()
        {
            Custname.Text = "";
            Custage.Text = "";
            Custnum.Text = "";
            Key = 0;
        }
        int Key = 0;

        private void CustDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Custname.Text =CustDGV.SelectedRows[0].Cells[1].Value.ToString();
            Custage.Text = CustDGV.SelectedRows[0].Cells[2].Value.ToString();
            Custsex.SelectedItem =CustDGV.SelectedRows[0].Cells[3].Value.ToString();
            Custnum.Text = CustDGV.SelectedRows[0].Cells[4].Value.ToString();
           
            if (Custname.Text == "" || Custage.Text == "" || Custsex.SelectedIndex == -1 || Custnum.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtnCust_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Please,Select Account Info");
            }
            else
            {
              if  (MessageBox.Show("Do you wish to delete this Customer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    try
                {
                   
                     con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Customers where CustId=@CKey", con);

                    cmd.Parameters.AddWithValue("@CKEY", Key);
                    cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer details has been deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    ShowCustomers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditbtnCust_Click(object sender, EventArgs e)
        {
            if (Custname.Text == "" || Custage.Text == "" || Custsex.SelectedIndex == -1 || Custnum.Text == "")
            {
                MessageBox.Show("Please fill out all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this  custmer info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("update Customers set Custname=@CA,Custage=@CB,Custsex=@CC,Custnum=@CD where CustId=@CKEY", con);
                        cmd.Parameters.AddWithValue("@CA", Custname.Text);
                        cmd.Parameters.AddWithValue("@CB", Custage.Text);
                        cmd.Parameters.AddWithValue("@CC", Custsex.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@CD", Custnum.Text);
                        cmd.Parameters.AddWithValue("@CKEY", Key);
        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        ShowCustomers();
                        Reset();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Custname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Custage_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Custnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
