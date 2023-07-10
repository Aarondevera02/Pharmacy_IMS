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
    public partial class CategoryController : UserControl
    {
        public CategoryController()
        {
            InitializeComponent();
            showCategory();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");

        private void showCategory()
        {
            con.Open();
            string Query = "Select * from category";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            CatDGV.DataSource = data.Tables[0];
            con.Close();
        }

        private void AddBtnInventory_Click(object sender, EventArgs e)
        {
                if (ProdNametxt.Text == "")
                {
                    MessageBox.Show("*Required. Please Insert Details.");
                }
                else
                {
                if (MessageBox.Show("Do you want add  this new category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into category(CatName)values(@PC)", con);

                        cmd.Parameters.AddWithValue("@PC", ProdNametxt.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New category added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        showCategory();
                        Reset();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }

        int Key = 0;

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ProdNametxt.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (ProdNametxt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CatDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            ProdNametxt.Text = "";
            Key = 0;
        }

        private void DeleteBtnInventory_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Please,Select Category Info");
            }
            else
            {
                if (MessageBox.Show("Do you wish to delete this category?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from category where CatId=@CKey", con);

                    cmd.Parameters.AddWithValue("@CKEY", Key);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category has been deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    con.Close();
                    showCategory();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditbtnInventory_Click(object sender, EventArgs e)
        {

            if (ProdNametxt.Text == "")
            {
                MessageBox.Show("*Required. Please Insert Details.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this  category info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Category set CatName=@PC where CatId=@CKey", con);
                    cmd.Parameters.AddWithValue("@PC", ProdNametxt.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    showCategory();
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

        private void ProdNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        
    }
    }
}
