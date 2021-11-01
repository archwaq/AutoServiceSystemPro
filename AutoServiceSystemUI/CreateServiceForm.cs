using AutoServiceSystemLibrary;
using AutoServiceSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceSystemUI
{
    public partial class CreateServiceForm : Form, IRepairRequester, IClientRequester
    {
        List<ClientModel> applyServicedClient = GlobalConfig.Connection.GetClient_All();
        List<ClientModel> selectedClient = new List<ClientModel>();
        List<RepairModel> selectedRepair = new List<RepairModel>();

        public CreateServiceForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectClientDropDown.DataSource = null;
            selectClientDropDown.DataSource = applyServicedClient;
            selectClientDropDown.DisplayMember = "Identity";

            serviceClientListBox.DataSource = null;
            serviceClientListBox.DataSource = selectedClient;
            serviceClientListBox.DisplayMember = "Identity";

            repairListBox.DataSource = null;
            repairListBox.DataSource = selectedRepair;
            repairListBox.DisplayMember = "FinalResult";
        }

        private void createNewClientLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateClientForm frm = new CreateClientForm(this);
            frm.Show();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            ClientModel c = (ClientModel)selectClientDropDown.SelectedItem;

            if (c != null)
            {
                applyServicedClient.Remove(c);
                selectedClient.Add(c);

                WireUpLists();
            }
        }

        private void createRepairButton_Click(object sender, EventArgs e)
        {
            // Call the CreateRepairForm
            CreateRepairForm frm = new CreateRepairForm(this);
            frm.Show();
        }

        public void RepairComplete(RepairModel model)
        {
            // Get back from the form a RepairModel
            // Take the RepairModel and put it into our list of selected repairs
            selectedRepair.Add(model);
            WireUpLists();
        }

        public void ClientComplete(ClientModel model)
        {
            selectedClient.Add(model);
            WireUpLists();
        }

        private void removeSelectedClientButton_Click(object sender, EventArgs e)
        {
            ClientModel c = (ClientModel)serviceClientListBox.SelectedItem;

            if (c != null)
            {
                selectedClient.Remove(c);
                applyServicedClient.Add(c);

                WireUpLists();
            }
        }

        private void removeSelectedRepairButton_Click(object sender, EventArgs e)
        {
            RepairModel r = (RepairModel)repairListBox.SelectedItem;

            if (r != null)
            {
                selectedRepair.Remove(r);

                WireUpLists();
            }
        }

        private void createServiceButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Create our Service model
                ServiceModel s = new ServiceModel();

                s.Description = serviceDescriptionValue.Text;

                s.CreatedRepairs = selectedRepair;
                s.ServicedClients = selectedClient;

                // Create Service entry
                // Create all of the repairs entries
                // Create all of the clients entries
                GlobalConfig.Connection.CreateService(s);

                WireUpLists();

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.", "Create Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (serviceClientListBox.Items.Count == 0)
            {
                output = false;
            }

            if (serviceClientListBox.Items.Count > 1)
            {
                output = false;
            }

            if (repairListBox.Items.Count == 0)
            {
                output = false;
            }

            if (serviceDescriptionValue.Text.Length == 0)
            {
                output = false;
            }

            if (serviceDescriptionValue.Text.Length > 50)
            {
                output = false;
            }

            return output;
        }
    }
}
