using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai18
{
    public partial class Form1 : Form
    {
        List<RadioButton> buttons;
        List<RadioButton> icons;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdo1.Checked)
            {
                if (rdo7.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (rdo8.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (rdo9.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rdo10.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (rdo2.Checked)
            {
                if (rdo7.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                }
                else if (rdo8.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else if (rdo9.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                else if (rdo10.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else if (rdo3.Checked)
            {
                if (rdo7.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                else if (rdo8.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                }
                else if (rdo9.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                }
                else if (rdo10.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                }
            }
            else if (rdo4.Checked)
            {
                if (rdo7.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                }
                else if (rdo8.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
                else if (rdo9.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                }
                else if (rdo10.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                }
            }
            else if (rdo5.Checked)
            {
                if (rdo7.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                }
                else if (rdo8.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (rdo9.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }
                else if (rdo10.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            else if (rdo6.Checked)
            {
                if (rdo7.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }
                else if (rdo8.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                }
                else if (rdo9.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
                else if (rdo10.Checked)
                {
                    MessageBox.Show("This is a message", "Notice", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
