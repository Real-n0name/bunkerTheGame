using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bunkerTheGame
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Close();
            welcome.Show();
        }
    }
}
