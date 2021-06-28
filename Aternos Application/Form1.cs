using Aternos_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aternos_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            using (Http.dWebHook dcWeb = new Http.dWebHook())
            {
                dcWeb.UserName = "App Access";
                dcWeb.WebHook = "https://discord.com/api/webhooks/857274587813511178/qErpSwZ57U7R08ErggP9Y20yp9fnL4DNTgg8KxeFe4jN4PXBlHE_TUPhwyaXCAFUL0Rs";
                try
                {
                    if (role.CheckedItems.Count != 0)
                    {
                        // If so, loop through all checked items and print results.  
                        string s = "";
                        for (int x = 0; x < role.CheckedItems.Count; x++)
                        {
                            s = s + "Choosed Roles :\n" +
                                "" + ("").ToString() + "" + role.CheckedItems[x].ToString() + "\n";
                        }
                        MessageBox.Show(s);
                    }




                    for (int x = 0; x < role.CheckedItems.Count; x++)
                    {
                        string a = "";
                        string s = "";
                        a = a + "" + ("").ToString() + "" + perms.CheckedItems[x].ToString();
                        s = s + "" + ("").ToString() + "" + role.CheckedItems[x].ToString();
                        dcWeb.SendMsg("Aternos Username [Key] : " + auser.Text + "\nDiscord Username : " + duser.Text + "\nClass [Role] : " + s + "\nPermissions : " + a);
                    }
                    MessageBox.Show("Application has succeed!");
                    Close();
                }
                catch
                {
                    MessageBox.Show("Are you offline or just having a bad internet?\nTry again WITHOUT using the MacDonalds' wifi.");
                }
                                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Settings.Default.LockDownB == true)
            {
                MessageBox.Show("Sorry, but you have already applied and the app is in a lockdown");
                MessageBox.Show("You still can reapply using the LockDownPass [Changes Everyday]");
                Hide();
                LockDPass f = new LockDPass();
                f.ShowDialog();
                Show();
                Focus();
            }
            if (Settings.Default.FInstall == true)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to install Impact font?\nIt's a great font for using this app!", "Font Might Be Missing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://cdn.discordapp.com/attachments/855766023499808779/857267716939448370/font.ttf", Application.StartupPath + "\\f.ttf");
                        }

                        Process.Start(Application.StartupPath + "\\f.ttf");

                        Settings.Default.FInstall = false;
                        Settings.Default.Save();
                        Close();
                    }
                    if (result == DialogResult.Cancel)
                    {
                        Close();
                    }
                }
                catch
                {
                    try
                    {
                        MessageBox.Show("GOD DAMN ERROR, try running it with admin.\nIf not working try deleting the ''t.ff'' file.", "oof", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Wtf man, stop ruining the whole thing", "Stupid man", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Close();
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                Settings.Default.Reset();
                Settings.Default.Save();
                try
                {
                    Directory.Delete(Application.StartupPath + "\\f.tff");
                }
                catch
                {
                    MessageBox.Show("Just a small error commonly happens.\nit happens when the Font File is not in the proper folder.\nAnd Deleted by the code, eh ignore it", "Common Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                Close();
            }
        }
    }
}
