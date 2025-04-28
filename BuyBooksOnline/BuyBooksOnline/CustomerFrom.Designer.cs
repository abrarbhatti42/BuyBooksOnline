namespace BuyBooksOnline
{
    partial class CustomerFrom
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
            this.buttonRefresh1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelForrating = new System.Windows.Forms.Label();
            this.textBoxIDToRate = new System.Windows.Forms.TextBox();
            this.labelIdToRate = new System.Windows.Forms.Label();
            this.textBoxBuyBookID = new System.Windows.Forms.TextBox();
            this.labelBookID = new System.Windows.Forms.Label();
            this.buttonBrowseBooks = new System.Windows.Forms.Button();
            this.buttonRateBook = new System.Windows.Forms.Button();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.buttonBuyBook = new System.Windows.Forms.Button();
            this.textBoxBuyBookTitle = new System.Windows.Forms.TextBox();
            this.labelBookTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh1
            // 
            this.buttonRefresh1.Location = new System.Drawing.Point(352, 377);
            this.buttonRefresh1.Name = "buttonRefresh1";
            this.buttonRefresh1.Size = new System.Drawing.Size(95, 20);
            this.buttonRefresh1.TabIndex = 73;
            this.buttonRefresh1.Text = "Refresh";
            this.buttonRefresh1.UseVisualStyleBackColor = true;
            this.buttonRefresh1.Click += new System.EventHandler(this.buttonRefresh1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(130, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 150);
            this.dataGridView2.TabIndex = 72;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(371, 316);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(172, 20);
            this.textBoxRating.TabIndex = 71;
            // 
            // labelForrating
            // 
            this.labelForrating.AutoSize = true;
            this.labelForrating.ForeColor = System.Drawing.Color.White;
            this.labelForrating.Location = new System.Drawing.Point(368, 276);
            this.labelForrating.Name = "labelForrating";
            this.labelForrating.Size = new System.Drawing.Size(94, 13);
            this.labelForrating.TabIndex = 70;
            this.labelForrating.Text = "Enter Your Rating:";
            // 
            // textBoxIDToRate
            // 
            this.textBoxIDToRate.Location = new System.Drawing.Point(113, 316);
            this.textBoxIDToRate.Name = "textBoxIDToRate";
            this.textBoxIDToRate.Size = new System.Drawing.Size(226, 20);
            this.textBoxIDToRate.TabIndex = 69;
            // 
            // labelIdToRate
            // 
            this.labelIdToRate.AutoSize = true;
            this.labelIdToRate.ForeColor = System.Drawing.Color.White;
            this.labelIdToRate.Location = new System.Drawing.Point(109, 276);
            this.labelIdToRate.Name = "labelIdToRate";
            this.labelIdToRate.Size = new System.Drawing.Size(117, 13);
            this.labelIdToRate.TabIndex = 68;
            this.labelIdToRate.Text = "Enter Book Id To Rate:";
            // 
            // textBoxBuyBookID
            // 
            this.textBoxBuyBookID.Location = new System.Drawing.Point(371, 227);
            this.textBoxBuyBookID.Name = "textBoxBuyBookID";
            this.textBoxBuyBookID.Size = new System.Drawing.Size(172, 20);
            this.textBoxBuyBookID.TabIndex = 67;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.ForeColor = System.Drawing.Color.White;
            this.labelBookID.Location = new System.Drawing.Point(368, 196);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(114, 13);
            this.labelBookID.TabIndex = 66;
            this.labelBookID.Text = "Enter Book ID To Buy:";
            // 
            // buttonBrowseBooks
            // 
            this.buttonBrowseBooks.Location = new System.Drawing.Point(112, 377);
            this.buttonBrowseBooks.Name = "buttonBrowseBooks";
            this.buttonBrowseBooks.Size = new System.Drawing.Size(95, 20);
            this.buttonBrowseBooks.TabIndex = 65;
            this.buttonBrowseBooks.Text = "Browse Books";
            this.buttonBrowseBooks.UseVisualStyleBackColor = true;
            this.buttonBrowseBooks.Click += new System.EventHandler(this.buttonBrowseBooks_Click);
            // 
            // buttonRateBook
            // 
            this.buttonRateBook.Location = new System.Drawing.Point(582, 316);
            this.buttonRateBook.Name = "buttonRateBook";
            this.buttonRateBook.Size = new System.Drawing.Size(93, 20);
            this.buttonRateBook.TabIndex = 64;
            this.buttonRateBook.Text = "Rate Book";
            this.buttonRateBook.UseVisualStyleBackColor = true;
            this.buttonRateBook.Click += new System.EventHandler(this.buttonRateBook_Click);
            // 
            // buttonExit2
            // 
            this.buttonExit2.Location = new System.Drawing.Point(582, 377);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(93, 20);
            this.buttonExit2.TabIndex = 63;
            this.buttonExit2.Text = "Exit";
            this.buttonExit2.UseVisualStyleBackColor = true;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit2_Click);
            // 
            // buttonBuyBook
            // 
            this.buttonBuyBook.Location = new System.Drawing.Point(582, 227);
            this.buttonBuyBook.Name = "buttonBuyBook";
            this.buttonBuyBook.Size = new System.Drawing.Size(93, 21);
            this.buttonBuyBook.TabIndex = 62;
            this.buttonBuyBook.Text = "Buy Book";
            this.buttonBuyBook.UseVisualStyleBackColor = true;
            this.buttonBuyBook.Click += new System.EventHandler(this.buttonBuyBook_Click);
            // 
            // textBoxBuyBookTitle
            // 
            this.textBoxBuyBookTitle.Location = new System.Drawing.Point(112, 227);
            this.textBoxBuyBookTitle.Name = "textBoxBuyBookTitle";
            this.textBoxBuyBookTitle.Size = new System.Drawing.Size(227, 20);
            this.textBoxBuyBookTitle.TabIndex = 61;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.ForeColor = System.Drawing.Color.White;
            this.labelBookTitle.Location = new System.Drawing.Point(110, 196);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(123, 13);
            this.labelBookTitle.TabIndex = 60;
            this.labelBookTitle.Text = "Enter Book Title To Buy:";
            // 
            // CustomerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(780, 431);
            this.Controls.Add(this.buttonRefresh1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.labelForrating);
            this.Controls.Add(this.textBoxIDToRate);
            this.Controls.Add(this.labelIdToRate);
            this.Controls.Add(this.textBoxBuyBookID);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.buttonBrowseBooks);
            this.Controls.Add(this.buttonRateBook);
            this.Controls.Add(this.buttonExit2);
            this.Controls.Add(this.buttonBuyBook);
            this.Controls.Add(this.textBoxBuyBookTitle);
            this.Controls.Add(this.labelBookTitle);
            this.Name = "CustomerFrom";
            this.Text = "BuyBooksOnline";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonRefresh1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelForrating;
        private System.Windows.Forms.TextBox textBoxIDToRate;
        private System.Windows.Forms.Label labelIdToRate;
        private System.Windows.Forms.TextBox textBoxBuyBookID;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Button buttonBrowseBooks;
        private System.Windows.Forms.Button buttonRateBook;
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.Button buttonBuyBook;
        private System.Windows.Forms.TextBox textBoxBuyBookTitle;
        private System.Windows.Forms.Label labelBookTitle;
    }
}
