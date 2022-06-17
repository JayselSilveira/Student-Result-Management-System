using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mini_Project_2
{
    public partial class FormBooks : Form
    {
        Form parentForm;
        public FormBooks(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBookDM F1 = new FormBookDM();
            F1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBookMADF f2 = new FormBookMADF();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBookOOSE f3 = new FormBookOOSE();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBookFLAT f4 = new FormBookFLAT();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBookECO f5 = new FormBookECO();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBookMPMC f6 = new FormBookMPMC();
            f6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

