namespace Lab4a2
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
            inputTextBox = new TextBox();
            browseInputButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            outputTextBox = new TextBox();
            label2 = new Label();
            browseOutputButton = new Button();
            folderBrowserDialog2 = new FolderBrowserDialog();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 69);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Input folder";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(155, 66);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(374, 23);
            inputTextBox.TabIndex = 1;
            // 
            // browseInputButton
            // 
            browseInputButton.Location = new Point(535, 66);
            browseInputButton.Name = "browseInputButton";
            browseInputButton.Size = new Size(75, 23);
            browseInputButton.TabIndex = 2;
            browseInputButton.Text = "Browse";
            browseInputButton.UseVisualStyleBackColor = true;
            browseInputButton.Click += BrowseButtonClick;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(155, 119);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(374, 23);
            outputTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 122);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Output folder";
            // 
            // browseOutputButton
            // 
            browseOutputButton.Location = new Point(535, 119);
            browseOutputButton.Name = "browseOutputButton";
            browseOutputButton.Size = new Size(75, 23);
            browseOutputButton.TabIndex = 5;
            browseOutputButton.Text = "Browse";
            browseOutputButton.UseVisualStyleBackColor = true;
            browseOutputButton.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(286, 9);
            label3.Name = "label3";
            label3.Size = new Size(175, 37);
            label3.TabIndex = 6;
            label3.Text = "Photo album";
            // 
            // button2
            // 
            button2.Location = new Point(263, 204);
            button2.Name = "button2";
            button2.Size = new Size(180, 54);
            button2.TabIndex = 7;
            button2.Text = "Copy photos";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(browseOutputButton);
            Controls.Add(outputTextBox);
            Controls.Add(label2);
            Controls.Add(browseInputButton);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Photo album";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private Button browseInputButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox outputTextBox;
        private Label label2;
        private Button browseOutputButton;
        private FolderBrowserDialog folderBrowserDialog2;
        private Label label3;
        private Button button2;
    }
}
