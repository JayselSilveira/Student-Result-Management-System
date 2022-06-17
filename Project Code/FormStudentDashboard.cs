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
    public partial class FormStudentDashboard : Form
    {
        Form parentForm;

        public FormStudentDashboard(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormScorecard newForm = new FormScorecard(this);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProgressReport newForm = new FormProgressReport(this);
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBooks newForm = new FormBooks(this);
            newForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormStudentDashboard_Load(object sender, EventArgs e)
        {
            label2.Text = Global.currStudent;
        }
    }
}
