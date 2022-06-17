using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;

namespace Mini_Project_2
{
    public partial class FormStudentForgot : Form
    {
        string randomCode;
        public static string to;

        Form parentForm;

        public FormStudentForgot(Form form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtemailid.Text) && !string.IsNullOrEmpty(textcode.Text))
            {
                try
                {
                    int flag = 0;
                    OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 12.0;");
                    con.Open();
                    String sql = "UPDATE [Students$] SET [Password] = @Password WHERE EmailId = @EmailId";
                    OleDbCommand cmd = new OleDbCommand(sql, con);

                    cmd.Parameters.Add(new OleDbParameter("@Password", textcode.Text));
                    cmd.Parameters.Add(new OleDbParameter("@EmailId", txtemailid.Text));

                    String read = "SELECT * FROM [Students$]";
                    OleDbCommand readCmd = new OleDbCommand(read, con);
                    OleDbDataReader r = readCmd.ExecuteReader();
                    while (r.Read())
                    {
                        if (randomCode == (textcode.Text).ToString() && txtemailid.Text == r[3].ToString())
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
                        MessageBox.Show("Invalid Password!");
                        textcode.Text = String.Empty;
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

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtemailid.Text))
            {
                try
                {
                    int flag = 0;

                    string from, messagebody, pass;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();
                    from = "donboscocollegeengineering@gmail.com";

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(from);
                    message.Subject = "New Login Password";
                    messagebody = "Your new Password : " + randomCode;
                    message.Body = messagebody;
                    message.Priority = MailPriority.High;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                    to = (txtemailid.Text).ToString();

                    pass = "Dbce@123";

                    message.To.Add(to);

                    smtp.UseDefaultCredentials = false;

                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'D:\\StudentResultManagementSystem.xlsx'; Extended Properties = Excel 12.0;");
                    con.Open();
                    String read = "SELECT * FROM [Students$]";
                    OleDbCommand readCmd = new OleDbCommand(read, con);
                    OleDbDataReader r = readCmd.ExecuteReader();

                    while (r.Read())
                    {
                        if (txtemailid.Text == r[3].ToString())
                        {
                            flag = 1;
                            con.Close();
                            smtp.Send(message);
                            MessageBox.Show("Password sent successfully!");
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Invalid Email Id!");
                        txtemailid.Text = String.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Email ID should be entered!");
            }
        }
    }
}
