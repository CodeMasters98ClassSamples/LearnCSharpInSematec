using LearnCSharpInSematec.Models;

namespace LearnCSharpInSematec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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

            ////Object
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
    }
}
