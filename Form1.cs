using Library.Controllers;
using Library.Data;
using Library.Enums;
using Library.Models;
using System.Reflection.Metadata.Ecma335;

namespace Library
{
    public partial class Form1 : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AuthorController _authorController;
        private readonly BookController _bookController;
        public Form1(IUnitOfWork unitOfWork, AuthorController authorController, BookController bookController)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _authorController = authorController;
            _bookController = bookController;
        }

        #region Formatting

        private void minLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitLabel_MouseHover(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.Red;
            exitLabel.BackColor = Color.FromArgb(40, 50, 70);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.White;
            exitLabel.BackColor = Color.FromArgb(35, 44, 65);
        }

        private void minLabel_MouseHover(object sender, EventArgs e)
        {
            minLabel.BackColor = Color.FromArgb(40, 50, 70);
        }

        private void minLabel_MouseLeave(object sender, EventArgs e)
        {
            minLabel.BackColor = Color.FromArgb(35, 44, 65);
            minLabel.ForeColor = Color.White;
        }
        private void ShowPanel(Panel showPanel)
        {
            var panles = new Panel[] { authorsPanel, addAuthorPanel, booksPanel, addBookPanel, editBookPanel };

            foreach (var panel in panles)
            {
                if (showPanel == panel)
                {
                    panel.Show();
                    panel.Dock = DockStyle.Fill;
                }
                else
                {
                    panel.Hide();
                    panel.Dock = DockStyle.None;
                }
            }
        }

        #endregion

        #region Author's panel
        private void authorsBtn_Click(object sender, EventArgs e) // Authors page
        {
            LoadAuthorsData();
            ShowPanel(authorsPanel);
        }

        private void LoadAuthorsData()
        {
            authorDataGridView.Rows.Clear();
            var authors = _unitOfWork.Authors.GetAllWithBooks();

            foreach (var author in authors)
            {
                authorDataGridView.Rows.Add(author.Name, author.BirthDate, author.Books.Count);
            }
        }

        private void addAuthor_Click(object sender, EventArgs e) // show panel, where can add new author
        {
            addAuthorPanel.Show();
        }

        private void addAuthorsExitLabel_Click(object sender, EventArgs e)
        {
            ResetAddAuthorsPanel();
            addAuthorPanel.Hide();
        }

        private void addAuhtorCancelBtn_Click(object sender, EventArgs e)
        {
            ResetAddAuthorsPanel();
            addAuthorPanel.Hide();
        }
        private void ResetAddAuthorsPanel()
        {
            authorNameTxtbox.Text = string.Empty;
            authorBirtDatePicker.Value = DateTime.Now;
        }

        private void addAuthorSaveBtn_Click(object sender, EventArgs e)
        {
            if (authorNameTxtbox.Text == string.Empty)
            {
                MessageBox.Show("Author's name can not be empty");
                return;
            }
            if (authorBirtDatePicker.Value >= DateTime.Now)
            {
                MessageBox.Show("Invalid date, date must be less than date of now");
                return;
            }

            var newAuthor = new Author
            {
                Name = authorNameTxtbox.Text,
                BirthDate = authorBirtDatePicker.Value,
            };

            bool canAddAuthor = _authorController.AddAuthor(newAuthor);

            if (canAddAuthor)
            {
                MessageBox.Show("Author is added.");
                LoadAuthorsData();
                ResetAddAuthorsPanel();
            }
            else
            {
                MessageBox.Show("Author's name is reserved.");
            }
        }

        private void authorDelete(Author author)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Want to delete author with her/his books?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _unitOfWork.Authors.Delete(author);
                _unitOfWork.Save();
                LoadAuthorsData();
                MessageBox.Show("Author is deleted!");
            }
        }

        private void authorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var authorName = authorDataGridView.CurrentRow.Cells[0].Value as string;
            var author = _unitOfWork.Authors.GetAll().Where(a => a.Name == authorName).First();

            switch (e.ColumnIndex)
            {
                case 3:
                    authorEditPanelOpen(author);
                    break;
                case 4:
                    authorDelete(author);
                    break;
                case 5:
                    MessageBox.Show("Books of author");
                    break;
            }
        }

        private void authorEditPanelOpen(Author author)
        {
            authorEditPanel.Show();
            authorEditOriginalName.Text = author.Name;
            authorEditOriginalDate.Value = author.BirthDate;
            authorEditNewDate.Value = author.BirthDate;
        }

        private void authorEditExit_Click(object sender, EventArgs e)
        {
            resetAuthorEditPanel();
        }

        private void authorEditCancel_Click(object sender, EventArgs e)
        {
            resetAuthorEditPanel();
        }

        private void resetAuthorEditPanel()
        {
            authorEditNewName.Text = string.Empty;
            authorEditPanel.Visible = false;
        }

        private void authorEditSave_Click(object sender, EventArgs e)
        {
            var authorName = authorEditOriginalName.Text;
            var author = _unitOfWork.Authors.GetAll().Where(a => a.Name == authorName).First();

            var authorNewName = authorEditNewName.Text;
            var auhtorNewDate = authorEditNewDate.Value;

            bool newNameOk = _unitOfWork.Authors.GetAll().Where(a => a.Name == authorNewName).Count() > 0 ? false : true;

            if (authorNewName == string.Empty)
            {
                MessageBox.Show("Author's name can not be empty");
                return;
            }
            if (auhtorNewDate >= DateTime.Now)
            {
                MessageBox.Show("Invalid date, date must be less than date of now");
                return;
            }

            if (author.Name == authorNewName && author.BirthDate == auhtorNewDate)
            {
                MessageBox.Show("No changes");
                return;
            }
            if (newNameOk)
            {
                author.Name = authorNewName;
                author.BirthDate = auhtorNewDate;
                _unitOfWork.Authors.Update(author);
                _unitOfWork.Save();
                LoadAuthorsData();
                MessageBox.Show("Author's data is changed.");
                resetAuthorEditPanel();
            }
        }

        private void authorSearchTxt_TextChanged(object sender, EventArgs e)
        {
            authorDataGridView.Rows.Clear();

            var searchText = authorSearchTxt.Text.ToLower();

            if (searchText.Length == 0)
            {
                LoadAuthorsData();
            }
            else
            {
                var authors = _unitOfWork.Authors.GetAll().Where(a => a.Name.ToLower().Contains(searchText) || a.BirthDate.ToString().Contains(searchText));

                if (authors.Any())
                {
                    foreach (var author in authors)
                    {
                        authorDataGridView.Rows.Add(author.Name, author.BirthDate, author.Books.Count);
                    }
                }
            }
        }
        #endregion

        #region Book's panel
        private void booksBtn_Click(object sender, EventArgs e)
        {
            LoadBooksData();
            ShowPanel(booksPanel);
        }

        private void LoadBooksData()
        {
            booksDataGridView.Rows.Clear();
            var books = _unitOfWork.Books.GetAllWithAuthor();

            foreach (var book in books)
            {
                booksDataGridView.Rows.Add(book.Title, book.Genre, book.Author.Name);
            }
        }
        #endregion

        private void booksAddBtn_Click(object sender, EventArgs e)
        {
            addBookPanel.Show();
            uploadNewBookCombobox();
            newBookGenreCombobox.SelectedIndex = 0;
            newBookAuthorComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetAddBookPanel();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            resetAddBookPanel();
        }

        private void uploadNewBookCombobox()
        {
            var authors = _unitOfWork.Authors.GetAll().Select(a => a.Name).ToList();

            newBookAuthorComboBox.DataSource = authors;

            var genres = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList();

            newBookGenreCombobox.DataSource = genres;
        }

        private void resetAddBookPanel()
        {
            addBookPanel.Hide();
            newBookNameTxt.Text = string.Empty;
            newBookGenreCombobox.SelectedIndex = 0;
            newBookAuthorComboBox.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newBookName = newBookNameTxt.Text;
            if (newBookName == string.Empty)
            {
                MessageBox.Show("Book's title can not be nothing.");
                return;
            }

            var authorId = _unitOfWork.Authors.GetAll().Where(a => a.Name == newBookAuthorComboBox.SelectedValue.ToString()).First().Id;

            var newBook = new Book
            {
                Title = newBookName,
                Genre = newBookGenreCombobox.SelectedValue.ToString(),
                AuthorId = authorId
            };

            bool canAddBook = _bookController.AddBook(newBook);

            if (!canAddBook)
            {
                MessageBox.Show("Book is already in the library.");
                return;
            }
            else
            {
                MessageBox.Show("Book is added.");
                _unitOfWork.Save();
                LoadBooksData();
                resetAddBookPanel();
            }
        }

        private void updateEditBookPanel(Book book)
        {

            var authors = _unitOfWork.Authors.GetAll().Select(a => a.Name).ToList();

            editBookAuthorComboBox.DataSource = authors;

            var genres = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList();

            editBookGenreComboBox.DataSource = genres;

            editBookOriginalTitle.Text = book.Title;
            editBookOriginalGenre.Text = book.Genre;
            editBookOriginalAuthor.Text = book.Author.Name;

            editBookGenreComboBox.SelectedText = book.Genre;
            editBookAuthorComboBox.SelectedText = book.Author.Name;

            editBookPanel.Show();
        }

        private void deleteBook(Book book)
        {
            _unitOfWork.Books.Delete(book);
            _unitOfWork.Save();
            LoadBooksData();
            MessageBox.Show("Book is deleted.");
        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var bookTitle = booksDataGridView.CurrentRow.Cells[0].Value as string;
            var book = _unitOfWork.Books.GetAllWithAuthor().Where(a => a.Title == bookTitle).First();

            switch (e.ColumnIndex)
            {
                case 3:
                    updateEditBookPanel(book);
                    break;
                case 4:
                    deleteBook(book);
                    break;
            }
        }

        private void editBookExitBtn_Click(object sender, EventArgs e)
        {
            editBookPanel.Hide();
        }

        private void editBookCaancelBtn_Click(object sender, EventArgs e)
        {
            editBookPanel.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var originalTitle = editBookOriginalTitle.Text;
            var originalGenre = editBookOriginalGenre.Text;
            var originalAuthor = editBookOriginalAuthor.Text;

            var newTitle = editBookNewTitle.Text;
            var newGenre = editBookGenreComboBox.SelectedValue.ToString();
            var newAuthor = editBookAuthorComboBox.SelectedValue.ToString();

            if (newTitle == string.Empty)
            {
                MessageBox.Show("Title can not be nothing.");
                return;
            }
            if (originalTitle == newTitle && originalGenre == newGenre && originalAuthor == newAuthor)
            {
                MessageBox.Show("No changes.");
                return;
            }
            if (originalTitle != newTitle)
            {
                bool nameIsOK = _unitOfWork.Books.GetAll().Where(b => b.Title == newTitle).ToList().Count == 0;
                if (nameIsOK)
                {

                    var Book = _unitOfWork.Books.GetAll().Where(b => b.Title == originalTitle).First();
                    var author = _unitOfWork.Authors.GetAll().Where(a => a.Name == newAuthor).First();

                    Book.Title = newTitle;
                    Book.Genre = newGenre;
                    Book.AuthorId = author.Id;

                    _unitOfWork.Books.Update(Book);
                    _unitOfWork.Save();
                    MessageBox.Show("Book is editted.");
                    editBookPanel.Hide();
                    LoadBooksData();
                    return;
                }
                else
                {
                    MessageBox.Show("Title is reserved.");
                    return;
                }
            }
            else
            {
                var Book = _unitOfWork.Books.GetAll().Where(b => b.Title == originalTitle).First();
                var author = _unitOfWork.Authors.GetAll().Where(a => a.Name == newAuthor).First();

                Book.Genre = newGenre;
                Book.AuthorId = author.Id;

                _unitOfWork.Books.Update(Book);
                _unitOfWork.Save();
                MessageBox.Show("Book is editted.");
                editBookPanel.Hide();
                LoadBooksData();
                return;
            }
        }

        private void booksSearchTxt_TextChanged(object sender, EventArgs e)
        {
            booksDataGridView.Rows.Clear();

            var searchText = booksSearchTxt.Text.ToLower();

            if (searchText.Length == 0)
            {
                LoadBooksData();
            }
            else
            {
                var books = _unitOfWork.Books.GetAllWithAuthor().Where(b => b.Title.ToLower().Contains(searchText) || b.Genre.ToLower().Contains(searchText) || b.Author.Name.ToLower().Contains(searchText)).ToList();

                if (books.Any())
                {
                    foreach (var book in books)
                    {
                        booksDataGridView.Rows.Add(book.Title,book.Genre,book.Author.Name);
                    }
                }
            }
        }
    }
}
