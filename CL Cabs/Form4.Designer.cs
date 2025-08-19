namespace CL_Cabs
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblSelectvehicle = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnExit4 = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRentedDate = new System.Windows.Forms.Label();
            this.DateRented = new System.Windows.Forms.DateTimePicker();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 24);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(87, 19);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblSelectvehicle
            // 
            this.lblSelectvehicle.AutoSize = true;
            this.lblSelectvehicle.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectvehicle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectvehicle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelectvehicle.Location = new System.Drawing.Point(12, 135);
            this.lblSelectvehicle.Name = "lblSelectvehicle";
            this.lblSelectvehicle.Size = new System.Drawing.Size(105, 19);
            this.lblSelectvehicle.TabIndex = 18;
            this.lblSelectvehicle.Text = "Selected Vehicle";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(179, 23);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(193, 22);
            this.txtCustomerID.TabIndex = 19;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtDriver_TextChanged);
            // 
            // txtNic
            // 
            this.txtNic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNic.Location = new System.Drawing.Point(179, 108);
            this.txtNic.Name = "txtNic";
            this.txtNic.ReadOnly = true;
            this.txtNic.Size = new System.Drawing.Size(193, 22);
            this.txtNic.TabIndex = 20;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Location = new System.Drawing.Point(12, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 19);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.BackColor = System.Drawing.Color.Transparent;
            this.lblNic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNic.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNic.Location = new System.Drawing.Point(12, 109);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(32, 19);
            this.lblNic.TabIndex = 22;
            this.lblNic.Text = "NIC";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(12, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(179, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(193, 22);
            this.txtAddress.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(179, 52);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 25;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicle.Location = new System.Drawing.Point(179, 135);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.ReadOnly = true;
            this.txtVehicle.Size = new System.Drawing.Size(193, 22);
            this.txtVehicle.TabIndex = 26;
            this.txtVehicle.TextChanged += new System.EventHandler(this.txtVehicle_TextChanged);
            // 
            // btnBack3
            // 
            this.btnBack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack3.Location = new System.Drawing.Point(12, 369);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(86, 30);
            this.btnBack3.TabIndex = 27;
            this.btnBack3.Text = "Back";
            this.btnBack3.UseVisualStyleBackColor = false;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // btnExit4
            // 
            this.btnExit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit4.Location = new System.Drawing.Point(286, 369);
            this.btnExit4.Name = "btnExit4";
            this.btnExit4.Size = new System.Drawing.Size(86, 30);
            this.btnExit4.TabIndex = 28;
            this.btnExit4.Text = "Exit";
            this.btnExit4.UseVisualStyleBackColor = false;
            this.btnExit4.Click += new System.EventHandler(this.btnExit4_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnView.Enabled = false;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnView.Location = new System.Drawing.Point(104, 198);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 30);
            this.btnView.TabIndex = 29;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCal.Enabled = false;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCal.Location = new System.Drawing.Point(139, 301);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(109, 30);
            this.btnCal.TabIndex = 30;
            this.btnCal.Text = "Calculate Payment";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblDistance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDistance.Location = new System.Drawing.Point(9, 266);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(146, 19);
            this.lblDistance.TabIndex = 31;
            this.lblDistance.Text = "Travelled Distance(Km)";
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistance.Location = new System.Drawing.Point(179, 265);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(193, 22);
            this.txtDistance.TabIndex = 32;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // btnCancel3
            // 
            this.btnCancel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel3.Enabled = false;
            this.btnCancel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel3.Location = new System.Drawing.Point(286, 198);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(86, 30);
            this.btnCancel3.TabIndex = 33;
            this.btnCancel3.Text = "Cancel";
            this.btnCancel3.UseVisualStyleBackColor = false;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(12, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 30);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRentedDate
            // 
            this.lblRentedDate.AutoSize = true;
            this.lblRentedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRentedDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentedDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRentedDate.Location = new System.Drawing.Point(12, 164);
            this.lblRentedDate.Name = "lblRentedDate";
            this.lblRentedDate.Size = new System.Drawing.Size(85, 19);
            this.lblRentedDate.TabIndex = 35;
            this.lblRentedDate.Text = "Rented Date";
            // 
            // DateRented
            // 
            this.DateRented.CustomFormat = "yyyy-MM-dd";
            this.DateRented.Enabled = false;
            this.DateRented.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRented.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateRented.Location = new System.Drawing.Point(179, 164);
            this.DateRented.Name = "DateRented";
            this.DateRented.Size = new System.Drawing.Size(193, 22);
            this.DateRented.TabIndex = 36;
            this.DateRented.Value = new System.DateTime(2020, 3, 6, 12, 33, 2, 0);
            this.DateRented.ValueChanged += new System.EventHandler(this.DateRented_ValueChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.BackColor = System.Drawing.Color.Transparent;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDays.Location = new System.Drawing.Point(9, 240);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(86, 19);
            this.lblDays.TabIndex = 37;
            this.lblDays.Text = "Rented Days";
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(179, 240);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(193, 22);
            this.txtDays.TabIndex = 38;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.DateRented);
            this.Controls.Add(this.lblRentedDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel3);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit4);
            this.Controls.Add(this.btnBack3);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblSelectvehicle);
            this.Controls.Add(this.lblCustomerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblSelectvehicle;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnExit4;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRentedDate;
        private System.Windows.Forms.DateTimePicker DateRented;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
    }
}