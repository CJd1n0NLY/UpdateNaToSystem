
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace System
{
    public partial class Form2 : Form
    {
        // private const string connection = "server=localhost;port=3306;database=hotel_system;user=root;password=";
        public Form2()
        {
            InitializeComponent();
        }

        private const string connection = "server=localhost;port=3306;database=managementsystem;user=root;password=";
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Email = txtEmail.Text;
            string Username = txtUsername.Text;
            string Password = txtConfirmPass.Text;

            string role = null;
            if(rdoAdmin.Checked)
            {
                role = "admin";
            }
            if(rdoUser.Checked)
            {
                role = "staff";
            }

            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtConfirmPass.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Kindly complete the blank.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = txtConfirmPass.Text = txtFirstName.Text = txtLastName.Text = txtUsername.Text = txtPassword.Text = "";
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand checkUsernameCmd = new MySqlCommand("SELECT COUNT(*) FROM accounts WHERE username = @username", con);
                    checkUsernameCmd.Parameters.AddWithValue("@username", Username);
                    int usernameCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());
                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    
                    MySqlCommand checkEmailCmd = new MySqlCommand("SELECT COUNT(*) FROM accounts WHERE email = @email", con);
                    checkEmailCmd.Parameters.AddWithValue("@email", Email);
                    int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());
                    if (emailCount > 0)
                    {
                        MessageBox.Show("Email already exists. Please use a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                   
                    MySqlCommand insertCmd = new MySqlCommand("INSERT INTO accounts(firstname, lastname, email, username, password, role) VALUES (@firstname, @lastname, @email, @username, @password, @role)", con);
                    insertCmd.Parameters.AddWithValue("@firstname", FirstName);
                    insertCmd.Parameters.AddWithValue("@lastname", LastName);
                    insertCmd.Parameters.AddWithValue("@email", Email);
                    insertCmd.Parameters.AddWithValue("@username", Username);
                    insertCmd.Parameters.AddWithValue("@password", Password);
                    insertCmd.Parameters.AddWithValue("@role", role);

                    int result = insertCmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEmail.Text = txtConfirmPass.Text = txtFirstName.Text = txtLastName.Text = txtUsername.Text = txtPassword.Text = "";

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
