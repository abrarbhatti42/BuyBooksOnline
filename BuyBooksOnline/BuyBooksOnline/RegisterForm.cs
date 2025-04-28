using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyBooksOnline
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            string username;
            int password;

            try
            {
                username = textBoxRegisterUsername.Text;
                password = int.Parse(textBoxRegisterPassword.Text);

                try
                {

                    BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
                    User user = new User { Name = username };

                    repository.registerUser(user,password);

                    MessageBox.Show("Registration Successful...");

                }
                catch (Exception)
                {
                    MessageBox.Show("Can't Register...");
                }

               

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Correct Usename and password To Register...");
            }

        }
    }
}
