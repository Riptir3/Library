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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
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
            authorEditPanel = new Panel();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            authorEditNewDate = new DateTimePicker();
            groupBox9 = new GroupBox();
            authorEditNewName = new TextBox();
            authorEditSave = new Button();
            authorEditCancel = new Button();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            authorEditOriginalDate = new DateTimePicker();
            groupBox6 = new GroupBox();
            authorEditOriginalName = new TextBox();
            panel3 = new Panel();
            authorEditExit = new Label();
            addAuthorPanel = new Panel();
            addAuthorGroupBox = new GroupBox();
            addAuhtorCancelBtn = new Button();
            addAuthorSaveBtn = new Button();
            groupBox4 = new GroupBox();
            authorBirtDatePicker = new DateTimePicker();
            groupBox3 = new GroupBox();
            authorNameTxtbox = new TextBox();
            panel1 = new Panel();
            addAuthorsExitLabel = new Label();
            detailedSearch = new PictureBox();
            exportAuthors = new PictureBox();
            addAuthor = new PictureBox();
            groupBox1 = new GroupBox();
            authorSearchTxt = new TextBox();
            authorDataGridView = new DataGridView();
            AuthorName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Books = new DataGridViewTextBoxColumn();
            ChangeBtn = new DataGridViewImageColumn();
            delBtn = new DataGridViewImageColumn();
            showBooks = new DataGridViewImageColumn();
            booksPanel = new Panel();
            addBookPanel = new Panel();
            groupBox10 = new GroupBox();
            groupBox13 = new GroupBox();
            newBookAuthorComboBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            groupBox11 = new GroupBox();
            newBookGenreCombobox = new ComboBox();
            groupBox12 = new GroupBox();
            newBookNameTxt = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            booksExportBtn = new PictureBox();
            booksAddBtn = new PictureBox();
            groupBox19 = new GroupBox();
            booksSearchTxt = new TextBox();
            booksDataGridView = new DataGridView();
            bookTitle = new DataGridViewTextBoxColumn();
            bookGenre = new DataGridViewTextBoxColumn();
            bookAuthor = new DataGridViewTextBoxColumn();
            bookEditBtn = new DataGridViewImageColumn();
            bookDelete = new DataGridViewImageColumn();
            HeaderPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            authorsPanel.SuspendLayout();
            authorEditPanel.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            panel3.SuspendLayout();
            addAuthorPanel.SuspendLayout();
            addAuthorGroupBox.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detailedSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exportAuthors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addAuthor).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)authorDataGridView).BeginInit();
            booksPanel.SuspendLayout();
            addBookPanel.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksExportBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksAddBtn).BeginInit();
            groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).BeginInit();
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
            booksBtn.Click += booksBtn_Click;
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
            authorsPanel.Controls.Add(authorEditPanel);
            authorsPanel.Controls.Add(addAuthorPanel);
            authorsPanel.Controls.Add(detailedSearch);
            authorsPanel.Controls.Add(exportAuthors);
            authorsPanel.Controls.Add(addAuthor);
            authorsPanel.Controls.Add(groupBox1);
            authorsPanel.Controls.Add(authorDataGridView);
            resources.ApplyResources(authorsPanel, "authorsPanel");
            authorsPanel.Name = "authorsPanel";
            // 
            // authorEditPanel
            // 
            authorEditPanel.BorderStyle = BorderStyle.FixedSingle;
            authorEditPanel.Controls.Add(groupBox7);
            authorEditPanel.Controls.Add(authorEditSave);
            authorEditPanel.Controls.Add(authorEditCancel);
            authorEditPanel.Controls.Add(groupBox2);
            authorEditPanel.Controls.Add(panel3);
            resources.ApplyResources(authorEditPanel, "authorEditPanel");
            authorEditPanel.Name = "authorEditPanel";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Controls.Add(groupBox9);
            resources.ApplyResources(groupBox7, "groupBox7");
            groupBox7.Name = "groupBox7";
            groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(authorEditNewDate);
            resources.ApplyResources(groupBox8, "groupBox8");
            groupBox8.Name = "groupBox8";
            groupBox8.TabStop = false;
            // 
            // authorEditNewDate
            // 
            resources.ApplyResources(authorEditNewDate, "authorEditNewDate");
            authorEditNewDate.Name = "authorEditNewDate";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(authorEditNewName);
            resources.ApplyResources(groupBox9, "groupBox9");
            groupBox9.Name = "groupBox9";
            groupBox9.TabStop = false;
            // 
            // authorEditNewName
            // 
            resources.ApplyResources(authorEditNewName, "authorEditNewName");
            authorEditNewName.Name = "authorEditNewName";
            // 
            // authorEditSave
            // 
            authorEditSave.BackColor = Color.FromArgb(35, 44, 65);
            resources.ApplyResources(authorEditSave, "authorEditSave");
            authorEditSave.ForeColor = SystemColors.ButtonHighlight;
            authorEditSave.Name = "authorEditSave";
            authorEditSave.UseVisualStyleBackColor = false;
            authorEditSave.Click += authorEditSave_Click;
            // 
            // authorEditCancel
            // 
            authorEditCancel.BackColor = Color.FromArgb(35, 44, 65);
            resources.ApplyResources(authorEditCancel, "authorEditCancel");
            authorEditCancel.ForeColor = SystemColors.ButtonFace;
            authorEditCancel.Name = "authorEditCancel";
            authorEditCancel.UseVisualStyleBackColor = false;
            authorEditCancel.Click += authorEditCancel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox6);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(authorEditOriginalDate);
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // authorEditOriginalDate
            // 
            resources.ApplyResources(authorEditOriginalDate, "authorEditOriginalDate");
            authorEditOriginalDate.Name = "authorEditOriginalDate";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(authorEditOriginalName);
            resources.ApplyResources(groupBox6, "groupBox6");
            groupBox6.Name = "groupBox6";
            groupBox6.TabStop = false;
            // 
            // authorEditOriginalName
            // 
            resources.ApplyResources(authorEditOriginalName, "authorEditOriginalName");
            authorEditOriginalName.Name = "authorEditOriginalName";
            authorEditOriginalName.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 44, 65);
            panel3.Controls.Add(authorEditExit);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // authorEditExit
            // 
            resources.ApplyResources(authorEditExit, "authorEditExit");
            authorEditExit.Cursor = Cursors.Hand;
            authorEditExit.ForeColor = SystemColors.ControlLightLight;
            authorEditExit.Name = "authorEditExit";
            authorEditExit.Click += authorEditExit_Click;
            // 
            // addAuthorPanel
            // 
            addAuthorPanel.BorderStyle = BorderStyle.FixedSingle;
            addAuthorPanel.Controls.Add(addAuthorGroupBox);
            addAuthorPanel.Controls.Add(panel1);
            resources.ApplyResources(addAuthorPanel, "addAuthorPanel");
            addAuthorPanel.Name = "addAuthorPanel";
            // 
            // addAuthorGroupBox
            // 
            addAuthorGroupBox.Controls.Add(addAuhtorCancelBtn);
            addAuthorGroupBox.Controls.Add(addAuthorSaveBtn);
            addAuthorGroupBox.Controls.Add(groupBox4);
            addAuthorGroupBox.Controls.Add(groupBox3);
            resources.ApplyResources(addAuthorGroupBox, "addAuthorGroupBox");
            addAuthorGroupBox.Name = "addAuthorGroupBox";
            addAuthorGroupBox.TabStop = false;
            // 
            // addAuhtorCancelBtn
            // 
            addAuhtorCancelBtn.BackColor = Color.FromArgb(35, 44, 65);
            resources.ApplyResources(addAuhtorCancelBtn, "addAuhtorCancelBtn");
            addAuhtorCancelBtn.ForeColor = SystemColors.ButtonFace;
            addAuhtorCancelBtn.Name = "addAuhtorCancelBtn";
            addAuhtorCancelBtn.UseVisualStyleBackColor = false;
            addAuhtorCancelBtn.Click += addAuhtorCancelBtn_Click;
            // 
            // addAuthorSaveBtn
            // 
            addAuthorSaveBtn.BackColor = Color.FromArgb(35, 44, 65);
            resources.ApplyResources(addAuthorSaveBtn, "addAuthorSaveBtn");
            addAuthorSaveBtn.ForeColor = SystemColors.ButtonHighlight;
            addAuthorSaveBtn.Name = "addAuthorSaveBtn";
            addAuthorSaveBtn.UseVisualStyleBackColor = false;
            addAuthorSaveBtn.Click += addAuthorSaveBtn_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(authorBirtDatePicker);
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // authorBirtDatePicker
            // 
            resources.ApplyResources(authorBirtDatePicker, "authorBirtDatePicker");
            authorBirtDatePicker.Name = "authorBirtDatePicker";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(authorNameTxtbox);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // authorNameTxtbox
            // 
            resources.ApplyResources(authorNameTxtbox, "authorNameTxtbox");
            authorNameTxtbox.Name = "authorNameTxtbox";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 44, 65);
            panel1.Controls.Add(addAuthorsExitLabel);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // addAuthorsExitLabel
            // 
            resources.ApplyResources(addAuthorsExitLabel, "addAuthorsExitLabel");
            addAuthorsExitLabel.Cursor = Cursors.Hand;
            addAuthorsExitLabel.ForeColor = SystemColors.ControlLightLight;
            addAuthorsExitLabel.Name = "addAuthorsExitLabel";
            addAuthorsExitLabel.Click += addAuthorsExitLabel_Click;
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
            addAuthor.Click += addAuthor_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(authorSearchTxt);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // authorSearchTxt
            // 
            resources.ApplyResources(authorSearchTxt, "authorSearchTxt");
            authorSearchTxt.Name = "authorSearchTxt";
            authorSearchTxt.TextChanged += authorSearchTxt_TextChanged;
            // 
            // authorDataGridView
            // 
            authorDataGridView.AllowUserToAddRows = false;
            authorDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            authorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(authorDataGridView, "authorDataGridView");
            authorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            authorDataGridView.BackgroundColor = Color.White;
            authorDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            authorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            authorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authorDataGridView.Columns.AddRange(new DataGridViewColumn[] { AuthorName, Date, Books, ChangeBtn, delBtn, showBooks });
            authorDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            authorDataGridView.MultiSelect = false;
            authorDataGridView.Name = "authorDataGridView";
            authorDataGridView.ReadOnly = true;
            authorDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            authorDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            authorDataGridView.RowTemplate.ReadOnly = true;
            authorDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            authorDataGridView.ShowEditingIcon = false;
            authorDataGridView.CellContentClick += authorDataGridView_CellContentClick;
            // 
            // AuthorName
            // 
            AuthorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AuthorName.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(AuthorName, "AuthorName");
            AuthorName.Name = "AuthorName";
            AuthorName.ReadOnly = true;
            // 
            // Date
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Date.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(Date, "Date");
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Books
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Books.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(Books, "Books");
            Books.Name = "Books";
            Books.ReadOnly = true;
            Books.Resizable = DataGridViewTriState.True;
            Books.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ChangeBtn
            // 
            resources.ApplyResources(ChangeBtn, "ChangeBtn");
            ChangeBtn.Image = (Image)resources.GetObject("ChangeBtn.Image");
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.ReadOnly = true;
            ChangeBtn.Resizable = DataGridViewTriState.True;
            // 
            // delBtn
            // 
            resources.ApplyResources(delBtn, "delBtn");
            delBtn.Image = (Image)resources.GetObject("delBtn.Image");
            delBtn.Name = "delBtn";
            delBtn.ReadOnly = true;
            delBtn.Resizable = DataGridViewTriState.True;
            // 
            // showBooks
            // 
            resources.ApplyResources(showBooks, "showBooks");
            showBooks.Image = (Image)resources.GetObject("showBooks.Image");
            showBooks.Name = "showBooks";
            showBooks.ReadOnly = true;
            showBooks.Resizable = DataGridViewTriState.True;
            showBooks.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // booksPanel
            // 
            booksPanel.BackColor = Color.FromArgb(28, 170, 93);
            booksPanel.Controls.Add(addBookPanel);
            booksPanel.Controls.Add(booksExportBtn);
            booksPanel.Controls.Add(booksAddBtn);
            booksPanel.Controls.Add(groupBox19);
            booksPanel.Controls.Add(booksDataGridView);
            resources.ApplyResources(booksPanel, "booksPanel");
            booksPanel.Name = "booksPanel";
            // 
            // addBookPanel
            // 
            addBookPanel.BorderStyle = BorderStyle.FixedSingle;
            addBookPanel.Controls.Add(groupBox10);
            addBookPanel.Controls.Add(panel4);
            resources.ApplyResources(addBookPanel, "addBookPanel");
            addBookPanel.Name = "addBookPanel";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(groupBox13);
            groupBox10.Controls.Add(button1);
            groupBox10.Controls.Add(button2);
            groupBox10.Controls.Add(groupBox11);
            groupBox10.Controls.Add(groupBox12);
            resources.ApplyResources(groupBox10, "groupBox10");
            groupBox10.Name = "groupBox10";
            groupBox10.TabStop = false;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(newBookAuthorComboBox);
            resources.ApplyResources(groupBox13, "groupBox13");
            groupBox13.Name = "groupBox13";
            groupBox13.TabStop = false;
            // 
            // newBookAuthorComboBox
            // 
            newBookAuthorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            newBookAuthorComboBox.FormattingEnabled = true;
            resources.ApplyResources(newBookAuthorComboBox, "newBookAuthorComboBox");
            newBookAuthorComboBox.Name = "newBookAuthorComboBox";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 44, 65);
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 44, 65);
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(newBookGenreCombobox);
            resources.ApplyResources(groupBox11, "groupBox11");
            groupBox11.Name = "groupBox11";
            groupBox11.TabStop = false;
            // 
            // newBookGenreCombobox
            // 
            newBookGenreCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            newBookGenreCombobox.FormattingEnabled = true;
            resources.ApplyResources(newBookGenreCombobox, "newBookGenreCombobox");
            newBookGenreCombobox.Name = "newBookGenreCombobox";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(newBookNameTxt);
            resources.ApplyResources(groupBox12, "groupBox12");
            groupBox12.Name = "groupBox12";
            groupBox12.TabStop = false;
            // 
            // newBookNameTxt
            // 
            resources.ApplyResources(newBookNameTxt, "newBookNameTxt");
            newBookNameTxt.Name = "newBookNameTxt";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 44, 65);
            panel4.Controls.Add(label2);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // booksExportBtn
            // 
            resources.ApplyResources(booksExportBtn, "booksExportBtn");
            booksExportBtn.Name = "booksExportBtn";
            booksExportBtn.TabStop = false;
            // 
            // booksAddBtn
            // 
            resources.ApplyResources(booksAddBtn, "booksAddBtn");
            booksAddBtn.Name = "booksAddBtn";
            booksAddBtn.TabStop = false;
            booksAddBtn.Click += booksAddBtn_Click;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(booksSearchTxt);
            groupBox19.ForeColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(groupBox19, "groupBox19");
            groupBox19.Name = "groupBox19";
            groupBox19.TabStop = false;
            // 
            // booksSearchTxt
            // 
            resources.ApplyResources(booksSearchTxt, "booksSearchTxt");
            booksSearchTxt.Name = "booksSearchTxt";
            // 
            // booksDataGridView
            // 
            booksDataGridView.AllowUserToAddRows = false;
            booksDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 192, 128);
            booksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(booksDataGridView, "booksDataGridView");
            booksDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            booksDataGridView.BackgroundColor = Color.White;
            booksDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            booksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            booksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGridView.Columns.AddRange(new DataGridViewColumn[] { bookTitle, bookGenre, bookAuthor, bookEditBtn, bookDelete });
            booksDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            booksDataGridView.MultiSelect = false;
            booksDataGridView.Name = "booksDataGridView";
            booksDataGridView.ReadOnly = true;
            booksDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            booksDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            booksDataGridView.RowTemplate.ReadOnly = true;
            booksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            booksDataGridView.ShowEditingIcon = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bookTitle.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(bookTitle, "bookTitle");
            bookTitle.Name = "bookTitle";
            bookTitle.ReadOnly = true;
            // 
            // bookGenre
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bookGenre.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(bookGenre, "bookGenre");
            bookGenre.Name = "bookGenre";
            bookGenre.ReadOnly = true;
            // 
            // bookAuthor
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bookAuthor.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(bookAuthor, "bookAuthor");
            bookAuthor.Name = "bookAuthor";
            bookAuthor.ReadOnly = true;
            bookAuthor.Resizable = DataGridViewTriState.True;
            bookAuthor.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // bookEditBtn
            // 
            resources.ApplyResources(bookEditBtn, "bookEditBtn");
            bookEditBtn.Image = (Image)resources.GetObject("bookEditBtn.Image");
            bookEditBtn.Name = "bookEditBtn";
            bookEditBtn.ReadOnly = true;
            bookEditBtn.Resizable = DataGridViewTriState.True;
            // 
            // bookDelete
            // 
            resources.ApplyResources(bookDelete, "bookDelete");
            bookDelete.Image = (Image)resources.GetObject("bookDelete.Image");
            bookDelete.Name = "bookDelete";
            bookDelete.ReadOnly = true;
            bookDelete.Resizable = DataGridViewTriState.True;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(booksPanel);
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
            authorEditPanel.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            addAuthorPanel.ResumeLayout(false);
            addAuthorGroupBox.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)detailedSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)exportAuthors).EndInit();
            ((System.ComponentModel.ISupportInitialize)addAuthor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)authorDataGridView).EndInit();
            booksPanel.ResumeLayout(false);
            addBookPanel.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox13.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)booksExportBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksAddBtn).EndInit();
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).EndInit();
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
        private DataGridView authorDataGridView;
        private TextBox authorSearchTxt;
        private GroupBox groupBox1;
        private PictureBox addAuthor;
        private PictureBox exportAuthors;
        private PictureBox detailedSearch;
        private DataGridViewTextBoxColumn AuthorName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Books;
        private DataGridViewImageColumn ChangeBtn;
        private DataGridViewImageColumn delBtn;
        private DataGridViewImageColumn showBooks;
        private Panel addAuthorPanel;
        private Panel panel1;
        private Label addAuthorsExitLabel;
        private GroupBox addAuthorGroupBox;
        private GroupBox groupBox3;
        private TextBox authorNameTxtbox;
        private Button addAuhtorCancelBtn;
        private Button addAuthorSaveBtn;
        private GroupBox groupBox4;
        private DateTimePicker authorBirtDatePicker;
        private Panel authorEditPanel;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private DateTimePicker authorEditNewDate;
        private GroupBox groupBox9;
        private TextBox authorEditNewName;
        private Button authorEditSave;
        private Button authorEditCancel;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private DateTimePicker authorEditOriginalDate;
        private GroupBox groupBox6;
        private TextBox authorEditOriginalName;
        private Panel panel3;
        private Label authorEditExit;
        private Panel booksPanel;
        private PictureBox booksExportBtn;
        private PictureBox booksAddBtn;
        private GroupBox groupBox19;
        private TextBox booksSearchTxt;
        private DataGridView booksDataGridView;
        private DataGridViewTextBoxColumn bookTitle;
        private DataGridViewTextBoxColumn bookGenre;
        private DataGridViewTextBoxColumn bookAuthor;
        private DataGridViewImageColumn bookEditBtn;
        private DataGridViewImageColumn bookDelete;
        private Panel addBookPanel;
        private GroupBox groupBox10;
        private Button button1;
        private Button button2;
        private GroupBox groupBox11;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox12;
        private TextBox newBookNameTxt;
        private Panel panel4;
        private Label label2;
        private GroupBox groupBox13;
        private ComboBox newBookAuthorComboBox;
        private ComboBox newBookGenreCombobox;
    }
}
