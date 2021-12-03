using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtname.Focus();
            piccloud.Visible = false;
            picrain.Visible = false;
            picsnow.Visible = false;
            picsun.Visible = false;

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                if (rdocloud.Checked)
                {
                    piccloud.Visible = true;
                    picrain.Visible = false;
                    picsnow.Visible = false;
                    picsun.Visible = false;
                    lblDisplay.Text = "Hi " + txtname.Text + ",it can be cloudy today and maybe rainy,bring a hat :D";
                }
                else if (rdorain.Checked)
                {
                    picrain.Visible = true;
                    piccloud.Visible = false;
                    picsnow.Visible = false;
                    picsun.Visible = false;
                    lblDisplay.Text = "Hi " + txtname.Text + ",it's raining! Remember to bring your coat or umbrella";
                }
                else if (rdosnow.Checked)
                {
                    picsnow.Visible = true;
                    piccloud.Visible = false;
                    picrain.Visible = false;
                    picsun.Visible = false;
                    lblDisplay.Text = "Hi " + txtname.Text + ",snow is beatiful but dirty,so don't forget to bring your boot";
                }
                else if (rdosun.Checked)
                {
                    picsun.Visible = true;
                    piccloud.Visible = false;
                    picrain.Visible = false;
                    picsnow.Visible = false;
                    lblDisplay.Text = "Hi " + txtname.Text + ",hot day,right? So,a hat or umbrella is the best choice";
                }
                else
                {
                    MessageBox.Show("Please choose weather!");
                }
            }
            else
            {
                MessageBox.Show("Do not leave name empty!");
                txtname.Focus();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdocloud_CheckedChanged(object sender, EventArgs e)
        {
            /*if (txtname.Text != "")
            {
                
               if (rdocloud.Checked)
            {
                piccloud.Visible = true;
                picrain.Visible = false;
                picsnow.Visible = false;
                picsun.Visible = false;
                lblDisplay.Text = "Hi " + txtname.Text + ",it can be cloudy today and maybe rainy,bring a hat :D";
            }
            else
            {
                piccloud.Visible = false;
                lblDisplay.Text = "";
            }
            }
            else
            {
                MessageBox.Show("Do not leave name empty!");
                txtname.Focus();
            }
            */
        }
    }
}
