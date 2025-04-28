using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BuyBooksOnline
{
    public partial class LoginForm : Form
    {

        static string username;

        public LoginForm()
        {
            InitializeComponent();
        }

        // event handler to show the registration form
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Hide();
            adminForm.Close();

            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        // event handler to show the form based on user type logs in
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = Database.Instance;
                database.CreateTablesIfNotExist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  : " + ex.Message +" " +ex.StackTrace);
            }

            // Get the user's input for email and password
            string username = textBoxUsername.Text;
            int password = int.Parse(textBoxPassword.Text);

            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());

            bool userFound = repository.LoginCheck(username, password);

            if(userFound == true)
            {
                if (username == "admin@gmail.com" && password == 1234)
                {


                    AdminForm adminFrom = new AdminForm();
                    adminFrom.Show();

                    LoginForm loginForm = new LoginForm();
                    loginForm.Hide();
                    loginForm.Close();


                    // getting database instane
                    // and chcing for tables if they exist
                    try
                    {
                        Database database = Database.Instance;
                        database.CreateTablesIfNotExist();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
                else
                {
                    CustomerForm customerForm = new CustomerForm();
                    customerForm.Show();

                    LoginForm loginForm = new LoginForm();
                    loginForm.Hide();
                    loginForm.Close();

                    // getting database instane
                    // and chcing for tables if they exist
                    try
                    {
                        Database database = Database.Instance;
                        database.CreateTablesIfNotExist();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Input Correct username and password");
                return;
            }

            // finally clearing the textboxes
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }

        private void buttonExit1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
