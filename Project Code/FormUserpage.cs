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
    public partial class FormUserpage : Form
    {
        Form parentForm;
        public FormUserpage(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FormStudentLogin newForm = new FormStudentLogin(this);
            newForm.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            FormTeacherLogin newForm = new FormTeacherLogin(this);
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
