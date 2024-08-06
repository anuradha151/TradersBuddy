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

namespace TradersBuddy
{
    public partial class FormEditCarDetails : MaterialForm
    {
        public FormEditCarDetails()
        {
            InitializeComponent();
            initializeMaterialSkin();
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
            if(Opacity == 1)
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
    }
}
