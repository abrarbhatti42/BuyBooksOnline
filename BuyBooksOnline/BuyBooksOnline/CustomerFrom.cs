using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BuyBooksOnline
{
    public partial class CustomerFrom : Form
    {
        public CustomerFrom()
        {
            InitializeComponent();
        }

        public void refresh1()
        {
            textBoxBuyBookID.Clear();
            textBoxBuyBookTitle.Clear();
            textBoxIDToRate.Clear();
            textBoxRating.Clear();
        }

        // button buy book event
        private void buttonBuyBook_Click(object sender, EventArgs e)
        {
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
            repository.ViewInventory();

            int bookId = 0;

            // getting book id
            try
            {

                bookId = int.Parse(textBoxBuyBookID.Text);

                // selling the book
                repository.BookSold(bookId);

                DataTable booksTable = repository.BrowseBooks();

                dataGridView2.ClearSelection();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = booksTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
            }

            refresh1();
        }

        // button rate book event
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
                string username = "admin";
                // rating the book
                repository.RateBook(bookIdToRate, rating, username);

                DataTable booksTable = repository.BrowseBooks();

                dataGridView2.ClearSelection();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = booksTable;
            }
            else
            {
                MessageBox.Show("Invalid Rating. Please enter a valid number.");
            }

            refresh1();
        }

        // view books button event 
        private void buttonBrowseBooks_Click(object sender, EventArgs e)
        {
            BookRepository repository = new ConcreteBookRepository(Database.Instance.GetConnection());
            DataTable booksTable = repository.BrowseBooks();

            dataGridView2.DataSource = booksTable;
        }

        // refreshing the inventory
        private void buttonRefresh1_Click(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            dataGridView2.DataSource = null;
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
