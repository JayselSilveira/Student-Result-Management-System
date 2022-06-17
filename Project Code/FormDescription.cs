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
    public partial class FormDescription : Form
    {
        Form parentForm;
        public FormDescription(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void btnLoginP_Click(object sender, EventArgs e)
        {
            FormUserpage newForm = new FormUserpage(this);
            newForm.Show();
        }
    }
}
