using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            pic2.BringToFront();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            pic1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic1.BringToFront();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (rdored.Checked)
            {
                lblmess.ForeColor = Color.Red;
            }
        }

        private void rdored_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdogreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdogreen.Checked)
            {
                lblmess.ForeColor = Color.Green;
            }
        }

        private void rdoblue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoblue.Checked)
            {
                lblmess.ForeColor = Color.Blue;
            }
        }

        private void rdoblack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoblack.Checked)
            {
                lblmess.ForeColor = Color.Black;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold );
            }
            else if (checkBox2.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Italic);
            }
            else if (checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Underline);
            }
            else if(checkBox1.Checked&&checkBox2.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold|FontStyle.Italic);
            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold | FontStyle.Underline);
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Italic | FontStyle.Underline);
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            }
            else
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Regular);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold);
            }
            else if (checkBox2.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Italic);
            }
            else if (checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Underline);
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold | FontStyle.Italic);
            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold | FontStyle.Underline);
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Italic | FontStyle.Underline);
            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            }
            else
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Regular);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold | FontStyle.Italic);
            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold | FontStyle.Underline);
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Italic | FontStyle.Underline);
            }
            else if (checkBox1.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Bold);
            }
            else if (checkBox2.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Italic);
            }
            else if (checkBox3.Checked)
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Underline);
            }
            else
            {
                lblmess.Font = new Font(lblmess.Font.Name, lblmess.Font.Size, FontStyle.Regular);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtmess.Text != "")
            {
                lblmess.Text = txtname.Text + '\n' + txtmess.Text;
            }
            else
            {
                MessageBox.Show("Do not leave feild blank!");
                if (txtname.Text == "")
                {
                    txtname.Focus();
                }
                else if (txtmess.Text == "")
                {
                    txtmess.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblmess.Text = "";
            txtmess.Clear();
            txtname.Clear();
            txtname.Focus();
            rdored.Checked = false;
            rdoblack.Checked = false;
            rdoblue.Checked = false;
            rdogreen.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
