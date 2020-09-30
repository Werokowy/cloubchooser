using System;
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
    public partial class collinf : Form
    {
        public collinf()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox3.Checked = false;
                checkBox2.Checked = false;
            }
            if (checkBox1.Checked == false)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox3.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                permissionkey.Visible = true;
                permissionlabel.Visible = true;
            }
            if (checkBox2.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                permissionkey.Visible = false;
                permissionlabel.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                permissionkey.Visible = true;
                permissionlabel.Visible = true;
            }
            if (checkBox3.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                permissionkey.Visible = false;
                permissionlabel.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nickbox.Text != null && serverpasswordbox.Text == "")
            {
                if (checkBox1.Checked == true)
                {
                    new sendtextchat().Show();
                    this.Hide();
                }

                if (checkBox2.Checked == true)
                {
                    if (permissionkey.Text == "$sLu/hh{4V4h{:ePpxE>W[jRhhXx#")
                    {
                        new sendtextchat().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("CRITICAL ERROR:Incorret key. Please try again", "GHJ Werok Services",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (checkBox3.Checked == true)
                {
                    if (permissionkey.Text == "^m9Ud)D%qF{)h=Tf/faE@e$#,X%T2:")
                    {
                        new sendtextchat().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("CRITICAL ERROR:Incorret key. Please try again", "GHJ Werok Services",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("")
            }
        }
    }
}
