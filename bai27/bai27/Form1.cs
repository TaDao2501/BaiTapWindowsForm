using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace bai27
{
    public partial class Form1 : Form
    {
        ArrayList arr;
        public Form1()
        {
            InitializeComponent();
            arr = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtname.Text = openFileDialog1.SafeFileName;
                listitem.Items.Add(openFileDialog1.SafeFileName);
                string line, kq = "";
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                while ((line = reader.ReadLine()) != null)
                {
                    kq += line + " ";
                }
                reader.Close();
                txtnd.Text = kq;
                arr.Add(kq);
            }
        }

        private void listitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnd.Clear();
            txtnd.Text = (string)arr[listitem.SelectedIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listitem.Items.Clear();
            txtnd.Clear();
            txtname.Clear();
        }
    }
}
