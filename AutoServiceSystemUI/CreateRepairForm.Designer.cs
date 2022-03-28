
namespace AutoServiceSystemUI
{
    partial class CreateRepairForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRepairForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.repairDescriptionValue = new System.Windows.Forms.TextBox();
            this.repairDescriptionLabel = new System.Windows.Forms.Label();
            this.repairPriceValue = new System.Windows.Forms.TextBox();
            this.repairPriceLabel = new System.Windows.Forms.Label();
            this.repairCreatedDateValue = new System.Windows.Forms.TextBox();
            this.repairCreatedDateLabel = new System.Windows.Forms.Label();
            this.createRepairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.headerLabel.Location = new System.Drawing.Point(33, 30);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(219, 47);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Repair";
            // 
            // repairDescriptionValue
            // 
            this.repairDescriptionValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.repairDescriptionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.repairDescriptionValue.Location = new System.Drawing.Point(82, 335);
            this.repairDescriptionValue.Multiline = true;
            this.repairDescriptionValue.Name = "repairDescriptionValue";
            this.repairDescriptionValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.repairDescriptionValue.Size = new System.Drawing.Size(410, 92);
            this.repairDescriptionValue.TabIndex = 22;
            // 
            // repairDescriptionLabel
            // 
            this.repairDescriptionLabel.AutoSize = true;
            this.repairDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.repairDescriptionLabel.Location = new System.Drawing.Point(75, 294);
            this.repairDescriptionLabel.Name = "repairDescriptionLabel";
            this.repairDescriptionLabel.Size = new System.Drawing.Size(122, 30);
            this.repairDescriptionLabel.TabIndex = 21;
            this.repairDescriptionLabel.Text = "Description";
            // 
            // repairPriceValue
            // 
            this.repairPriceValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.repairPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.repairPriceValue.Location = new System.Drawing.Point(82, 248);
            this.repairPriceValue.Name = "repairPriceValue";
            this.repairPriceValue.Size = new System.Drawing.Size(410, 36);
            this.repairPriceValue.TabIndex = 20;
            // 
            // repairPriceLabel
            // 
            this.repairPriceLabel.AutoSize = true;
            this.repairPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.repairPriceLabel.Location = new System.Drawing.Point(75, 207);
            this.repairPriceLabel.Name = "repairPriceLabel";
            this.repairPriceLabel.Size = new System.Drawing.Size(60, 30);
            this.repairPriceLabel.TabIndex = 19;
            this.repairPriceLabel.Text = "Price";
            // 
            // repairCreatedDateValue
            // 
            this.repairCreatedDateValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.repairCreatedDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.repairCreatedDateValue.Location = new System.Drawing.Point(82, 161);
            this.repairCreatedDateValue.Name = "repairCreatedDateValue";
            this.repairCreatedDateValue.Size = new System.Drawing.Size(410, 36);
            this.repairCreatedDateValue.TabIndex = 18;
            // 
            // repairCreatedDateLabel
            // 
            this.repairCreatedDateLabel.AutoSize = true;
            this.repairCreatedDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.repairCreatedDateLabel.Location = new System.Drawing.Point(75, 120);
            this.repairCreatedDateLabel.Name = "repairCreatedDateLabel";
            this.repairCreatedDateLabel.Size = new System.Drawing.Size(58, 30);
            this.repairCreatedDateLabel.TabIndex = 17;
            this.repairCreatedDateLabel.Text = "Date";
            // 
            // createRepairButton
            // 
            this.createRepairButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.createRepairButton.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.createRepairButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.createRepairButton.Location = new System.Drawing.Point(135, 460);
            this.createRepairButton.Name = "createRepairButton";
            this.createRepairButton.Size = new System.Drawing.Size(317, 68);
            this.createRepairButton.TabIndex = 24;
            this.createRepairButton.Text = "Create Repair";
            this.createRepairButton.UseVisualStyleBackColor = false;
            this.createRepairButton.Click += new System.EventHandler(this.createRepairButton_Click);
            // 
            // CreateRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(594, 635);
            this.Controls.Add(this.createRepairButton);
            this.Controls.Add(this.repairDescriptionValue);
            this.Controls.Add(this.repairDescriptionLabel);
            this.Controls.Add(this.repairPriceValue);
            this.Controls.Add(this.repairPriceLabel);
            this.Controls.Add(this.repairCreatedDateValue);
            this.Controls.Add(this.repairCreatedDateLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateRepairForm";
            this.Text = "Create Repair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox repairDescriptionValue;
        private System.Windows.Forms.Label repairDescriptionLabel;
        private System.Windows.Forms.TextBox repairPriceValue;
        private System.Windows.Forms.Label repairPriceLabel;
        private System.Windows.Forms.TextBox repairCreatedDateValue;
        private System.Windows.Forms.Label repairCreatedDateLabel;
        private System.Windows.Forms.Button createRepairButton;
    }
}