using BaseBackend.Entities;
using LearnCSharpInSematec.Dtos;
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
            //Single Responsility

            //Call Validation
            if (!IsValidRegistrationForm())
                return;

            //Add
            AddStudent addStudent = new AddStudent()
            {
                NationalCode = nationalCodeTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text.CleanPhoneNumber(),
            };
            AddStudent(addStudent);

            //Message
            MessageBox.Show("Register Successfully");

            //Reset
            ResetRegistrationForm();
        }

        //DTO => Data Transffer Object
        public void AddStudent(AddStudent addStudent)
        {
            //CreateObject
            Student student = new(firstName: addStudent.FirstName, lastName: addStudent.LastName, phoneNumber: addStudent.PhoneNumber, nationalCode: addStudent.NationalCode);

            //Add To Collection
            students.Add(student);
        }

        private void ResetRegistrationForm()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            nationalCodeTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
        }

        private bool IsValidRegistrationForm()
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) ||
                string.IsNullOrEmpty(lastNameTextBox.Text) ||
                string.IsNullOrEmpty(phoneNumberTextBox.Text) ||
                string.IsNullOrEmpty(nationalCodeTextBox.Text))
            {
                MessageBox.Show("Please enter valid inputs");
                return false;
            }
            else
                return true;
        }


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
    }
}
