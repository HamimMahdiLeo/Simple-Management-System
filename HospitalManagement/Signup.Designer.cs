namespace HospitalManagement
{
    partial class Signup
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
            this.SignupLabel = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DOB_DTP = new System.Windows.Forms.DateTimePicker();
            this.Contact = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.SignupBack = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.Proceed = new System.Windows.Forms.Button();
            this.BloodGroup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.SignupLabel.Location = new System.Drawing.Point(331, 39);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(124, 39);
            this.SignupLabel.TabIndex = 0;
            this.SignupLabel.Text = "Signup";
            this.SignupLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SignupLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FullName.Location = new System.Drawing.Point(175, 104);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(92, 20);
            this.FullName.TabIndex = 1;
            this.FullName.Text = "Full Name : ";
            this.FullName.Click += new System.EventHandler(this.label2_Click);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(284, 104);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(321, 20);
            this.FullNameTextBox.TabIndex = 2;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DOB.Location = new System.Drawing.Point(156, 134);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(111, 20);
            this.DOB.TabIndex = 3;
            this.DOB.Text = "Date of Birth : ";
            this.DOB.Click += new System.EventHandler(this.label3_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Gender.Location = new System.Drawing.Point(192, 205);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(75, 20);
            this.Gender.TabIndex = 4;
            this.Gender.Text = "Gender : ";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Category.Location = new System.Drawing.Point(182, 311);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(85, 20);
            this.Category.TabIndex = 5;
            this.Category.Text = "Category : ";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(284, 204);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(70, 21);
            this.GenderComboBox.TabIndex = 6;
            this.GenderComboBox.Text = "Select";
            this.GenderComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Doctor",
            "Nurse",
            "Patient"});
            this.CategoryComboBox.Location = new System.Drawing.Point(284, 310);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 7;
            this.CategoryComboBox.Text = "Select";
            // 
            // DOB_DTP
            // 
            this.DOB_DTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DOB_DTP.CustomFormat = "\'Select\'";
            this.DOB_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOB_DTP.Location = new System.Drawing.Point(284, 134);
            this.DOB_DTP.Name = "DOB_DTP";
            this.DOB_DTP.Size = new System.Drawing.Size(321, 20);
            this.DOB_DTP.TabIndex = 8;
            this.DOB_DTP.ValueChanged += new System.EventHandler(this.DOB_ValueChanged);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Contact.Location = new System.Drawing.Point(190, 240);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(77, 20);
            this.Contact.TabIndex = 9;
            this.Contact.Text = "Contact : ";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(284, 240);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(321, 20);
            this.ContactTextBox.TabIndex = 10;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Username.Location = new System.Drawing.Point(172, 348);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(95, 20);
            this.Username.TabIndex = 11;
            this.Username.Text = "Username : ";
            this.Username.Click += new System.EventHandler(this.label7_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Password.Location = new System.Drawing.Point(177, 386);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(90, 20);
            this.Password.TabIndex = 12;
            this.Password.Text = "Password : ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(284, 386);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(321, 20);
            this.PasswordTextBox.TabIndex = 13;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(284, 348);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(321, 20);
            this.UsernameTextBox.TabIndex = 14;
            // 
            // SignupBack
            // 
            this.SignupBack.Location = new System.Drawing.Point(12, 415);
            this.SignupBack.Name = "SignupBack";
            this.SignupBack.Size = new System.Drawing.Size(75, 23);
            this.SignupBack.TabIndex = 15;
            this.SignupBack.Text = "Back";
            this.SignupBack.UseVisualStyleBackColor = true;
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(380, 415);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 23);
            this.ClearAll.TabIndex = 16;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // Proceed
            // 
            this.Proceed.Location = new System.Drawing.Point(713, 415);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(75, 23);
            this.Proceed.TabIndex = 17;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseVisualStyleBackColor = true;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // BloodGroup
            // 
            this.BloodGroup.AutoSize = true;
            this.BloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BloodGroup.Location = new System.Drawing.Point(156, 273);
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.Size = new System.Drawing.Size(111, 20);
            this.BloodGroup.TabIndex = 18;
            this.BloodGroup.Text = "Blood Group : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(217, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Age : ";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(284, 169);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 21;
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BloodGroupComboBox.Location = new System.Drawing.Point(284, 275);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(70, 21);
            this.BloodGroupComboBox.TabIndex = 22;
            this.BloodGroupComboBox.Text = "Select";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BloodGroupComboBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BloodGroup);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.SignupBack);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.DOB_DTP);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.SignupLabel);
            this.Name = "Signup";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignupLabel;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DateTimePicker DOB_DTP;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button SignupBack;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.Label BloodGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.ComboBox BloodGroupComboBox;
    }
}