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
    public partial class FormUploadResults : Form
    {
        Form parentForm;
        int flag = 0;
        String classTrPass;

        public FormUploadResults(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void FormUploadResults_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 8.0;");
                con.Open();

                String read = "SELECT * FROM [Semester4$]";
                OleDbCommand readCmd = new OleDbCommand(read, con);
                OleDbDataReader r = readCmd.ExecuteReader();
                while (r.Read())
                {
                    Global.uploaded = 0;
                    if (r[2].ToString() != "" && r[3].ToString() != "" && r[4].ToString() != "" && r[5].ToString() != "" && r[6].ToString() != "" && r[7].ToString() != "" && r[8].ToString() != "" && r[10].ToString() != "")
                    {
                        Global.uploaded = 1;
                    }
                }
                if (Global.uploaded == 1)
                {
                    MessageBox.Show("Results have been Uploaded!");
                    this.Close();
                }
                if (Global.uploaded == 0)
                {
                    MessageBox.Show("All marks need to be entered and percentage has to be calculated.");
                    this.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
