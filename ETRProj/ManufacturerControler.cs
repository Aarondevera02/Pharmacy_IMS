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
    public partial class ManufacturerControler : UserControl
    {
        public ManufacturerControler()
        {
            InitializeComponent();
            ShowManuf();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowManuf()
        {
            con.Open();
            string Query = "Select * from Manufacturer";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            ManufacturerDGV.DataSource = data.Tables[0];
            con.Close();

        }

        private void SaveButtonManuf_Click(object sender, EventArgs e)
        {



            if (MedManName.Text == "" || MedManAdd.Text == "" || MedManPhone.Text == "")
            {
                MessageBox.Show("*Required. Please Insert Details.");
            }
            else
            {
                if (MessageBox.Show("Do you want add  this new manufacturer details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Manufacturer(MedManName,MedManAdd,MedManPhone)values(@MN,@MA,@MP)", con);

                    cmd.Parameters.AddWithValue("@MN", MedManName.Text);
                    cmd.Parameters.AddWithValue("@MA", MedManAdd.Text);
                    cmd.Parameters.AddWithValue("@MP", MedManPhone.Text);
                    cmd.ExecuteNonQuery();
                        MessageBox.Show("Manufacturer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    ShowManuf();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;

        private void ManufacturerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MedManName.Text = ManufacturerDGV.SelectedRows[0].Cells[1].Value.ToString();
            MedManAdd.Text = ManufacturerDGV.SelectedRows[0].Cells[2].Value.ToString();
            MedManPhone.Text = ManufacturerDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (MedManName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ManufacturerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void ManufListDelete_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Please,Select Manufacturer Info");
            }
            else
            {
                if (MessageBox.Show("Do you wish to delete this product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Manufacturer where MedManId=@MKEY", con);

                    cmd.Parameters.AddWithValue("@MKEY", Key);

                    cmd.ExecuteNonQuery();
                        MessageBox.Show("Manufacturer has been deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    ShowManuf();
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
            MedManName.Text = "";
            MedManAdd.Text = "";
            MedManPhone.Text = "";
            Key = 0;
        }

        private void ManufListEdit_Click(object sender, EventArgs e)
        {


            if (MedManName.Text == "" || MedManAdd.Text == "" || MedManPhone.Text == "")
            {
                MessageBox.Show("*Required. Please Insert Details.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this  manufacturer info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Manufacturer set MedManName=@MN,MedManAdd=@MA,MedManPhone=@MP where MedManid=@MKey", con);

                    cmd.Parameters.AddWithValue("@MN", MedManName.Text);
                    cmd.Parameters.AddWithValue("@MA", MedManAdd.Text);
                    cmd.Parameters.AddWithValue("@MP", MedManPhone.Text);
                    cmd.Parameters.AddWithValue("@MKEY", Key);
                    cmd.ExecuteNonQuery();
                     MessageBox.Show("Manufacturer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    ShowManuf();
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

        private void MedManName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MedManPhone_KeyPress(object sender, KeyPressEventArgs e)
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