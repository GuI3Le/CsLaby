namespace Lab4a
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
            label1 = new Label();
            label2 = new Label();
            inputTextBox = new TextBox();
            label3 = new Label();
            outputTextBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            convertButton = new Button();
            browseButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 12);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "CSV to HTML converter";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 84);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Path to csv file";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(189, 80);
            inputTextBox.Margin = new Padding(3, 4, 3, 4);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(637, 27);
            inputTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 145);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 3;
            label3.Text = "Path to html file";
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(189, 141);
            outputTextBox.Margin = new Padding(3, 4, 3, 4);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(637, 27);
            outputTextBox.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // convertButton
            // 
            convertButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            convertButton.Location = new Point(423, 297);
            convertButton.Margin = new Padding(3, 4, 3, 4);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(178, 89);
            convertButton.TabIndex = 5;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += ConvertButtonClick;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(833, 80);
            browseButton.Margin = new Padding(3, 4, 3, 4);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(93, 31);
            browseButton.TabIndex = 7;
            browseButton.Text = "Browse files";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += BrowseButtonClick;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(833, 141);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(93, 31);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save file";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 600);
            Controls.Add(saveButton);
            Controls.Add(browseButton);
            Controls.Add(convertButton);
            Controls.Add(outputTextBox);
            Controls.Add(label3);
            Controls.Add(inputTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "CSV to HTML converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inputTextBox;
        private Label label3;
        private TextBox outputTextBox;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button convertButton;
        private Button browseButton;
        private Button saveButton;
    }
}
