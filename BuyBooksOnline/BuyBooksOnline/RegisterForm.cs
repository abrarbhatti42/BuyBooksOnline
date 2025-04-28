using System;
using System.Windows.Forms;

namespace BuyBooksOnline
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // event handler for regsitering the new user
        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            string name,email,address;
            int password = 0;

            try
            {

                name = textBoxRegisterUsername.Text;

                email = textBoxRegsiterEmail.Text;

                address = textBoxRegisterAddress.Text;

                password = int.Parse(textBoxRegisterPassword.Text);

                try
                {
                    BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
                    User user;
                   if (name != "" && email != "" && address != "" && password != 0)
                    {
                        // BookRepository instance
                        user = new User { Name = name, Email = email, Address = address, Password = password };
                        // registering the user
                        repository.registerUser(user);
                    }
                    else
                    {
                        MessageBox.Show("Enter All the Details");
                    }
                   
                    //MessageBox.Show("Registration Successful...");

                }
                catch (Exception)
                {
                    MessageBox.Show("Errro : Can't Register...");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Enter Correct Details To Register\nPassword must be numeric value...");
            }

            // refreshing the textboxes
            textBoxRegisterUsername.Clear();
            textBoxRegsiterEmail.Clear();
            textBoxRegisterPassword.Clear();
            textBoxRegisterAddress.Clear();


        }
    }
}
