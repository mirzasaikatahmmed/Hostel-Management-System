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

namespace Hostel_Management_System.Requests
{
    public partial class ViewRequestStatusForm : Form
    {
        private readonly ServiceRequestController serviceRequestController;
        public ViewRequestStatusForm()
        {
            InitializeComponent();
            serviceRequestController = new ServiceRequestController();
            InitializeFormControls();
            LoadServiceRequestsGrid();
        }

        private void InitializeFormControls()
        {
            statusComboBox.Items.Add("All");
            statusComboBox.Items.Add("Pending");
            statusComboBox.Items.Add("In Progress");
            statusComboBox.Items.Add("Completed");
            statusComboBox.Items.Add("Rejected");
            statusComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndexChanged += new EventHandler(statusComboBox_SelectedIndexChanged);
        }

        private void LoadServiceRequestsGrid(string status = null)
        {
            try
            {
                List<ServiceRequestModel> requestList;

                if (string.IsNullOrEmpty(status) || status == "All")
                {
                    requestList = serviceRequestController.GetAllServiceRequests();
                }
                else
                {
                    requestList = serviceRequestController.GetAllServiceRequests()
                                                        .Where(r => r.Status == status)
                                                        .ToList();
                }

                viewRequestFormDataGridView.DataSource = requestList;
                viewRequestFormDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load service requests: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = statusComboBox.SelectedItem?.ToString();
            LoadServiceRequestsGrid(selectedStatus);
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = 0;
            LoadServiceRequestsGrid();
        }
    }
}