using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class ForgotPass : Form
    {
        string email = FindAccount.to;

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPass.Text) || string.IsNullOrEmpty(txtConfirmNewPass.Text))
            {
                MessageBox.Show("Please kindly enter the code we sent to your email to complete changing your password.", "Code Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string password = txtConfirmNewPass.Text;

                if (txtNewPass.Text == password)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=managementsystem;user=root;password=");
                    string updateQuery = "UPDATE `accounts` SET `password` = '" + password + "' WHERE `email` = '" + email + "'";
                    
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Your new password and confirm password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            }
        }
    }

