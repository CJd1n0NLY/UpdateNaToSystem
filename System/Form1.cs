using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace System
{
    public partial class Form1 : Form
    {
        private Timer animationTimer;
        private int animationCounter;
        private int animationDuration = 10;
        private const string con = "server=localhost;port=3306;database=managementsystem;user=root;password=";

        public Form1()
        {
            InitializeComponent();
            InitializeAnimationTimer();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new Timer();
            animationTimer.Interval = animationDuration;
            animationTimer.Tick += timerSignUp_Tick;
        }


        private void lblSignup_Click(object sender, EventArgs e)
        {
            animationCounter = 0;
            animationTimer.Start();
        }

        private void timerSignUp_Tick(object sender, EventArgs e)
        {
            animationCounter++;

            if (animationCounter <= 30) // Adjust the value as needed for desired animation duration
            {
                // Fade out the login form
                this.Opacity -= 0.08;
                // Slide out the login form to the left
                this.Left -= 10;
            }
            else
            {
                // Stop the animation timer
                animationTimer.Stop();

                // Create and show the signup form
                Form2 form2 = new Form2();
                form2.Left = this.Left + this.Width; // Position the signup form to the right of the login form
                form2.Show();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = "";

            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("No input..", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = txtUsername.Text = "";
            }
            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                string selectQuery = "SELECT * FROM accounts WHERE username = @username AND password = @password;";
                string roleQuery = "SELECT role FROM accounts WHERE username = @username AND password = @password;";

                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                sdr.Close();

                                using (MySqlCommand roleCmd = new MySqlCommand(roleQuery, connection))
                                {
                                    roleCmd.Parameters.AddWithValue("@username", username);
                                    roleCmd.Parameters.AddWithValue("@password", password);

                                    using (MySqlDataReader roleReader = roleCmd.ExecuteReader())
                                    {
                                        if (roleReader.Read())
                                        {
                                            role = roleReader["role"].ToString();
                                        }
                                    }
                                }

                                if (role == "staff")
                                {
                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    Dashboard dashboard = new Dashboard();
                                    dashboard.Show();


                                }
                                else if (role == "admin")
                                {

                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    AdminDashboard adminDashboard = new AdminDashboard();
                                    adminDashboard.Show();



                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnShowpassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '●';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FindAccount fa = new FindAccount();
            this.Hide();
            fa.Show();
        }
    }
}

      
        

   

 
