using BaseBackend.Entities;
using LearnCSharpInSematec.Dtos;
using Newtonsoft.Json;

namespace LearnCSharpInSematec
{
    public partial class Form1 : Form
    {
        List<UserLogin> userLogins;

        public Form1()
        {
            //UI
            InitializeComponent();
            isRememberMeCheckBox.Checked = true;

            var userLoginJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "UserLogin.json");
            if (File.Exists(userLoginJsonPath))
            {
                string userLoginJsonStr = File.ReadAllText(userLoginJsonPath);
                userLogins = JsonConvert.DeserializeObject<List<UserLogin>>(userLoginJsonStr) ?? [];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Older Than C# 2
            bool isValidUsernameAndPassword = false;
            bool isRemember = isRememberMeCheckBox.Checked;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter valid input!");
                return;
            }

            //Linq
            //C# 2 -> Delegate
            List<UserLogin> findedUserLogins = userLogins
                    .Where(userLogin => username.ToLower() == userLogin.UserName.ToLower() && 
                    password == userLogin.Password)
                    .ToList();
            if (findedUserLogins is not null && findedUserLogins.Count > 0)
            {
                isValidUsernameAndPassword = true;
                //Redirect to Student Form
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();
            }

            //foreach (var userLogin in userLogins)
            //{
            //    if (username.ToLower() == userLogin.UserName.ToLower() && password == userLogin.Password)
            //    {
            //        isValidUsernameAndPassword = true;
            //        //Redirect to Student Form
            //        StudentForm studentForm = new StudentForm();
            //        studentForm.Show();
            //        this.Hide();
            //        break;
            //    }
            //    else
            //        continue;
            //}

            if (!isValidUsernameAndPassword)
            {
                UsernameTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                MessageBox.Show("Username or password is invalid!");
            }
        }
    }
}
