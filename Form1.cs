using Library.DatabaseConfig;
using Library.Models;
using Library.Repositories;

namespace Library
{
    public partial class Form1 : Form
    {
        private readonly IBookRepository _bookRepository;
        public Form1()
        {
            InitializeComponent();
            _bookRepository = new BookRepository(new AppDbContext());
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = _bookRepository.GetAll();
        }

        private void AddBtn_Click(object sender, EventArgs e) //Add
        {
            var book = new Book
            {
                Title = textBox1.Text,
                Genre = textBox2.Text,
                YearPublished = dateTimePicker1.Value
            };

            _bookRepository.Add(book);
            LoadData();

            MessageBox.Show("Book added successfully!");
        }

        private void DelBtn_Click(object sender, EventArgs e) //Delete
        {
            if(dataGridView1.CurrentRow != null)
            {
                int bookId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                _bookRepository.Delete(bookId);
                LoadData();
                MessageBox.Show("Book deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }
    }
}
