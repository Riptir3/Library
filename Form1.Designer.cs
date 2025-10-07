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
            HeaderPanel = new Panel();
            label1 = new Label();
            exitLabel = new Label();
            minLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            homeBtn = new Button();
            authorsBtn = new Button();
            booksBtn = new Button();
            statBtn = new Button();
            HeaderPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(HeaderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.75D;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
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
    }
}
