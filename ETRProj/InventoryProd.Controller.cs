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
    public partial class InventoryProd : UserControl
    {
        public InventoryProd()
        {
            InitializeComponent();
            ShowInventory();
            GetManufacturer();
            GetCategory();
            GetMedManuf();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowInventory()
        {
            con.Open();
            string Query = "Select * from Inventory ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            InventoryDGV.DataSource = data.Tables[0];
            con.Close();


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (MedName.Text == "" || MedDes.Text == "" || MedQty.Text == "" || MedPrice.Text == "" || MedManName.Text == "")
            {
                MessageBox.Show("*Required. Please Insert Details.");
            }
            else
            {
                if (MessageBox.Show("Do you want add  this new product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Inventory(MedName,MedDes,MedCat,MedQty,MedPrice,MedManName,MedManid)values(@MMN,@MMD,@MMC,@MMQ,@MMP,@MMM,@MMMId)", con);

                    cmd.Parameters.AddWithValue("@MMN", MedName.Text);
                    cmd.Parameters.AddWithValue("@MMD", MedDes.Text);
                    cmd.Parameters.AddWithValue("@MMC", MedCat.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MMQ", MedQty.Text);
                    cmd.Parameters.AddWithValue("@MMP", MedPrice.Text);
                    cmd.Parameters.AddWithValue("@MMM", MedManName.Text);
                    cmd.Parameters.AddWithValue("@MMMId", MedManid.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                        MessageBox.Show("New products added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    ShowInventory();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        public void GetCategory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CatName from category", con);
            SqlDataReader rdr1;
            rdr1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("CatName", typeof(string));
            MedCat.ValueMember = "CatName";
            MedCat.DataSource = dt1;
            dt1.Load(rdr1);
            con.Close();
        }
        public void GetMedManuf()
        {
            con.Open();
            String query = "Select * from Manufacturer where MedManid = '" + MedManid.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MedManName.Text = dr["MedManName"].ToString();
            }
            con.Close();
        }

        public void GetManufacturer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select MedManid from Manufacturer", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MedManid", typeof(int));
            MedManid.ValueMember = "MedManid";
            MedManid.DataSource = dt;
            dt.Load(rdr);
            con.Close();
        }

        private void Reset()
        {
            MedName.Text = "";
            MedDes.Text = "";
            MedQty.Text = "";
            MedPrice.Text = "";
            Key = 0;

        }
        int Key = 0;

        private void InventoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MedName.Text = InventoryDGV.SelectedRows[0].Cells[1].Value.ToString();
            MedDes.Text = InventoryDGV.SelectedRows[0].Cells[2].Value.ToString();
            MedCat.Text = InventoryDGV.SelectedRows[0].Cells[3].Value.ToString();
            MedQty.Text = InventoryDGV.SelectedRows[0].Cells[4].Value.ToString();
            MedPrice.Text = InventoryDGV.SelectedRows[0].Cells[5].Value.ToString();
            MedManName.Text = InventoryDGV.SelectedRows[0].Cells[6].Value.ToString();
            MedManid.SelectedValue = InventoryDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (MedName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(InventoryDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Please,Select Product Inventory Info");
            }
            else
            {
                if (MessageBox.Show("Do you wish to delete this product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Inventory where Medid=@MedKEY", con);

                    cmd.Parameters.AddWithValue("@MedKEY", Key);

                    cmd.ExecuteNonQuery();
                        MessageBox.Show("Product has been deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    Show();
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


            if (MedName.Text == "" || MedDes.Text == "" || MedQty.Text == "" || MedPrice.Text == "" || MedManName.Text == "")
            {
                MessageBox.Show("*Required. Please Insert Details.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this  product info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Inventory set MedName=@MMN,MedDes=MMD,MedCat=MMC,MedQty=MMQ,MedPrice=MMP,MedManName=MMM,MedManid=MMMId where Medid=@MedKEY", con);

                    cmd.Parameters.AddWithValue("@MMN", MedName.Text);
                    cmd.Parameters.AddWithValue("@MMD", MedDes.Text);
                    cmd.Parameters.AddWithValue("@MMC", MedCat.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MMQ", MedQty.Text);
                    cmd.Parameters.AddWithValue("@MMP", MedPrice.Text);
                    cmd.Parameters.AddWithValue("@MMM", MedManName.Text);
                    cmd.Parameters.AddWithValue("@MMMId", MedManid.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MedKEY", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    ShowInventory();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MedManid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetMedManuf();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetManufacturer();
            GetMedManuf();
            GetCategory();
            Reset();
        }

        private void SearchStock_TextChanged(object sender, EventArgs e)
        {
            searching(SearchStock.Text);
        }

        private void searching(String searchValue)
        {

            con.Open();
            string Query = "select MedName, MedQty,MedPrice,MedDes,MedCat,MedManName,Medmanid from Inventory where concat(MedName, MedQty,MedPrice,MedDes,MedCat,MedManName,MedManid) LIKE '%" + SearchStock.Text + "%' ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            InventoryDGV.DataSource = data.Tables[0];
            con.Close();

        }

        private void MedName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MedQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MedPrice_KeyPress(object sender, KeyPressEventArgs e)
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
