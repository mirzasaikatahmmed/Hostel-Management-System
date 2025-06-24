using Hostel_Management_System.Controller;
using Hostel_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.View.Rooms
{
    public partial class AddRoomForm : Form
    {
        private readonly RoomController roomController;
        private int? roomIdToEdit;
        public AddRoomForm()
        {
            InitializeComponent();
            roomController = new RoomController();
            InitializeFormControls();
            roomIdToEdit = null;
        }

        public AddRoomForm(int roomId)
        {
            InitializeComponent();
            roomController = new RoomController();
            InitializeFormControls();
            roomIdToEdit = roomId;
            LoadRoomDetails();
        }
        private void InitializeFormControls()
        {
            statusComboBox.Items.Add("Available");
            statusComboBox.Items.Add("Occupied");
            statusComboBox.SelectedIndex = 0;
        }
        private void LoadRoomDetails()
        {
            if (roomIdToEdit.HasValue)
            {
                try
                {
                    RoomModel room = roomController.GetRoomById(roomIdToEdit.Value);
                    if (room != null)
                    {
                        roomNoTextBox.Text = room.RoomNumber;
                        capacityTextBox.Text = room.Capacity.ToString();
                        statusComboBox.SelectedItem = room.Status;
                    }
                    else
                    {
                        MessageBox.Show("Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load room details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void addRoomBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomNoTextBox.Text))
            {
                MessageBox.Show("Room Number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(capacityTextBox.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for Capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (statusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = statusComboBox.SelectedItem.ToString();

            RoomModel room = new RoomModel
            {
                RoomNumber = roomNoTextBox.Text.Trim(),
                Capacity = capacity,
                Status = status
            };

            bool success = false;
            try
            {
                if (roomIdToEdit.HasValue)
                {
                    room.RoomID = roomIdToEdit.Value;
                    success = roomController.UpdateRoom(room);
                    if (success)
                    {
                        MessageBox.Show("Room updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update room. Room number might already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    success = roomController.AddRoom(room);
                    if (success)
                    {
                        MessageBox.Show("New Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new room. Room number might already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (success)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
