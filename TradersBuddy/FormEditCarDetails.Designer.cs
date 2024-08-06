namespace TradersBuddy
{
    partial class FormEditCarDetails
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
            components = new System.ComponentModel.Container();
            modelEffectTimer = new System.Windows.Forms.Timer(components);
            cmbCarBrand = new MaterialSkin.Controls.MaterialComboBox();
            txtModel = new MaterialSkin.Controls.MaterialTextBox();
            txtYear = new MaterialSkin.Controls.MaterialTextBox();
            txtEngine = new MaterialSkin.Controls.MaterialTextBox();
            cmbBodyStyle = new MaterialSkin.Controls.MaterialComboBox();
            txtTransmission = new MaterialSkin.Controls.MaterialTextBox();
            cmbDrivetrain = new MaterialSkin.Controls.MaterialComboBox();
            cmbFuelType = new MaterialSkin.Controls.MaterialComboBox();
            txtMileage = new MaterialSkin.Controls.MaterialTextBox();
            txtVIN = new MaterialSkin.Controls.MaterialTextBox();
            txtColor = new MaterialSkin.Controls.MaterialTextBox();
            txtInteriorColor = new MaterialSkin.Controls.MaterialTextBox();
            txtDoors = new MaterialSkin.Controls.MaterialTextBox();
            txtSeatingCapacity = new MaterialSkin.Controls.MaterialTextBox();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // modelEffectTimer
            // 
            modelEffectTimer.Enabled = true;
            modelEffectTimer.Interval = 1;
            modelEffectTimer.Tick += modelEffectTimer_Tick;
            // 
            // cmbCarBrand
            // 
            cmbCarBrand.AutoResize = false;
            cmbCarBrand.BackColor = Color.FromArgb(255, 255, 255);
            cmbCarBrand.Depth = 0;
            cmbCarBrand.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCarBrand.DropDownHeight = 862;
            cmbCarBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarBrand.DropDownWidth = 121;
            cmbCarBrand.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCarBrand.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCarBrand.FormattingEnabled = true;
            cmbCarBrand.IntegralHeight = false;
            cmbCarBrand.ItemHeight = 43;
            cmbCarBrand.Items.AddRange(new object[] { "Acura", "Alfa Romeo", "Alpine", "Alpina", "Aston Martin", "Audi", "Bentley", "BMW", "Brilliance", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroën", "Dacia", "Daewoo", "Dodge", "Ferrari", "Fiat", "Ford", "GMC", "Genesis", "Geo", "Great Wall", "Honda", "Hummer", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lotus", "McLaren", "Mazda", "Mercedes-Benz", "MG", "Mini", "Mitsubishi", "Nissan", "Opel", "Peugeot", "Polestar", "Pontiac", "Porsche", "Ram", "Renault", "Rolls-Royce", "Saab", "Seat", "Skoda", "Smart", "SsangYong", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            cmbCarBrand.Location = new Point(20, 84);
            cmbCarBrand.MaxDropDownItems = 20;
            cmbCarBrand.MouseState = MaterialSkin.MouseState.OUT;
            cmbCarBrand.Name = "cmbCarBrand";
            cmbCarBrand.Size = new Size(265, 49);
            cmbCarBrand.StartIndex = 0;
            cmbCarBrand.TabIndex = 0;
            cmbCarBrand.SelectedIndexChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // txtModel
            // 
            txtModel.AnimateReadOnly = false;
            txtModel.BorderStyle = BorderStyle.None;
            txtModel.Depth = 0;
            txtModel.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModel.Hint = "Model";
            txtModel.LeadingIcon = null;
            txtModel.Location = new Point(20, 139);
            txtModel.MaxLength = 50;
            txtModel.MouseState = MaterialSkin.MouseState.OUT;
            txtModel.Multiline = false;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(265, 50);
            txtModel.TabIndex = 1;
            txtModel.Text = "";
            txtModel.TrailingIcon = null;
            // 
            // txtYear
            // 
            txtYear.AnimateReadOnly = false;
            txtYear.BorderStyle = BorderStyle.None;
            txtYear.Depth = 0;
            txtYear.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtYear.Hint = "Year";
            txtYear.LeadingIcon = null;
            txtYear.Location = new Point(20, 195);
            txtYear.MaxLength = 50;
            txtYear.MouseState = MaterialSkin.MouseState.OUT;
            txtYear.Multiline = false;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(265, 50);
            txtYear.TabIndex = 1;
            txtYear.Text = "";
            txtYear.TrailingIcon = null;
            // 
            // txtEngine
            // 
            txtEngine.AnimateReadOnly = false;
            txtEngine.BorderStyle = BorderStyle.None;
            txtEngine.Depth = 0;
            txtEngine.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEngine.Hint = "Engine Description";
            txtEngine.LeadingIcon = null;
            txtEngine.Location = new Point(20, 306);
            txtEngine.MaxLength = 50;
            txtEngine.MouseState = MaterialSkin.MouseState.OUT;
            txtEngine.Multiline = false;
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(265, 50);
            txtEngine.TabIndex = 1;
            txtEngine.Text = "";
            txtEngine.TrailingIcon = null;
            // 
            // cmbBodyStyle
            // 
            cmbBodyStyle.AutoResize = false;
            cmbBodyStyle.BackColor = Color.FromArgb(255, 255, 255);
            cmbBodyStyle.Depth = 0;
            cmbBodyStyle.DrawMode = DrawMode.OwnerDrawVariable;
            cmbBodyStyle.DropDownHeight = 862;
            cmbBodyStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBodyStyle.DropDownWidth = 121;
            cmbBodyStyle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbBodyStyle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbBodyStyle.FormattingEnabled = true;
            cmbBodyStyle.IntegralHeight = false;
            cmbBodyStyle.ItemHeight = 43;
            cmbBodyStyle.Items.AddRange(new object[] { "Sedan", "Hatchback", "SUV (Sport Utility Vehicle)", "CUV (Crossover Utility Vehicle)", "Coupe", "Convertible", "Wagon (Estate)", "Pickup Truck", "Van", "Minivan" });
            cmbBodyStyle.Location = new Point(20, 251);
            cmbBodyStyle.MaxDropDownItems = 20;
            cmbBodyStyle.MouseState = MaterialSkin.MouseState.OUT;
            cmbBodyStyle.Name = "cmbBodyStyle";
            cmbBodyStyle.Size = new Size(265, 49);
            cmbBodyStyle.StartIndex = 0;
            cmbBodyStyle.TabIndex = 0;
            cmbBodyStyle.SelectedIndexChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // txtTransmission
            // 
            txtTransmission.AnimateReadOnly = false;
            txtTransmission.BorderStyle = BorderStyle.None;
            txtTransmission.Depth = 0;
            txtTransmission.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTransmission.Hint = "Transmission Description";
            txtTransmission.LeadingIcon = null;
            txtTransmission.Location = new Point(20, 362);
            txtTransmission.MaxLength = 50;
            txtTransmission.MouseState = MaterialSkin.MouseState.OUT;
            txtTransmission.Multiline = false;
            txtTransmission.Name = "txtTransmission";
            txtTransmission.Size = new Size(265, 50);
            txtTransmission.TabIndex = 1;
            txtTransmission.Text = "";
            txtTransmission.TrailingIcon = null;
            // 
            // cmbDrivetrain
            // 
            cmbDrivetrain.AutoResize = false;
            cmbDrivetrain.BackColor = Color.FromArgb(255, 255, 255);
            cmbDrivetrain.Depth = 0;
            cmbDrivetrain.DrawMode = DrawMode.OwnerDrawVariable;
            cmbDrivetrain.DropDownHeight = 862;
            cmbDrivetrain.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrivetrain.DropDownWidth = 121;
            cmbDrivetrain.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbDrivetrain.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbDrivetrain.FormattingEnabled = true;
            cmbDrivetrain.IntegralHeight = false;
            cmbDrivetrain.ItemHeight = 43;
            cmbDrivetrain.Items.AddRange(new object[] { "FWD (Front-Wheel Drive)", "RWD (Rear-Wheel Drive)", "AWD (All-Wheel Drive)", "4WD (Four-Wheel Drive)" });
            cmbDrivetrain.Location = new Point(20, 418);
            cmbDrivetrain.MaxDropDownItems = 20;
            cmbDrivetrain.MouseState = MaterialSkin.MouseState.OUT;
            cmbDrivetrain.Name = "cmbDrivetrain";
            cmbDrivetrain.Size = new Size(265, 49);
            cmbDrivetrain.StartIndex = 0;
            cmbDrivetrain.TabIndex = 0;
            cmbDrivetrain.SelectedIndexChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // cmbFuelType
            // 
            cmbFuelType.AutoResize = false;
            cmbFuelType.BackColor = Color.FromArgb(255, 255, 255);
            cmbFuelType.Depth = 0;
            cmbFuelType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFuelType.DropDownHeight = 862;
            cmbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuelType.DropDownWidth = 121;
            cmbFuelType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFuelType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.IntegralHeight = false;
            cmbFuelType.ItemHeight = 43;
            cmbFuelType.Items.AddRange(new object[] { "Gasoline(Petrol)", "Diesal", "Electric", "Hybrid" });
            cmbFuelType.Location = new Point(314, 84);
            cmbFuelType.MaxDropDownItems = 20;
            cmbFuelType.MouseState = MaterialSkin.MouseState.OUT;
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(265, 49);
            cmbFuelType.StartIndex = 0;
            cmbFuelType.TabIndex = 0;
            cmbFuelType.SelectedIndexChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // txtMileage
            // 
            txtMileage.AnimateReadOnly = false;
            txtMileage.BorderStyle = BorderStyle.None;
            txtMileage.Depth = 0;
            txtMileage.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMileage.Hint = "Mileage";
            txtMileage.LeadingIcon = null;
            txtMileage.Location = new Point(314, 139);
            txtMileage.MaxLength = 50;
            txtMileage.MouseState = MaterialSkin.MouseState.OUT;
            txtMileage.Multiline = false;
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(265, 50);
            txtMileage.TabIndex = 1;
            txtMileage.Text = "";
            txtMileage.TrailingIcon = null;
            // 
            // txtVIN
            // 
            txtVIN.AnimateReadOnly = false;
            txtVIN.BorderStyle = BorderStyle.None;
            txtVIN.Depth = 0;
            txtVIN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVIN.Hint = "VIN";
            txtVIN.LeadingIcon = null;
            txtVIN.Location = new Point(314, 195);
            txtVIN.MaxLength = 50;
            txtVIN.MouseState = MaterialSkin.MouseState.OUT;
            txtVIN.Multiline = false;
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(265, 50);
            txtVIN.TabIndex = 1;
            txtVIN.Text = "";
            txtVIN.TrailingIcon = null;
            // 
            // txtColor
            // 
            txtColor.AnimateReadOnly = false;
            txtColor.BorderStyle = BorderStyle.None;
            txtColor.Depth = 0;
            txtColor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtColor.Hint = "Color";
            txtColor.LeadingIcon = null;
            txtColor.Location = new Point(314, 251);
            txtColor.MaxLength = 50;
            txtColor.MouseState = MaterialSkin.MouseState.OUT;
            txtColor.Multiline = false;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(265, 50);
            txtColor.TabIndex = 1;
            txtColor.Text = "";
            txtColor.TrailingIcon = null;
            // 
            // txtInteriorColor
            // 
            txtInteriorColor.AnimateReadOnly = false;
            txtInteriorColor.BorderStyle = BorderStyle.None;
            txtInteriorColor.Depth = 0;
            txtInteriorColor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInteriorColor.Hint = "Interior Color";
            txtInteriorColor.LeadingIcon = null;
            txtInteriorColor.Location = new Point(314, 306);
            txtInteriorColor.MaxLength = 50;
            txtInteriorColor.MouseState = MaterialSkin.MouseState.OUT;
            txtInteriorColor.Multiline = false;
            txtInteriorColor.Name = "txtInteriorColor";
            txtInteriorColor.Size = new Size(265, 50);
            txtInteriorColor.TabIndex = 1;
            txtInteriorColor.Text = "";
            txtInteriorColor.TrailingIcon = null;
            // 
            // txtDoors
            // 
            txtDoors.AnimateReadOnly = false;
            txtDoors.BorderStyle = BorderStyle.None;
            txtDoors.Depth = 0;
            txtDoors.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDoors.Hint = "Number Of Doors";
            txtDoors.LeadingIcon = null;
            txtDoors.Location = new Point(314, 362);
            txtDoors.MaxLength = 50;
            txtDoors.MouseState = MaterialSkin.MouseState.OUT;
            txtDoors.Multiline = false;
            txtDoors.Name = "txtDoors";
            txtDoors.Size = new Size(265, 50);
            txtDoors.TabIndex = 1;
            txtDoors.Text = "";
            txtDoors.TrailingIcon = null;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.AnimateReadOnly = false;
            txtSeatingCapacity.BorderStyle = BorderStyle.None;
            txtSeatingCapacity.Depth = 0;
            txtSeatingCapacity.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSeatingCapacity.Hint = "Seating Capacity";
            txtSeatingCapacity.LeadingIcon = null;
            txtSeatingCapacity.Location = new Point(314, 417);
            txtSeatingCapacity.MaxLength = 50;
            txtSeatingCapacity.MouseState = MaterialSkin.MouseState.OUT;
            txtSeatingCapacity.Multiline = false;
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.Size = new Size(265, 50);
            txtSeatingCapacity.TabIndex = 1;
            txtSeatingCapacity.Text = "";
            txtSeatingCapacity.TrailingIcon = null;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(502, 476);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(77, 36);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // FormEditCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 613);
            Controls.Add(btnUpdate);
            Controls.Add(txtTransmission);
            Controls.Add(txtEngine);
            Controls.Add(txtYear);
            Controls.Add(txtSeatingCapacity);
            Controls.Add(txtDoors);
            Controls.Add(txtInteriorColor);
            Controls.Add(txtColor);
            Controls.Add(txtVIN);
            Controls.Add(txtMileage);
            Controls.Add(txtModel);
            Controls.Add(cmbFuelType);
            Controls.Add(cmbDrivetrain);
            Controls.Add(cmbBodyStyle);
            Controls.Add(cmbCarBrand);
            Name = "FormEditCarDetails";
            Opacity = 0D;
            Text = "Update Car Details";
            Load += FormEditCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer modelEffectTimer;
        private MaterialSkin.Controls.MaterialComboBox cmbCarBrand;
        private MaterialSkin.Controls.MaterialTextBox txtModel;
        private MaterialSkin.Controls.MaterialTextBox txtYear;
        private MaterialSkin.Controls.MaterialTextBox txtEngine;
        private MaterialSkin.Controls.MaterialComboBox cmbBodyStyle;
        private MaterialSkin.Controls.MaterialTextBox txtTransmission;
        private MaterialSkin.Controls.MaterialComboBox cmbDrivetrain;
        private MaterialSkin.Controls.MaterialComboBox cmbFuelType;
        private MaterialSkin.Controls.MaterialTextBox txtMileage;
        private MaterialSkin.Controls.MaterialTextBox txtVIN;
        private MaterialSkin.Controls.MaterialTextBox txtColor;
        private MaterialSkin.Controls.MaterialTextBox txtInteriorColor;
        private MaterialSkin.Controls.MaterialTextBox txtDoors;
        private MaterialSkin.Controls.MaterialTextBox txtSeatingCapacity;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
    }
}