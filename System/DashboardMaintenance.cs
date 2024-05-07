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
    public partial class DashboardMaintenance : UserControl
    {
        private const string connection = "server=localhost;port=3306;database=managementsystem;user=root;password=";
        public DashboardMaintenance()
        {
            InitializeComponent();
        }

        private void DashboardMaintenance_Load(object sender, EventArgs e)
        {

            for(int i = 0; i < 12; i++)
            {
                cmbHrs.Items.Add(i + 1);
            }

            for (int i = 10; i < 60; i++)
            {
                cmbMinutes.Items.Add(i);
            }


            viewSheduledMaintenance();
            viewOnGoingMaintenance();


        }

        public void viewSheduledMaintenance()
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connection))
            {
                sqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT room_number, maintenance_date, maintenance_time FROM maitenance WHERE maintenance_status = 'Scheduled'", sqlcon);
                DataTable tbl = new DataTable();
                sqlDa.Fill(tbl);

                gridMaintenance.Columns["Column1"].DataPropertyName = "room_number";
                gridMaintenance.Columns["Column2"].DataPropertyName = "maintenance_date";
                gridMaintenance.Columns["Column3"].DataPropertyName = "maintenance_time";
                gridMaintenance.DataSource = tbl;


            }
        }


        public void viewOnGoingMaintenance()
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connection))
            {
                sqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT room_number, maintenance_date, maintenance_time FROM maitenance WHERE maintenance_status = 'On Going'", sqlcon);
                DataTable tbl = new DataTable();
                sqlDa.Fill(tbl);

                gridOnGoing.Columns["Column5"].DataPropertyName = "room_number";
                gridOnGoing.Columns["Column6"].DataPropertyName = "maintenance_date";
                gridOnGoing.Columns["Column7"].DataPropertyName = "maintenance_time";
                gridOnGoing.DataSource = tbl;


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO maitenance(room_number,maintenance_status,maintenance_date,maintenance_time,maintenance_issue) VALUES  (@room_number,@maintenance_status,@maintenance_date,@maintenance_time,@maintenance_issue)";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@room_number", txtRoom.Text);
                    cmd.Parameters.AddWithValue("@maintenance_status", "Reported");
                    cmd.Parameters.AddWithValue("@maintenance_date", dateReported.Text);
                    cmd.Parameters.AddWithValue("@maintenance_time", cmbHrs.Text + ": " + cmbMinutes.Text + " " + guna2ComboBox1.Text);
                    cmd.Parameters.AddWithValue("@maintenance_issue", reportedIssue.Text);


                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRoom.Clear();
                        dateReported.Text = "";
                        cmbHrs.Text = "";
                        cmbMinutes.Text = "";
                        guna2ComboBox1.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
