using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mini_Project_2
{
    public partial class FormProgressReport : Form
    {
        Form parentForm;
        public FormProgressReport(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProgressReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 8.0;");
                con.Open();

                String read = "SELECT * FROM [Students$]";
                OleDbCommand readCmd = new OleDbCommand(read, con);
                OleDbDataReader r = readCmd.ExecuteReader();
                while (r.Read())
                {
                    if (Global.currStudent == r[1].ToString())
                    {
                        chart1.Series["Percentage"].Points.AddXY("Semester 1", r[4].ToString());
                        chart1.Series["Percentage"].Points.AddXY("Semester 2", r[5].ToString());
                        chart1.Series["Percentage"].Points.AddXY("Semester 3", r[6].ToString());
                        chart1.Titles.Add("" + r[7].ToString() + "'s Percentage Chart");
                        label4.Text = "" + r[7].ToString() + "'s PROGRESS REPORT";
                        chart1.ChartAreas[0].AxisY.Maximum = 100;
                        chart1.ChartAreas[0].AxisY.Minimum = 0;
                        con.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (Global.uploaded == 1)
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
                        if (Global.currStudName == r[1].ToString())
                        {
                            chart1.Series["Percentage"].Points.AddXY("Semester 4", r[10].ToString());
                            con.Close();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
