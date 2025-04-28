using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BuyBooksOnline
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        // method to read the data from books table and returns the data
        private List<int> RetrieveBookIDsFromDatabase()
        {
            // list for storing books title
            List<int> bookIds = new List<int>();

            // Connection to database
            OleDbConnection connection = Database.Instance.GetConnection();

            try
            {
                
                connection.Open();

                string query = "SELECT BookId FROM Books";
                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ids = (int)reader["BookId"];
                    bookIds.Add(ids);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving book titles: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return bookIds;
        }
       
        // method refersh the form
        public void refresh1()
        {
            comboBoxBuyBook.Items.Clear();
            textBoxIDToRate.Clear();
            textBoxRating.Clear();
        }

        // button buy book event
        // this method checks the book title in combobox
        // after that the book is sold out
        private void buttonBuyBook_Click(object sender, EventArgs e)
        {
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
            repository.BrowseBooks();


            OleDbConnection connection = Database.Instance.GetConnection();

            try
            {

                int selectedBookID = (int)comboBoxBuyBook.SelectedItem;

                string query = "SELECT BookId FROM Books WHERE BookId = @BookID";
                connection.Open();

                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@BookID", selectedBookID);
                int selectedBookId = (int)command.ExecuteScalar();

                repository.BookSold(selectedBookId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }


            textBoxIDToRate.Clear();
            textBoxRating.Clear();
        }

        // button rate book event to rate the book
        private void buttonRateBook_Click(object sender, EventArgs e)
        {
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());

            repository.BrowseBooks();


            int bookIdToRate = 0;

            // getting book id
            try
            {
                bookIdToRate = int.Parse(textBoxIDToRate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
            }

            int rating = 0;

            // getting rating
            try
            {
                rating = int.Parse(textBoxRating.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Rating. Please enter a valid number.");
            }

            // validating id and rating
            if (rating > 0 && rating < 6)
            {
                LoginForm loginForm = new LoginForm();
                string username = "user";

                // rating the book
                repository.RateBook(bookIdToRate, rating, username);

                DataTable booksTable = repository.BrowseBooks();

                dataGridViewCustomer.ClearSelection();

                dataGridViewCustomer.DataSource = null;
                dataGridViewCustomer.DataSource = booksTable;
            }
            else
            {
                MessageBox.Show("Invalid Rating. Please enter a valid number.");
            }

            textBoxIDToRate.Clear();
            textBoxRating.Clear();
        }

        // browse books button event 
        // this button shows the list of books in data grif view
        private void buttonBrowseBooks_Click(object sender, EventArgs e)
        {
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
            DataTable booksTable = repository.BrowseBooks();

            dataGridViewCustomer.DataSource = booksTable;

            List<int> bookIds = RetrieveBookIDsFromDatabase();

            comboBoxBuyBook.Items.Clear();
            
            foreach (int ids in bookIds)
            {
                comboBoxBuyBook.Items.Add(ids);
            }
        }

        // refreshing the inventory
        private void buttonRefresh1_Click(object sender, EventArgs e)
        {
            refresh1();
            dataGridViewCustomer.ClearSelection();
            dataGridViewCustomer.DataSource = null;
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // closing all the forms to avoid the app to run in background 
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Close();

            RegisterForm registerForm = new RegisterForm();
            registerForm.Close();

            CustomerForm customerForm = new CustomerForm();
            customerForm.Close();

            AdminForm adminForm = new AdminForm();
            adminForm.Close();

            e.Cancel = false;
        }
    }
}
