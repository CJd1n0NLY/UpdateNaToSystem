using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace System
{
    public partial class Admin : Form
    {
        private const string connection = "server=localhost;port=3306;database=hotel_system;user=root;password=";

        public Admin()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomNumber.Text) || string.IsNullOrEmpty(txtRoomCapacity.Text) || string.IsNullOrEmpty(txtRoomAmenities.Text) || string.IsNullOrEmpty(txtRoomPrice.Text))
            {
                MessageBox.Show("Kindly complete the blank", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNumber.Text = txtRoomAmenities.Text = txtRoomCapacity.Text = txtRoomPrice.Text = "";
            }
            else
            {
                if (picRoom.Image == null)
                {
                    MessageBox.Show("Please insert an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] photoData;
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        picRoom.Image.Save(ms, picRoom.Image.RawFormat);
                        photoData = ms.ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string roomCapacity = txtRoomCapacity.Text;
                string roomAmenities = txtRoomAmenities.Text;
                string roomPrice = txtRoomPrice.Text;

                string insertQuery = "INSERT INTO roominformation (roomCapacity, roomAmenities, roomPrice, roomPhoto) VALUES (@roomCapacity, @roomAmenities, @roomPrice, @roomPhoto)";

                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.Add("@roomCapacity", MySqlDbType.VarChar).Value = roomCapacity;
                        cmd.Parameters.Add("@roomAmenities", MySqlDbType.VarChar).Value = roomAmenities;
                        cmd.Parameters.Add("@roomPrice", MySqlDbType.VarChar).Value = roomPrice;
                        cmd.Parameters.Add("@roomPhoto", MySqlDbType.Blob).Value = photoData;

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtRoomNumber.Text = txtRoomAmenities.Text = txtRoomCapacity.Text = txtRoomPrice.Text = "";
                            picRoom.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg, *.gif, *.bmp)|*.jpg;*.png;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Image img = Image.FromFile(openFileDialog.FileName))
                    {
                        picRoom.Image = new Bitmap(img);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomNumber.Text))
            {
                MessageBox.Show("Please enter a room number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();

                string sqlSelectquery = "SELECT * FROM roominformation WHERE idRoom = @RoomID";
                using (MySqlCommand cmd = new MySqlCommand(sqlSelectquery, con))
                {
                    cmd.Parameters.AddWithValue("@RoomID", int.Parse(txtRoomNumber.Text));

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            label11.Text = dr["idRoom"].ToString();
                            label12.Text = dr["roomCapacity"].ToString();
                            label13.Text = dr["roomAmenities"].ToString();
                            label15.Text = dr["roomPrice"].ToString();


                            byte[] imageData = (byte[])dr["roomPhoto"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                roomImage.Image = Image.FromStream(ms);
                            }

                            btnInsertImage.Enabled = false;
                            txtRoomCapacity.Enabled = false;
                            txtRoomAmenities.Enabled = false;
                            txtRoomPrice.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Room not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            label11.Text = label12.Text = label13.Text = label15.Text = "";
                            txtRoomAmenities.Text = txtRoomCapacity.Text = txtRoomPrice.Text = "";
                            roomImage.Image = null;



                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label11.Text))
            {
                MessageBox.Show("Please search for a room first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (picRoom.Image == null)
            {
                MessageBox.Show("Please insert an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] photoData;
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    ImageFormat imageFormat = picRoom.Image.RawFormat;
                    picRoom.Image.Save(ms, imageFormat);
                    photoData = ms.ToArray();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string updateQuery = "UPDATE roominformation SET roomCapacity = @roomCapacity, roomAmenities = @roomAmenities, roomPrice = @roomPrice, roomPhoto = @roomPhoto WHERE idRoom = @idRoom";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@roomCapacity", txtRoomCapacity.Text);
                    cmd.Parameters.AddWithValue("@roomAmenities", txtRoomAmenities.Text);
                    cmd.Parameters.AddWithValue("@roomPrice", txtRoomPrice.Text);
                    cmd.Parameters.AddWithValue("@roomPhoto", photoData);
                    cmd.Parameters.AddWithValue("@idRoom", int.Parse(label11.Text));

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRoomNumber.Text = txtRoomAmenities.Text = txtRoomCapacity.Text = txtRoomPrice.Text = "";
                        label11.Text = label12.Text = label13.Text = label15.Text = "";
                      
                    }
                    else
                    {
                        MessageBox.Show("Room not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtRoomCapacity.Text = label12.Text;
            txtRoomAmenities.Text = label13.Text;
            txtRoomPrice.Text = label15.Text;
            picRoom.Image = roomImage.Image;
            txtRoomCapacity.Enabled = true;
            txtRoomAmenities.Enabled = true;
            txtRoomPrice.Enabled = true;
            btnInsertImage.Enabled = true;
        }
    }
}
