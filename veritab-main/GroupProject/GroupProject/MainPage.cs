using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//icon source: https://www.flaticon.com/free-icons

namespace GroupProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        bool isAvailable = GlobalVariables.Availability;

        private void MainPage_Load(object sender, EventArgs e)
        {
            UpdateAvailability();
        }

        private void buttonRoom101_Click(object sender, EventArgs e)
        {
            Available available = new Available();
            Unavailable unavailable = new Unavailable();

            if (buttonRoom101.BackColor == SystemColors.Control)
            {
                available.Show();
            }
            else
            {
                unavailable.Show();
            }

            available.FormClosed += (s, args) =>
            {
                if (!isAvailable)
                {
                    buttonRoom101.BackColor = Color.Red;
                }
                else
                {
                    buttonRoom101.BackColor = SystemColors.Control;
                }

            };
        }

        public void UpdateAvailability()
        {
            if (!isAvailable)
            {
                buttonRoom101.BackColor = Color.Red;
            }
            else
            {
                buttonRoom101.BackColor = SystemColors.Control;
            }
        }
    }
}
