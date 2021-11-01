using AutoServiceSystemLibrary;
using AutoServiceSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceSystemUI
{
    public partial class CreateClientForm : Form
    {
        private List<VehicleModel> applyClientVehicle = GlobalConfig.Connection.GetVehicle_All();
        private List<VehicleModel> selectedAcquisition = new List<VehicleModel>();
        private IClientRequester callingForm;
        public CreateClientForm(IClientRequester caller)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            callingForm = caller;

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectVehicleAcquisitionDropDown.DataSource = null;

            selectVehicleAcquisitionDropDown.DataSource = applyClientVehicle;
            selectVehicleAcquisitionDropDown.DisplayMember = "Details";

            clientVehicleListBox.DataSource = null;

            clientVehicleListBox.DataSource = selectedAcquisition;
            clientVehicleListBox.DisplayMember = "Details";

        }

        private void vehicleAcquisitionGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void createVehicleButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                VehicleModel v = new VehicleModel();

                v.VehicleIdentificationNumber = vehicleIdentificationNumberValue.Text;
                v.Plate = vehiclePlateValue.Text;
                v.Make = vehicleMakeValue.Text;
                v.Model = vehicleModelValue.Text;
                v.Color = vehicleColorValue.Text;

                GlobalConfig.Connection.CreateVehicle(v);

                selectedAcquisition.Add(v);

                WireUpLists();

                vehicleIdentificationNumberValue.Text = "";
                vehiclePlateValue.Text = "";
                vehicleMakeValue.Text = "";
                vehicleModelValue.Text = "";
                vehicleColorValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill properly in all of the vehicle fields.", "Create Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (vehicleIdentificationNumberValue.Text.Length == 0)
            {
                output = false;
            }

            if (vehicleIdentificationNumberValue.Text.Length > 17)
            {
                output = false;
            }

            if (vehiclePlateValue.Text.Length == 0)
            {
                output = false;
            }

            if (vehiclePlateValue.Text.Length > 10)
            {
                output = false;
            }

            if (vehicleMakeValue.Text.Length == 0)
            {
                output = false;
            }

            if (vehicleMakeValue.Text.Length > 20)
            {
                output = false;
            }

            if (vehicleModelValue.Text.Length == 0)
            {
                output = false;
            }

            if (vehicleModelValue.Text.Length > 50)
            {
                output = false;
            }

            if (vehicleColorValue.Text.Length == 0)
            {
                output = false;
            }

            if (vehicleColorValue.Text.Length > 20)
            {
                output = false;
            }

            return output;
        }

        private void addSelectedVehicleAcquisitionButton_Click(object sender, EventArgs e)
        {
            VehicleModel v = (VehicleModel)selectVehicleAcquisitionDropDown.SelectedItem;

            if (v != null)
            {
                applyClientVehicle.Remove(v);
                selectedAcquisition.Add(v);

                WireUpLists();
            }
        }

        private void removeSelectedVehicleButton_Click(object sender, EventArgs e)
        {
            VehicleModel v = (VehicleModel)clientVehicleListBox.SelectedItem;

            if (v != null)
            {
                selectedAcquisition.Remove(v);
                applyClientVehicle.Add(v);

                WireUpLists();
            }
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {
            if (ValidateMainForm())
            {
                ClientModel c = new ClientModel();

                c.FirstName = clientFirstNameValue.Text;
                c.LastName = clientLastNameValue.Text;
                c.CellphoneNumber = clientCellphoneNumberValue.Text;
                c.Address = clientAddressValue.Text;
                c.Email = clientEmailValue.Text;
                c.NationalCardNumber = clientNationalCardNumberValue.Text;
                c.PersonalIdentificationNumber = clientPersonalIdentificationNumberValue.Text;
                c.VehicleAcquisition = selectedAcquisition;

                GlobalConfig.Connection.CreateClient(c);

                // TODO - if we aren't closing this form after creation, reset the form
                callingForm.ClientComplete(c);
                CreateServiceForm frm = new CreateServiceForm();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to fill properly in all of the client fields", "Create Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateMainForm()
        {
            bool output = true;

            if (clientVehicleListBox.Items.Count == 0)
            {
                output = false;
            }

            if (clientVehicleListBox.Items.Count > 1)
            {
                output = false;
            }

            if (clientFirstNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (clientFirstNameValue.Text.Length > 50)
            {
                output = false;
            }

            if (clientLastNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (clientLastNameValue.Text.Length > 50)
            {
                output = false;
            }

            if (clientCellphoneNumberValue.Text.Length == 0)
            {
                output = false;
            }

            if (clientCellphoneNumberValue.Text.Length > 20)
            {
                output = false;
            }

            if (clientAddressValue.Text.Length == 0)
            {
                output = false;
            }

            if (clientAddressValue.Text.Length > 100)
            {
                output = false;
            }

            if (clientEmailValue.Text.Length == 0)
            {
                output = false;
            }

            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValidEmail = regex.IsMatch(clientEmailValue.Text);
            if (!isValidEmail)
            {
                output = false;
            }            

            if (clientNationalCardNumberValue.Text.Length == 0)
            {
                output = false;
            }

            if (clientNationalCardNumberValue.Text.Length > 20)
            {
                output = false;
            }

            if (clientPersonalIdentificationNumberValue.Text.Length == 0)
            {
                output = false;
            }

            if (clientPersonalIdentificationNumberValue.Text.Length > 10)
            {
                output = false;
            }

            return output;
        }

        private void clientVehicleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
