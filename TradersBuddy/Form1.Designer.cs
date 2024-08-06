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
            tabAddNewCar = new TabPage();
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
            tabAllCars = new TabPage();
            btnCarTableLoad = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtCarSearch = new MaterialSkin.Controls.MaterialTextBox();
            tblCarDetails = new MaterialSkin.Controls.MaterialListView();
            clmBrand = new ColumnHeader();
            clmModel = new ColumnHeader();
            clmYear = new ColumnHeader();
            clmBodyStyle = new ColumnHeader();
            clmEngine = new ColumnHeader();
            clmTransmission = new ColumnHeader();
            clmDrivetrain = new ColumnHeader();
            clmFuelType = new ColumnHeader();
            clmMileage = new ColumnHeader();
            clmVIN = new ColumnHeader();
            clmColor = new ColumnHeader();
            clmInteriorColor = new ColumnHeader();
            clmNumOfDoors = new ColumnHeader();
            clmSeatingCapacity = new ColumnHeader();
            clmAction = new ColumnHeader();
            tabAddCustomer = new TabPage();
            btnSaveCustomer = new MaterialSkin.Controls.MaterialButton();
            txtAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtCity = new MaterialSkin.Controls.MaterialTextBox();
            txtNIC = new MaterialSkin.Controls.MaterialTextBox();
            txtMobileNumber2 = new MaterialSkin.Controls.MaterialTextBox();
            txtMobileNumber1 = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtFullName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            tabCustomerFindAll = new TabPage();
            btnCustomerTableLoad = new MaterialSkin.Controls.MaterialButton();
            txtCustomerSearch = new MaterialSkin.Controls.MaterialTextBox();
            tblCustomerDetails = new MaterialSkin.Controls.MaterialListView();
            clmFullName = new ColumnHeader();
            clmEmail = new ColumnHeader();
            clmMobileNumber1 = new ColumnHeader();
            clmMobileNumber2 = new ColumnHeader();
            clmNIC = new ColumnHeader();
            clmCity = new ColumnHeader();
            clmAddress = new ColumnHeader();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialTabControl1.SuspendLayout();
            tabDashboard.SuspendLayout();
            tabAddNewCar.SuspendLayout();
            tabAllCars.SuspendLayout();
            tabAddCustomer.SuspendLayout();
            tabCustomerFindAll.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "office-material.png");
            imageList1.Images.SetKeyName(1, "transport.png");
            imageList1.Images.SetKeyName(2, "electric-car.png");
            imageList1.Images.SetKeyName(3, "add.png");
            imageList1.Images.SetKeyName(4, "add-user.png");
            imageList1.Images.SetKeyName(5, "");
            imageList1.Images.SetKeyName(6, "people.png");
            // 
            // materialTabControl1
            // 
            materialTabControl1.Alignment = TabAlignment.Left;
            materialTabControl1.Controls.Add(tabDashboard);
            materialTabControl1.Controls.Add(tabAddNewCar);
            materialTabControl1.Controls.Add(tabAllCars);
            materialTabControl1.Controls.Add(tabAddCustomer);
            materialTabControl1.Controls.Add(tabCustomerFindAll);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.Padding = new Point(10, 5);
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1893, 942);
            materialTabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(materialLabel2);
            tabDashboard.ImageKey = "office-material.png";
            tabDashboard.Location = new Point(43, 4);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1846, 934);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(21, 18);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(141, 24);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Analytics Board";
            // 
            // tabAddNewCar
            // 
            tabAddNewCar.Controls.Add(btnSaveCar);
            tabAddNewCar.Controls.Add(cmbDrivetrain);
            tabAddNewCar.Controls.Add(cmbFuelType);
            tabAddNewCar.Controls.Add(cmbBodyStyle);
            tabAddNewCar.Controls.Add(cmbCarBrand);
            tabAddNewCar.Controls.Add(materialLabel3);
            tabAddNewCar.Controls.Add(txtTransmission);
            tabAddNewCar.Controls.Add(txtEngine);
            tabAddNewCar.Controls.Add(txtManufacturedYear);
            tabAddNewCar.Controls.Add(txtSeatingCapacity);
            tabAddNewCar.Controls.Add(txtNumberOfDoors);
            tabAddNewCar.Controls.Add(txtInteriorColor);
            tabAddNewCar.Controls.Add(txtColor);
            tabAddNewCar.Controls.Add(txtVIN);
            tabAddNewCar.Controls.Add(txtMileage);
            tabAddNewCar.Controls.Add(txtCarModel);
            tabAddNewCar.Controls.Add(materialLabel1);
            tabAddNewCar.ImageKey = "add.png";
            tabAddNewCar.Location = new Point(43, 4);
            tabAddNewCar.Name = "tabAddNewCar";
            tabAddNewCar.Size = new Size(1846, 934);
            tabAddNewCar.TabIndex = 1;
            tabAddNewCar.Text = "Car";
            // 
            // btnSaveCar
            // 
            btnSaveCar.AutoSize = false;
            btnSaveCar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveCar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnSaveCar.Depth = 0;
            btnSaveCar.HighEmphasis = true;
            btnSaveCar.Icon = null;
            btnSaveCar.Location = new Point(498, 447);
            btnSaveCar.Margin = new Padding(4, 6, 4, 6);
            btnSaveCar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveCar.Name = "btnSaveCar";
            btnSaveCar.NoAccentTextColor = Color.Empty;
            btnSaveCar.Size = new Size(80, 36);
            btnSaveCar.TabIndex = 9;
            btnSaveCar.Text = "Save";
            btnSaveCar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveCar.UseAccentColor = false;
            btnSaveCar.UseVisualStyleBackColor = true;
            btnSaveCar.Click += btnSaveCar_Click;
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
            cmbDrivetrain.Items.AddRange(new object[] { "FWD (Front-Wheel Drive)", "RWD (Rear-Wheel Drive)", "AWD (All-Wheel Drive)", "4WD (Four-Wheel Drive)" });
            cmbDrivetrain.Location = new Point(23, 389);
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
            cmbFuelType.Location = new Point(313, 55);
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
            cmbBodyStyle.Location = new Point(23, 222);
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
            cmbCarBrand.Location = new Point(23, 55);
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
            materialLabel3.Location = new Point(386, 230);
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
            txtTransmission.Location = new Point(23, 333);
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
            txtEngine.Location = new Point(23, 277);
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
            txtManufacturedYear.Location = new Point(23, 166);
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
            txtSeatingCapacity.Location = new Point(313, 388);
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
            txtNumberOfDoors.Location = new Point(313, 334);
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
            txtInteriorColor.Location = new Point(313, 278);
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
            txtColor.Location = new Point(313, 222);
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
            txtVIN.Location = new Point(313, 166);
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
            txtMileage.Location = new Point(313, 110);
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
            txtCarModel.Location = new Point(23, 110);
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
            materialLabel1.Location = new Point(23, 21);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(184, 24);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Add New Car Record";
            materialLabel1.Click += materialLabel1_Click_1;
            // 
            // tabAllCars
            // 
            tabAllCars.Controls.Add(btnCarTableLoad);
            tabAllCars.Controls.Add(materialLabel4);
            tabAllCars.Controls.Add(txtCarSearch);
            tabAllCars.Controls.Add(tblCarDetails);
            tabAllCars.ImageKey = "electric-car.png";
            tabAllCars.Location = new Point(43, 4);
            tabAllCars.Name = "tabAllCars";
            tabAllCars.Size = new Size(1846, 934);
            tabAllCars.TabIndex = 2;
            tabAllCars.Text = "Car Finder";
            // 
            // btnCarTableLoad
            // 
            btnCarTableLoad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCarTableLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCarTableLoad.Depth = 0;
            btnCarTableLoad.HighEmphasis = true;
            btnCarTableLoad.Icon = Properties.Resources.refresh;
            btnCarTableLoad.ImageList = imageList1;
            btnCarTableLoad.Location = new Point(1277, 228);
            btnCarTableLoad.Margin = new Padding(4, 6, 4, 6);
            btnCarTableLoad.MouseState = MaterialSkin.MouseState.HOVER;
            btnCarTableLoad.Name = "btnCarTableLoad";
            btnCarTableLoad.NoAccentTextColor = Color.Empty;
            btnCarTableLoad.Size = new Size(105, 36);
            btnCarTableLoad.TabIndex = 4;
            btnCarTableLoad.Text = "Reload";
            btnCarTableLoad.TextAlign = ContentAlignment.BottomCenter;
            btnCarTableLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCarTableLoad.UseAccentColor = true;
            btnCarTableLoad.UseVisualStyleBackColor = true;
            btnCarTableLoad.Click += btnCarTableLoad_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel4.Location = new Point(21, 20);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(93, 24);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Car Finder";
            // 
            // txtCarSearch
            // 
            txtCarSearch.AnimateReadOnly = false;
            txtCarSearch.BorderStyle = BorderStyle.None;
            txtCarSearch.Depth = 0;
            txtCarSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCarSearch.Hint = "Search";
            txtCarSearch.LeadingIcon = null;
            txtCarSearch.Location = new Point(1389, 221);
            txtCarSearch.MaxLength = 50;
            txtCarSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtCarSearch.Multiline = false;
            txtCarSearch.Name = "txtCarSearch";
            txtCarSearch.Size = new Size(406, 50);
            txtCarSearch.TabIndex = 1;
            txtCarSearch.Text = "";
            txtCarSearch.TrailingIcon = null;
            txtCarSearch.KeyDown += txtCarSearch_KeyDown;
            // 
            // tblCarDetails
            // 
            tblCarDetails.AutoSizeTable = false;
            tblCarDetails.BackColor = Color.FromArgb(255, 255, 255);
            tblCarDetails.BorderStyle = BorderStyle.None;
            tblCarDetails.Columns.AddRange(new ColumnHeader[] { clmBrand, clmModel, clmYear, clmBodyStyle, clmEngine, clmTransmission, clmDrivetrain, clmFuelType, clmMileage, clmVIN, clmColor, clmInteriorColor, clmNumOfDoors, clmSeatingCapacity, clmAction });
            tblCarDetails.Depth = 0;
            tblCarDetails.FullRowSelect = true;
            tblCarDetails.Location = new Point(21, 277);
            tblCarDetails.MinimumSize = new Size(200, 100);
            tblCarDetails.MouseLocation = new Point(-1, -1);
            tblCarDetails.MouseState = MaterialSkin.MouseState.OUT;
            tblCarDetails.Name = "tblCarDetails";
            tblCarDetails.OwnerDraw = true;
            tblCarDetails.Size = new Size(1793, 622);
            tblCarDetails.TabIndex = 0;
            tblCarDetails.UseCompatibleStateImageBehavior = false;
            tblCarDetails.View = View.Details;
            tblCarDetails.DoubleClick += tblCarDetails_DoubleClick;
            // 
            // clmBrand
            // 
            clmBrand.Text = "Brand";
            clmBrand.Width = 100;
            // 
            // clmModel
            // 
            clmModel.Text = "Model";
            clmModel.Width = 100;
            // 
            // clmYear
            // 
            clmYear.Text = "Year";
            clmYear.Width = 80;
            // 
            // clmBodyStyle
            // 
            clmBodyStyle.Text = "Body Style";
            clmBodyStyle.Width = 150;
            // 
            // clmEngine
            // 
            clmEngine.Text = "Engine";
            clmEngine.Width = 100;
            // 
            // clmTransmission
            // 
            clmTransmission.Text = "Transmission";
            clmTransmission.Width = 150;
            // 
            // clmDrivetrain
            // 
            clmDrivetrain.Text = "Drivetrain";
            clmDrivetrain.Width = 120;
            // 
            // clmFuelType
            // 
            clmFuelType.Text = "Fuel Type";
            clmFuelType.Width = 150;
            // 
            // clmMileage
            // 
            clmMileage.Text = "Mileage";
            clmMileage.Width = 100;
            // 
            // clmVIN
            // 
            clmVIN.Text = "VIN";
            clmVIN.Width = 100;
            // 
            // clmColor
            // 
            clmColor.Text = "Color";
            clmColor.Width = 100;
            // 
            // clmInteriorColor
            // 
            clmInteriorColor.Text = "Interior Color";
            clmInteriorColor.Width = 150;
            // 
            // clmNumOfDoors
            // 
            clmNumOfDoors.Text = "Doors";
            clmNumOfDoors.Width = 100;
            // 
            // clmSeatingCapacity
            // 
            clmSeatingCapacity.Text = "Seat Count";
            clmSeatingCapacity.Width = 100;
            // 
            // clmAction
            // 
            clmAction.Text = "Action";
            clmAction.Width = 150;
            // 
            // tabAddCustomer
            // 
            tabAddCustomer.Controls.Add(btnSaveCustomer);
            tabAddCustomer.Controls.Add(txtAddress);
            tabAddCustomer.Controls.Add(txtCity);
            tabAddCustomer.Controls.Add(txtNIC);
            tabAddCustomer.Controls.Add(txtMobileNumber2);
            tabAddCustomer.Controls.Add(txtMobileNumber1);
            tabAddCustomer.Controls.Add(txtEmail);
            tabAddCustomer.Controls.Add(txtFullName);
            tabAddCustomer.Controls.Add(materialLabel5);
            tabAddCustomer.ImageKey = "add-user.png";
            tabAddCustomer.Location = new Point(43, 4);
            tabAddCustomer.Name = "tabAddCustomer";
            tabAddCustomer.Size = new Size(1846, 934);
            tabAddCustomer.TabIndex = 3;
            tabAddCustomer.Text = "Add Customer";
            // 
            // btnSaveCustomer
            // 
            btnSaveCustomer.AutoSize = false;
            btnSaveCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveCustomer.Depth = 0;
            btnSaveCustomer.HighEmphasis = true;
            btnSaveCustomer.Icon = null;
            btnSaveCustomer.Location = new Point(517, 288);
            btnSaveCustomer.Margin = new Padding(4, 6, 4, 6);
            btnSaveCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveCustomer.Name = "btnSaveCustomer";
            btnSaveCustomer.NoAccentTextColor = Color.Empty;
            btnSaveCustomer.Size = new Size(80, 36);
            btnSaveCustomer.TabIndex = 8;
            btnSaveCustomer.Text = "Save";
            btnSaveCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveCustomer.UseAccentColor = false;
            btnSaveCustomer.UseVisualStyleBackColor = true;
            btnSaveCustomer.Click += btnSaveCustomer_Click;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.HideSelection = true;
            txtAddress.Hint = "Address";
            txtAddress.Location = new Point(332, 61);
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.ReadOnly = false;
            txtAddress.ScrollBars = ScrollBars.None;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(265, 106);
            txtAddress.TabIndex = 7;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // txtCity
            // 
            txtCity.AnimateReadOnly = false;
            txtCity.BorderStyle = BorderStyle.None;
            txtCity.Depth = 0;
            txtCity.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCity.Hint = "City";
            txtCity.LeadingIcon = null;
            txtCity.Location = new Point(332, 173);
            txtCity.MaxLength = 50;
            txtCity.MouseState = MaterialSkin.MouseState.OUT;
            txtCity.Multiline = false;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(265, 50);
            txtCity.TabIndex = 5;
            txtCity.Text = "";
            txtCity.TrailingIcon = null;
            // 
            // txtNIC
            // 
            txtNIC.AnimateReadOnly = false;
            txtNIC.BorderStyle = BorderStyle.None;
            txtNIC.Depth = 0;
            txtNIC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNIC.Hint = "NIC";
            txtNIC.LeadingIcon = null;
            txtNIC.Location = new Point(332, 229);
            txtNIC.MaxLength = 50;
            txtNIC.MouseState = MaterialSkin.MouseState.OUT;
            txtNIC.Multiline = false;
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(265, 50);
            txtNIC.TabIndex = 5;
            txtNIC.Text = "";
            txtNIC.TrailingIcon = null;
            // 
            // txtMobileNumber2
            // 
            txtMobileNumber2.AnimateReadOnly = false;
            txtMobileNumber2.BorderStyle = BorderStyle.None;
            txtMobileNumber2.Depth = 0;
            txtMobileNumber2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMobileNumber2.Hint = "Mobile Number 2 (Optional)";
            txtMobileNumber2.LeadingIcon = null;
            txtMobileNumber2.Location = new Point(24, 229);
            txtMobileNumber2.MaxLength = 50;
            txtMobileNumber2.MouseState = MaterialSkin.MouseState.OUT;
            txtMobileNumber2.Multiline = false;
            txtMobileNumber2.Name = "txtMobileNumber2";
            txtMobileNumber2.Size = new Size(265, 50);
            txtMobileNumber2.TabIndex = 5;
            txtMobileNumber2.Text = "";
            txtMobileNumber2.TrailingIcon = null;
            // 
            // txtMobileNumber1
            // 
            txtMobileNumber1.AnimateReadOnly = false;
            txtMobileNumber1.BorderStyle = BorderStyle.None;
            txtMobileNumber1.Depth = 0;
            txtMobileNumber1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMobileNumber1.Hint = "Mobile Number 1";
            txtMobileNumber1.LeadingIcon = null;
            txtMobileNumber1.Location = new Point(24, 173);
            txtMobileNumber1.MaxLength = 50;
            txtMobileNumber1.MouseState = MaterialSkin.MouseState.OUT;
            txtMobileNumber1.Multiline = false;
            txtMobileNumber1.Name = "txtMobileNumber1";
            txtMobileNumber1.Size = new Size(265, 50);
            txtMobileNumber1.TabIndex = 5;
            txtMobileNumber1.Text = "";
            txtMobileNumber1.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(24, 117);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 50);
            txtEmail.TabIndex = 5;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtFullName
            // 
            txtFullName.AnimateReadOnly = false;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Depth = 0;
            txtFullName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFullName.Hint = "Full Name";
            txtFullName.LeadingIcon = null;
            txtFullName.Location = new Point(24, 61);
            txtFullName.MaxLength = 50;
            txtFullName.MouseState = MaterialSkin.MouseState.OUT;
            txtFullName.Multiline = false;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(265, 50);
            txtFullName.TabIndex = 5;
            txtFullName.Text = "";
            txtFullName.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.Location = new Point(24, 21);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(173, 24);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Add New Customer";
            materialLabel5.Click += materialLabel5_Click;
            // 
            // tabCustomerFindAll
            // 
            tabCustomerFindAll.Controls.Add(btnCustomerTableLoad);
            tabCustomerFindAll.Controls.Add(txtCustomerSearch);
            tabCustomerFindAll.Controls.Add(tblCustomerDetails);
            tabCustomerFindAll.Controls.Add(materialLabel6);
            tabCustomerFindAll.ImageKey = "people.png";
            tabCustomerFindAll.Location = new Point(43, 4);
            tabCustomerFindAll.Name = "tabCustomerFindAll";
            tabCustomerFindAll.Size = new Size(1846, 934);
            tabCustomerFindAll.TabIndex = 4;
            tabCustomerFindAll.Text = "Customer Finder";
            // 
            // btnCustomerTableLoad
            // 
            btnCustomerTableLoad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomerTableLoad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCustomerTableLoad.Depth = 0;
            btnCustomerTableLoad.HighEmphasis = true;
            btnCustomerTableLoad.Icon = Properties.Resources.refresh;
            btnCustomerTableLoad.ImageList = imageList1;
            btnCustomerTableLoad.Location = new Point(1275, 248);
            btnCustomerTableLoad.Margin = new Padding(4, 6, 4, 6);
            btnCustomerTableLoad.MouseState = MaterialSkin.MouseState.HOVER;
            btnCustomerTableLoad.Name = "btnCustomerTableLoad";
            btnCustomerTableLoad.NoAccentTextColor = Color.Empty;
            btnCustomerTableLoad.Size = new Size(105, 36);
            btnCustomerTableLoad.TabIndex = 9;
            btnCustomerTableLoad.Text = "Reload";
            btnCustomerTableLoad.TextAlign = ContentAlignment.BottomCenter;
            btnCustomerTableLoad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCustomerTableLoad.UseAccentColor = true;
            btnCustomerTableLoad.UseVisualStyleBackColor = true;
            btnCustomerTableLoad.Click += btnCustomerTableLoad_Click;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.AnimateReadOnly = false;
            txtCustomerSearch.BorderStyle = BorderStyle.None;
            txtCustomerSearch.Depth = 0;
            txtCustomerSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCustomerSearch.Hint = "Search";
            txtCustomerSearch.LeadingIcon = null;
            txtCustomerSearch.Location = new Point(1387, 241);
            txtCustomerSearch.MaxLength = 50;
            txtCustomerSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtCustomerSearch.Multiline = false;
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(406, 50);
            txtCustomerSearch.TabIndex = 8;
            txtCustomerSearch.Text = "";
            txtCustomerSearch.TrailingIcon = null;
            txtCustomerSearch.KeyDown += txtCustomerSearch_KeyDown;
            // 
            // tblCustomerDetails
            // 
            tblCustomerDetails.AutoSizeTable = false;
            tblCustomerDetails.BackColor = Color.FromArgb(255, 255, 255);
            tblCustomerDetails.BorderStyle = BorderStyle.None;
            tblCustomerDetails.Columns.AddRange(new ColumnHeader[] { clmFullName, clmEmail, clmMobileNumber1, clmMobileNumber2, clmNIC, clmCity, clmAddress });
            tblCustomerDetails.Depth = 0;
            tblCustomerDetails.FullRowSelect = true;
            tblCustomerDetails.Location = new Point(22, 297);
            tblCustomerDetails.MinimumSize = new Size(200, 100);
            tblCustomerDetails.MouseLocation = new Point(-1, -1);
            tblCustomerDetails.MouseState = MaterialSkin.MouseState.OUT;
            tblCustomerDetails.Name = "tblCustomerDetails";
            tblCustomerDetails.OwnerDraw = true;
            tblCustomerDetails.Size = new Size(1793, 618);
            tblCustomerDetails.TabIndex = 6;
            tblCustomerDetails.UseCompatibleStateImageBehavior = false;
            tblCustomerDetails.View = View.Details;
            // 
            // clmFullName
            // 
            clmFullName.Text = "Full Name";
            clmFullName.Width = 200;
            // 
            // clmEmail
            // 
            clmEmail.Text = "Email";
            clmEmail.Width = 200;
            // 
            // clmMobileNumber1
            // 
            clmMobileNumber1.Text = "Mobile Number 1";
            clmMobileNumber1.Width = 150;
            // 
            // clmMobileNumber2
            // 
            clmMobileNumber2.Text = "Mobile Number 2";
            clmMobileNumber2.Width = 150;
            // 
            // clmNIC
            // 
            clmNIC.Text = "NIC";
            clmNIC.Width = 150;
            // 
            // clmCity
            // 
            clmCity.Text = "City";
            clmCity.Width = 150;
            // 
            // clmAddress
            // 
            clmAddress.Text = "Address";
            clmAddress.Width = 400;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel6.Location = new Point(22, 19);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(149, 24);
            materialLabel6.TabIndex = 5;
            materialLabel6.Text = "Customer Finder";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 1009);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TradersBuddy";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            tabAddNewCar.ResumeLayout(false);
            tabAddNewCar.PerformLayout();
            tabAllCars.ResumeLayout(false);
            tabAllCars.PerformLayout();
            tabAddCustomer.ResumeLayout(false);
            tabAddCustomer.PerformLayout();
            tabCustomerFindAll.ResumeLayout(false);
            tabCustomerFindAll.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabDashboard;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage tabAddNewCar;
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
        private TabPage tabAllCars;
        private MaterialSkin.Controls.MaterialListView tblCarDetails;
        private ColumnHeader clmBrand;
        private ColumnHeader clmModel;
        private ColumnHeader clmYear;
        private ColumnHeader clmBodyStyle;
        private ColumnHeader clmEngine;
        private ColumnHeader clmTransmission;
        private ColumnHeader clmDrivetrain;
        private ColumnHeader clmFuelType;
        private ColumnHeader clmMileage;
        private ColumnHeader clmVIN;
        private ColumnHeader clmColor;
        private ColumnHeader clmInteriorColor;
        private ColumnHeader clmNumOfDoors;
        private ColumnHeader clmSeatingCapacity;
        private MaterialSkin.Controls.MaterialTextBox txtCarSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private TabPage tabAddCustomer;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtCity;
        private MaterialSkin.Controls.MaterialTextBox txtMobileNumber2;
        private MaterialSkin.Controls.MaterialTextBox txtMobileNumber1;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtFullName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialTextBox txtNIC;
        private MaterialSkin.Controls.MaterialButton btnSaveCustomer;
        private TabPage tabCustomerFindAll;
        private MaterialSkin.Controls.MaterialTextBox txtCustomerSearch;
        private MaterialSkin.Controls.MaterialListView tblCustomerDetails;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private ColumnHeader clmFullName;
        private ColumnHeader clmEmail;
        private ColumnHeader clmMobileNumber1;
        private ColumnHeader clmMobileNumber2;
        private ColumnHeader clmNIC;
        private ColumnHeader clmCity;
        private ColumnHeader clmAddress;
        private MaterialSkin.Controls.MaterialButton btnCarTableLoad;
        private MaterialSkin.Controls.MaterialButton btnCustomerTableLoad;
        private ColumnHeader clmAction;
    }
}
