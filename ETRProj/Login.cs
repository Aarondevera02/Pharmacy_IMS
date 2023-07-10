using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//connect ot database
using System.Configuration;
using System.Runtime.InteropServices;



namespace ETRProj
{
    public partial class Login : Form
    {
        //connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Echo\Documents\PharmaIMS-ETR.mdf;Integrated Security=True;Connect Timeout=30");
        public static String User;
        public Login()
        {
            InitializeComponent();
        }
        //show icon
        private void show_Click(object sender, EventArgs e)
        {
            if (passwordtxt.PasswordChar == '*')
            {
                hide.BringToFront();
                passwordtxt.PasswordChar = '\0';
            }

        }
        //hide icon
        private void hide_Click(object sender, EventArgs e)
        {

            if (passwordtxt.PasswordChar == '\0')
            {
                show.BringToFront();
                passwordtxt.PasswordChar = '*';
            }
        }

      
        //Login button
        private void loginbutton_Click(object sender, EventArgs e)
            {
                if (usernametxt.Text == "")
                {
                    MessageBox.Show("Please fill out the username", "Username is required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (passwordtxt.Text == "")
                {
                    MessageBox.Show("Please fill out the password", "Password is required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (usertype.SelectedItem == null)
                {
                    MessageBox.Show("Please select a user type", "User type is required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string userType = usertype.SelectedItem.ToString();
                    string query = "";

                    if (usertype.SelectedIndex == 0)
                    {
                        query = "select * from Admin where AdminUser = @userId and AdminPassword = @password";
                    }
                    else if (usertype.SelectedIndex == 1)
                    {
                        query = "select * from Pharmacist where PUser = @userId and PPassword = @password";
                    }
                    else
                    {
                        MessageBox.Show("Invalid user type selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userId", usernametxt.Text);
                    cmd.Parameters.AddWithValue("@password", passwordtxt.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("You are logged in as a " + userType);
                        if (usertype.SelectedIndex == 0)
                        {
                            Admin admin = new Admin();
                            this.Hide();
                            admin.Show();
                        }
                        else if (usertype.SelectedIndex == 1)
                        {
                        User = usernametxt.Text;
                            Staff staff = new Staff();
                            this.Hide();
                            staff.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
            }
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            string text = usernametxt.Text;
            if (text != string.Empty)
            {
                loginbutton.Enabled = true;
            }
        }

        private void passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbutton.PerformClick();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            loginbutton.Enabled = false;
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
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

