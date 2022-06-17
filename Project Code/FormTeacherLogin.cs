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
    public partial class FormTeacherLogin : Form
    {
        Form parentForm;
        int flag = 0;

        public FormTeacherLogin(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void btnTeacherForgot_Click(object sender, EventArgs e)
        {
            FormTeacherForgot newForm = new FormTeacherForgot(this);
            newForm.Show();
        }

        private void btnTeacherReset_Click(object sender, EventArgs e)
        {
            FormTeacherReset newForm = new FormTeacherReset(this);
            newForm.Show();
        }

        private void btnTecherLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 8.0;");
                    con.Open();

                    String read = "SELECT * FROM [Teachers$]";
                    OleDbCommand readCmd = new OleDbCommand(read, con);
                    OleDbDataReader r = readCmd.ExecuteReader();
                    while (r.Read())
                    {
                        if (textBox1.Text == r[1].ToString() && textBox2.Text == r[2].ToString())
                        {
                            flag = 1;
                            Global.currTeacher = textBox1.Text;
                            FormTeacherDashboard newForm = new FormTeacherDashboard(this);
                            newForm.Show();
                            this.Close();
                            con.Close();
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Invalid Credentials.");
                        textBox1.Text = String.Empty;
                        textBox2.Text = String.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("All fields should be filled!");
            }
        }

        private void btnLoginP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
