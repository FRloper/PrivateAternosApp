using Aternos_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aternos_Application
{
    public partial class LockDPass : Form
    {
        public LockDPass()
        {
            InitializeComponent();
        }

        private void LockDPass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient cleint = new WebClient();

            var pass = cleint.DownloadString("https://pastebin.com/raw/tfh2QdFC");

            if (textBox1.Text == pass)
            {
                Settings.Default.LockDownB = false;
                Settings.Default.Save();
                MessageBox.Show("You have passed the lockdown!\nThe app will be directed to you to perform the apply!");
            }
        }
    }
}
