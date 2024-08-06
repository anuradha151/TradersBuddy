using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using TradersBuddy.Model;
using WinFormEFDemo.Data;

namespace TradersBuddy
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            initializeMaterialSkin();
            setNewCarFormTabIndexes();
            setNewCustomerFormTabIndexes();

        }

        private void initializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.DeepPurple700,
                TextShade.WHITE
                );
        }

        private void setNewCustomerFormTabIndexes()
        {
            txtFullName.TabIndex = 15;
            txtEmail.TabIndex = 16;
            txtMobileNumber1.TabIndex = 17;
            txtMobileNumber2.TabIndex = 18;
            txtAddress.TabIndex = 19;
            txtCity.TabIndex = 20;
            txtNIC.TabIndex = 21;
            btnSaveCustomer.TabIndex = 22;
        }

        private void setNewCarFormTabIndexes()
        {
            cmbCarBrand.TabIndex = 0;
            txtCarModel.TabIndex = 1;
            txtManufacturedYear.TabIndex = 2;
            cmbBodyStyle.TabIndex = 3;
            txtEngine.TabIndex = 4;
            txtTransmission.TabIndex = 5;
            cmbDrivetrain.TabIndex = 6;
            cmbFuelType.TabIndex = 7;
            txtMileage.TabIndex = 8;
            txtVIN.TabIndex = 9;
            txtColor.TabIndex = 10;
            txtInteriorColor.TabIndex = 11;
            txtNumberOfDoors.TabIndex = 12;
            txtSeatingCapacity.TabIndex = 13;
            btnSaveCar.TabIndex = 14;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars = dbContext.cars.ToList();
                loadCarTable(cars);
                var customers = dbContext.customer.ToList();
                loadCustomerTable(customers);
            }
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var car = new Car
                {
                    Brand = cmbCarBrand.Text,
                    Model = txtCarModel.Text,
                    Year = txtManufacturedYear.Text,
                    BodyStyle = cmbBodyStyle.Text,
                    Engine = txtEngine.Text,
                    Transmission = txtTransmission.Text,
                    Drivetrain = cmbDrivetrain.Text,
                    FuelType = cmbFuelType.Text,
                    Mileage = txtMileage.Text,
                    VIN = txtVIN.Text,
                    Color = txtColor.Text,
                    InteriorColor = txtInteriorColor.Text,
                    NumOfDoors = txtNumberOfDoors.Text,
                    SeatingCapacity = txtSeatingCapacity.Text
                };
                dbContext.cars.Add(car);
                dbContext.SaveChanges();
                MessageBox.Show("Car details saved successfully");
                cleanTextBoxes();
            }

        }

        private void cleanTextBoxes()
        {
            txtCarModel.Text = "";
            txtManufacturedYear.Text = "";
            txtEngine.Text = "";
            txtTransmission.Text = "";
            txtMileage.Text = "";
            txtVIN.Text = "";
            txtColor.Text = "";
            txtInteriorColor.Text = "";
            txtNumberOfDoors.Text = "";
            txtSeatingCapacity.Text = "";
        }

        private void loadCarTable(List<Car> cars)
        {
            tblCarDetails.Items.Clear();

            foreach (var car in cars)
            {
                var listViewItem = new ListViewItem(new[]
                {
                        car.Brand,
                        car.Model,
                        car.Year,
                        car.BodyStyle,
                        car.Engine,
                        car.Transmission,
                        car.Drivetrain,
                        car.FuelType,
                        car.Mileage,
                        car.VIN,
                        car.Color,
                        car.InteriorColor,
                        car.NumOfDoors,
                        car.SeatingCapacity
                    });

                tblCarDetails.Items.Add(listViewItem);
            }

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            // Save customer details

            using (var dbContext = new ApplicationDBContext())
            {
                var customer = new Customer
                {
                    FullName = txtFullName.Text,
                    Email = txtEmail.Text,
                    MobileNumber1 = txtMobileNumber1.Text,
                    MobileNumber2 = txtMobileNumber2.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    NIC = txtNIC.Text
                };
                dbContext.customer.Add(customer);
                dbContext.SaveChanges();
                MessageBox.Show("Customer details saved successfully");
                cleanCustomerTextBoxes();
            }
        }

        private void cleanCustomerTextBoxes()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtMobileNumber1.Text = "";
            txtMobileNumber2.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtNIC.Text = "";
        }

        private void txtCustomerSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var searchTerm = txtCustomerSearch.Text;
            using (var dbContext = new ApplicationDBContext())
            {

                var customers = new List<Customer>();
                if (searchTerm == "")
                {
                    customers = dbContext.customer.ToList();
                }
                else
                {
                    customers = dbContext.customer
                    .Where(customer => customer.FullName.Contains(searchTerm)
                                 || customer.Email.Contains(searchTerm)
                                 || customer.MobileNumber1.Contains(searchTerm)
                                 || customer.MobileNumber2.Contains(searchTerm)
                                 || customer.Address.Contains(searchTerm)
                                 || customer.City.Contains(searchTerm)
                                 || customer.NIC.Contains(searchTerm))
                    .ToList();
                }
                loadCustomerTable(customers);
            }
        }

        private void loadCustomerTable(List<Customer> customers)
        {
            tblCustomerDetails.Items.Clear();

            foreach (var customer in customers)
            {
                var listViewItem = new ListViewItem(new[]
                {
                        customer.FullName,
                        customer.Email,
                        customer.MobileNumber1,
                        customer.MobileNumber2,
                        customer.NIC ,
                        customer.City,
                        customer.Address
                    });

                tblCustomerDetails.Items.Add(listViewItem);
            }
        }

        private void txtCarSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var searchTerm = txtCarSearch.Text;
            using (var dbContext = new ApplicationDBContext())
            {
                var cars = new List<Car>();
                if (searchTerm == "")
                {
                    cars = dbContext.cars.ToList();
                }
                else
                {
                    cars = dbContext.cars
                    .Where(car => car.Brand.Contains(searchTerm)
                                 || car.Model.Contains(searchTerm)
                                 || car.Year.Contains(searchTerm)
                                 || car.BodyStyle.Contains(searchTerm)
                                 || car.Engine.Contains(searchTerm)
                                 || car.Transmission.Contains(searchTerm)
                                 || car.Drivetrain.Contains(searchTerm)
                                 || car.FuelType.Contains(searchTerm)
                                 || car.Mileage.Contains(searchTerm)
                                 || car.VIN.Contains(searchTerm)
                                 || car.Color.Contains(searchTerm)
                                 || car.InteriorColor.Contains(searchTerm)
                                 || car.NumOfDoors.Contains(searchTerm)
                                 || car.SeatingCapacity.Contains(searchTerm))
                    .ToList();
                }
                loadCarTable(cars);
            }
        }

        private void btnCarTableLoad_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars = dbContext.cars.ToList();
                loadCarTable(cars);
            }
        }

        private void btnCustomerTableLoad_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var customers = dbContext.customer.ToList();
                loadCustomerTable(customers);
            }

        }

        public static int parentX, parentY;

        private void tblCarDetails_DoubleClick(object sender, EventArgs e)
        {
           // I want to show the FormEditCarDetails As a modal
           Form modalBackground = new Form();
           using(FormEditCarDetails formEditCarDetails = new FormEditCarDetails())
           {
               modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                formEditCarDetails.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                formEditCarDetails.ShowDialog();
                modalBackground.Dispose();
           }


        }

       
    }
}














