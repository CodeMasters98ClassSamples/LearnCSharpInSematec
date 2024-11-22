using BaseBackend.Businesses;
using BaseBackend.Entities;
using BaseBackend.Enums;
using LearnCSharpInSematec.Dtos;
using LearnCSharpInSematec.Utilities;

namespace LearnCSharpInSematec
{
    public partial class StudentForm : Form
    {

        private readonly StudentBusiness _studentBusiness;

        //Delegate
        public delegate void ReloadData(List<Student> students);

        //Event?
        // Declare the event.
        public event ReloadData ReloadDataEvent;

        List<Student> students;
        Student currentStudent;

        /// <summary>
        /// Fill Combobox,Fill Intial Data
        /// </summary>
        public StudentForm()
        {
            InitializeComponent();
            ReloadDataEvent += FillDataIntoDataGridView; //Bind Method to event

            _studentBusiness = new StudentBusiness();
            students = _studentBusiness.GetAll();
            ReloadDataEvent.Invoke(students);

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
            currentStudent = null;
        }

        public void FillDataIntoDataGridView(List<Student> students)
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
            //students.Add(student);

            //From Db
            _studentBusiness.Add(student);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
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
                Gender = (Gender)genderComboBox.SelectedIndex
            };
            AddStudent(addStudent);
            students = _studentBusiness.GetAll();
            ReloadDataEvent.Invoke(students);
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
            if (e.RowIndex >= 0)
            {
                var row = studentDataGridView.Rows[e.RowIndex];
                var id = (int)row.Cells["Id"].Value;
                var student = students.Where(x => x.Id == id).FirstOrDefault();

                nationalCodeTextBox.Text = student.NationalCode;
                firstNameTextBox.Text = student.FirstName;
                lastNameTextBox.Text = student.LastName;
                phoneNumberTextBox.Text = student.PhoneNumber;
                genderComboBox.SelectedIndex = (int)student.Gender;
                currentStudent = student;
            }
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (currentStudent is null)
            {
                MessageBox.Show("شما کاربری را جهت به روز رسانی اطلاعات انتخاب نکرده اید!");
                return;
            }

            Student student = new Student()
            {
                NationalCode = nationalCodeTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text.CleanPhoneNumber(),
                Gender = (Gender)genderComboBox.SelectedIndex,
                Id = currentStudent.Id
            };
            _studentBusiness.Update(student);
            students = _studentBusiness.GetAll();
            ReloadDataEvent.Invoke(students);
            ResetRegistrationForm();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            students = _studentBusiness.GetAll();
            ReloadDataEvent.Invoke(students);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (currentStudent is null)
            {
                MessageBox.Show("شما کاربری را جهت به حذف اطلاعات انتخاب نکرده اید!");
                return;
            }
            _studentBusiness.Delete(Id: currentStudent.Id);
            students = _studentBusiness.GetAll();
            ReloadDataEvent.Invoke(students);
            ResetRegistrationForm();
        }

        private void SoftDeleteButton_Click(object sender, EventArgs e)
        {
            if (currentStudent is null)
            {
                MessageBox.Show("شما کاربری را جهت به حذف اطلاعات انتخاب نکرده اید!");
                return;
            }
            Student student = new Student()
            {
                NationalCode = currentStudent.NationalCode,
                FirstName = currentStudent.FirstName,
                LastName = currentStudent.LastName,
                PhoneNumber = currentStudent.PhoneNumber,
                Gender = currentStudent.Gender,
                Id = currentStudent.Id,
                IsDeleted = true,
                DeletedAt = DateTime.Now,
            };
            _studentBusiness.Update(student);
            students = _studentBusiness.GetAll();
            ReloadDataEvent.Invoke(students);
        }

        private void fisrtNameSeacrhTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchedText = fisrtNameSeacrhTextBox.Text;
            if (string.IsNullOrEmpty(searchedText))
            {
                students = _studentBusiness.GetAll();
                ReloadDataEvent.Invoke(students);
            }
            else
            {
                searchedText = searchedText.Trim().ToLower();
                students = students.Where(x => x.FirstName.ToLower().Contains(searchedText)).ToList();
                ReloadDataEvent.Invoke(students);
            }
            
        }
    }
}
