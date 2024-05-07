using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace System
{
    public partial class UserInformation_UC : UserControl
    {
        private const string connection = "server=localhost;port=3306;database=managementsystem;user=root;password=";
        public UserInformation_UC()
        {
            InitializeComponent();
        }

        private void UserInformation_UC_Load(object sender, EventArgs e)
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connection))
            {
                sqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM accounts", sqlcon);
                DataTable tbl = new DataTable();
                sqlDa.Fill(tbl);

                gridUserInfo.DataSource = tbl;
            }
            timer1.Start();
        }

        public void refreshUserInfo()
        {
            string sqlq = "SELECT * FROM accounts";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlq, connection);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "accounts");
            gridUserInfo.DataSource = DS.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshUserInfo();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
