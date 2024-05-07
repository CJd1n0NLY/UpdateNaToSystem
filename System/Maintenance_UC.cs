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
    public partial class Maintenance_UC : UserControl
    {
        private int clickedRowIndex;
        String maintenanceTImeSchedule = "";
        private const string connection = "server=localhost;port=3306;database=managementsystem;user=root;password=";
        public Maintenance_UC()
        {
            InitializeComponent();
        }

        private void Maintenance_UC_Load(object sender, EventArgs e)
        {
     
            cbMaintenanceStatus.Items.Add("Not Set");
            cbMaintenanceStatus.Items.Add("Scheduled");
            cbMaintenanceStatus.Items.Add("On Going");

            showMaintenanceInformation();
            showReportedMaintenance();


        }

        private void showMaintenanceInformation()
        {

            using (MySqlConnection sqlcon = new MySqlConnection(connection))
            {
                sqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT room_number, maintenance_status, maintenance_date, maintenance_time, maintenance_issue FROM maitenance", sqlcon);
                DataTable tbl = new DataTable();
                sqlDa.Fill(tbl);

                gridMaintenance.Columns["Column1"].DataPropertyName = "room_number";
                gridMaintenance.Columns["Column2"].DataPropertyName = "maintenance_status";
                gridMaintenance.Columns["Column3"].DataPropertyName = "maintenance_date";
                gridMaintenance.Columns["Column4"].DataPropertyName = "maintenance_time";
                gridMaintenance.Columns["Column5"].DataPropertyName = "maintenance_issue";

                gridMaintenance.DataSource = tbl;


            }
        }

        private void showReportedMaintenance()
        {

            using (MySqlConnection sqlcon = new MySqlConnection(connection))
            {
                sqlcon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT room_number, maintenance_date, maintenance_time, maintenance_issue FROM maitenance WHERE maintenance_status = 'Reported'", sqlcon);
                DataTable tbl = new DataTable();
                sqlDa.Fill(tbl);

                gridReport.Columns["Column6"].DataPropertyName = "room_number";
                gridReport.Columns["Column7"].DataPropertyName = "maintenance_date";
                gridReport.Columns["Column8"].DataPropertyName = "maintenance_time";
                gridReport.Columns["Column9"].DataPropertyName = "maintenance_issue";

                gridReport.DataSource = tbl;


            }
        }

        private void gridMaintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedRowIndex = e.RowIndex;

            DataGridViewRow row = gridMaintenance.Rows[e.RowIndex];
            txtRoomNumber.Text = row.Cells[0].Value.ToString();
            roomIssue.Text = row.Cells[4].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (clickedRowIndex >= 0)
            {
                if(cbMaintenanceStatus.Text != "")
                {
                    MessageBox.Show("Maintenance Successfully Scheduled");
                    gridMaintenance.Rows[clickedRowIndex].Cells[1].Value = cbMaintenanceStatus.Text;
                    gridMaintenance.Rows[clickedRowIndex].Cells[2].Value = dateTimePicker.Text;
                    gridMaintenance.Rows[clickedRowIndex].Cells[3].Value = maintenanceTImeSchedule;

                    string insertQuery = "INSERT INTO maintenance(room_number,maintenance_status,maintenance_date,maintenance_time,maintenance_issue) VALUES  (@room_number,@maintenance_status,@maintenance_date,@maintenance_time,@maintenance_issue)";

                    using (MySqlConnection con = new MySqlConnection(connection))
                    {
                        con.Open();
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@room_number", txtRoomNumber.Text);
                            cmd.Parameters.AddWithValue("@maintenance_status", cbMaintenanceStatus.Text);
                            cmd.Parameters.AddWithValue("@maintenance_date", dateTimePicker.Text);
                            cmd.Parameters.AddWithValue("@maintenance_time", maintenanceTImeSchedule);
                            cmd.Parameters.AddWithValue("@maintenance_issue", roomIssue.Text);
   

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    showMaintenanceInformation();
                    showReportedMaintenance();
                }
            }
            else
            {
                MessageBox.Show("No row has been clicked yet.");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            tmrSetTime.Start();
        }


        bool timeSetExpanded = true;
        private void tmrSetTime_Tick(object sender, EventArgs e)
        {
            if (timeSetExpanded)
            {
                tmrSetTime.Start();
                panelSetTime.Height += 10;
                if(panelSetTime.Height >= 198)
                {
                    tmrSetTime.Stop();
                    timeSetExpanded = false;
                }
            } else
            {
                tmrSetTime.Start();
                panelSetTime.Height -= 10;
                if(panelSetTime.Height <= 0)
                {
                    tmrSetTime.Stop();
                    timeSetExpanded = true;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void btn7am_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "7:00 AM";
        }

        private void btn9am_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "9:00 AM";
        }

        private void btn10am_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "10:00 AM";
        }

        private void btn8am_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "8:00 AM";
        }

        private void btn11am_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "11:00 AM";
        }

        private void btn12pm_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "12:00 PM";
        }

        private void btn1pm_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "1:00 PM";
        }

        private void btn2pm_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "2:00 PM";
        }

        private void btn3pm_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "3:00 PM";
        }

        private void btn4pm_Click(object sender, EventArgs e)
        {
            maintenanceTImeSchedule = "4:00 PM";
        }

        private void gridReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedRowIndex = e.RowIndex;

            DataGridViewRow row = gridReport.Rows[e.RowIndex];
            txtRoomNumber.Text = row.Cells[0].Value.ToString();
            roomIssue.Text = row.Cells[3].Value.ToString();
        }
    
    }

 
}
