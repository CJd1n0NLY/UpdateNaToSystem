using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class FindAccount : Form
    {
        private const string con = "server=localhost;port=3306;database=managementsystem;user=root;password=";

        string randomcode;
        public static string to;
        public FindAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchForgotPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailForgotPass.Text))
            {
                MessageBox.Show("Please kindly fill up your email to reset your password.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                string findEmail = txtEmailForgotPass.Text;

                string selectQuery = "SELECT * FROM accounts WHERE email = @findEmail;";

                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@findEmail", findEmail);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string from, pass, messagebody;
                                Random rand = new Random();
                                randomcode = (rand.Next(999999)).ToString();
                                MailMessage message = new MailMessage();
                                to = (txtEmailForgotPass.Text).ToString();
                                from = "systemhotel0@gmail.com";
                                pass = "edvd gftb vljk tpbx";
                                messagebody = $"Did you try to reset your password? ... Your Reset Code is {randomcode}";
                                message.To.Add(to);
                                message.From = new MailAddress(from);
                                message.Body = messagebody;
                                message.Subject = "Password Reset Verification Code";
                                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                                smtp.EnableSsl = true;
                                smtp.Port = 587;
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.Credentials = new NetworkCredential(from, pass);
                                try
                                {
                                    smtp.Send(message);
                                    MessageBox.Show("Code Successfully Sent");
                                    label3.Show();
                                    txtCode.Show();
                                    btnVerify.Show();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email not found in our Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Please kindly enter the code we sent to your email to complete changing your password.", "Code Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (randomcode == (txtCode.Text).ToString())
                {
                    to = txtEmailForgotPass.Text;
                    ForgotPass fp = new ForgotPass();
                    this.Hide();
                    fp.Show();
                }
                else
                {
                    MessageBox.Show("The code you have enter doesn't match with the system's auto-generated code.", "Code Mismatch!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


           
        }
    }
}
