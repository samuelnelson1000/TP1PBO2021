using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BringToFront();
            panel2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBox1.Text);
            string b = Convert.ToString(textBox2.Text);
            if ((a == null) || (b != "pbo123"))
            {
                string message = "Username dan Password Salah";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
            else
            {
                textBox1.Text = null;
                textBox2.Text = null;
                panel2.BringToFront();
                panel2.Visible = true;
                panel1.Visible = true;
                panel1.SendToBack();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://shopee.co.id/");
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel2.SendToBack();
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.BringToFront();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel2.Visible = true;
            panel1.Visible = true;
            panel1.SendToBack();

        }
    }
}
