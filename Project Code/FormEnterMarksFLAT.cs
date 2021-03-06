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
    public partial class FormEnterMarksFLAT : Form
    {
        Form parentForm;

        public FormEnterMarksFLAT(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 8.0;");
                con.Open();
                String qry = "SELECT * FROM [Semester4$]";
                OleDbDataAdapter ad = new OleDbDataAdapter(qry, con);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox5.Text))
            {
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 8.0;");
                    con.Open();
                    String sql = "UPDATE [Semester4$] SET Formal_Language_and_Automata_Theory = @FLAT where StudentId = @ID";
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.Parameters.Add(new OleDbParameter("@FLAT", textBox5.Text));
                    cmd.Parameters.Add(new OleDbParameter("@ID", textBox1.Text));

                    cmd.ExecuteNonQuery();
                    textBox1.Text = String.Empty;
                    textBox5.Text = String.Empty;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 8.0;");
                    con.Open();
                    String qry = "SELECT * FROM [Semester4$]";
                    OleDbDataAdapter ad = new OleDbDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Student ID and marks should be entered to save.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
