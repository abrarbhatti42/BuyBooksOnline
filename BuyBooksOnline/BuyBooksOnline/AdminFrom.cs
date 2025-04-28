using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyBooksOnline
{
    public partial class AdminFrom : Form
    {
        public AdminFrom()
        {
            InitializeComponent();
        }

        public void refresh2()
        {
            textBoxForBookTitle.Clear();
            textBoxForAuthorName.Clear();
            textBoxPrice.Clear();
            textBoxForQuantity.Clear();
            textBoxEnterBookName.Clear();
            textBoxEnterBookID.Clear();
        }

        // add book button event to add the book in table 
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            // instance of bookrepository class
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());

            string title = "";
            string author = "";

            decimal price = 0;
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

            try
            {
                price = decimal.Parse(textBoxPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Price. Please enter a valid number.");
            }

            try
            {
                quantity = int.Parse(textBoxForQuantity.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Quantity. Please enter a valid number.");
            }

            // validating the book details
            if (title != "" && author != "" && price != 0 && quantity != 0)
            {
                // create new book based on details 
                Book newBook = new Book { Title = title, Author = author, Price = price, Quantity = quantity };

                // add book to the inventory
                repository.AddBook(newBook);

                DataTable booksTable = repository.ViewInventory();

                dataGridView1.ClearSelection();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = booksTable;
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
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());

            int bookId = 0;

            // getting book id
            try
            {
                bookId = int.Parse(textBoxEnterBookID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Book ID. Please enter a valid number.");
            }

            // validating book id
            if (bookId != 0)
            {
                // removing book
                repository.RemoveBook(bookId);

                refresh2();
                DataTable booksTable = repository.ViewInventory();

                dataGridView1.ClearSelection();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = booksTable;
            }
            else
            {
                MessageBox.Show("Book ID Can Not be Null or Zero. Please enter a valid number.");
            }


        }

        // view books button event 
        private void buttonViewBooks_Click(object sender, EventArgs e)
        {
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());

            DataTable booksTable = repository.ViewInventory();

            dataGridView1.DataSource = booksTable;
        }

        // refreshing the inventory
        private void buttonRefresh2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = null;
        }

        private void buttonExit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
