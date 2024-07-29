namespace TradersBuddy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabDashboard = new TabPage();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            tabCar = new TabPage();
            btnSaveCar = new MaterialSkin.Controls.MaterialButton();
            cmbDrivetrain = new MaterialSkin.Controls.MaterialComboBox();
            cmbFuelType = new MaterialSkin.Controls.MaterialComboBox();
            cmbBodyStyle = new MaterialSkin.Controls.MaterialComboBox();
            cmbCarBrand = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txtTransmission = new MaterialSkin.Controls.MaterialTextBox();
            txtEngine = new MaterialSkin.Controls.MaterialTextBox();
            txtManufacturedYear = new MaterialSkin.Controls.MaterialTextBox();
            txtSeatingCapacity = new MaterialSkin.Controls.MaterialTextBox();
            txtNumberOfDoors = new MaterialSkin.Controls.MaterialTextBox();
            txtInteriorColor = new MaterialSkin.Controls.MaterialTextBox();
            txtColor = new MaterialSkin.Controls.MaterialTextBox();
            txtVIN = new MaterialSkin.Controls.MaterialTextBox();
            txtMileage = new MaterialSkin.Controls.MaterialTextBox();
            txtCarModel = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialTabControl1.SuspendLayout();
            tabDashboard.SuspendLayout();
            tabCar.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "car.png");
            imageList1.Images.SetKeyName(1, "dashboard.png");
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabDashboard);
            materialTabControl1.Controls.Add(tabCar);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.Padding = new Point(10, 5);
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1562, 706);
            materialTabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(materialLabel2);
            tabDashboard.ImageKey = "dashboard.png";
            tabDashboard.Location = new Point(4, 43);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1554, 659);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(685, 317);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(184, 24);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Add New Car Record";
            // 
            // tabCar
            // 
            tabCar.Controls.Add(btnSaveCar);
            tabCar.Controls.Add(cmbDrivetrain);
            tabCar.Controls.Add(cmbFuelType);
            tabCar.Controls.Add(cmbBodyStyle);
            tabCar.Controls.Add(cmbCarBrand);
            tabCar.Controls.Add(materialLabel3);
            tabCar.Controls.Add(txtTransmission);
            tabCar.Controls.Add(txtEngine);
            tabCar.Controls.Add(txtManufacturedYear);
            tabCar.Controls.Add(txtSeatingCapacity);
            tabCar.Controls.Add(txtNumberOfDoors);
            tabCar.Controls.Add(txtInteriorColor);
            tabCar.Controls.Add(txtColor);
            tabCar.Controls.Add(txtVIN);
            tabCar.Controls.Add(txtMileage);
            tabCar.Controls.Add(txtCarModel);
            tabCar.Controls.Add(materialLabel1);
            tabCar.ImageKey = "car.png";
            tabCar.Location = new Point(4, 43);
            tabCar.Name = "tabCar";
            tabCar.Size = new Size(1554, 659);
            tabCar.TabIndex = 1;
            tabCar.Text = "Car";
            // 
            // btnSaveCar
            // 
            btnSaveCar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveCar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnSaveCar.Depth = 0;
            btnSaveCar.HighEmphasis = true;
            btnSaveCar.Icon = null;
            btnSaveCar.Location = new Point(505, 468);
            btnSaveCar.Margin = new Padding(4, 6, 4, 6);
            btnSaveCar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.NoAccentTextColor = Color.Empty;
            btnSaveCar.Size = new Size(64, 36);
            btnSaveCar.TabIndex = 9;
            btnSaveCar.Text = "Save";
            btnSaveCar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveCar.UseAccentColor = false;
            btnSaveCar.UseVisualStyleBackColor = true;
            // 
            // cmbDrivetrain
            // 
            cmbDrivetrain.AutoCompleteCustomSource.AddRange(new string[] { "FWD (Front-Wheel Drive)", "RWD (Rear-Wheel Drive)", "AWD (All-Wheel Drive)", "4WD (Four-Wheel Drive)" });
            cmbDrivetrain.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            cmbDrivetrain.Items.AddRange(new object[] { "FWD (Front-Wheel Drive)", "RWD (Rear-Wheel Drive)", "AWD (All-Wheel Drive)", "4WD (Four-Wheel Drive)", "" });
            cmbDrivetrain.Location = new Point(14, 381);
            cmbDrivetrain.MaxDropDownItems = 20;
            cmbDrivetrain.MouseState = MaterialSkin.MouseState.OUT;
            cmbDrivetrain.Name = "cmbDrivetrain";
            cmbDrivetrain.Size = new Size(265, 49);
            cmbDrivetrain.StartIndex = 0;
            cmbDrivetrain.TabIndex = 8;
            cmbDrivetrain.SelectedIndexChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // cmbFuelType
            // 
            cmbFuelType.AutoCompleteCustomSource.AddRange(new string[] { "Gasoline(Petrol)", "Diesal", "Electric", "Hybrid" });
            cmbFuelType.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            cmbFuelType.Location = new Point(304, 47);
            cmbFuelType.MaxDropDownItems = 20;
            cmbFuelType.MouseState = MaterialSkin.MouseState.OUT;
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(265, 49);
            cmbFuelType.StartIndex = 0;
            cmbFuelType.TabIndex = 8;
            cmbFuelType.SelectedIndexChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // cmbBodyStyle
            // 
            cmbBodyStyle.AutoCompleteCustomSource.AddRange(new string[] { "Acura", "Alfa Romeo", "Alpine", "Alpina", "Aston Martin", "Audi", "Bentley", "BMW", "Brilliance", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroën", "Dacia", "Daewoo", "Dodge", "Ferrari", "Fiat", "Ford", "GMC", "Genesis", "Geo", "Great Wall", "Honda", "Hummer", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lotus", "McLaren", "Mazda", "Mercedes-Benz", "MG", "Mini", "Mitsubishi", "Nissan", "Opel", "Peugeot", "Polestar", "Pontiac", "Porsche", "Ram", "Renault", "Rolls-Royce", "Saab", "Seat", "Skoda", "Smart", "SsangYong", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            cmbBodyStyle.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            cmbBodyStyle.Location = new Point(14, 214);
            cmbBodyStyle.MaxDropDownItems = 20;
            cmbBodyStyle.MouseState = MaterialSkin.MouseState.OUT;
            cmbBodyStyle.Name = "cmbBodyStyle";
            cmbBodyStyle.Size = new Size(265, 49);
            cmbBodyStyle.StartIndex = 0;
            cmbBodyStyle.TabIndex = 8;
            cmbBodyStyle.SelectedIndexChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // cmbCarBrand
            // 
            cmbCarBrand.AutoCompleteCustomSource.AddRange(new string[] { "Acura", "Alfa Romeo", "Alpine", "Alpina", "Aston Martin", "Audi", "Bentley", "BMW", "Brilliance", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroën", "Dacia", "Daewoo", "Dodge", "Ferrari", "Fiat", "Ford", "GMC", "Genesis", "Geo", "Great Wall", "Honda", "Hummer", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lotus", "McLaren", "Mazda", "Mercedes-Benz", "MG", "Mini", "Mitsubishi", "Nissan", "Opel", "Peugeot", "Polestar", "Pontiac", "Porsche", "Ram", "Renault", "Rolls-Royce", "Saab", "Seat", "Skoda", "Smart", "SsangYong", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            cmbCarBrand.AutoCompleteMode = AutoCompleteMode.Append;
            cmbCarBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            cmbCarBrand.Location = new Point(14, 47);
            cmbCarBrand.MaxDropDownItems = 20;
            cmbCarBrand.MouseState = MaterialSkin.MouseState.OUT;
            cmbCarBrand.Name = "cmbCarBrand";
            cmbCarBrand.Size = new Size(265, 49);
            cmbCarBrand.StartIndex = 0;
            cmbCarBrand.TabIndex = 8;
            cmbCarBrand.SelectedIndexChanged += cmbCarBrand_SelectedIndexChanged;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(377, 222);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(1, 0);
            materialLabel3.TabIndex = 7;
            materialLabel3.Click += materialLabel3_Click;
            // 
            // txtTransmission
            // 
            txtTransmission.AnimateReadOnly = false;
            txtTransmission.BorderStyle = BorderStyle.None;
            txtTransmission.Depth = 0;
            txtTransmission.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTransmission.Hint = "Transmission Description";
            txtTransmission.LeadingIcon = null;
            txtTransmission.Location = new Point(14, 325);
            txtTransmission.MaxLength = 50;
            txtTransmission.MouseState = MaterialSkin.MouseState.OUT;
            txtTransmission.Multiline = false;
            txtTransmission.Name = "txtTransmission";
            txtTransmission.Size = new Size(265, 50);
            txtTransmission.TabIndex = 4;
            txtTransmission.Text = "";
            txtTransmission.TrailingIcon = null;
            // 
            // txtEngine
            // 
            txtEngine.AnimateReadOnly = false;
            txtEngine.BorderStyle = BorderStyle.None;
            txtEngine.Depth = 0;
            txtEngine.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEngine.Hint = "Engine Description";
            txtEngine.LeadingIcon = null;
            txtEngine.Location = new Point(14, 269);
            txtEngine.MaxLength = 50;
            txtEngine.MouseState = MaterialSkin.MouseState.OUT;
            txtEngine.Multiline = false;
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(265, 50);
            txtEngine.TabIndex = 4;
            txtEngine.Text = "";
            txtEngine.TrailingIcon = null;
            // 
            // txtManufacturedYear
            // 
            txtManufacturedYear.AnimateReadOnly = false;
            txtManufacturedYear.BorderStyle = BorderStyle.None;
            txtManufacturedYear.Depth = 0;
            txtManufacturedYear.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtManufacturedYear.Hint = "Year";
            txtManufacturedYear.LeadingIcon = null;
            txtManufacturedYear.Location = new Point(14, 158);
            txtManufacturedYear.MaxLength = 50;
            txtManufacturedYear.MouseState = MaterialSkin.MouseState.OUT;
            txtManufacturedYear.Multiline = false;
            txtManufacturedYear.Name = "txtManufacturedYear";
            txtManufacturedYear.Size = new Size(265, 50);
            txtManufacturedYear.TabIndex = 4;
            txtManufacturedYear.Text = "";
            txtManufacturedYear.TrailingIcon = null;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.AnimateReadOnly = false;
            txtSeatingCapacity.BorderStyle = BorderStyle.None;
            txtSeatingCapacity.Depth = 0;
            txtSeatingCapacity.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSeatingCapacity.Hint = "Seating Capacity";
            txtSeatingCapacity.LeadingIcon = null;
            txtSeatingCapacity.Location = new Point(304, 380);
            txtSeatingCapacity.MaxLength = 50;
            txtSeatingCapacity.MouseState = MaterialSkin.MouseState.OUT;
            txtSeatingCapacity.Multiline = false;
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.Size = new Size(265, 50);
            txtSeatingCapacity.TabIndex = 5;
            txtSeatingCapacity.Text = "";
            txtSeatingCapacity.TrailingIcon = null;
            txtSeatingCapacity.TextChanged += txtColor_TextChanged;
            // 
            // txtNumberOfDoors
            // 
            txtNumberOfDoors.AnimateReadOnly = false;
            txtNumberOfDoors.BorderStyle = BorderStyle.None;
            txtNumberOfDoors.Depth = 0;
            txtNumberOfDoors.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumberOfDoors.Hint = "Number of Doors";
            txtNumberOfDoors.LeadingIcon = null;
            txtNumberOfDoors.Location = new Point(304, 326);
            txtNumberOfDoors.MaxLength = 50;
            txtNumberOfDoors.MouseState = MaterialSkin.MouseState.OUT;
            txtNumberOfDoors.Multiline = false;
            txtNumberOfDoors.Name = "txtNumberOfDoors";
            txtNumberOfDoors.Size = new Size(265, 50);
            txtNumberOfDoors.TabIndex = 5;
            txtNumberOfDoors.Text = "";
            txtNumberOfDoors.TrailingIcon = null;
            txtNumberOfDoors.TextChanged += txtColor_TextChanged;
            // 
            // txtInteriorColor
            // 
            txtInteriorColor.AnimateReadOnly = false;
            txtInteriorColor.BorderStyle = BorderStyle.None;
            txtInteriorColor.Depth = 0;
            txtInteriorColor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtInteriorColor.Hint = "Interior Color";
            txtInteriorColor.LeadingIcon = null;
            txtInteriorColor.Location = new Point(304, 270);
            txtInteriorColor.MaxLength = 50;
            txtInteriorColor.MouseState = MaterialSkin.MouseState.OUT;
            txtInteriorColor.Multiline = false;
            txtInteriorColor.Name = "txtInteriorColor";
            txtInteriorColor.Size = new Size(265, 50);
            txtInteriorColor.TabIndex = 5;
            txtInteriorColor.Text = "";
            txtInteriorColor.TrailingIcon = null;
            txtInteriorColor.TextChanged += txtColor_TextChanged;
            // 
            // txtColor
            // 
            txtColor.AnimateReadOnly = false;
            txtColor.BorderStyle = BorderStyle.None;
            txtColor.Depth = 0;
            txtColor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtColor.Hint = "Color";
            txtColor.LeadingIcon = null;
            txtColor.Location = new Point(304, 214);
            txtColor.MaxLength = 50;
            txtColor.MouseState = MaterialSkin.MouseState.OUT;
            txtColor.Multiline = false;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(265, 50);
            txtColor.TabIndex = 5;
            txtColor.Text = "";
            txtColor.TrailingIcon = null;
            txtColor.TextChanged += txtColor_TextChanged;
            // 
            // txtVIN
            // 
            txtVIN.AnimateReadOnly = false;
            txtVIN.BorderStyle = BorderStyle.None;
            txtVIN.Depth = 0;
            txtVIN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVIN.Hint = "VIN";
            txtVIN.LeadingIcon = null;
            txtVIN.Location = new Point(304, 158);
            txtVIN.MaxLength = 50;
            txtVIN.MouseState = MaterialSkin.MouseState.OUT;
            txtVIN.Multiline = false;
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(265, 50);
            txtVIN.TabIndex = 5;
            txtVIN.Text = "";
            txtVIN.TrailingIcon = null;
            // 
            // txtMileage
            // 
            txtMileage.AnimateReadOnly = false;
            txtMileage.BorderStyle = BorderStyle.None;
            txtMileage.Depth = 0;
            txtMileage.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMileage.Hint = "Mileage";
            txtMileage.LeadingIcon = null;
            txtMileage.Location = new Point(304, 102);
            txtMileage.MaxLength = 50;
            txtMileage.MouseState = MaterialSkin.MouseState.OUT;
            txtMileage.Multiline = false;
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(265, 50);
            txtMileage.TabIndex = 5;
            txtMileage.Text = "";
            txtMileage.TrailingIcon = null;
            // 
            // txtCarModel
            // 
            txtCarModel.AnimateReadOnly = false;
            txtCarModel.BorderStyle = BorderStyle.None;
            txtCarModel.Depth = 0;
            txtCarModel.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCarModel.Hint = "Model";
            txtCarModel.LeadingIcon = null;
            txtCarModel.Location = new Point(14, 102);
            txtCarModel.MaxLength = 50;
            txtCarModel.MouseState = MaterialSkin.MouseState.OUT;
            txtCarModel.Multiline = false;
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(265, 50);
            txtCarModel.TabIndex = 5;
            txtCarModel.Text = "";
            txtCarModel.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(14, 13);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(184, 24);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Add New Car Record";
            materialLabel1.Click += materialLabel1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1568, 773);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "Form1";
            Text = "TradersBuddy";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            tabCar.ResumeLayout(false);
            tabCar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabDashboard;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage tabCar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtManufacturedYear;
        private MaterialSkin.Controls.MaterialTextBox txtCarModel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbCarBrand;
        private MaterialSkin.Controls.MaterialButton btnSaveCar;
        private MaterialSkin.Controls.MaterialComboBox cmbFuelType;
        private MaterialSkin.Controls.MaterialComboBox cmbBodyStyle;
        private MaterialSkin.Controls.MaterialComboBox cmbDrivetrain;
        private MaterialSkin.Controls.MaterialTextBox txtTransmission;
        private MaterialSkin.Controls.MaterialTextBox txtEngine;
        private MaterialSkin.Controls.MaterialTextBox txtColor;
        private MaterialSkin.Controls.MaterialTextBox txtVIN;
        private MaterialSkin.Controls.MaterialTextBox txtMileage;
        private MaterialSkin.Controls.MaterialTextBox txtSeatingCapacity;
        private MaterialSkin.Controls.MaterialTextBox txtNumberOfDoors;
        private MaterialSkin.Controls.MaterialTextBox txtInteriorColor;
    }
}
