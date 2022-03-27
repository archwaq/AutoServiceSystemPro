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
    public partial class CreateVehicleForm : Form
    {
        IVehicleRequester callingForm;
        public CreateVehicleForm(IVehicleRequester caller)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            callingForm = caller;
        }

        private void createVehicleButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                VehicleModel model = new VehicleModel(
                    vehicleIdentificationNumberValue.Text,
                    vehiclePlateValue.Text,
                    vehicleMakeValue.Text,
                    vehicleModelValue.Text,
                    vehicleColorValue.Text);


                GlobalConfig.Connection.CreateVehicle(model);

                callingForm.VehicleComplete(model);

                this.Close();

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
    }
}
