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
    public partial class FormBookDM : Form
    {
        public FormBookDM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://drive.google.com/file/d/0B-xGCX-DplrcRmp6T2pKLVg0YVk/view");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.dbscience.org/wp-content/uploads/2020/03/Discrete_Mathematical_Structures-Kolman.pdf");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(" https://www.scribd.com/document/369727151/Discrete-Mathematical-Structures-with-Applications-to-Computer-Science-by-J-P-Tremblay-R-Manohar-pdf");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("  http://dns3.estudiocom.com.br/download/a-textbook-of-discrete-mathematics-by-swapan-kumar-sarkar-pdf_pdf");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(" https://www.researchgate.net/publication/268045959_Discrete_mathematics_and_graph_theory_2nd_ed");
        }
    }
}