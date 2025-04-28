using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyBooksOnline
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            LoginForm loginForm = new LoginForm();
            loginForm.Close();

            RegisterForm registerForm = new RegisterForm();
            registerForm.Close();

            CustomerForm customerForm = new CustomerForm();
            customerForm.Close();

            AdminForm adminForm = new AdminForm();
            adminForm.Close();
        }
    }
}
