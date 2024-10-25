using BaseBackend.Entities;
using BaseBackend.Enums;
using LearnCSharpInSematec.Dtos;
using LearnCSharpInSematec.Utilities;

namespace LearnCSharpInSematec
{
    public partial class StudentForm : Form
    {
        List<Student> students;

        public StudentForm()
        {
            InitializeComponent();
            //Initial Value Form
            students = new List<Student>();
            students.Add(new Student() { FirstName = "Parham", LastName = "Darvsihi", IsDeleted = false,NationalCode = "00000"});
            students.Add(new Student() { FirstName = "Parham 2", LastName = "Darvsihi 2", IsDeleted = true, NationalCode = "00001" });
            studentDataGridView.DataSource = students;

            List<string> comboList = new List<string>();
            //comboList.Add("لطفا انتخاب نمایید");
            //comboList.Add("مرد");
            //comboList.Add("زن");
            //comboList.Add("نامخشص");
            genderComboBox.DataSource = comboList;
            genderComboBox.BackColor = Color.Red;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var genderEnum = genderComboBox.SelectedIndex;

            Student student = new Student();
            student.FirstName = firstNameTextBox.Text;

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
                Gender = (Gender)genderEnum
            };
            AddStudent(addStudent);

            //Message
            MessageBox.Show("Register Successfully");

            //Reset
            ResetRegistrationForm();
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

        private void ResetRegistrationForm()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            nationalCodeTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
        }

        //DTO => Data Transffer Object
        public void AddStudent(AddStudent addStudent)
        {
            //CreateObject
            Student student = new(firstName: addStudent.FirstName, lastName: addStudent.LastName, phoneNumber: addStudent.PhoneNumber, nationalCode: addStudent.NationalCode);

            //Add To Collection
            students.Add(student);

            studentDataGridView.DataSource = null;
            studentDataGridView.DataSource = students;
            studentDataGridView.Refresh();
        }
    }
}
