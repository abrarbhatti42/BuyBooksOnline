using System;
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

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            RegisterForm form2 = new RegisterForm();
            form2.Show();
            this.Hide();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
        
            // Display The Customer/admin based on user type
            // 1. admin
            // 2. user/customer

            
            int password;
            bool userExists;

            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
            

            // user credentials
            try
            {
                username = textBoxUsername.Text;

                userExists = repository.UserExists(username);

                password = int.Parse(textBoxPassword.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Input Correct username and password");
                return;
            }

            if(userExists)
            {
                // user validation
                if (username == "admin" && password == 1234)
                {
                    AdminFrom form4 = new AdminFrom();
                    form4.Show();
                    this.Hide();

                    // Inititate Database and create table 
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
                else if (username == "user" && password == 1234)
                {
                    CustomerFrom form3 = new CustomerFrom();
                    form3.Show();
                    this.Hide();

                    // Inititate Database and create table 
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
                    CustomerFrom form3 = new CustomerFrom();
                    form3.Show();
                    this.Hide();

                    // Inititate Database and create table 
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
            }
        }

        private void buttonExit1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
