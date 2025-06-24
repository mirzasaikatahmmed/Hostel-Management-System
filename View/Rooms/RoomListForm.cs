using Hostel_Management_System.Controller;
using Hostel_Management_System.Model;
using Hostel_Management_System.View.Rooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Rooms
{
    public partial class RoomListForm : Form
    {
        private readonly RoomController roomController;

        public RoomListForm()
        {
            InitializeComponent();
            roomController = new RoomController();
            LoadRoomGrid();
        }

        private void LoadRoomGrid(string roomNumberFilter = null)
        {
            try
            {
                List<RoomModel> roomList = roomController.GetAllRooms();

                if (!string.IsNullOrWhiteSpace(roomNumberFilter))
                {
                    roomList = roomList.Where(r => r.RoomNumber.ToLower().Contains(roomNumberFilter.ToLower())).ToList();
                }

                roomListFormDataGridView.DataSource = roomList;
                roomListFormDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load room list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchRoomNumber = roomNoTextBox.Text.Trim();
            LoadRoomGrid(searchRoomNumber);
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            roomNoTextBox.Text = string.Empty;
            LoadRoomGrid();
        }

        private void addRoomBTN_Click(object sender, EventArgs e)
        {
            AddRoomForm form = new AddRoomForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadRoomGrid();
            }
        }

        private void updateRoomBTN_Click(object sender, EventArgs e)
        {
            if (roomListFormDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = roomListFormDataGridView.SelectedRows[0];

                if (int.TryParse(selectedRow.Cells["RoomID"].Value?.ToString(), out int roomId))
                {
                    AddRoomForm editForm = new AddRoomForm(roomId);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadRoomGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid room selected. Please ensure the selected row has a valid Room ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a room to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteRoomBTN_Click(object sender, EventArgs e)
        {
            if (roomListFormDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = roomListFormDataGridView.SelectedRows[0];

                if (int.TryParse(selectedRow.Cells["RoomID"].Value?.ToString(), out int roomId))
                {
                    string roomNumber = selectedRow.Cells["RoomNumber"].Value?.ToString();

                    DialogResult confirmResult = MessageBox.Show(
                        $"Are you sure you want to delete room {roomNumber} (ID: {roomId})?\n" +
                        "This action cannot be undone and may affect related data (e.g., RoomAssignments, ServiceRequests, UtilityBills).",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        bool success = roomController.DeleteRoom(roomId);

                        if (success)
                        {
                            MessageBox.Show($"Room {roomNumber} deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadRoomGrid();
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete room {roomNumber}. It might be associated with students or bills.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid room selected. Please ensure the selected row has a valid Room ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void assignRoomBTN_Click(object sender, EventArgs e)
        {
            AssignRoomForm form = new AssignRoomForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadRoomGrid();
            }
        }
    }
}