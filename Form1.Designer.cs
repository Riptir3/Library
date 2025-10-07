namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            HeaderPanel = new Panel();
            label1 = new Label();
            exitLabel = new Label();
            minLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            homeBtn = new Button();
            authorsBtn = new Button();
            booksBtn = new Button();
            statBtn = new Button();
            authorsPanel = new Panel();
            detailedSearch = new PictureBox();
            exportAuthors = new PictureBox();
            addAuthor = new PictureBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            AuthorName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Books = new DataGridViewComboBoxColumn();
            ChangeBtn = new DataGridViewImageColumn();
            delBtn = new DataGridViewImageColumn();
            HeaderPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            authorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detailedSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exportAuthors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addAuthor).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.FromArgb(35, 44, 65);
            HeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            HeaderPanel.Controls.Add(label1);
            HeaderPanel.Controls.Add(exitLabel);
            HeaderPanel.Controls.Add(minLabel);
            resources.ApplyResources(HeaderPanel, "HeaderPanel");
            HeaderPanel.Name = "HeaderPanel";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Name = "label1";
            // 
            // exitLabel
            // 
            resources.ApplyResources(exitLabel, "exitLabel");
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.ForeColor = SystemColors.ControlLightLight;
            exitLabel.Name = "exitLabel";
            exitLabel.Click += exitLabel_Click;
            exitLabel.MouseLeave += exitLabel_MouseLeave;
            exitLabel.MouseHover += exitLabel_MouseHover;
            // 
            // minLabel
            // 
            resources.ApplyResources(minLabel, "minLabel");
            minLabel.Cursor = Cursors.Hand;
            minLabel.ForeColor = SystemColors.ControlLightLight;
            minLabel.Name = "minLabel";
            minLabel.Click += minLabel_Click;
            minLabel.MouseLeave += minLabel_MouseLeave;
            minLabel.MouseHover += minLabel_MouseHover;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 44, 65);
            flowLayoutPanel1.Controls.Add(homeBtn);
            flowLayoutPanel1.Controls.Add(authorsBtn);
            flowLayoutPanel1.Controls.Add(booksBtn);
            flowLayoutPanel1.Controls.Add(statBtn);
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // homeBtn
            // 
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(homeBtn, "homeBtn");
            homeBtn.ForeColor = SystemColors.ButtonHighlight;
            homeBtn.Name = "homeBtn";
            homeBtn.UseVisualStyleBackColor = true;
            // 
            // authorsBtn
            // 
            authorsBtn.Cursor = Cursors.Hand;
            authorsBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(authorsBtn, "authorsBtn");
            authorsBtn.ForeColor = SystemColors.ButtonHighlight;
            authorsBtn.Name = "authorsBtn";
            authorsBtn.UseVisualStyleBackColor = true;
            authorsBtn.Click += authorsBtn_Click;
            // 
            // booksBtn
            // 
            booksBtn.Cursor = Cursors.Hand;
            booksBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(booksBtn, "booksBtn");
            booksBtn.ForeColor = SystemColors.ButtonHighlight;
            booksBtn.Name = "booksBtn";
            booksBtn.UseVisualStyleBackColor = true;
            // 
            // statBtn
            // 
            statBtn.Cursor = Cursors.Hand;
            statBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(statBtn, "statBtn");
            statBtn.ForeColor = SystemColors.ButtonHighlight;
            statBtn.Name = "statBtn";
            statBtn.UseVisualStyleBackColor = true;
            // 
            // authorsPanel
            // 
            authorsPanel.BackColor = Color.FromArgb(159, 2, 94);
            authorsPanel.Controls.Add(detailedSearch);
            authorsPanel.Controls.Add(exportAuthors);
            authorsPanel.Controls.Add(addAuthor);
            authorsPanel.Controls.Add(groupBox1);
            authorsPanel.Controls.Add(dataGridView1);
            resources.ApplyResources(authorsPanel, "authorsPanel");
            authorsPanel.Name = "authorsPanel";
            // 
            // detailedSearch
            // 
            resources.ApplyResources(detailedSearch, "detailedSearch");
            detailedSearch.Name = "detailedSearch";
            detailedSearch.TabStop = false;
            // 
            // exportAuthors
            // 
            resources.ApplyResources(exportAuthors, "exportAuthors");
            exportAuthors.Name = "exportAuthors";
            exportAuthors.TabStop = false;
            // 
            // addAuthor
            // 
            resources.ApplyResources(addAuthor, "addAuthor");
            addAuthor.Name = "addAuthor";
            addAuthor.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AuthorName, Date, Books, ChangeBtn, delBtn });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ShowEditingIcon = false;
            // 
            // AuthorName
            // 
            AuthorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(AuthorName, "AuthorName");
            AuthorName.Name = "AuthorName";
            // 
            // Date
            // 
            resources.ApplyResources(Date, "Date");
            Date.Name = "Date";
            // 
            // Books
            // 
            resources.ApplyResources(Books, "Books");
            Books.Name = "Books";
            // 
            // ChangeBtn
            // 
            resources.ApplyResources(ChangeBtn, "ChangeBtn");
            ChangeBtn.Image = (Image)resources.GetObject("ChangeBtn.Image");
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Resizable = DataGridViewTriState.True;
            // 
            // delBtn
            // 
            resources.ApplyResources(delBtn, "delBtn");
            delBtn.Image = (Image)resources.GetObject("delBtn.Image");
            delBtn.Name = "delBtn";
            delBtn.Resizable = DataGridViewTriState.True;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(authorsPanel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(HeaderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.75D;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            authorsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)detailedSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)exportAuthors).EndInit();
            ((System.ComponentModel.ISupportInitialize)addAuthor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button homeBtn;
        private Button authorsBtn;
        private Button booksBtn;
        private Button statBtn;
        private Label minLabel;
        private Label exitLabel;
        private Label label1;
        private Panel authorsPanel;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private PictureBox addAuthor;
        private PictureBox exportAuthors;
        private PictureBox detailedSearch;
        private DataGridViewTextBoxColumn AuthorName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewComboBoxColumn Books;
        private DataGridViewImageColumn ChangeBtn;
        private DataGridViewImageColumn delBtn;
    }
}
