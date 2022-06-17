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
    public partial class FormBookOOSE : Form
    {
        public FormBookOOSE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://prof.mau.ac.ir/images/Uploaded_files/Stephen%20R.%20Schach-Object-Oriented%20and%20Classical%20Software%20Engineering,%208th%20Edition%20%20-McGraw-Hill%20Companies%20(2010)[8505044].PDF");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.researchgate.net/publication/310449505_Software_Project_Management_In_Practice_by_Pankaj_Jalote_Book_Review");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://ce.sharif.edu/courses/98-99/2/ce474-2/resources/root/Roger%20S.%20Pressman_%20Bruce%20R.%20Maxin%20-%20Software%20Engineering_%20A%20Practitioner%E2%80%99s%20Approach-McGraw-Hill%20Education%20(2014).pdf");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.researchgate.net/publication/235116544_The_Personal_Software_ProcessSM_PSPSM_Body_of_Knowledge_Version_20");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.softwaretestinggenius.com/download/EMFST.pdf");
        }
        
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://docplayer.net/19647475-The-art-of-software-testing-second-edition.html");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.cs.cmu.edu/~luluo/Courses/17939Report.pdf");
        }
    }
}
