using Library.Data;
using Library.Models;

namespace Library
{
    public partial class Form1 : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public Form1(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

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

        private void authorsBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(authorsPanel);
        }

        private void ShowPanel(Panel showPanel)
        {
            var panles = new Panel[] { authorsPanel };

            foreach (var panel in panles)
            {
                if (showPanel == panel) panel.Show();
                else panel.Hide();
            }
        }

    }
}
