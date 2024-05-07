using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System
{
    public partial class EditRooms_UC : UserControl
    {
        private const string connection = "server=localhost;port=3306;database=managementsystem;user=root;password=";
        public EditRooms_UC()
        {
            InitializeComponent();

        }

        private void EditRooms_UC_Load(object sender, EventArgs e)
        {
            cmbBoxAmenities.Items.Add("Kitchen");
            cmbBoxAmenities.Items.Add("Bathroom");
            cmbBoxAmenities.Items.Add("Bedroom");
            cmbBoxAmenities.Items.Add("Room");

            kitchenAmenitiesGrid.Rows.Add("Coffe Machine");
            kitchenAmenitiesGrid.Rows.Add("Toaster");
            kitchenAmenitiesGrid.Rows.Add("Blender");
            kitchenAmenitiesGrid.Rows.Add("Plates");
            kitchenAmenitiesGrid.Rows.Add("Kitchen Utensils");
            kitchenAmenitiesGrid.Rows.Add("Pans");

            bedroomAmenitiesGrid.Rows.Add("Extra Pillows");
            bedroomAmenitiesGrid.Rows.Add("Hangers");
            bedroomAmenitiesGrid.Rows.Add("Bed Sheets");
            bedroomAmenitiesGrid.Rows.Add("Drawer");
            bedroomAmenitiesGrid.Rows.Add("Wardrobe");

            bathroomAmenitiesGrid.Rows.Add("Shampoo");
            bathroomAmenitiesGrid.Rows.Add("Body Soap");
            bathroomAmenitiesGrid.Rows.Add("Bidet");
            bathroomAmenitiesGrid.Rows.Add("Shower");
            bathroomAmenitiesGrid.Rows.Add("Bath Towel");
            bathroomAmenitiesGrid.Rows.Add("Hair Dryer");

            roomsAmenitiesGrid.Rows.Add("Wifi");
            roomsAmenitiesGrid.Rows.Add("Air Condition");
            roomsAmenitiesGrid.Rows.Add("Room Service");
            roomsAmenitiesGrid.Rows.Add("Free Parking");
            roomsAmenitiesGrid.Rows.Add("Washing Machine");
            roomsAmenitiesGrid.Rows.Add("Luggage Storage");
        }

        private void cmbBoxAmenities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxAmenities.SelectedIndex == 0)
            {
                kitchenAmenities.Visible = true;
                bathroomAmenities.Visible = false;
                bedroomAmenities.Visible = false;
                roomAmenities.Visible = false;
            }
            else if (cmbBoxAmenities.SelectedIndex == 1)
            {
                kitchenAmenities.Visible = false;
                bathroomAmenities.Visible = true;
                bedroomAmenities.Visible = false;
                roomAmenities.Visible = false;
            }
            else if (cmbBoxAmenities.SelectedIndex == 2)
            {
                kitchenAmenities.Visible = false;
                bathroomAmenities.Visible = false;
                bedroomAmenities.Visible = true;
                roomAmenities.Visible = false;
            }
            else if (cmbBoxAmenities.SelectedIndex == 3)
            {
                kitchenAmenities.Visible = false;
                bathroomAmenities.Visible = false;
                bedroomAmenities.Visible = false;
                roomAmenities.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Rooms Checkbox
            cbKitchen.Checked = false;
            cbBathroom.Checked = false;
            cbBedroom.Checked = false;
            cbBalcony.Checked = false;

            //Kitchen Amenities Checkbox
            cbCoffeeMachine.Checked = false;
            cbToaster.Checked = false;
            cbBlender.Checked = false;
            cbPlates.Checked = false;
            cbUtensils.Checked = false;
            cbPans.Checked = false;

            //Bathroom Amenities Checkbox
            cbShampoo.Checked = false;
            cbBodySoap.Checked = false;
            cbBidet.Checked = false;
            cbShower.Checked = false;
            cbBathTowel.Checked = false;
            cbHairDryer.Checked = false;

            //Bedroom Amenities Checkbox
            cbExtraPillows.Checked = false;
            cbHangers.Checked = false;
            cbBedSheets.Checked = false;
            cbDrawer.Checked = false;
            cbWardrobe.Checked = false;

            //Room Amenities Checkbox
            cbWifi.Checked = false;
            cbAirConditioned.Checked = false;
            cbRoomService.Checked = false;
            cbFreeParking.Checked = false;
            cbWashingMachine.Checked = false;
            cbLuggageStorage.Checked = false;
        }
        private string roomInclusions()
        {
            string inclusions = "";
            if (cbKitchen.Checked)
                inclusions += "Kitchen, ";
            if (cbBathroom.Checked)
                inclusions += "Bathroom, ";
            if (cbBedroom.Checked)
                inclusions += "Bedroom, ";
            if (cbBalcony.Checked)
                inclusions += "Balcony, ";


            if (!string.IsNullOrEmpty(inclusions))
                inclusions = inclusions.TrimEnd(',', ' ');
            return inclusions;
        }


        private string roomAminities()
        {
            string Amenities = "";
            //Kitchen Amenities Checkbox
            if (cbCoffeeMachine.Checked)
                Amenities += "Coffee Machine, ";

            if (cbToaster.Checked)
                Amenities += "Toaster, ";

            if (cbBlender.Checked)
                Amenities += "Blender, ";

            if (cbPlates.Checked)
                Amenities += "Plates, ";

            if (cbUtensils.Checked)
                Amenities += "Utensils, ";

            if (cbPans.Checked)
                Amenities += "Pans, ";

            //Bathroom Amenities Checkbox
            if (cbShampoo.Checked)
                Amenities += "Shampoo, ";

            if (cbBodySoap.Checked)
                Amenities += "Body Soap, ";

            if (cbBidet.Checked)
                Amenities += "Bidet, ";

            if (cbShower.Checked)
                Amenities += "Shower, ";

            if (cbBathTowel.Checked)
                Amenities += "Bath Towel, ";

            if (cbHairDryer.Checked)
                Amenities += "Hair Dryer, ";

            //Bedroom Amenities Checkbox
            if (cbExtraPillows.Checked)
                Amenities += "Extra Pillows, ";

            if (cbHangers.Checked)
                Amenities += "Hangers, ";

            if (cbBedSheets.Checked)
                Amenities += "Bed Sheets, ";

            if (cbDrawer.Checked)
                Amenities += "Drawer, ";

            if (cbWardrobe.Checked)
                Amenities += "Wardrobe, ";

            //Room Amenities Checkbox
            if (cbWifi.Checked)
                Amenities += "Wifi, ";

            if (cbAirConditioned.Checked)
                Amenities += "Air Conditioned, ";

            if (cbRoomService.Checked)
                Amenities += "Room Service, ";

            if (cbFreeParking.Checked)
                Amenities += "Free Parking, ";

            if (cbWashingMachine.Checked)
                Amenities += "Washing Machine, ";

            if (cbLuggageStorage.Checked)
                Amenities += "Luggage Storage, ";

            if (!string.IsNullOrEmpty(Amenities))
                Amenities = Amenities.TrimEnd(',', ' ');

            return Amenities;
        }





        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomNumber.Text))
            {
                MessageBox.Show("Please enter a room number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectQuery = "SELECT idRooms, room_capacity, rooms_included, room_price FROM rooms WHERE idRooms = @idRoom";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, con))
                {
                    cmd.Parameters.AddWithValue("@idRoom", txtRoomNumber.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label11.Text = reader["idRooms"].ToString();
                            label12.Text = reader["room_capacity"].ToString();
                            label3.Text = reader["rooms_included"].ToString();
                       /*     string roomAmenities = reader["roomAmenities"].ToString();
                            string[] amenitiesArray = roomAmenities.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                            StringBuilder displayText = new StringBuilder();
                            int amenityCount = 0;
                            foreach (string amenity in amenitiesArray)
                            {
                                displayText.Append(amenity.Trim());
                                displayText.Append(" | ");
                                amenityCount++;

                                if (amenityCount % 4 == 0)
                                    displayText.AppendLine();
                            }*/

                            label15.Text = reader["room_price"].ToString();

                            btnCancel.Enabled = false;
                            btnUpdate.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Room not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            label11.Text = label12.Text = label3.Text = label15.Text;
                        }
                    }
                }
            }

            showKitchenAmenities();
            showBathroomAmenities();
            showBedroomAmenities();
            showRoomsAmenities();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE  SET roomCapacity = @roomCapacity, roomInclustions = @roomInclustions, roomAmenities = @roomAmenities, roomPrice = @roomPrice,roomAmenities = @roomAmenities WHERE idRoom = @idRoom";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                string inclusions = roomInclusions();
                string Aminities = roomAminities();
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@roomInclusions", txtRoomCapacity.Text);
                    cmd.Parameters.AddWithValue("@roomCapacity", inclusions);
                    cmd.Parameters.AddWithValue("@roomAmenities", Aminities);
                    cmd.Parameters.AddWithValue("@roomPrice", txtRoomPrice.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Room not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

            String CoffeeMachine = "Not Available";
            String Toaster = "Not Available";
            String Blender = "Not Available";
            String Plates = "Not Available";
            String KitchenUtensils = "Not Available";
            String Pans = "Not Available";
            String roomId = label11.Text;

            if (cbCoffeeMachine.Checked)
            {
               CoffeeMachine = "Available";
            }
            if (cbToaster.Checked)
            {
                Toaster = "Available";
            }

            if (cbBlender.Checked)
            {
               Blender = "Available";
            }

            if (cbPlates.Checked)
            {
               Plates = "Available";
            }

            if (cbUtensils.Checked)
            {
               KitchenUtensils = "Available";
            }

            if (cbPans.Checked)
            {
               Pans = "Available";
            }


            string insertQuery = "INSERT INTO kitchen_amenities(coffee_machine,toaster,blender,plates,kitchen_utensils,pans, idRooms) VALUES  (@coffee_machine,@toaster,@blender,@plates,@kitchen_utensils,@pans, @idRooms)";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@coffee_machine", CoffeeMachine);
                    cmd.Parameters.AddWithValue("@toaster", Toaster);
                    cmd.Parameters.AddWithValue("@blender", Blender);
                    cmd.Parameters.AddWithValue("@plates", Plates);
                    cmd.Parameters.AddWithValue("@kitchen_utensils", KitchenUtensils);
                    cmd.Parameters.AddWithValue("@pans", Pans);
                    cmd.Parameters.AddWithValue("@idRooms", roomId);

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
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            String Shampoo = "Not Available";
            String BodySoap = "Not Available";
            String Bidet = "Not Available";
            String Shower = "Not Available";
            String BathTowel = "Not Available";
            String HairDryer = "Not Available";
            String roomId = label11.Text;

            if (cbShampoo.Checked)
            {
                Shampoo = "Available";
            }

            if (cbBodySoap.Checked)
            {
                BodySoap = "Available";
            }

            if (cbBidet.Checked)
            {
               Bidet = "Available";
            }

            if (cbShower.Checked)
            {
               Shower = "Available";
            }
            if (cbBathTowel.Checked)
            {
                BathTowel = "Available";
            }

            if (cbHairDryer.Checked)
            {
                HairDryer = "Available";

            }


            string insertQuery = "INSERT INTO bathroom_amenities(shampoo,body_soap,bidet,shower,bath_towel,hair_dryer, idRooms) VALUES  (@shampoo,@body_soap,@bidet,@shower,@bath_towel,@hair_dryer, @idRooms)";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@shampoo", Shampoo);
                    cmd.Parameters.AddWithValue("@body_soap", BodySoap);
                    cmd.Parameters.AddWithValue("@bidet", Bidet);
                    cmd.Parameters.AddWithValue("@shower", Shower);
                    cmd.Parameters.AddWithValue("@bath_towel", BathTowel);
                    cmd.Parameters.AddWithValue("@hair_dryer", HairDryer);
                    cmd.Parameters.AddWithValue("@idRooms", roomId);

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
        }

        private void cbRoomService_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAirConditioned_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbWifi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            String Wifi = "Not Available";
            String AirCondition = "Not Available";
            String RoomService = "Not Available";
            String FreeParking = "Not Available";
            String WashingMachine = "Not Available";
            String LuggageStorage = "Not Available";
            String roomId = label11.Text;

            //Room Amenities Checkbox
            if (cbWifi.Checked)
            {
                Wifi = "Available";
            }


            if (cbAirConditioned.Checked)
            {
               AirCondition = "Available";
            }


            if (cbRoomService.Checked)
            {
                RoomService = "Available";
            }


            if (cbFreeParking.Checked)
            {
               FreeParking = "Available";
            }


            if (cbWashingMachine.Checked)
            {
               WashingMachine = "Available";
            }


            if (cbLuggageStorage.Checked)
            {
                LuggageStorage = "Available";
            }

            string insertQuery = "INSERT INTO room_amenities(wifi,air_conditioned,room_service,free_parking,washing_machine,luggage_storage, idRooms) VALUES  (@wifi,@air_conditioned,@room_service,@free_parking,@washing_machine,@luggage_storage,@idRooms)";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@wifi",Wifi);
                    cmd.Parameters.AddWithValue("@air_conditioned",AirCondition);
                    cmd.Parameters.AddWithValue("@room_service", RoomService);
                    cmd.Parameters.AddWithValue("@free_parking", FreeParking);
                    cmd.Parameters.AddWithValue("@washing_machine", WashingMachine);
                    cmd.Parameters.AddWithValue("@luggage_storage", LuggageStorage);
                    cmd.Parameters.AddWithValue("@idRooms", roomId);

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
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            String ExtraPillows = "Not Available";
            String Hangers = "Not Available";
            String BedSheets = "Not Available";
            String Drawers = "Not Available";
            String Wardrobe = "Not Available";
            String roomId = label11.Text;

            if (cbExtraPillows.Checked)
            {
                ExtraPillows = "Available";
            }


            if (cbHangers.Checked)
            {
               Hangers = "Available";
            }


            if (cbBedSheets.Checked)
            {
               BedSheets = "Available";
            }


            if (cbDrawer.Checked)
            {
               Drawers = "Available";
            }


            if (cbWardrobe.Checked)
            {
               Wardrobe = "Available";
            }



            string insertQuery = "INSERT INTO bedroom_amenities(extra_pillow,hangers,bed_sheets,drawers,wardrobe,idRooms) VALUES  (@extra_pillow,@hangers,@bed_sheets,@drawers,@wardrobe,@idRooms)";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@extra_pillow", ExtraPillows);
                    cmd.Parameters.AddWithValue("@hangers",Hangers);
                    cmd.Parameters.AddWithValue("@bed_sheets",BedSheets);
                    cmd.Parameters.AddWithValue("@drawers",Drawers);
                    cmd.Parameters.AddWithValue("@wardrobe", Wardrobe);
                    cmd.Parameters.AddWithValue("@idRooms", roomId);

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
        }


        public void showKitchenAmenities()
        {
            String roomId = label11.Text;

            string sqlQuery = "SELECT coffee_machine, toaster, blender, plates, kitchen_utensils, pans FROM kitchen_amenities WHERE idRooms = @roomId";
            string connectionString = "server=localhost;port=3306;database=managementsystem;user=root;password=";

            MySqlConnection connectionSql = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sqlQuery, connectionSql);
            cmd.Parameters.AddWithValue("@roomId", roomId);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            try
            {
                connectionSql.Open();
                dataAdapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            finally
            {
                connectionSql.Close();
            }

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    kitchenAmenitiesGrid.Rows[i].Cells[1].Value = dt.Rows[0][i];
                }
            }
        }

        public void showBathroomAmenities()
        {
            String roomId = label11.Text;

            string sqlQuery = "SELECT shampoo, body_soap, bidet,shower, bath_towel, hair_dryer FROM bathroom_amenities WHERE idRooms = @roomId";
            string connectionString = "server=localhost;port=3306;database=managementsystem;user=root;password=";

            MySqlConnection connectionSql = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sqlQuery, connectionSql);
            cmd.Parameters.AddWithValue("@roomId", roomId);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            try
            {
                connectionSql.Open();
                dataAdapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            finally
            {
                connectionSql.Close();
            }

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    bathroomAmenitiesGrid.Rows[i].Cells[1].Value = dt.Rows[0][i];
                }
            }
        }

        public void showBedroomAmenities()
        {
            String roomId = label11.Text;

            string sqlQuery = "SELECT extra_pillow, hangers, bed_sheets,drawers, wardrobe FROM bedroom_amenities WHERE idRooms = @roomId";
            string connectionString = "server=localhost;port=3306;database=managementsystem;user=root;password=";

            MySqlConnection connectionSql = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sqlQuery, connectionSql);
            cmd.Parameters.AddWithValue("@roomId", roomId);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            try
            {
                connectionSql.Open();
                dataAdapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            finally
            {
                connectionSql.Close();
            }

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    bedroomAmenitiesGrid.Rows[i].Cells[1].Value = dt.Rows[0][i];
                }
            }
        }

        public void showRoomsAmenities()
        {
            String roomId = label11.Text;

            string sqlQuery = "SELECT wifi, air_conditioned, room_service, free_parking, washing_machine, luggage_storage FROM room_amenities WHERE idRooms = @roomId";
            string connectionString = "server=localhost;port=3306;database=managementsystem;user=root;password=";

            MySqlConnection connectionSql = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sqlQuery, connectionSql);
            cmd.Parameters.AddWithValue("@roomId", roomId);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            try
            {
                connectionSql.Open();
                dataAdapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            finally
            {
                connectionSql.Close();
            }

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    roomsAmenitiesGrid.Rows[i].Cells[1].Value = dt.Rows[0][i];
                }
            }
        }

        private void AdminBg_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
