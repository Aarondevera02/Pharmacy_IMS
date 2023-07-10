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
    public partial class AddPharmacist : UserControl
    {
        public AddPharmacist()
        {
            InitializeComponent();
            ShowPharmacist();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowPharmacist()
        {
            con.Open();
            string Query = "Select * from Pharmacist";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            PharmaDGV.DataSource = data.Tables[0];
            con.Close();
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {

            if (PharmaName.Text == "" || Pharmalname.Text == "" || PharmaGender.SelectedIndex == -1 || PharmaAddress.Text == "" || PUser.Text == "" || PPassword.Text == "" || PharmaNumer.Text == "")
            {
                MessageBox.Show("*Required. Please Insert Details.");
            }
            else
            {
                if (MessageBox.Show("Do you want add  this new Pharmacist details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Pharmacist(PharmaName,Pharmalname,PharmaGender,PharmaAddress,PUser,PPassword,PharmaNumber)values(@PA,@PB,@PC,@PD,@PE,@PF,@PG)", con);

                    cmd.Parameters.AddWithValue("@PA", PharmaName.Text);
                    cmd.Parameters.AddWithValue("@PB", Pharmalname.Text);
                    cmd.Parameters.AddWithValue("@PC", PharmaGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PG", PharmaNumer.Text);
                    cmd.Parameters.AddWithValue("@PE", PUser.Text);
                    cmd.Parameters.AddWithValue("@PF", PPassword.Text);
                    cmd.Parameters.AddWithValue("@PD", PharmaAddress.Text);



                    cmd.ExecuteNonQuery();
                      MessageBox.Show("New Pharmacist added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    ShowPharmacist();
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
            PharmaName.Text = "";
            Pharmalname.Text = "";
            PharmaNumer.Text = "";
            PUser.Text = "";
            PPassword.Text = "";
            PharmaAddress.Text = "";
            Key = 0;
        }
        int Key = 0;

        private void PharmaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            PharmaName.Text = PharmaDGV.SelectedRows[0].Cells[1].Value.ToString();
            Pharmalname.Text = PharmaDGV.SelectedRows[0].Cells[2].Value.ToString();
            PharmaGender.SelectedItem = PharmaDGV.SelectedRows[0].Cells[3].Value.ToString();
            PharmaNumer.Text = PharmaDGV.SelectedRows[0].Cells[4].Value.ToString();
            PUser.Text = PharmaDGV.SelectedRows[0].Cells[5].Value.ToString();
            PPassword.Text = PharmaDGV.SelectedRows[0].Cells[6].Value.ToString();
            PharmaAddress.Text = PharmaDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (PharmaName.Text == "" || Pharmalname.Text == "" || PharmaGender.SelectedIndex == -1 || PharmaNumer.Text == "" || PUser.Text == "" || PPassword.Text == "" || PharmaAddress.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PharmaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Please,Select Account Info");
            }
            else
            {
                if (MessageBox.Show("Do you wish to delete this account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Pharmacist where PharmaId=@PKey", con);
                   
                    cmd.Parameters.AddWithValue("@PKEY", Key);

                    cmd.ExecuteNonQuery();
                        MessageBox.Show("Pharma details has been deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    ShowPharmacist();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {

            if (PharmaName.Text == "" || Pharmalname.Text == "" || PharmaGender.SelectedIndex == -1 || PharmaAddress.Text == "" || PUser.Text == "" || PPassword.Text == "" || PharmaNumer.Text == "")
            {
                MessageBox.Show("*Required. Please Insert Details.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this  Pharmacist info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Pharmacist set PharmaName=@PA,Pharmalname=@PB,PharmaGender=@PC,PharmaNumber=@PD,PUser=@PE,PPassword=@PF,PharmaAddress=@PG where PharmaId=@PKey", con);
                    cmd.Parameters.AddWithValue("@PA", PharmaName.Text);
                    cmd.Parameters.AddWithValue("@PB", Pharmalname.Text);
                    cmd.Parameters.AddWithValue("@PC", PharmaGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PD", PharmaNumer.Text);
                    cmd.Parameters.AddWithValue("@PE", PUser.Text);
                    cmd.Parameters.AddWithValue("@PF", PPassword.Text);
                    cmd.Parameters.AddWithValue("@PG", PharmaAddress.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);


                    cmd.ExecuteNonQuery();
                        MessageBox.Show("Pharmacist details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                   ShowPharmacist();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
