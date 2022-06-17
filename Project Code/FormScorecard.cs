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
    public partial class FormScorecard : Form
    {
        Form parentForm;
        Double total;
        Double percentage;

        public FormScorecard(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormScorecard_Load(object sender, EventArgs e)
        {
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
                            label39.Text = Global.currStudName;
                            label40.Text = r[0].ToString();

                            label30.Text = r[2].ToString();
                            label31.Text = r[3].ToString();
                            label32.Text = r[4].ToString();
                            label33.Text = r[5].ToString();
                            label34.Text = r[6].ToString();
                            label35.Text = r[7].ToString();

                            this.Controls.Add(label30);
                            this.Controls.Add(label31);
                            this.Controls.Add(label32);
                            this.Controls.Add(label33);
                            this.Controls.Add(label34);
                            this.Controls.Add(label35);

                            total = int.Parse(label30.Text) + int.Parse(label31.Text) + int.Parse(label32.Text) + int.Parse(label33.Text) + int.Parse(label34.Text) + int.Parse(label35.Text);
                            label36.Text = total.ToString();
                            this.Controls.Add(label36);

                            percentage = total / 6;
                            label37.Text = percentage.ToString();
                            this.Controls.Add(label37);

                            if (int.Parse(label30.Text) >= 35 && int.Parse(label31.Text) >= 35 && int.Parse(label32.Text) >= 35 && int.Parse(label33.Text) >= 35 && int.Parse(label34.Text) >= 35 && int.Parse(label35.Text) >= 35)
                            {
                                label38.Text = "PASSED!!!";
                                label38.ForeColor = Color.LimeGreen;
                                break;
                            }
                            else
                            {
                                label38.Text = "FAILED!!!";
                                label38.ForeColor = Color.Red;
                                break;
                            }
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Result has not yet been uploaded.");
                this.Close();
            }
        }
    }
}
