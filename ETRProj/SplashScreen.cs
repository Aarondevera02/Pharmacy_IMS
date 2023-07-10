using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETRProj
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pan2.Width += 3;
            if (pan2.Width >= 423)
            {
                timer1.Stop();
                Login f2 = new Login();
                f2.Show();
                this.Hide();

            }
        }
        }
    }
