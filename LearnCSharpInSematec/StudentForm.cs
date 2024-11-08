using BaseBackend.Entities;
using BaseBackend.Enums;
using LearnCSharpInSematec.Dtos;
using LearnCSharpInSematec.Utilities;
using Newtonsoft.Json;

namespace LearnCSharpInSematec
{
    public partial class StudentForm : Form
    {
        //Delegate
        public delegate void ReloadData();

        //Event?
        // Declare the event.
        public event ReloadData ReloadDataEvent;

        List<Student> students;

        /// <summary>
        /// Fill Combobox,Fill Intial Data
        /// </summary>
        public StudentForm()
        {
            InitializeComponent();
            ReloadDataEvent += FillDataIntoDataGridView; //Bind Method to event
            var studentJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Students.json");
            if (File.Exists(studentJsonPath))
            {
                string studentJsonStr = File.ReadAllText(studentJsonPath);
                students = JsonConvert.DeserializeObject<List<Student>>(studentJsonStr) ?? [];
                ReloadDataEvent.Invoke();
            }
            FillGenderComoboBox();
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
            genderComboBox.SelectedIndex = 0;
        }

        public void FillDataIntoDataGridView()
        {
            studentDataGridView.DataSource = null;
            studentDataGridView.DataSource = students;
            studentDataGridView.Refresh();
        }

        private void FillGenderComoboBox()
        {
            List<string> comboList = new List<string>();
            genderComboBox.DataSource = comboList;
            genderComboBox.BackColor = Color.Red;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        /// <summary>
        /// Add Student To Student List, Get Student Data Transfer Object(Dto)
        /// </summary>
        /// <param name="addStudent"></param>
        public void AddStudent(AddStudent addStudent)
        {
            //CreateObject
            Student student = new(firstName: addStudent.FirstName, lastName: addStudent.LastName, phoneNumber: addStudent.PhoneNumber, nationalCode: addStudent.NationalCode);

            //Add To Collection
            students.Add(student);
            ReloadDataEvent.Invoke();
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
            //Method Call
            ResetRegistrationForm();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetRegistrationForm();
            MessageBox.Show("Form Reset!");
        }

        private void studentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = 0;
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
