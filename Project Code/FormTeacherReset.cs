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
    public partial class FormTeacherReset : Form
    {
        Form parentForm;
        int flag = 0;

        public FormTeacherReset(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void btnTfg_Click(object sender, EventArgs e)
        {
            FormStudentForgot newForm = new FormStudentForgot(this);
            newForm.Show();
        }

        private void btnTRest_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 8.0;");
                    con.Open();
                    String sql = "UPDATE [Teachers$] SET [Password] = @Password WHERE Username = @Username";
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.Add(new OleDbParameter("@Password", textBox2.Text));
                    cmd.Parameters.Add(new OleDbParameter("@Username", textBox3.Text));

                    String read = "SELECT * FROM [Teachers$]";
                    OleDbCommand readCmd = new OleDbCommand(read, con);
                    OleDbDataReader r = readCmd.ExecuteReader();
                    while (r.Read())
                    {
                        if (textBox3.Text == r[1].ToString() && textBox1.Text == r[2].ToString())
                        {
                            flag = 1;
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Your password has been changed.");
                            this.Close();
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Invalid Current Credentials.");
                        textBox1.Text = String.Empty;
                        textBox2.Text = String.Empty;
                        textBox3.Text = String.Empty;
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

        private void btnTlg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
