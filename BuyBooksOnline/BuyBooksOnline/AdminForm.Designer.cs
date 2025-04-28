namespace BuyBooksOnline
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonRefresh2 = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.buttonRemoveBok = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.textBoxForBookTitle = new System.Windows.Forms.TextBox();
            this.labelFroTitle = new System.Windows.Forms.Label();
            this.buttonExit3 = new System.Windows.Forms.Button();
            this.textBoxForQuantity = new System.Windows.Forms.TextBox();
            this.labelForQuantity = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelForPrice = new System.Windows.Forms.Label();
            this.textBoxForAuthorName = new System.Windows.Forms.TextBox();
            this.labelforAuthorName = new System.Windows.Forms.Label();
            this.buttonViewBooks = new System.Windows.Forms.Button();
            this.comboBoxRemoveBook = new System.Windows.Forms.ComboBox();
            this.labelRemoveBook = new System.Windows.Forms.Label();
            this.dataGridViewUsersList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonViewUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh2
            // 
            this.buttonRefresh2.Location = new System.Drawing.Point(430, 411);
            this.buttonRefresh2.Name = "buttonRefresh2";
            this.buttonRefresh2.Size = new System.Drawing.Size(95, 20);
            this.buttonRefresh2.TabIndex = 78;
            this.buttonRefresh2.Text = "Refresh";
            this.buttonRefresh2.UseVisualStyleBackColor = true;
            this.buttonRefresh2.Click += new System.EventHandler(this.buttonRefresh2_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(47, 59);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(333, 150);
            this.dataGridViewAdmin.TabIndex = 77;
            // 
            // buttonRemoveBok
            // 
            this.buttonRemoveBok.Location = new System.Drawing.Point(584, 350);
            this.buttonRemoveBok.Name = "buttonRemoveBok";
            this.buttonRemoveBok.Size = new System.Drawing.Size(94, 20);
            this.buttonRemoveBok.TabIndex = 76;
            this.buttonRemoveBok.Text = "Remove Book";
            this.buttonRemoveBok.UseVisualStyleBackColor = true;
            this.buttonRemoveBok.Click += new System.EventHandler(this.buttonRemoveBok_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(584, 261);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(94, 20);
            this.buttonAddBook.TabIndex = 75;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // textBoxForBookTitle
            // 
            this.textBoxForBookTitle.Location = new System.Drawing.Point(115, 261);
            this.textBoxForBookTitle.Name = "textBoxForBookTitle";
            this.textBoxForBookTitle.Size = new System.Drawing.Size(98, 20);
            this.textBoxForBookTitle.TabIndex = 74;
            // 
            // labelFroTitle
            // 
            this.labelFroTitle.AutoSize = true;
            this.labelFroTitle.ForeColor = System.Drawing.Color.White;
            this.labelFroTitle.Location = new System.Drawing.Point(114, 231);
            this.labelFroTitle.Name = "labelFroTitle";
            this.labelFroTitle.Size = new System.Drawing.Size(82, 13);
            this.labelFroTitle.TabIndex = 73;
            this.labelFroTitle.Text = "Enter Book title:";
            // 
            // buttonExit3
            // 
            this.buttonExit3.Location = new System.Drawing.Point(584, 411);
            this.buttonExit3.Name = "buttonExit3";
            this.buttonExit3.Size = new System.Drawing.Size(94, 20);
            this.buttonExit3.TabIndex = 72;
            this.buttonExit3.Text = "Exit";
            this.buttonExit3.UseVisualStyleBackColor = true;
            this.buttonExit3.Click += new System.EventHandler(this.buttonExit3_Click);
            // 
            // textBoxForQuantity
            // 
            this.textBoxForQuantity.Location = new System.Drawing.Point(480, 261);
            this.textBoxForQuantity.Name = "textBoxForQuantity";
            this.textBoxForQuantity.Size = new System.Drawing.Size(86, 20);
            this.textBoxForQuantity.TabIndex = 67;
            // 
            // labelForQuantity
            // 
            this.labelForQuantity.AutoSize = true;
            this.labelForQuantity.ForeColor = System.Drawing.Color.White;
            this.labelForQuantity.Location = new System.Drawing.Point(477, 230);
            this.labelForQuantity.Name = "labelForQuantity";
            this.labelForQuantity.Size = new System.Drawing.Size(77, 13);
            this.labelForQuantity.TabIndex = 66;
            this.labelForQuantity.Text = "Enter Quantity:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(374, 261);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(87, 20);
            this.textBoxPrice.TabIndex = 65;
            // 
            // labelForPrice
            // 
            this.labelForPrice.AutoSize = true;
            this.labelForPrice.ForeColor = System.Drawing.Color.White;
            this.labelForPrice.Location = new System.Drawing.Point(371, 230);
            this.labelForPrice.Name = "labelForPrice";
            this.labelForPrice.Size = new System.Drawing.Size(90, 13);
            this.labelForPrice.TabIndex = 64;
            this.labelForPrice.Text = "Enter Book Price:";
            // 
            // textBoxForAuthorName
            // 
            this.textBoxForAuthorName.Location = new System.Drawing.Point(245, 261);
            this.textBoxForAuthorName.Name = "textBoxForAuthorName";
            this.textBoxForAuthorName.Size = new System.Drawing.Size(97, 20);
            this.textBoxForAuthorName.TabIndex = 63;
            // 
            // labelforAuthorName
            // 
            this.labelforAuthorName.AutoSize = true;
            this.labelforAuthorName.ForeColor = System.Drawing.Color.White;
            this.labelforAuthorName.Location = new System.Drawing.Point(242, 230);
            this.labelforAuthorName.Name = "labelforAuthorName";
            this.labelforAuthorName.Size = new System.Drawing.Size(100, 13);
            this.labelforAuthorName.TabIndex = 62;
            this.labelforAuthorName.Text = "Enetr Author Name:";
            // 
            // buttonViewBooks
            // 
            this.buttonViewBooks.Location = new System.Drawing.Point(115, 411);
            this.buttonViewBooks.Name = "buttonViewBooks";
            this.buttonViewBooks.Size = new System.Drawing.Size(94, 20);
            this.buttonViewBooks.TabIndex = 61;
            this.buttonViewBooks.Text = "View Inventory";
            this.buttonViewBooks.UseVisualStyleBackColor = true;
            this.buttonViewBooks.Click += new System.EventHandler(this.buttonViewBooks_Click);
            // 
            // comboBoxRemoveBook
            // 
            this.comboBoxRemoveBook.FormattingEnabled = true;
            this.comboBoxRemoveBook.Location = new System.Drawing.Point(115, 349);
            this.comboBoxRemoveBook.Name = "comboBoxRemoveBook";
            this.comboBoxRemoveBook.Size = new System.Drawing.Size(410, 21);
            this.comboBoxRemoveBook.TabIndex = 80;
            // 
            // labelRemoveBook
            // 
            this.labelRemoveBook.AutoSize = true;
            this.labelRemoveBook.ForeColor = System.Drawing.Color.White;
            this.labelRemoveBook.Location = new System.Drawing.Point(112, 320);
            this.labelRemoveBook.Name = "labelRemoveBook";
            this.labelRemoveBook.Size = new System.Drawing.Size(419, 13);
            this.labelRemoveBook.TabIndex = 79;
            this.labelRemoveBook.Text = "1st View Inventory and then Select  Book ID From ComBox to Remove From Inventory " +
    ":";
            // 
            // dataGridViewUsersList
            // 
            this.dataGridViewUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersList.Location = new System.Drawing.Point(404, 59);
            this.dataGridViewUsersList.Name = "dataGridViewUsersList";
            this.dataGridViewUsersList.Size = new System.Drawing.Size(333, 150);
            this.dataGridViewUsersList.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Books In The Inventory :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(511, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Registered Users :";
            // 
            // buttonViewUsers
            // 
            this.buttonViewUsers.Location = new System.Drawing.Point(271, 411);
            this.buttonViewUsers.Name = "buttonViewUsers";
            this.buttonViewUsers.Size = new System.Drawing.Size(94, 20);
            this.buttonViewUsers.TabIndex = 84;
            this.buttonViewUsers.Text = "View Users";
            this.buttonViewUsers.UseVisualStyleBackColor = true;
            this.buttonViewUsers.Click += new System.EventHandler(this.buttonViewUsers_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.buttonViewUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewUsersList);
            this.Controls.Add(this.comboBoxRemoveBook);
            this.Controls.Add(this.labelRemoveBook);
            this.Controls.Add(this.buttonRefresh2);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.buttonRemoveBok);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBoxForBookTitle);
            this.Controls.Add(this.labelFroTitle);
            this.Controls.Add(this.buttonExit3);
            this.Controls.Add(this.textBoxForQuantity);
            this.Controls.Add(this.labelForQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelForPrice);
            this.Controls.Add(this.textBoxForAuthorName);
            this.Controls.Add(this.labelforAuthorName);
            this.Controls.Add(this.buttonViewBooks);
            this.Name = "AdminForm";
            this.Text = "Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonRefresh2;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button buttonRemoveBok;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.TextBox textBoxForBookTitle;
        private System.Windows.Forms.Label labelFroTitle;
        private System.Windows.Forms.Button buttonExit3;
        private System.Windows.Forms.TextBox textBoxForQuantity;
        private System.Windows.Forms.Label labelForQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelForPrice;
        private System.Windows.Forms.TextBox textBoxForAuthorName;
        private System.Windows.Forms.Label labelforAuthorName;
        private System.Windows.Forms.Button buttonViewBooks;
        private System.Windows.Forms.ComboBox comboBoxRemoveBook;
        private System.Windows.Forms.Label labelRemoveBook;
        private System.Windows.Forms.DataGridView dataGridViewUsersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonViewUsers;
    }
}
