using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Signup : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True;TrustServerCertificate=True");

        public Signup()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            DOB_DTP.Format = DateTimePickerFormat.Long;

            DateTime dob = DOB_DTP.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age))
            {
                age--;
            }

            AgeTextBox.Text = age.ToString();
        }
        //pass things
        private bool HasSpecialChar(string password)
        {
            return password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private bool HasUpperCase(string password)
        {
            return password.Any(ch => char.IsUpper(ch));
        }

        private bool HasLowerCase(string password)
        {
            return password.Any(ch => char.IsLower(ch));
        }

        private bool HasNumber(string password)
        {
            return password.Any(ch => char.IsDigit(ch));
        }
        //pass thing ends here 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = "";
            AgeTextBox.Text = "";
            ContactTextBox.Text = "";
            BloodGroupComboBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";

            if (GenderComboBox.Items.Count > 0)
            {
                GenderComboBox.Text = "Select";
            }

            if (CategoryComboBox.Items.Count > 0)
            {
                CategoryComboBox.Text = "Select";
            }

            DOB_DTP.Format = DateTimePickerFormat.Custom;
            DOB_DTP.CustomFormat = "'Select'";

            FullNameTextBox.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            // 1️⃣ Check if ALL fields are empty
            if (FullNameTextBox.Text == "" &&
                DOB_DTP.CustomFormat == "'Select'" &&
                GenderComboBox.Text == "Select" &&
                BloodGroupComboBox.Text == "" &&
                ContactTextBox.Text == "" &&
                CategoryComboBox.Text == "Select" &&
                UsernameTextBox.Text == "" &&
                PasswordTextBox.Text == "" &&
                ConfirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields before proceeding.");
                return;
            }

            // 2️⃣ Password validation only if both password fields are not empty
            string password = PasswordTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();

            if (password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please enter and confirm your password.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

            if (!HasUpperCase(password))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.");
                return;
            }

            if (!HasLowerCase(password))
            {
                MessageBox.Show("Password must contain at least one lowercase letter.");
                return;
            }

            if (!HasNumber(password))
            {
                MessageBox.Show("Password must contain at least one number.");
                return;
            }

            if (!HasSpecialChar(password))
            {
                MessageBox.Show("Password must contain at least one special character.");
                return;
            }

            // ✅ All validations passed
            MessageBox.Show("Account created successfully!");
        }


        // ✅ Password verification done



        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
