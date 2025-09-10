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
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True;TrustServerCertificate=True");

        public Signup()
        {
            InitializeComponent();
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
            ContactTextBox.Text = "";
            BloodGroupComboBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";

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
            // Validation check (use OR instead of AND)
            if (FullNameTextBox.Text == "" &&
                DOB_DTP.CustomFormat == "'Select'" &&
                GenderComboBox.Text == "Select" &&
                BloodGroupComboBox.Text == "" &&
                ContactTextBox.Text == "" &&
                CategoryComboBox.Text == "Select" &&
                UsernameTextBox.Text == "" &&
                PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields before proceeding.");
                return;
            }

            // Make sure UserId is first, then all other fields
            string insert_query = "INSERT INTO Users (FullName, DOB, Gender, BloodGroup, Contact, Category, Username, Password) VALUES ('"
    + FullNameTextBox.Text + "', '"
    + DOB_DTP.Value.ToString("yyyy-MM-dd") + "', '"
    + GenderComboBox.Text + "', '"
    + BloodGroupComboBox.Text + "', '"
    + ContactTextBox.Text + "', '"
    + CategoryComboBox.Text + "', '"
    + UsernameTextBox.Text + "', '"
    + PasswordTextBox.Text + "')";



            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(insert_query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
