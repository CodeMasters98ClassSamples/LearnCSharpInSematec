namespace LearnCSharpInSematec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //UI
            InitializeComponent();
            isRememberMeCheckBox.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isRemember = isRememberMeCheckBox.Checked;
             string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter valid input!");
                return;
            }
            if (username.ToLower() == "parham" && password == "1234")
            {
                //Redirect to Student Form
                StudentForm studentForm = new StudentForm();
                studentForm.Show();

                this.Hide();
            }
            else
            {
                UsernameTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                MessageBox.Show("Username or password is invalid!");
            }
                
        }
    }
}
