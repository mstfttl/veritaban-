using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GroupProject
{
    public partial class Unavailable : Form
    {
        public Unavailable()
        {
            InitializeComponent();
        }

        private void Unavailable_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ButtonClear.BackColor = SystemColors.Control;
        }

        private void ClearInputs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
            }
        }
    }
}
