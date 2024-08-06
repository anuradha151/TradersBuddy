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
    public partial class FormEditCustomer : MaterialForm
    {

        private int customerId = 0;
        public FormEditCustomer()
        {
            InitializeComponent();
            initializeMaterialSkin();
            setTabIndexes();
        }

        public FormEditCustomer(int Id)
        {
            InitializeComponent();
            initializeMaterialSkin();
            setTabIndexes();
            customerId = Id;

            using (var dbContext = new ApplicationDBContext())
            {
                var customer = dbContext.customer.Where(c => c.Id == Id).FirstOrDefault();
                if (customer != null)
                {
                    txtFullName.Text = customer.FullName;
                    txtEmail.Text = customer.Email;
                    txtMobileNumber1.Text = customer.MobileNumber1;
                    txtMobileNumber2.Text = customer.MobileNumber2;
                    txtAddress.Text = customer.Address;
                    txtCity.Text = customer.City;
                    txtNIC.Text = customer.NIC;
                }
            }
        }

        private void setTabIndexes()
        {
            txtFullName.TabIndex = 0;
            txtEmail.TabIndex = 1;
            txtMobileNumber1.TabIndex = 2;
            txtMobileNumber2.TabIndex = 3;
            txtAddress.TabIndex = 4;
            txtCity.TabIndex = 5;
            txtNIC.TabIndex = 6;
            btnUpdate.TabIndex = 7;
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
        private void FormEditCustomer_Load(object sender, EventArgs e)
        {
            i = Form1.parentY + 150;
            this.Location = new Point(Form1.parentX + 500, Form1.parentY + 150);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // update customer
            using (var dbContext = new ApplicationDBContext())
            {
                var customer = dbContext.customer.Where(c => c.Id == customerId).FirstOrDefault();
                if (customer != null)
                {
                    customer.FullName = txtFullName.Text;
                    customer.Email = txtEmail.Text;
                    customer.MobileNumber1 = txtMobileNumber1.Text;
                    customer.MobileNumber2 = txtMobileNumber2.Text;
                    customer.Address = txtAddress.Text;
                    customer.City = txtCity.Text;
                    customer.NIC = txtNIC.Text;

                    dbContext.SaveChanges();
                    MessageBox.Show("Customer updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void tmrUpdateCustomer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tmrUpdateCustomer.Stop();
            }
            else
            {
                Opacity += 0.03;
            }
        }
    }
}
