namespace BuyBooksOnline
{
    partial class CustomerForm
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
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelForrating = new System.Windows.Forms.Label();
            this.textBoxIDToRate = new System.Windows.Forms.TextBox();
            this.labelIdToRate = new System.Windows.Forms.Label();
            this.labelCombox = new System.Windows.Forms.Label();
            this.buttonBrowseBooks = new System.Windows.Forms.Button();
            this.buttonRateBook = new System.Windows.Forms.Button();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.buttonBuyBook = new System.Windows.Forms.Button();
            this.comboBoxBuyBook = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
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
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(130, 25);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(529, 150);
            this.dataGridViewCustomer.TabIndex = 72;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(281, 316);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(244, 20);
            this.textBoxRating.TabIndex = 71;
            // 
            // labelForrating
            // 
            this.labelForrating.AutoSize = true;
            this.labelForrating.ForeColor = System.Drawing.Color.White;
            this.labelForrating.Location = new System.Drawing.Point(278, 287);
            this.labelForrating.Name = "labelForrating";
            this.labelForrating.Size = new System.Drawing.Size(94, 13);
            this.labelForrating.TabIndex = 70;
            this.labelForrating.Text = "Enter Your Rating:";
            // 
            // textBoxIDToRate
            // 
            this.textBoxIDToRate.Location = new System.Drawing.Point(130, 316);
            this.textBoxIDToRate.Name = "textBoxIDToRate";
            this.textBoxIDToRate.Size = new System.Drawing.Size(114, 20);
            this.textBoxIDToRate.TabIndex = 69;
            // 
            // labelIdToRate
            // 
            this.labelIdToRate.AutoSize = true;
            this.labelIdToRate.ForeColor = System.Drawing.Color.White;
            this.labelIdToRate.Location = new System.Drawing.Point(127, 287);
            this.labelIdToRate.Name = "labelIdToRate";
            this.labelIdToRate.Size = new System.Drawing.Size(117, 13);
            this.labelIdToRate.TabIndex = 68;
            this.labelIdToRate.Text = "Enter Book Id To Rate:";
            // 
            // labelCombox
            // 
            this.labelCombox.AutoSize = true;
            this.labelCombox.ForeColor = System.Drawing.Color.White;
            this.labelCombox.Location = new System.Drawing.Point(127, 208);
            this.labelCombox.Name = "labelCombox";
            this.labelCombox.Size = new System.Drawing.Size(330, 13);
            this.labelCombox.TabIndex = 66;
            this.labelCombox.Text = "1st Browse The Books and then Select  Book From ComBox to Buy :";
            // 
            // buttonBrowseBooks
            // 
            this.buttonBrowseBooks.Location = new System.Drawing.Point(130, 377);
            this.buttonBrowseBooks.Name = "buttonBrowseBooks";
            this.buttonBrowseBooks.Size = new System.Drawing.Size(95, 20);
            this.buttonBrowseBooks.TabIndex = 65;
            this.buttonBrowseBooks.Text = "Browse Books";
            this.buttonBrowseBooks.UseVisualStyleBackColor = true;
            this.buttonBrowseBooks.Click += new System.EventHandler(this.buttonBrowseBooks_Click);
            // 
            // buttonRateBook
            // 
            this.buttonRateBook.Location = new System.Drawing.Point(566, 315);
            this.buttonRateBook.Name = "buttonRateBook";
            this.buttonRateBook.Size = new System.Drawing.Size(93, 20);
            this.buttonRateBook.TabIndex = 64;
            this.buttonRateBook.Text = "Rate Book";
            this.buttonRateBook.UseVisualStyleBackColor = true;
            this.buttonRateBook.Click += new System.EventHandler(this.buttonRateBook_Click);
            // 
            // buttonExit2
            // 
            this.buttonExit2.Location = new System.Drawing.Point(566, 377);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(93, 20);
            this.buttonExit2.TabIndex = 63;
            this.buttonExit2.Text = "Exit";
            this.buttonExit2.UseVisualStyleBackColor = true;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit2_Click);
            // 
            // buttonBuyBook
            // 
            this.buttonBuyBook.Location = new System.Drawing.Point(566, 236);
            this.buttonBuyBook.Name = "buttonBuyBook";
            this.buttonBuyBook.Size = new System.Drawing.Size(93, 21);
            this.buttonBuyBook.TabIndex = 62;
            this.buttonBuyBook.Text = "Buy Book";
            this.buttonBuyBook.UseVisualStyleBackColor = true;
            this.buttonBuyBook.Click += new System.EventHandler(this.buttonBuyBook_Click);
            // 
            // comboBoxBuyBook
            // 
            this.comboBoxBuyBook.FormattingEnabled = true;
            this.comboBoxBuyBook.Location = new System.Drawing.Point(130, 237);
            this.comboBoxBuyBook.Name = "comboBoxBuyBook";
            this.comboBoxBuyBook.Size = new System.Drawing.Size(395, 21);
            this.comboBoxBuyBook.TabIndex = 75;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(780, 431);
            this.Controls.Add(this.comboBoxBuyBook);
            this.Controls.Add(this.buttonRefresh1);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.labelForrating);
            this.Controls.Add(this.textBoxIDToRate);
            this.Controls.Add(this.labelIdToRate);
            this.Controls.Add(this.labelCombox);
            this.Controls.Add(this.buttonBrowseBooks);
            this.Controls.Add(this.buttonRateBook);
            this.Controls.Add(this.buttonExit2);
            this.Controls.Add(this.buttonBuyBook);
            this.Name = "CustomerForm";
            this.Text = "Book Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonRefresh1;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelForrating;
        private System.Windows.Forms.TextBox textBoxIDToRate;
        private System.Windows.Forms.Label labelIdToRate;
        private System.Windows.Forms.Label labelCombox;
        private System.Windows.Forms.Button buttonBrowseBooks;
        private System.Windows.Forms.Button buttonRateBook;
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.Button buttonBuyBook;
        private System.Windows.Forms.ComboBox comboBoxBuyBook;
    }
}
