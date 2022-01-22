using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunkerTheGame
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin f1 = new Admin();
            this.Hide();
            f1.Show();
        }

        private void buttonLetsGo_Click(object sender, EventArgs e)
        {
            LetsGo f2 = new LetsGo();
            this.Hide();
            f2.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"D:\Study\practice2022\bunkerTheGame\bunkerInfo\rules.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
