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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BuyBooksOnline
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        // method to read the data from books table and returns the data
        private List<int> RetrieveBookIDsFromDatabase()
        {
            // list for storing books ids
            List<int> bookIds = new List<int>();
            OleDbConnection connection = Database.Instance.GetConnection();

            try
            {

                connection.Open();

                // Query to get the book ids
                string query = "SELECT BookId FROM Books";
                OleDbCommand command = new OleDbCommand(query, connection);

                OleDbDataReader reader = command.ExecuteReader();

                // Read book ids from the database
                while (reader.Read())
                {
                    int ids = (int)reader["BookId"];
                    bookIds.Add(ids);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Getting book Ids: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return bookIds;
        }

        // method refersh the form
        public void refresh2()
        {
            textBoxForBookTitle.Clear();
            textBoxForAuthorName.Clear();
            textBoxPrice.Clear();
            textBoxForQuantity.Clear();
        }

        // add book button event to add the book in table 
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            // instance of bookrepository class
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());

            string title = "";
            string author = "";

            double price = 0;
            int quantity = 0;

            // getting book details
            try
            {
                title = textBoxForBookTitle.Text;
                if (title == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Title. Please enter a valid Title.");
            }

            // getting author detail
            try
            {
                author = textBoxForAuthorName.Text;
                if (author == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Author Name. Please enter a valid Name.");
            }

            // getting price 
            try
            {
                price = double.Parse(textBoxPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Price. Please enter a valid number.");
            }

            // getting quantity
            try
            {
                quantity = int.Parse(textBoxForQuantity.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Quantity. Please enter a valid number.");
            }

            // checking the book details
            if (title != "" && author != "" && price != 0 && quantity != 0)
            {
                // create new book based on details 
                Book newBook = new Book { Title = title, Author = author, Price = price, Quantity = quantity };

                // add book to the inventory
                repository.AddBook(newBook);

                DataTable booksTable = repository.ViewInventory();

                dataGridViewAdmin.ClearSelection();

                dataGridViewAdmin.DataSource = null;
                dataGridViewAdmin.DataSource = booksTable;
            }
            else
            {
                MessageBox.Show("Please Enter The Book Details\nTo Add to Inventory");
            }

            refresh2();
        }

        // remove button click event to remove book
        private void buttonRemoveBok_Click(object sender, EventArgs e)
        {
            try
            {
                BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
                int selectedBookTitle = (int)comboBoxRemoveBook.SelectedItem;

                repository.RemoveBook(selectedBookTitle);

                refresh2();
                DataTable booksTable = repository.ViewInventory();

                dataGridViewAdmin.ClearSelection();

                dataGridViewAdmin.DataSource = null;
                dataGridViewAdmin.DataSource = booksTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message + " " + ex.StackTrace);
            }

        }

        // view books button event 
        private void buttonViewBooks_Click(object sender, EventArgs e)
        {
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
            DataTable booksTable = repository.ViewInventory();

            dataGridViewAdmin.DataSource = booksTable;

            List<int> bookIds = RetrieveBookIDsFromDatabase();

            comboBoxRemoveBook.Items.Clear();

            foreach (int id in bookIds)
            {
                comboBoxRemoveBook.Items.Add(id);
            }
        }

        // refreshing the inventory
        private void buttonRefresh2_Click(object sender, EventArgs e)
        {
            dataGridViewAdmin.ClearSelection();
            dataGridViewAdmin.DataSource = null;

            dataGridViewUsersList.ClearSelection();
            dataGridViewUsersList.DataSource = null;
        }

        private void buttonExit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // event handler for the admin to see the list of users registered
        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
            DataTable usersTable = repository.ViewUsers();

            dataGridViewUsersList.DataSource = usersTable;
        }
    }
}
