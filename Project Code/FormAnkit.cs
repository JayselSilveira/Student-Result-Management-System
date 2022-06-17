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
    public partial class FormAnkit : Form
    {
        Form parentForm;
        public FormAnkit(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
