using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mini_Project_2
{
    public partial class FormTeacherDashboard : Form
    {
        Form parentForm;

        public FormTeacherDashboard(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormUlpa newForm = new FormUlpa(this);
            newForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormAmrita newForm = new FormAmrita(this);
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormJanhavi newForm = new FormJanhavi(this);
            newForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormVivek newForm = new FormVivek(this);
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAmey newForm = new FormAmey(this);
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAnkit newForm = new FormAnkit(this);
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBooks newForm = new FormBooks(this);
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Global.currTeacher == "Ulpa_Waingankar")
            {
                FormEnterMarksDM newForm = new FormEnterMarksDM(this);
                newForm.Show();
            }
            if (Global.currTeacher == "Amrita_Naik")
            {
                FormEnterMarksMADF newForm = new FormEnterMarksMADF(this);
                newForm.Show();
            } 
            if (Global.currTeacher == "Janhavi_Naik")
            {
                FormEnterMarksOOSE newForm = new FormEnterMarksOOSE(this);
                newForm.Show();
            }
            if (Global.currTeacher == "Vivek_Jog")
            {
                FormEnterMarksMPMC newForm = new FormEnterMarksMPMC(this);
                newForm.Show();
            }
            if (Global.currTeacher == "Amey_Kerkar")
            {
                FormEnterMarksFLAT newForm = new FormEnterMarksFLAT(this);
                newForm.Show();
            }
            if (Global.currTeacher == "Ankit_Tiwari")
            {
                FormEnterMarksECO newForm = new FormEnterMarksECO(this);
                newForm.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUploadResults newForm = new FormUploadResults(this);
            newForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormTeacherDashboard_Load(object sender, EventArgs e)
        {
            label2.Text = Global.currTeacher;
            if (Global.currTeacher == "Ankit_Tiwari")
            {
                button2.Visible = true;
                pictureBox1.Image = pictureBox3.Image;
            }
            else
            {
                button2.Visible = false;
                if (Global.currTeacher == "Ulpa_Waingankar")
                {
                    pictureBox1.Image = pictureBox2.Image;
                }
                if (Global.currTeacher == "Amrita_Naik")
                {
                    pictureBox1.Image = pictureBox7.Image;
                }
                if (Global.currTeacher == "Janhavi_Naik")
                {
                    pictureBox1.Image = pictureBox6.Image;
                }
                if (Global.currTeacher == "Vivek_Jog")
                {
                    pictureBox1.Image = pictureBox5.Image;
                }
                if (Global.currTeacher == "Amey_Kerkar")
                {
                    pictureBox1.Image = pictureBox4.Image;
                }
            }
        }
    }
}
