using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace BuyBooksOnline
{

    /* 
      
      Defualt password for all the users is numeric and 1234 fixed

      ADMIN  

      username : admin@gmail.com
      password ; 1234

      CUSTOMER/USER

      username : user@gmail.com
      password ; 1234
    
   */


    // Creational Design Pattern for database : Singleton
    /* Database class which implements 
       singleton pattern that insures,
       class has only one instance
       and gives global access to that instance */
    public class Database
    {
        // connection string for OleDbdatabase
        private static readonly string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=myDB.accdb;";

        // initializing database instance
        private static Database instance;


        // implementation of singleton pattern below
        private Database() { }

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        // returning instance of database
        public OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }

        // creatted tables with the help of these queries
        // this Function checks for if specified table does not exist
        // if it does  already exists then it does not create it again
        public void CreateTablesIfNotExist()
        {
            try
            {
                using (OleDbConnection connection = GetOleDbConnection())
                {
                    connection.Open();

                    // for Authors table existense
                    if (!TableExists(connection, "Authors"))
                    {
                        string createAuthorsTableQuery = @"
                                                        CREATE TABLE Authors (
                                                            AuthorId AUTOINCREMENT PRIMARY KEY,
                                                            Name NVARCHAR(100) NOT NULL
                                                        );";
                        OleDbCommand createAuthorsTableCommand = new OleDbCommand(createAuthorsTableQuery, connection);
                        createAuthorsTableCommand.ExecuteNonQuery();
                    }

                    // for Users table existence
                    if (!TableExists(connection, "Users"))
                    {
                        string createUsersTableQuery = @"
                                                        CREATE TABLE Users (
                                                            UserId COUNTER PRIMARY KEY,
                                                            Name NVARCHAR(100) NOT NULL,
                                                            Email NVARCHAR(255) NOT NULL,
                                                            Address NVARCHAR(255) NOT NULL,
                                                            [Password] INT NOT NULL
                                                        );";
                        OleDbCommand createUsersTableCommand = new OleDbCommand(createUsersTableQuery, connection);
                        createUsersTableCommand.ExecuteNonQuery();
                    }



                    // for Books table exististense
                    if (!TableExists(connection, "Books"))
                    {
                        string createBooksTableQuery = @"
                                                        CREATE TABLE Books (
                                                            BookId AUTOINCREMENT PRIMARY KEY,
                                                            Title NVARCHAR(100) NOT NULL,
                                                            Author NVARCHAR(100) NOT NULL,
                                                            AuthorId INT NOT NULL,
                                                            Price DECIMAL(10, 2) NOT NULL,
                                                            Quantity INT NOT NULL,
                                                            AverageRating DECIMAL(5, 2),
                                                            CONSTRAINT FK_Author FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId)
                                                        );";
                        OleDbCommand createBooksTableCommand = new OleDbCommand(createBooksTableQuery, connection);
                        createBooksTableCommand.ExecuteNonQuery();
                    }

                    // for Ratings table exististense
                    if (!TableExists(connection, "Ratings"))
                    {
                        string createRatingsTableQuery = @"
                                                        CREATE TABLE Ratings (
                                                            RatingId AUTOINCREMENT PRIMARY KEY,
                                                            BookId INT NOT NULL,
                                                            UserId INT NOT NULL,
                                                            Rating FLOAT NOT NULL,
                                                            CONSTRAINT FK_Book_Rating FOREIGN KEY (BookId) REFERENCES Books(BookId),
                                                            CONSTRAINT FK_User_Rating FOREIGN KEY (UserId) REFERENCES Users(UserId)
                                                        );";
                        OleDbCommand createRatingsTableCommand = new OleDbCommand(createRatingsTableQuery, connection);
                        createRatingsTableCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating tables: " + ex.Message +" " + ex.StackTrace);
            }
        }

        // function to check if table exist or not
        private bool TableExists(OleDbConnection connection, string tableName)
        {
            DataTable schema = connection.GetSchema("Tables");
            foreach (DataRow row in schema.Rows)
            {
                if (row["TABLE_NAME"].ToString() == tableName)
                {
                    return true;
                }
            }
            return false;
        }

        // Getting connection of oledbConnection
        private OleDbConnection GetOleDbConnection()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=myDB.accdb;";
            return new OleDbConnection(connectionString);
        }

    }

    // Book class
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }

    // User Class
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Password { get; set; }
        public bool IsAdmin { get; set; }
    }

    // BookRepository class with Decorator pattern
    // structural pattern
    /* in this class Decorator structural pattern is applied
       which insures the working of objects individually 
       without affecting other object's behavior */
    public abstract class BookRepository
    {
        protected OleDbConnection connection;

        public BookRepository(OleDbConnection connection)
        {
            this.connection = connection;
        }

        // defining components
        public abstract void AddBook(Book book);
        public abstract void BookSold(int bookid);
        public abstract void RemoveBook(int bookId);
        public abstract DataTable ViewInventory();
        public abstract DataTable BrowseBooks();
        public abstract DataTable ViewUsers();
        public abstract void RateBook(int bookId, int rating, string username);
        public abstract void registerUser(User user);
        public abstract bool LoginCheck(string email, int password);
        public abstract bool UserExists(string username);
    }

    // concrete class to imlement the behavior of components
    public class ConcreteBookRepository : BookRepository
    {
        public ConcreteBookRepository(OleDbConnection connection) : base(connection) { }

        // method to register the new user
        public override void registerUser(User user)
        {
            try
            {
                connection.Open();
                string insertUserQuery = "INSERT INTO Users (Name,Email,Address,[Password]) VALUES (@Name,@Email,@Address,@Password);";
                OleDbCommand insertUserCommand = new OleDbCommand(insertUserQuery, connection);
                insertUserCommand.Parameters.AddWithValue("@Name", user.Name);
                insertUserCommand.Parameters.AddWithValue("@Email", user.Email);
                insertUserCommand.Parameters.AddWithValue("@Address", user.Address);
                insertUserCommand.Parameters.AddWithValue("@Password", user.Password);
                int rowsAffected = insertUserCommand.ExecuteNonQuery(); ;

                if (rowsAffected > 0)
                {
                    MessageBox.Show("\nRegistration Successful...");
                }
                else
                {
                    MessageBox.Show("Registration Failed...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Registration: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // loginCheck Mthod to check the user 
        public override bool LoginCheck(string email, int password)
        {
            try
            {
                // Query the database to check if there is a user with the provided email and password
                Database database = Database.Instance;
                OleDbConnection connection = database.GetConnection();
                connection.Open();
                string query = "SELECT Email, Password FROM Users WHERE Email = @Email AND Password = @Password";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                OleDbDataReader reader = command.ExecuteReader();

                // If a user with matching credentials is found
                if (reader.Read())
                {
                    email = reader.GetString(0);
                    password = reader.GetInt32(1);

                    // MessageBox.Show(">>."+email +">>."+password);

                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.");
                }

                // Close the database connection and release resources
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return false;
        }

        // Method in the Database class to check if a user exists
        public override bool UserExists(string username)
        {
            bool userExists = false;
            try
            {

                connection.Open();

                string UserExistQuery = "SELECT COUNT(*) FROM Users WHERE Name = @Name";

                OleDbCommand UserExistCommand = new OleDbCommand(UserExistQuery, connection);

                UserExistCommand.Parameters.AddWithValue("@Name", username);

                int count = (int)UserExistCommand.ExecuteScalar();

                // Check if the count is greater than 0
                userExists = (count > 0);

                //return userExists;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Finding User " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return userExists;
        }

        // method to add the book to inventory
        // it checks if the book already exists
        // id exists then updates quantity
        // otherwise inserts the book
        public override void AddBook(Book book)
        {
            try
            {
                connection.Open();

                // Checking if the book already exists in the Books table
                string checkBookQuery = "SELECT BookId, Quantity FROM Books WHERE Title = @Title AND Author = @Author";
                OleDbCommand checkBookCommand = new OleDbCommand(checkBookQuery, connection);
                checkBookCommand.Parameters.AddWithValue("@Title", book.Title);
                checkBookCommand.Parameters.AddWithValue("@Author", book.Author);
                OleDbDataReader reader = checkBookCommand.ExecuteReader();

                // Checking if the author already  exists in the Authors table
                string authorIdQuery = "SELECT AuthorId FROM Authors WHERE Name = @Author";
                OleDbCommand authorIdCommand = new OleDbCommand(authorIdQuery, connection);
                authorIdCommand.Parameters.AddWithValue("@Author", book.Author);
                object authorIdResult = authorIdCommand.ExecuteScalar();
                int authorId;

                if (authorIdResult != null)
                {
                    // if Author exists get the AuthorId
                    authorId = Convert.ToInt32(authorIdResult);
                }
                else
                {
                    // if author does not exist then insert new author
                    string insertAuthorQuery = "INSERT INTO Authors (Name) VALUES (@Author)";
                    OleDbCommand insertAuthorCommand = new OleDbCommand(insertAuthorQuery, connection);
                    insertAuthorCommand.Parameters.AddWithValue("@Author", book.Author);
                    insertAuthorCommand.ExecuteNonQuery();

                    // After inserting the author get the generated AuthorId
                    string getAuthorIdQuery = "SELECT @@IDENTITY";
                    OleDbCommand getAuthorIdCommand = new OleDbCommand(getAuthorIdQuery, connection);
                    authorId = Convert.ToInt32(getAuthorIdCommand.ExecuteScalar());
                }



                if (reader.Read())
                {
                    // if Book already exists then update the quantity
                    int existingBookId = reader.GetInt32(0);
                    int existingQuantity = reader.GetInt32(1);
                    int newQuantity = existingQuantity + book.Quantity;

                    double newPrice = book.Price;

                    string updateQuantityAndPriceQuery = "UPDATE Books SET Quantity = @Quantity, Price = @Price WHERE BookId = @BookId";
                    OleDbCommand updateQuantityAndPriceCommand = new OleDbCommand(updateQuantityAndPriceQuery, connection);
                    updateQuantityAndPriceCommand.Parameters.AddWithValue("@Quantity", newQuantity);
                    updateQuantityAndPriceCommand.Parameters.AddWithValue("@Price", newPrice);
                    updateQuantityAndPriceCommand.Parameters.AddWithValue("@BookId", existingBookId);
                    int rowsAffected = updateQuantityAndPriceCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Book.");
                    }
                }
                else
                {
                    // if book does not exist then insert the book into the Books table with the AuthorId
                    string insertBookQuery = "INSERT INTO Books (Title, AuthorId, Author, Price, Quantity) VALUES (@Title, @AuthorId, @Author, @Price, @Quantity)";
                    OleDbCommand insertBookCommand = new OleDbCommand(insertBookQuery, connection);
                    insertBookCommand.Parameters.AddWithValue("@Title", book.Title);
                    insertBookCommand.Parameters.AddWithValue("@AuthorId", authorId);
                    insertBookCommand.Parameters.AddWithValue("@Author", book.Author);
                    insertBookCommand.Parameters.AddWithValue("@Price", book.Price);
                    insertBookCommand.Parameters.AddWithValue("@Quantity", book.Quantity);
                    int rowsAffected = insertBookCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book added to Inventory Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add book to Inventory.");
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message +" " +ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }



        // if user buys a book then the book is decremented by 1
        // method for selling the book to the user
        // this methods dislpalys book list 
        // sales the book and decrements
        // it also prompts the user to rate the book from (1 - 5)
        public override void BookSold(int bookId)
        {
            try
            {
                connection.Open();

                // Checking if book exists in inventory or not
                string checkQuantityQuery = "SELECT Quantity FROM Books WHERE BookId = @BookId";
                OleDbCommand checkQuantityCommand = new OleDbCommand(checkQuantityQuery, connection);
                checkQuantityCommand.Parameters.AddWithValue("@BookId", bookId);
                int quantity = Convert.ToInt32(checkQuantityCommand.ExecuteScalar());

                if (quantity > 0)
                {
                    if (quantity == 1)
                    {
                        // If the quantity is 1, set it to 0
                        string updateQuery = "UPDATE Books SET Quantity = 0 WHERE BookId = @BookId";
                        OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@BookId", bookId);
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thanks for buying the last copy of the book. Your book will be delivered to your address shortly.");
                        }
                        else
                        {
                            MessageBox.Show("Book with the entered ID not found.");
                        }
                    }
                    else if (quantity > 1)
                    {
                        // Updating books after selling and decrementing book
                        string updateQuery = "UPDATE Books SET Quantity = Quantity - 1 WHERE BookId = @BookId";
                        OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@BookId", bookId);
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thanks for buying the book.\nYour book will be delivered to your address shortly.");
                        }
                        else
                        {
                            MessageBox.Show("Can not buy the book right now.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Can not buy this book right now Out of Stock..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Displaying the actual error message
                MessageBox.Show("Can not buy this book right now.");
            }
            finally
            {
                // Ensure that the database connection is always closed
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }





        // method for only admin access to remove
        // any specific book from the list 
        // is its not available sold physically
        public override void RemoveBook(int bookId)
        {
            try
            {
                connection.Open();

                // Checking for book if the book exists in the table
                string checkBookQuery = "SELECT COUNT(*) FROM Books WHERE BookId = @BookID";
                OleDbCommand checkBookCommand = new OleDbCommand(checkBookQuery, connection);
                checkBookCommand.Parameters.AddWithValue("@BookID", bookId);
                int bookCount = Convert.ToInt32(checkBookCommand.ExecuteScalar());

                // If book exists, delete the book
                if (bookCount > 0)
                {
                    // Delete ratings of the book from the Ratings table
                    string deleteRatingsQuery = "DELETE FROM Ratings WHERE BookId IN (SELECT BookId FROM Books WHERE BookId = @BookID)";
                    OleDbCommand deleteRatingsCommand = new OleDbCommand(deleteRatingsQuery, connection);
                    deleteRatingsCommand.Parameters.AddWithValue("@BokID", bookId);
                    deleteRatingsCommand.ExecuteNonQuery();

                    // Delete the book from the Books table
                    string deleteBookQuery = "DELETE FROM Books WHERE BookId = @BookId";
                    OleDbCommand deleteBookCommand = new OleDbCommand(deleteBookQuery, connection);
                    deleteBookCommand.Parameters.AddWithValue("@BookID", bookId);
                    int rowsAffected = deleteBookCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book removed from the inventory.");
                    }
                    else
                    {
                        MessageBox.Show("Book with the entered Id not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Book with the entered Id not found.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while removing book from inventory.");
            }
            finally
            {
                connection.Close();
            }
        }



        // Method to view inventory and all available books
        // it displays the book list with quantity and all
        // other elated information
        public override DataTable ViewInventory()
        {
            DataTable booksTable = new DataTable();
            try
            {
                connection.Open();

                string query = @"
                                SELECT b.BookId, b.Title, b.Author, b.Price, b.Quantity, 
                                IIF(ISNULL(AVG(r.Rating)), 0, AVG(r.Rating)) AS AverageRating
                                FROM Books AS b
                                LEFT JOIN Ratings AS r ON b.BookId = r.BookId
                                GROUP BY b.BookId, b.Title, b.Author, b.Price, b.Quantity";

                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.Fill(booksTable);

                if (booksTable.Rows.Count > 0)
                {
                    //  MessageBox.Show("books found in the inventory.");
                }
                else
                {
                    MessageBox.Show("No books found in the inventory.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error browsing books.");
            }
            finally
            {
                connection.Close();
            }

            return booksTable;
        }


        // Method to view inventory and all available books
        // it displays the book list with quantity and all
        // other elated information
        public override DataTable BrowseBooks()
        {
            DataTable booksTable = new DataTable();
            try
            {
                connection.Open();

                string query = @"
                                 SELECT b.BookId, b.Title, b.Author, b.Price, 
                                 IIF(ISNULL(AVG(r.Rating)), 0, AVG(r.Rating)) AS AverageRating
                                 FROM Books AS b
                                 LEFT JOIN Ratings AS r ON b.BookId = r.BookId
                                 GROUP BY b.BookId, b.Title, b.Author, b.Price";

                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.Fill(booksTable);

                if (booksTable.Rows.Count > 0)
                {
                    //  MessageBox.Show("books found in the inventory.");
                }
                else
                {
                    MessageBox.Show("No books found in the inventory.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error browsing books.");
            }
            finally
            {
                connection.Close();
            }

            return booksTable;
        }


        // Method to view all the registered
        // it displays the users list registered
        // and other user related information
        public override DataTable ViewUsers()
        {
            DataTable booksTable = new DataTable();
            try
            {
                connection.Open();

                string query = @"
                                SELECT u.UserId, u.Name, u.Email, u.Address, u.Password
                                FROM Users AS u
                                GROUP BY u.UserId, u.Name, u.Email, u.Address, u.Password";

                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.Fill(booksTable);

                if (booksTable.Rows.Count > 0)
                {
                    //  MessageBox.Show("books found in the inventory.");
                }
                else
                {
                    MessageBox.Show("No books found in the inventory.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error browsing books.");
            }
            finally
            {
                connection.Close();
            }

            return booksTable;
        }

        // method for users to rate the book when they buy the book 
        // or anytim after that if they like the book
        public override void RateBook(int bookId, int rating, string username)
        {
            try
            {
                connection.Open();

                // Checking for if the user exists in the table
                string checkUserQuery = "SELECT UserId FROM Users WHERE Name = @Name";
                OleDbCommand checkUserCommand = new OleDbCommand(checkUserQuery, connection);
                checkUserCommand.Parameters.AddWithValue("@Name", username);

                // get UserId based on the user's name
                object userId = checkUserCommand.ExecuteScalar();

                // If the user does not exist in table
                if (userId == null)
                {
                    string insertUserQuery = "INSERT INTO Users (Name) VALUES (@Name); SELECT @@IDENTITY";
                    OleDbCommand insertUserCommand = new OleDbCommand(insertUserQuery, connection);
                    insertUserCommand.Parameters.AddWithValue("@Name", userId);

                    userId = insertUserCommand.ExecuteScalar();
                }

                // Insert rating in table
                string insertRatingQuery = "INSERT INTO Ratings (BookId, UserId, Rating) VALUES (@BookId, @UserId, @Rating)";
                OleDbCommand insertRatingCommand = new OleDbCommand(insertRatingQuery, connection);
                insertRatingCommand.Parameters.AddWithValue("@BookId", bookId);
                insertRatingCommand.Parameters.AddWithValue("@UserId", userId);
                insertRatingCommand.Parameters.AddWithValue("@Rating", rating);

                int rowsAffected = insertRatingCommand.ExecuteNonQuery();

                MessageBox.Show("Thanks for Rating The Book..");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }

    }

    // Behavioral Design Patterm
    // Command Design Pattern
    // it insures that commands / requestes
    // are converted into objects

    // command interface
    public interface ICommand
    {
        void Execute();
    }

    public class AddBookCommand : ICommand
    {
        private BookRepository repository;
        private Book book;

        public AddBookCommand(BookRepository repository, Book book)
        {
            this.repository = repository;
            this.book = book;
        }

        // executing the command
        public void Execute()
        {
            repository.AddBook(book);
        }
    }
}
