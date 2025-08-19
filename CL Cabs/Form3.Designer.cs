namespace CL_Cabs
{
    partial class frmCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCD));
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnExit3 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblSelectvehicle = new System.Windows.Forms.Label();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dateRent = new System.Windows.Forms.DateTimePicker();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(19, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Location = new System.Drawing.Point(19, 66);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 19);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCustomerID.Location = new System.Drawing.Point(19, 100);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(87, 19);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.BackColor = System.Drawing.Color.Transparent;
            this.lblNic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNic.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNic.Location = new System.Drawing.Point(19, 134);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(32, 19);
            this.lblNic.TabIndex = 3;
            this.lblNic.Text = "NIC";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(179, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(179, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(179, 99);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(193, 22);
            this.txtCustomerID.TabIndex = 6;
            // 
            // txtNic
            // 
            this.txtNic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNic.Location = new System.Drawing.Point(179, 133);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(193, 22);
            this.txtNic.TabIndex = 7;
            this.txtNic.TextChanged += new System.EventHandler(this.txtNic_TextChanged);
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack2.Location = new System.Drawing.Point(12, 369);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(86, 30);
            this.btnBack2.TabIndex = 12;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnExit3
            // 
            this.btnExit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit3.Location = new System.Drawing.Point(286, 369);
            this.btnExit3.Name = "btnExit3";
            this.btnExit3.Size = new System.Drawing.Size(86, 30);
            this.btnExit3.TabIndex = 13;
            this.btnExit3.Text = "Exit";
            this.btnExit3.UseVisualStyleBackColor = false;
            this.btnExit3.Click += new System.EventHandler(this.btnExit3_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel2.Enabled = false;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel2.Location = new System.Drawing.Point(104, 260);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(86, 30);
            this.btnCancel2.TabIndex = 14;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDone.Enabled = false;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDone.Location = new System.Drawing.Point(286, 260);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(86, 30);
            this.btnDone.TabIndex = 15;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInsert.Enabled = false;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInsert.Location = new System.Drawing.Point(12, 260);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 30);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblSelectvehicle
            // 
            this.lblSelectvehicle.AutoSize = true;
            this.lblSelectvehicle.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectvehicle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectvehicle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelectvehicle.Location = new System.Drawing.Point(19, 164);
            this.lblSelectvehicle.Name = "lblSelectvehicle";
            this.lblSelectvehicle.Size = new System.Drawing.Size(90, 19);
            this.lblSelectvehicle.TabIndex = 17;
            this.lblSelectvehicle.Text = "Select Vehicle";
            // 
            // cbVehicle
            // 
            this.cbVehicle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Items.AddRange(new object[] {
            "Car - Audi",
            "Car - BMW",
            "Van - Nissan",
            "Van - KDH",
            "Jeep - Toyota"});
            this.cbVehicle.Location = new System.Drawing.Point(179, 164);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(193, 21);
            this.cbVehicle.TabIndex = 18;
            this.cbVehicle.Text = "----Select Here----";
            this.cbVehicle.SelectedIndexChanged += new System.EventHandler(this.cbVehicle_SelectedIndexChanged);
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRentDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRentDate.Location = new System.Drawing.Point(19, 194);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(89, 19);
            this.lblRentDate.TabIndex = 19;
            this.lblRentDate.Text = "Renting Date";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.BackColor = System.Drawing.Color.Transparent;
            this.lblReturn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturn.Location = new System.Drawing.Point(19, 225);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(102, 19);
            this.lblReturn.TabIndex = 20;
            this.lblReturn.Text = "Returning Date";
            // 
            // dateRent
            // 
            this.dateRent.CustomFormat = "yyyy-MM-dd";
            this.dateRent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRent.Location = new System.Drawing.Point(179, 194);
            this.dateRent.Name = "dateRent";
            this.dateRent.Size = new System.Drawing.Size(193, 22);
            this.dateRent.TabIndex = 21;
            // 
            // dateReturn
            // 
            this.dateReturn.CustomFormat = "yyyy-MM-dd";
            this.dateReturn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReturn.Location = new System.Drawing.Point(179, 225);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(193, 22);
            this.dateReturn.TabIndex = 22;
            // 
            // frmCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.dateRent);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblRentDate);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.lblSelectvehicle);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnExit3);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnExit3;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblSelectvehicle;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dateRent;
        private System.Windows.Forms.DateTimePicker dateReturn;
    }
}