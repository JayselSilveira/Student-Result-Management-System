using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace Mini_Project_2
{
    public partial class FormBookECO : Form
    {
        public FormBookECO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://pombo.free.fr/samunord19.pdf");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(" https://ucanapplym.s3.ap-south-1.amazonaws.com/RGU/notifications/E_learning/study_online/A_Koutsoyiannis_Modern_Microeconomics_Se.pdf");
        }
    }
}
