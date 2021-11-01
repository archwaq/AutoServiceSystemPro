
namespace AutoServiceSystemUI
{
    partial class CreateServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateServiceForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.serviceDescriptionLabel = new System.Windows.Forms.Label();
            this.serviceDescriptionValue = new System.Windows.Forms.TextBox();
            this.selectClientDropDown = new System.Windows.Forms.ComboBox();
            this.selectClientLabel = new System.Windows.Forms.Label();
            this.createNewClientLink = new System.Windows.Forms.LinkLabel();
            this.addClientButton = new System.Windows.Forms.Button();
            this.createRepairButton = new System.Windows.Forms.Button();
            this.serviceClientListBox = new System.Windows.Forms.ListBox();
            this.servicedClientLabel = new System.Windows.Forms.Label();
            this.removeSelectedRepairButton = new System.Windows.Forms.Button();
            this.repairLabel = new System.Windows.Forms.Label();
            this.repairListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedClientButton = new System.Windows.Forms.Button();
            this.createServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.headerLabel.Location = new System.Drawing.Point(21, 24);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(284, 59);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Create Service";
            // 
            // serviceDescriptionLabel
            // 
            this.serviceDescriptionLabel.AutoSize = true;
            this.serviceDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serviceDescriptionLabel.Location = new System.Drawing.Point(61, 137);
            this.serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            this.serviceDescriptionLabel.Size = new System.Drawing.Size(158, 38);
            this.serviceDescriptionLabel.TabIndex = 1;
            this.serviceDescriptionLabel.Text = "Description";
            // 
            // serviceDescriptionValue
            // 
            this.serviceDescriptionValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.serviceDescriptionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serviceDescriptionValue.Location = new System.Drawing.Point(68, 191);
            this.serviceDescriptionValue.Name = "serviceDescriptionValue";
            this.serviceDescriptionValue.Size = new System.Drawing.Size(377, 43);
            this.serviceDescriptionValue.TabIndex = 2;
            // 
            // selectClientDropDown
            // 
            this.selectClientDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.selectClientDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.selectClientDropDown.FormattingEnabled = true;
            this.selectClientDropDown.Location = new System.Drawing.Point(68, 375);
            this.selectClientDropDown.Name = "selectClientDropDown";
            this.selectClientDropDown.Size = new System.Drawing.Size(377, 45);
            this.selectClientDropDown.TabIndex = 3;
            // 
            // selectClientLabel
            // 
            this.selectClientLabel.AutoSize = true;
            this.selectClientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.selectClientLabel.Location = new System.Drawing.Point(61, 334);
            this.selectClientLabel.Name = "selectClientLabel";
            this.selectClientLabel.Size = new System.Drawing.Size(170, 38);
            this.selectClientLabel.TabIndex = 4;
            this.selectClientLabel.Text = "Select Client";
            // 
            // createNewClientLink
            // 
            this.createNewClientLink.AutoSize = true;
            this.createNewClientLink.Location = new System.Drawing.Point(293, 334);
            this.createNewClientLink.Name = "createNewClientLink";
            this.createNewClientLink.Size = new System.Drawing.Size(152, 38);
            this.createNewClientLink.TabIndex = 5;
            this.createNewClientLink.TabStop = true;
            this.createNewClientLink.Text = "create new";
            this.createNewClientLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewClientLink_LinkClicked);
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.addClientButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.addClientButton.Location = new System.Drawing.Point(68, 449);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(377, 47);
            this.addClientButton.TabIndex = 6;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // createRepairButton
            // 
            this.createRepairButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.createRepairButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRepairButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.createRepairButton.Location = new System.Drawing.Point(112, 518);
            this.createRepairButton.Name = "createRepairButton";
            this.createRepairButton.Size = new System.Drawing.Size(285, 56);
            this.createRepairButton.TabIndex = 7;
            this.createRepairButton.Text = "Create Repair";
            this.createRepairButton.UseVisualStyleBackColor = false;
            this.createRepairButton.Click += new System.EventHandler(this.createRepairButton_Click);
            // 
            // serviceClientListBox
            // 
            this.serviceClientListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.serviceClientListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.serviceClientListBox.FormattingEnabled = true;
            this.serviceClientListBox.ItemHeight = 37;
            this.serviceClientListBox.Location = new System.Drawing.Point(708, 191);
            this.serviceClientListBox.Name = "serviceClientListBox";
            this.serviceClientListBox.Size = new System.Drawing.Size(434, 152);
            this.serviceClientListBox.TabIndex = 8;
            // 
            // servicedClientLabel
            // 
            this.servicedClientLabel.AutoSize = true;
            this.servicedClientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.servicedClientLabel.Location = new System.Drawing.Point(701, 137);
            this.servicedClientLabel.Name = "servicedClientLabel";
            this.servicedClientLabel.Size = new System.Drawing.Size(200, 38);
            this.servicedClientLabel.TabIndex = 9;
            this.servicedClientLabel.Text = "Serviced Client";
            // 
            // removeSelectedRepairButton
            // 
            this.removeSelectedRepairButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.removeSelectedRepairButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedRepairButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.removeSelectedRepairButton.Location = new System.Drawing.Point(1164, 449);
            this.removeSelectedRepairButton.Name = "removeSelectedRepairButton";
            this.removeSelectedRepairButton.Size = new System.Drawing.Size(179, 47);
            this.removeSelectedRepairButton.TabIndex = 13;
            this.removeSelectedRepairButton.Text = "Remove Selected";
            this.removeSelectedRepairButton.UseVisualStyleBackColor = false;
            this.removeSelectedRepairButton.Click += new System.EventHandler(this.removeSelectedRepairButton_Click);
            // 
            // repairLabel
            // 
            this.repairLabel.AutoSize = true;
            this.repairLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.repairLabel.Location = new System.Drawing.Point(701, 394);
            this.repairLabel.Name = "repairLabel";
            this.repairLabel.Size = new System.Drawing.Size(95, 38);
            this.repairLabel.TabIndex = 12;
            this.repairLabel.Text = "Repair";
            // 
            // repairListBox
            // 
            this.repairListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.repairListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.repairListBox.FormattingEnabled = true;
            this.repairListBox.ItemHeight = 37;
            this.repairListBox.Location = new System.Drawing.Point(708, 449);
            this.repairListBox.Name = "repairListBox";
            this.repairListBox.Size = new System.Drawing.Size(434, 152);
            this.repairListBox.TabIndex = 11;
            // 
            // removeSelectedClientButton
            // 
            this.removeSelectedClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.removeSelectedClientButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedClientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.removeSelectedClientButton.Location = new System.Drawing.Point(1164, 191);
            this.removeSelectedClientButton.Name = "removeSelectedClientButton";
            this.removeSelectedClientButton.Size = new System.Drawing.Size(179, 43);
            this.removeSelectedClientButton.TabIndex = 14;
            this.removeSelectedClientButton.Text = "Remove Selected";
            this.removeSelectedClientButton.UseVisualStyleBackColor = false;
            this.removeSelectedClientButton.Click += new System.EventHandler(this.removeSelectedClientButton_Click);
            // 
            // createServiceButton
            // 
            this.createServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.createServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.createServiceButton.Location = new System.Drawing.Point(548, 681);
            this.createServiceButton.Name = "createServiceButton";
            this.createServiceButton.Size = new System.Drawing.Size(353, 66);
            this.createServiceButton.TabIndex = 15;
            this.createServiceButton.Text = "Create Service";
            this.createServiceButton.UseVisualStyleBackColor = false;
            this.createServiceButton.Click += new System.EventHandler(this.createServiceButton_Click);
            // 
            // CreateServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1408, 800);
            this.Controls.Add(this.createServiceButton);
            this.Controls.Add(this.removeSelectedClientButton);
            this.Controls.Add(this.removeSelectedRepairButton);
            this.Controls.Add(this.repairLabel);
            this.Controls.Add(this.repairListBox);
            this.Controls.Add(this.servicedClientLabel);
            this.Controls.Add(this.serviceClientListBox);
            this.Controls.Add(this.createRepairButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.createNewClientLink);
            this.Controls.Add(this.selectClientLabel);
            this.Controls.Add(this.selectClientDropDown);
            this.Controls.Add(this.serviceDescriptionValue);
            this.Controls.Add(this.serviceDescriptionLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateServiceForm";
            this.Text = "Create Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label serviceDescriptionLabel;
        private System.Windows.Forms.TextBox serviceDescriptionValue;
        private System.Windows.Forms.ComboBox selectClientDropDown;
        private System.Windows.Forms.Label selectClientLabel;
        private System.Windows.Forms.LinkLabel createNewClientLink;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button createRepairButton;
        private System.Windows.Forms.ListBox serviceClientListBox;
        private System.Windows.Forms.Label servicedClientLabel;
        private System.Windows.Forms.Button removeSelectedRepairButton;
        private System.Windows.Forms.Label repairLabel;
        private System.Windows.Forms.ListBox repairListBox;
        private System.Windows.Forms.Button removeSelectedClientButton;
        private System.Windows.Forms.Button createServiceButton;
    }
}

