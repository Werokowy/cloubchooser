using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloubs_Chooser
{
    public partial class sendtextchat : Form
    {
        public string path = "DIRECTSERVERDLLDATES";
        public bool joined = false;
        public bool connected = false;
        public sendtextchat()
        {
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            

            if (joined == false)
            {
                File.Create(path + "defaultclubjoined.ghjlocal");
                joined = true;
                leaveorjoinButton.Text = "Leave";
                disconnect.Visible = true;
                connect.Visible = true;
                statuslabel.Text = "Attached";
                return;
               

            }
            if (joined == true)
            {
                
                
                
                
                    
                       
                    
                

                MessageBox.Show(
                    "Successfully disconnected from the club. Please note that only the current application is closed, but please restart the entire application completely.",
                    "GHJ Werok Aplications Services");
                MessageBox.Show("After disconnecting from a club, the application requires a restart",
                    "GHJ Werok Aplicationss Services");
                
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (File.Exists("DIRECTSERVERDLLDATES\\defaultclubjoined.ghjlocal"))
            {
                joined = true;
                leaveorjoinButton.Text = "Leave";
                disconnect.Visible = true;
                connect.Visible = true;
                statuslabel.Text = "Attached";
                
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (connected == true || joined == false) 
            {
                MessageBox.Show(
                    "Unable to connect because you are already connected or you don't have internet.",
                    "GHJ Werok Services");

            }
            else
            {

                {

                    connected = true;
                    send.Enabled = true;
                    connectedstatuslabel.Text = "Connection: Connected";
                }
                
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("<Player> " + textBox1.Text);
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            if(connected == false || joined == false)
            {
                

            }
            else
            {

                

                    
                

            }
        }
    }
}
