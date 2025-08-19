namespace CL_Cabs
{
    partial class frmAvailable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvailable));
            this.Vehicle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit5 = new System.Windows.Forms.Button();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.dateRent = new System.Windows.Forms.DateTimePicker();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.lblSelectvehicle = new System.Windows.Forms.Label();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vehicle
            // 
            this.Vehicle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicle.FormattingEnabled = true;
            this.Vehicle.Items.AddRange(new object[] {
            "Car - Audi",
            "Car - BMW",
            "Van - Nissan",
            "Van - KDH",
            "Jeep - Toyota"});
            this.Vehicle.Location = new System.Drawing.Point(179, 43);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(206, 21);
            this.Vehicle.TabIndex = 0;
            this.Vehicle.Text = "----Select Here----";
            this.Vehicle.SelectedIndexChanged += new System.EventHandler(this.Vehicle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Vehicle";
            // 
            // btnExit5
            // 
            this.btnExit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit5.Location = new System.Drawing.Point(437, 423);
            this.btnExit5.Name = "btnExit5";
            this.btnExit5.Size = new System.Drawing.Size(86, 30);
            this.btnExit5.TabIndex = 33;
            this.btnExit5.Text = "Exit";
            this.btnExit5.UseVisualStyleBackColor = false;
            this.btnExit5.Click += new System.EventHandler(this.btnExit5_Click);
            // 
            // btnBack4
            // 
            this.btnBack4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack4.Location = new System.Drawing.Point(12, 423);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(86, 30);
            this.btnBack4.TabIndex = 32;
            this.btnBack4.Text = "Back";
            this.btnBack4.UseVisualStyleBackColor = false;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(425, 36);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 30);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dateReturn
            // 
            this.dateReturn.CustomFormat = "yyyy-MM-dd";
            this.dateReturn.Enabled = false;
            this.dateReturn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReturn.Location = new System.Drawing.Point(254, 274);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(193, 22);
            this.dateReturn.TabIndex = 48;
            // 
            // dateRent
            // 
            this.dateRent.CustomFormat = "yyyy-MM-dd";
            this.dateRent.Enabled = false;
            this.dateRent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRent.Location = new System.Drawing.Point(254, 246);
            this.dateRent.Name = "dateRent";
            this.dateRent.Size = new System.Drawing.Size(193, 22);
            this.dateRent.TabIndex = 47;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.BackColor = System.Drawing.Color.Transparent;
            this.lblReturn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturn.Location = new System.Drawing.Point(96, 277);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(102, 19);
            this.lblReturn.TabIndex = 46;
            this.lblReturn.Text = "Returning Date";
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRentDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRentDate.Location = new System.Drawing.Point(96, 249);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(89, 19);
            this.lblRentDate.TabIndex = 45;
            this.lblRentDate.Text = "Renting Date";
            // 
            // cbVehicle
            // 
            this.cbVehicle.Enabled = false;
            this.cbVehicle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Items.AddRange(new object[] {
            "Car - Audi",
            "Car - BMW",
            "Van - Nissan",
            "Van - KDH",
            "Jeep - Toyota"});
            this.cbVehicle.Location = new System.Drawing.Point(254, 219);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(193, 21);
            this.cbVehicle.TabIndex = 44;
            // 
            // lblSelectvehicle
            // 
            this.lblSelectvehicle.AutoSize = true;
            this.lblSelectvehicle.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectvehicle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectvehicle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelectvehicle.Location = new System.Drawing.Point(95, 219);
            this.lblSelectvehicle.Name = "lblSelectvehicle";
            this.lblSelectvehicle.Size = new System.Drawing.Size(90, 19);
            this.lblSelectvehicle.TabIndex = 43;
            this.lblSelectvehicle.Text = "Select Vehicle";
            // 
            // txtNic
            // 
            this.txtNic.Enabled = false;
            this.txtNic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNic.Location = new System.Drawing.Point(254, 191);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(193, 22);
            this.txtNic.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(254, 163);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 22);
            this.txtAddress.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(254, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 39;
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.BackColor = System.Drawing.Color.Transparent;
            this.lblNic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNic.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNic.Location = new System.Drawing.Point(94, 191);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(32, 19);
            this.lblNic.TabIndex = 38;
            this.lblNic.Text = "NIC";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Location = new System.Drawing.Point(94, 163);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 19);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(94, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name";
            // 
            // frmAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 465);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.dateRent);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblRentDate);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.lblSelectvehicle);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnExit5);
            this.Controls.Add(this.btnBack4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAvailable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Available Vehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Vehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit5;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.DateTimePicker dateRent;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.Label lblSelectvehicle;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
    }
}