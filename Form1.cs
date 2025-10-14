using DocumentFormat.OpenXml.Drawing.Charts;
using Library.Controllers;
using Library.Data;
using Library.DatabaseConfig;
using Library.Enums;
using Library.Excel;
using Library.Log;
using Library.Models;
using ScottPlot;
using ScottPlot.WinForms;

namespace Library
{
    public partial class Form1 : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AuthorController _authorController;
        private readonly BookController _bookController;
        private readonly AdvancedLoggerSync logger;
        public Form1(IUnitOfWork unitOfWork, AuthorController authorController, BookController bookController)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _authorController = authorController;
            _bookController = bookController;

            logger = new AdvancedLoggerSync("Logs");

            ShowPanel(homePanel);
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
            exitLabel.ForeColor = System.Drawing.Color.Red;
            exitLabel.BackColor = System.Drawing.Color.FromArgb(40, 50, 70);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = System.Drawing.Color.White;
            exitLabel.BackColor = System.Drawing.Color.FromArgb(35, 44, 65);
        }

        private void minLabel_MouseHover(object sender, EventArgs e)
        {
            minLabel.BackColor = System.Drawing.Color.FromArgb(40, 50, 70);
        }

        private void minLabel_MouseLeave(object sender, EventArgs e)
        {
            minLabel.BackColor = System.Drawing.Color.FromArgb(35, 44, 65);
            minLabel.ForeColor = System.Drawing.Color.White;
        }
        private void ShowPanel(Panel showPanel)
        {
            var panles = new Panel[] { authorsPanel, addAuthorPanel, booksPanel, addBookPanel, editBookPanel, homePanel, statPanel };

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

        #region Home's panel
        private void homeBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(homePanel);
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
                logger.Log($"Author with name: {newAuthor.Name} added.", LogLevel.Info);
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
                logger.Log($"Author with name: {author.Name} is deleted.", LogLevel.Warning);
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
                    authorBookShow(author);
                    break;
            }
        }

        private void authorBookShow(Author author)
        {
            var booksCount = _unitOfWork.Books.GetAllWithAuthor().Where(b => b.Author == author).Count();

            if (booksCount != 0)
            {
                booksSearchTxt.Text = author.Name;
                ShowPanel(booksPanel);
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
                logger.Log($"Author with name: {authorNewName} editted.", LogLevel.Warning);
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
                logger.Log($"Book with title: {newBook.Title} added.", LogLevel.Info);
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
            logger.Log($"Book with title: {book.Title} is deleted.", LogLevel.Warning);
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
                    logger.Log($"Book with title: {newTitle} is edttted.", LogLevel.Warning);
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
                        booksDataGridView.Rows.Add(book.Title, book.Genre, book.Author.Name);
                    }
                }
            }
        }
        #endregion

        #region Excel
        private void exportAuthors_Click(object sender, EventArgs e)
        {
            var authors = _unitOfWork.Authors.GetAllWithBooks().Select(a => new
            {
                a.Name,
                a.BirthDate,
                a.Books.Count,
            }).ToList();

            ExcelHelper.ExportToExcel(authors, "Auhor's Data", "Authors");
            logger.Log("Author's excel file is created", LogLevel.Info);
        }

        private void booksExportBtn_Click(object sender, EventArgs e)
        {
            var books = _unitOfWork.Books.GetAllWithAuthor().Select(b => new
            {
                b.Title,
                b.Genre,
                Author = b.Author.Name
            }).ToList();

            ExcelHelper.ExportToExcel(books, "Book's data", "Books");
            logger.Log("Book's excel file is created", LogLevel.Info);
        }
        #endregion

        #region Stat's panel
        private void statBtn_Click(object sender, EventArgs e)
        {
            bool canOpen = _unitOfWork.Books.GetAll().Count() > 0;
            if (canOpen)
            {
                ShowPanel(statPanel);
                loadAuthorsName();
                CreatePieChart();
                CreateBarChart();
            }
            else
            {
                MessageBox.Show("No data to show.");
            }
        }

        private void loadAuthorsName()
        {
            var authorsName = _unitOfWork.Books.GetAllWithAuthor().Select(b => b.Author.Name).Distinct().ToList();

            authorsStatCombobox.DataSource = authorsName;
        }

        private void CreatePieChart()
        {
            Random rnd = new Random();

            ScottPlot.Color GetRandomColor() => new ScottPlot.Color(rnd.Next(50, 256), rnd.Next(50, 256), rnd.Next(50, 256));
            HashSet<ScottPlot.Color> usedColors = [];

            var authorName = authorsStatCombobox.SelectedValue.ToString();
            var dtos = _unitOfWork.Authors.GetAuthorGenreStatList(authorName);

            var formsPlot = new FormsPlot
            {
                Dock = DockStyle.Fill
            };

            ScottPlot.Plot myPlot = formsPlot.Plot;

            List<PieSlice> slices = [];

            foreach (var dto in dtos)
            {
                ScottPlot.Color color;

                do
                {
                  color = GetRandomColor();
                } while (usedColors.Contains(color));

                PieSlice slice = new() { Value = dto.BookCount, FillColor = color, Label = dto.BookCount.ToString() };
                slice.LegendText = dto.Genre;
                slice.LabelBold = true;
                slices.Add(slice);
            }

            var pie = myPlot.Add.Pie(slices);
            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = dtos.Count() != 1 ? 0.5 : 0;

            slices.ForEach(x => x.LabelFontColor = x.FillColor.Darken(.5));

            myPlot.Axes.Frameless();
            myPlot.HideGrid();

            auhtorPieChartPanel.Controls.Clear();
            auhtorPieChartPanel.Controls.Add(formsPlot);

            formsPlot.Refresh();
        }

        private void CreateBarChart()
        {
            var authors = _unitOfWork.Authors.GetAllWithBooks().ToList();

            var formsPlot1 = new FormsPlot
            {
                Dock = DockStyle.Fill
            };

            double[] values = new double[authors.Count];
            Tick[] ticks = new Tick[authors.Count];

            for (int i = 0; i < authors.Count(); i++)
            {
                values[i] = authors[i].Books.Count;
                ticks[i] = new Tick(i, authors[i].Name);
            }

            formsPlot1.Plot.Add.Bars(values);
            formsPlot1.Plot.Axes.Margins(bottom: 0);

            formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;

            // determine the width of the largest tick label
            float largestLabelWidth = 0;
            using (Paint paint = ScottPlot.Paint.NewDisposablePaint())
            {
                foreach (Tick tick in ticks)
                {
                    PixelSize size = formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Measure(tick.Label, paint).Size;
                    largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
                }
            }
            // ensure axis panels do not get smaller than the largest label
            formsPlot1.Plot.Axes.Bottom.MinimumSize = largestLabelWidth;
            formsPlot1.Plot.Axes.Right.MinimumSize = largestLabelWidth;

            authorsAllStatPanel.Controls.Clear();
            authorsAllStatPanel.Controls.Add(formsPlot1);

            formsPlot1.Refresh();
        }

        private void authorsStatCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            CreatePieChart();
        }

        #endregion
    }
}
