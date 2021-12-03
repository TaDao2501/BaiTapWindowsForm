using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace bai26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtname.Text = openFileDialog1.SafeFileName;
                string line, kq = "";
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                while ((line = reader.ReadLine()) != null)
                {
                    kq += line + " ";
                }
                reader.Close();
                txtnd.Text = kq;
            }
        }
    }
}
