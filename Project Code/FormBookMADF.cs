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
    public partial class FormBookMADF : Form
    {
        public FormBookMADF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://nasirmir.files.wordpress.com/2012/09/fundamentals-of-computer-algorithms-by-ellis-horowitz-1984.pdf");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://web.iiit.ac.in/~pratik.kamble/storage/Algorithms/Cormen_Algorithms_3rd.pdf");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://doc.lagout.org/science/0_Computer%20Science/2_Algorithms/Algorithm%20Design_%20Foundations%2C%20Analysis%2C%20and%20Internet%20Examples%20%5BGoodrich%20%26%20Tamassia%202001%5D.pdf");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://cerocks.files.wordpress.com/2011/03/fundamentals-of-algorithmics-brassard_ingles.pdf");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.cs.sjtu.edu.cn/~jiangli/teaching/CS222/files/materials/Algorithm%20Design.pdf");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://doc.lagout.org/science/0_Computer%20Science/2_Algorithms/Introduction%20to%20Algorithms_%20A%20Creative%20Approach%20%5BManber%201989-01-11%5D.pdf");
        }
    }
}
