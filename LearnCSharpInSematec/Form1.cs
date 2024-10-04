using LearnCSharpInSematec.Enums;
using LearnCSharpInSematec.Models;
using LearnCSharpInSematec.Utilities;

namespace LearnCSharpInSematec
{
    public partial class Form1 : Form
    {

        List<Student> students;

        public Form1()
        {
            //Initial Value Form
            students = new List<Student>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Predefine Data Type
            ////DataType Name = intial Value;
            //string name = "Parsa";

            ////Object
            //Student student = new Student();
            //student.FirstName = "Parham";
            //student.LastName = "Darvishi";
            //student.PhoneNumber = "1234567890";
            //student.NationalCode = "1234567890";

            //Object
            //Student student1 = new Student();
            //student1.FirstName = "Amir hossein";
            //student1.LastName = "BabaAli";
            //student1.PhoneNumber = "1234567890";
            //student1.NationalCode = "1234567890";

            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter valid input!");
                return;
            }

            if (username.ToLower() == "parham" && password == "1234")
                MessageBox.Show("Login successfully");
            else
                MessageBox.Show("Username or password is invalid!");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(firstNameTextBox.Text) ||
                string.IsNullOrEmpty(lastNameTextBox.Text) ||
                string.IsNullOrEmpty(phoneNumberTextBox.Text) || 
                string.IsNullOrEmpty(nationalCodeTextBox.Text)) {
                MessageBox.Show("Please enter valid inputs");
                return;
            }

            Console.WriteLine();

            //9129564205
            //string phoneNumber = CleanPhoneNumber();
            string phoneNumber = CleanData.PhoneNumber(phoneNumberTextBox.Text);
            
            //Style 1
            //Student student = new Student();
            //student.FirstName = firstNameTextBox.Text;
            //student.LastName = lastNameTextBox.Text;
            //student.NationalCode = nationalCodeTextBox.Text;
            //student.PhoneNumber = phoneNumberTextBox.Text;

            //Style 2
            //Student student = new();
            //student.FirstName = firstNameTextBox.Text;
            //student.LastName = lastNameTextBox.Text;
            //student.NationalCode = nationalCodeTextBox.Text;
            //student.PhoneNumber = phoneNumberTextBox.Text;

            //Style 3
            //Student student = new()
            //{
            //    FirstName = firstNameTextBox.Text,
            //    LastName = lastNameTextBox.Text,
            //    NationalCode = nationalCodeTextBox.Text,
            //    PhoneNumber = phoneNumberTextBox.Text
            //};


            Student student = new(firstName: firstNameTextBox.Text, lastName: lastNameTextBox.Text, phoneNumber: phoneNumber, nationalCode:nationalCodeTextBox.Text);
            students.Add(student);

            Student student1 = new(phoneNumber: phoneNumberTextBox.Text, nationalCode: nationalCodeTextBox.Text);
            student1.Gender = Gender.MALE;
            //Add Collection
            //Add Database
            MessageBox.Show("Register Successfully");

            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            nationalCodeTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
        }

        //private string CleanPhoneNumber(string phoneNumber)
        //{
        //    if (string.IsNullOrEmpty(phoneNumber))
        //        return string.Empty;

        //    phoneNumber = phoneNumber.Trim().Replace("+98", "0").Replace("0098", "0");
        //    phoneNumber = phoneNumber.Length == 10 ? "0" + phoneNumber : phoneNumber;
        //    return phoneNumber;
        //}

        private string CleanNationalCode(string nationalCode)
        {
            return nationalCode;
        }

    }
}
