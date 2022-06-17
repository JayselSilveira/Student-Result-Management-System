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
    public partial class FormCalcTotalPercentage : Form
    {
        Int64 s1, s2, s3, s4, s5, s6;
        Double total, percentage;
        String r1, r2, r3, r4, r5, r6;
        Form parentForm;

        public FormCalcTotalPercentage(Form form)
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

                String read = "SELECT * FROM [Semester4$]";
                OleDbCommand readCmd = new OleDbCommand(read, con);
                OleDbDataReader r = readCmd.ExecuteReader();
                while (r.Read())
                {
                    Global.calcP = 0;
                    if (r[2].ToString() != "" && r[3].ToString() != "" && r[4].ToString() != "" && r[5].ToString() != "" && r[6].ToString() != "" && r[7].ToString() != "")
                    {
                        Global.calcP = 1;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (Global.calcP == 1)
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
                        r1 = r[2].ToString();
                        r2 = r[3].ToString();
                        r3 = r[4].ToString();
                        r4 = r[5].ToString();
                        r5 = r[6].ToString();
                        r6 = r[7].ToString();

                        s1 = int.Parse(r1);
                        s2 = int.Parse(r2);
                        s3 = int.Parse(r3);
                        s4 = int.Parse(r4);
                        s5 = int.Parse(r5);
                        s6 = int.Parse(r6);
                        total = (s1 + s2 + s3 + s4 + s5 + s6);
                        percentage = total / 6;

                        String sql = "UPDATE [Semester4$] SET Total_Obtained_Marks = '" + total + "', Percentage = '" + percentage + "' WHERE StudentId = @StudentId";
                        OleDbCommand cmd = new OleDbCommand(sql, con);
                        cmd.Parameters.Add(new OleDbParameter("@StudentId", r[0].ToString()));
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                    try
                    {
                        OleDbConnection con1 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 8.0;");
                        con1.Open();
                        String qry = "SELECT * FROM [Semester4$]";
                        OleDbDataAdapter ad = new OleDbDataAdapter(qry, con1);
                        DataSet ds = new DataSet();
                        ad.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        con1.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    MessageBox.Show("Percentage Calculated!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (Global.calcP == 0)
            {
                MessageBox.Show("All marks are not entered.");
                this.Close();
            }
        }

        private void FormCalcTotalPercentage_Load(object sender, EventArgs e)
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
            this.Close();
        }
    }
}