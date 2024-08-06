using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormEFDemo.Data;

namespace TradersBuddy
{
    public partial class FormEditCarDetails : MaterialForm
    {
        private int carId = 0;
        public FormEditCarDetails()
        {
            InitializeComponent();
            initializeMaterialSkin();
            setTabIndexes();
        }

        public FormEditCarDetails(int Id)
        {
            InitializeComponent();
            initializeMaterialSkin();
            setTabIndexes();
            carId = Id;

            using (var dbContext = new ApplicationDBContext())
            {
                var car = dbContext.cars.Where(c => c.Id == Id).FirstOrDefault();
                if (car != null)
                {
                    cmbCarBrand.Text = car.Brand;
                    txtModel.Text = car.Model;
                    txtYear.Text = car.Year;
                    cmbBodyStyle.Text = car.BodyStyle;
                    txtEngine.Text = car.Engine;
                    txtTransmission.Text = car.Transmission;
                    cmbDrivetrain.Text = car.Drivetrain;
                    cmbFuelType.Text = car.FuelType;
                    txtMileage.Text = car.Mileage;
                    txtVIN.Text = car.VIN;
                    txtColor.Text = car.Color;
                    txtInteriorColor.Text = car.InteriorColor;
                    txtDoors.Text = car.NumOfDoors;
                    txtSeatingCapacity.Text = car.SeatingCapacity;
                }
            }

        }

        private void setTabIndexes()
        {
            cmbCarBrand.TabIndex = 0;
            txtModel.TabIndex = 1;
            txtYear.TabIndex = 2;
            cmbBodyStyle.TabIndex = 3;
            txtEngine.TabIndex = 4;
            txtTransmission.TabIndex = 5;
            cmbDrivetrain.TabIndex = 6;
            cmbFuelType.TabIndex = 7;
            txtMileage.TabIndex = 8;
            txtVIN.TabIndex = 9;
            txtColor.TabIndex = 10;
            txtInteriorColor.TabIndex = 11;
            txtDoors.TabIndex = 12;
            txtSeatingCapacity.TabIndex = 13;
            btnUpdate.TabIndex = 14;
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

        int i;
        private void FormEditCarDetails_Load(object sender, EventArgs e)
        {
            i = Form1.parentY + 150;
            this.Location = new Point(Form1.parentX + 500, Form1.parentY + 150);

        }

        private void modelEffectTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                modelEffectTimer.Stop();
            }
            else
            {
                Opacity += 0.03;
            }
        }

        private void cmbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var car = dbContext.cars.Where(c => c.Id == carId).FirstOrDefault();
                if (car != null)
                {
                    car.Brand = cmbCarBrand.Text;
                    car.Model = txtModel.Text;
                    car.Year = txtYear.Text;
                    car.BodyStyle = cmbBodyStyle.Text;
                    car.Engine = txtEngine.Text;
                    car.Transmission = txtTransmission.Text;
                    car.Drivetrain = cmbDrivetrain.Text;
                    car.FuelType = cmbFuelType.Text;
                    car.Mileage = txtMileage.Text;
                    car.VIN = txtVIN.Text;
                    car.Color = txtColor.Text;
                    car.InteriorColor = txtInteriorColor.Text;
                    car.NumOfDoors = txtDoors.Text;
                    car.SeatingCapacity = txtSeatingCapacity.Text;

                    dbContext.SaveChanges();
                    MessageBox.Show("Car details updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Car not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
