using MyFirstWinForms.Models;

namespace MyFirstWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValidToLogin = default;
                List<User> users = InitialData();
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;

                for (int i = 0; i < users.Count; i++) {
                    if (username.ToLower() == users[i].Username.ToLower() && password == users[i].Password)
                    {
                        isValidToLogin = true;
                        break;
                    }
                    else
                        continue;
                }

                //Style 1
                //if (isValidToLogin)
                //    MessageBox.Show("Valid Login");
                //else
                //    MessageBox.Show("InValid Login");

                //Style 2
                //string message = isValidToLogin ? "Valid Login" : "InValid Login";
                //MessageBox.Show(message);

                //Style 3
                MessageBox.Show(isValidToLogin ? "Valid Login" : "InValid Login");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public List<User> InitialData()
        {
            List<User> users = new List<User>();
            User user1 = new User()
            {
                Username = "parham",
                Password = "123"
            };
            users.Add(user1);

            User user2 = new User()
            {
                Username = "delaram",
                Password = "456"
            };
            users.Add(user2);
            User user3 = new User()
            {
                Username = "mohammdmahdi",
                Password = "789"
            };
            users.Add(user3);
            return users;
        }

        private void ResetLoginForm()
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }
    }
}
