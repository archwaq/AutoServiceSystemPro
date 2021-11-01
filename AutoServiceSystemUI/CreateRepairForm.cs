using AutoServiceSystemLibrary;
using AutoServiceSystemLibrary.DataAccess;
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
    public partial class CreateRepairForm : Form
    {
        IRepairRequester callingForm;

        public CreateRepairForm(IRepairRequester caller)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            callingForm = caller;
        }

        private void createRepairButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                RepairModel model = new RepairModel(
                    repairDescriptionValue.Text, 
                    repairPriceValue.Text, 
                    repairCreatedDateValue.Text);


                GlobalConfig.Connection.CreateRepair(model);

                callingForm.RepairComplete(model);

                this.Close();

                //repairDescriptionValue.Text = "";
                //repairPriceValue.Text = "";
                //repairCreatedDateValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.", "Create Repair", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            decimal repairValue = 0;
            bool repairValueValidValue = decimal.TryParse(repairPriceValue.Text, out repairValue);

            if (!repairValueValidValue)
            {
                output = false;
            }

            if (repairValue < 1)
            {
                output = false;
            }

            if (repairDescriptionValue.Text.Length == 0)
            {
                output = false;
            }

            if (repairDescriptionValue.Text.Length > 150)
            {
                output = false;
            }

            if (repairCreatedDateValue.Text.Length == 0)
            {
                output = false;
            }

            if (DateTime.TryParse(repairCreatedDateValue.Text, out DateTime value))
            {
                repairCreatedDateValue.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                return false;
            }

            return output;
        }
    }
}
