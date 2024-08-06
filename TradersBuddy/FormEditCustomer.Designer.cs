namespace TradersBuddy
{
    partial class FormEditCustomer
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
            txtFullName = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtMobileNumber1 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            txtMobileNumber2 = new MaterialSkin.Controls.MaterialTextBox();
            txtNIC = new MaterialSkin.Controls.MaterialTextBox();
            txtCity = new MaterialSkin.Controls.MaterialTextBox();
            txtAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            tmrUpdateCustomer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.AnimateReadOnly = false;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Depth = 0;
            txtFullName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFullName.Hint = "Full Name";
            txtFullName.LeadingIcon = null;
            txtFullName.Location = new Point(21, 84);
            txtFullName.MaxLength = 50;
            txtFullName.MouseState = MaterialSkin.MouseState.OUT;
            txtFullName.Multiline = false;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(265, 50);
            txtFullName.TabIndex = 7;
            txtFullName.Text = "";
            txtFullName.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(21, 140);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 50);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtMobileNumber1
            // 
            txtMobileNumber1.AnimateReadOnly = false;
            txtMobileNumber1.BorderStyle = BorderStyle.None;
            txtMobileNumber1.Depth = 0;
            txtMobileNumber1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMobileNumber1.Hint = "Mobile Number 1";
            txtMobileNumber1.LeadingIcon = null;
            txtMobileNumber1.Location = new Point(21, 196);
            txtMobileNumber1.MaxLength = 50;
            txtMobileNumber1.MouseState = MaterialSkin.MouseState.OUT;
            txtMobileNumber1.Multiline = false;
            txtMobileNumber1.Name = "txtMobileNumber1";
            txtMobileNumber1.Size = new Size(265, 50);
            txtMobileNumber1.TabIndex = 7;
            txtMobileNumber1.Text = "";
            txtMobileNumber1.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox3.Hint = "Full Name";
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(6, 252);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(265, 50);
            materialTextBox3.TabIndex = 7;
            materialTextBox3.Text = "";
            materialTextBox3.TrailingIcon = null;
            // 
            // txtMobileNumber2
            // 
            txtMobileNumber2.AnimateReadOnly = false;
            txtMobileNumber2.BorderStyle = BorderStyle.None;
            txtMobileNumber2.Depth = 0;
            txtMobileNumber2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMobileNumber2.Hint = "Mobile Number 2 (Optional)";
            txtMobileNumber2.LeadingIcon = null;
            txtMobileNumber2.Location = new Point(21, 252);
            txtMobileNumber2.MaxLength = 50;
            txtMobileNumber2.MouseState = MaterialSkin.MouseState.OUT;
            txtMobileNumber2.Multiline = false;
            txtMobileNumber2.Name = "txtMobileNumber2";
            txtMobileNumber2.Size = new Size(265, 50);
            txtMobileNumber2.TabIndex = 7;
            txtMobileNumber2.Text = "";
            txtMobileNumber2.TrailingIcon = null;
            // 
            // txtNIC
            // 
            txtNIC.AnimateReadOnly = false;
            txtNIC.BorderStyle = BorderStyle.None;
            txtNIC.Depth = 0;
            txtNIC.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNIC.Hint = "NIC";
            txtNIC.LeadingIcon = null;
            txtNIC.Location = new Point(311, 252);
            txtNIC.MaxLength = 50;
            txtNIC.MouseState = MaterialSkin.MouseState.OUT;
            txtNIC.Multiline = false;
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(265, 50);
            txtNIC.TabIndex = 7;
            txtNIC.Text = "";
            txtNIC.TrailingIcon = null;
            // 
            // txtCity
            // 
            txtCity.AnimateReadOnly = false;
            txtCity.BorderStyle = BorderStyle.None;
            txtCity.Depth = 0;
            txtCity.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCity.Hint = "City";
            txtCity.LeadingIcon = null;
            txtCity.Location = new Point(311, 196);
            txtCity.MaxLength = 50;
            txtCity.MouseState = MaterialSkin.MouseState.OUT;
            txtCity.Multiline = false;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(265, 50);
            txtCity.TabIndex = 7;
            txtCity.Text = "";
            txtCity.TrailingIcon = null;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.HideSelection = true;
            txtAddress.Hint = "Address";
            txtAddress.Location = new Point(311, 84);
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
            txtAddress.TabIndex = 8;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(499, 311);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(77, 36);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tmrUpdateCustomer
            // 
            tmrUpdateCustomer.Enabled = true;
            tmrUpdateCustomer.Interval = 1;
            tmrUpdateCustomer.Tick += tmrUpdateCustomer_Tick;
            // 
            // FormEditCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtNIC);
            Controls.Add(txtMobileNumber2);
            Controls.Add(materialTextBox3);
            Controls.Add(txtMobileNumber1);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Name = "FormEditCustomer";
            Text = "Update Customer";
            Load += FormEditCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtFullName;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtMobileNumber1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox txtMobileNumber2;
        private MaterialSkin.Controls.MaterialTextBox txtNIC;
        private MaterialSkin.Controls.MaterialTextBox txtCity;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private System.Windows.Forms.Timer tmrUpdateCustomer;
    }
}