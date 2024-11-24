namespace Lab5
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lastnameTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            birthDateTimePicker = new DateTimePicker();
            genderComboBox = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            editButton = new Button();
            loadButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            writeToFileButton = new Button();
            readFromFileButton = new Button();
            peopleListBox = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.10722F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.89278F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(peopleListBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.381443F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.61855F));
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(lastnameTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(nameTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(birthDateTimePicker, 1, 2);
            tableLayoutPanel2.Controls.Add(genderComboBox, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(388, 525);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(64, 445);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 11;
            label3.Text = "Płeć";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 299);
            label2.Name = "label2";
            label2.Size = new Size(99, 56);
            label2.TabIndex = 9;
            label2.Text = "Data urodzenia";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 182);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 8;
            label1.Text = "Nazwisko";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lastnameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnameTextBox.Location = new Point(117, 179);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.PlaceholderText = "Nazwisko";
            lastnameTextBox.Size = new Size(268, 34);
            lastnameTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F);
            nameLabel.Location = new Point(62, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Imię";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(117, 48);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Imię";
            nameTextBox.Size = new Size(268, 34);
            nameTextBox.TabIndex = 1;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            birthDateTimePicker.Location = new Point(117, 314);
            birthDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(268, 27);
            birthDateTimePicker.TabIndex = 10;
            // 
            // genderComboBox
            // 
            genderComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Mężczyzna", "Kobieta" });
            genderComboBox.Location = new Point(117, 445);
            genderComboBox.Margin = new Padding(3, 4, 3, 4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(268, 28);
            genderComboBox.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(editButton, 3, 0);
            tableLayoutPanel3.Controls.Add(loadButton, 2, 0);
            tableLayoutPanel3.Controls.Add(deleteButton, 1, 0);
            tableLayoutPanel3.Controls.Add(addButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 535);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(388, 61);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // editButton
            // 
            editButton.Dock = DockStyle.Fill;
            editButton.Location = new Point(294, 4);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(91, 53);
            editButton.TabIndex = 3;
            editButton.Text = "Edytuj";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButtonClick;
            // 
            // loadButton
            // 
            loadButton.Dock = DockStyle.Fill;
            loadButton.Location = new Point(197, 4);
            loadButton.Margin = new Padding(3, 4, 3, 4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(91, 53);
            loadButton.TabIndex = 2;
            loadButton.Text = "Wczytaj";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += LoadButtonClick;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Location = new Point(100, 4);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(91, 53);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Usuń";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButtonClick;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 4);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(91, 53);
            addButton.TabIndex = 0;
            addButton.Text = "Dodaj";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButtonClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(writeToFileButton, 1, 0);
            tableLayoutPanel4.Controls.Add(readFromFileButton, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(397, 535);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(514, 61);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // writeToFileButton
            // 
            writeToFileButton.Dock = DockStyle.Fill;
            writeToFileButton.Location = new Point(260, 4);
            writeToFileButton.Margin = new Padding(3, 4, 3, 4);
            writeToFileButton.Name = "writeToFileButton";
            writeToFileButton.Size = new Size(251, 53);
            writeToFileButton.TabIndex = 2;
            writeToFileButton.Text = "Zapisz do pliku";
            writeToFileButton.UseVisualStyleBackColor = true;
            // 
            // readFromFileButton
            // 
            readFromFileButton.Dock = DockStyle.Fill;
            readFromFileButton.Location = new Point(3, 4);
            readFromFileButton.Margin = new Padding(3, 4, 3, 4);
            readFromFileButton.Name = "readFromFileButton";
            readFromFileButton.Size = new Size(251, 53);
            readFromFileButton.TabIndex = 1;
            readFromFileButton.Text = "Wczytaj do pliku";
            readFromFileButton.UseVisualStyleBackColor = true;
            // 
            // peopleListBox
            // 
            peopleListBox.Dock = DockStyle.Fill;
            peopleListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            peopleListBox.FormattingEnabled = true;
            peopleListBox.ItemHeight = 32;
            peopleListBox.Location = new Point(397, 4);
            peopleListBox.Margin = new Padding(3, 4, 3, 4);
            peopleListBox.Name = "peopleListBox";
            peopleListBox.Size = new Size(514, 523);
            peopleListBox.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button editButton;
        private Button loadButton;
        private Button deleteButton;
        private Button addButton;
        private Button writeToFileButton;
        private Button readFromFileButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox lastnameTextBox;
        private DateTimePicker birthDateTimePicker;
        private ComboBox genderComboBox;
        private ContextMenuStrip contextMenuStrip1;
        private ListBox peopleListBox;
    }
}
