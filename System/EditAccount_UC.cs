using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System
{
    public partial class EditAccount_UC : UserControl
    {
        private const string con = "server=localhost;port=3306;database=managementsystem;user=root;password=";
    
        public EditAccount_UC()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string firstName = txt_Fname.Text;
            string lastName = txt_Lname.Text;
            string email = txt_Email.Text;
            string username = txt_Uname.Text;
            string password = txt_Password.Text;
            string confirmPassword = txt_ConfirmPass.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
        string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) ||
        string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            UpdateAccount(firstName, lastName, email, username, password);            
        }

        private void EditAccount_UC_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Uname.Text) && !string.IsNullOrEmpty(txt_Password.Text))
            {
                string username = txt_Uname.Text;
                string password = txt_Password.Text;

                string selectQuery = "SELECT * FROM accounts WHERE username = @username AND password = @password;";

                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_Fname.Text = reader["firstname"].ToString();
                                txt_Lname.Text = reader["lastname"].ToString();
                                txt_Email.Text = reader["email"].ToString();
                                txt_Uname.Text = reader["username"].ToString();
                                txt_Password.Text = reader["password"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void UpdateAccount(string firstName, string lastName, string email, string username, string password)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(con))
            {
                string updateQuery = "UPDATE accounts SET firstname = @FirstName, lastname = @LastName, email = @Email, username = @Username, password = @Password WHERE idAccounts = @Id";

                MySqlCommand cmd = new MySqlCommand(updateQuery, sqlCon);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    sqlCon.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
