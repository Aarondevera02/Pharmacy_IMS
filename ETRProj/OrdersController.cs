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
    public partial class OrdersController : UserControl
    {
        public OrdersController()
        {
            InitializeComponent();
            ShowInventory();
            Showbill();
            GetCustId();
            PharmaName.Text = Login.User;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");

       
        private void qtyupdate()
        {
            try
            {
              
                    int newQty = Stock - Convert.ToInt32(MedQty.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Inventory set MedQty=@MMQ where Medid=@MedKEY", con);


                cmd.Parameters.AddWithValue("@MMQ", newQty);
                cmd.Parameters.AddWithValue("@MedKEY", Key);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Qty has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                ShowInventory();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addBill()
        {
           if (Custname.Text == "")
            {

            } else

            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Bill(PUser,CustId,Custname,billDate,billAmount)values(@BA,@BB,@BC,@BD,@BE)", con);

                    cmd.Parameters.AddWithValue("@BA", PharmaName.Text);
                    cmd.Parameters.AddWithValue("@BB", CustId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@BC", Custname.Text);
                    cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@BE", grandTotal);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Added");
                    con.Close();
                    Showbill();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void ShowInventory()
        {
            con.Open();
            string Query = "Select * from Inventory ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            StocksDGV.DataSource = data.Tables[0];
            con.Close();


        }

        private void Showbill()
        {
            con.Open();
            string Query = "Select * from Bill where PUser = '" + PharmaName.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            TransDGV.DataSource = data.Tables[0];
            con.Close();
        }


        private void getCustName()
        {
            con.Open();
            String query = "Select * from Customers where Custid = '" + CustId.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               Custname.Text = dr["Custname"].ToString();
            }
            con.Close();
        }

        private void GetCustId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Custid from Customers", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            CustId.ValueMember = "CustId";
            CustId.DataSource = dt;
            dt.Load(rdr);
            con.Close();
        }


        int Key = 0, Stock;

        int n = 0 ,grandTotal=0;

       

        int Medid;
        string MedTitle;
        int qty;
        int price;
        int grand;

        int pos = 60;

       

        private void PrintBillbtn_Click(object sender, EventArgs e)
        {
            
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            addBill();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pharmacy IMS", new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(80));
            e.Graphics.DrawString("ID MEDICINE PRICE QTY TOTAL", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(26, 24));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                Medid = +Convert.ToInt32(row.Cells["Column1"].Value);
                MedTitle = "" + row.Cells["Column2"].Value;
                qty = Convert.ToInt32(row.Cells["Column3"].Value);
                price = Convert.ToInt32(row.Cells["Column4"].Value);
                grand = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + Medid, new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString("" + MedTitle, new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, new Point(45, pos));
                e.Graphics.DrawString("" + qty, new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, new Point(120, pos));
                e.Graphics.DrawString("" + price, new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, new Point(170, pos));
                e.Graphics.DrawString("" + grand, new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total:Php" + grandTotal, new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(50, pos + 50));
            e.Graphics.DrawString("---------------Thank you--------------", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(10, pos + 85));

            BillDGV.Refresh();
            grandTotal = 100;
            n = 0;
        }

        private void CustId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getCustName();
        }

        private void searching(String searchValue)
        {
          
            con.Open();
            string Query = "select MedName, MedQty,MedPrice,MedDes,MedCat,MedManName,Medmanid from Inventory where concat(MedName, MedQty,MedPrice,MedDes,MedCat,MedManName,MedManid) LIKE '%" + SearchStock.Text + "%' " ;
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var data = new DataSet();
            sda.Fill(data);
            StocksDGV.DataSource = data.Tables[0];
            con.Close();

        }

        private void SearchStock_TextChanged(object sender, EventArgs e)
        {
            searching(SearchStock.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCustName();
            GetCustId();
            Reset();
        }

        private void Reset()
        {
            MedQty.Text = "";
            Key = 0 ;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (MedQty.Text == "" || Convert.ToInt32(MedQty.Text) > Stock)
            {
                MessageBox.Show("Enter correct Quantity");
            }
            else
            {
                // Confirmation message box
                DialogResult result = MessageBox.Show("Do you want to place this order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int total = Convert.ToInt32(MedQty.Text) * Convert.ToInt32(MedPrice.Text);
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(BillDGV);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = MedName.Text;
                    newRow.Cells[2].Value = MedQty.Text;
                    newRow.Cells[3].Value = MedPrice.Text;
                    newRow.Cells[4].Value = total;
                    BillDGV.Rows.Add(newRow);
                    grandTotal = grandTotal + total;
                    BillGrandTotal.Text = "Php " + grandTotal;
                    n++;
                    qtyupdate();
                }
            }
        }


        private void StocksDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MedName.Text = StocksDGV.SelectedRows[0].Cells[1].Value.ToString();
            Stock = Convert.ToInt32(StocksDGV.SelectedRows[0].Cells[4].Value.ToString());
            MedPrice.Text = StocksDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (MedName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StocksDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }
    }
}
