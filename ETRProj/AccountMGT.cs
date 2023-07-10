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
    
    public partial class AccountMGT : UserControl
    {
        public AccountMGT()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");
        public string userIDValue { get; set; }
        private void Save_Click(object sender, EventArgs e)
        {
            useraccount.Text = userIDValue;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pharmacist WHERE PUser = '" + useraccount.Text + "'", con);
        }
    }
}
