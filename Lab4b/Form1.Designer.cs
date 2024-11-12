namespace Lab4b
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
            tableLayoutPanel1 = new TableLayoutPanel();
            equalButton = new Button();
            commaButton = new Button();
            value0Button = new Button();
            negateButton = new Button();
            plusButton = new Button();
            value3Button = new Button();
            value2Button = new Button();
            value1Button = new Button();
            minusButton = new Button();
            value6Button = new Button();
            value5Button = new Button();
            value4Button = new Button();
            mulButton = new Button();
            value9Button = new Button();
            value8Button = new Button();
            value7Button = new Button();
            divButton = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            delButton = new Button();
            cButton = new Button();
            ceButton = new Button();
            percentButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button29 = new Button();
            button28 = new Button();
            button27 = new Button();
            button26 = new Button();
            button25 = new Button();
            inputTextBox = new TextBox();
            operationTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(equalButton, 3, 5);
            tableLayoutPanel1.Controls.Add(commaButton, 2, 5);
            tableLayoutPanel1.Controls.Add(value0Button, 1, 5);
            tableLayoutPanel1.Controls.Add(negateButton, 0, 5);
            tableLayoutPanel1.Controls.Add(plusButton, 3, 4);
            tableLayoutPanel1.Controls.Add(value3Button, 2, 4);
            tableLayoutPanel1.Controls.Add(value2Button, 1, 4);
            tableLayoutPanel1.Controls.Add(value1Button, 0, 4);
            tableLayoutPanel1.Controls.Add(minusButton, 3, 3);
            tableLayoutPanel1.Controls.Add(value6Button, 2, 3);
            tableLayoutPanel1.Controls.Add(value5Button, 1, 3);
            tableLayoutPanel1.Controls.Add(value4Button, 0, 3);
            tableLayoutPanel1.Controls.Add(mulButton, 3, 2);
            tableLayoutPanel1.Controls.Add(value9Button, 2, 2);
            tableLayoutPanel1.Controls.Add(value8Button, 1, 2);
            tableLayoutPanel1.Controls.Add(value7Button, 0, 2);
            tableLayoutPanel1.Controls.Add(divButton, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(delButton, 3, 0);
            tableLayoutPanel1.Controls.Add(cButton, 2, 0);
            tableLayoutPanel1.Controls.Add(ceButton, 1, 0);
            tableLayoutPanel1.Controls.Add(percentButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 107);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(322, 336);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // equalButton
            // 
            equalButton.AutoSize = true;
            equalButton.BackColor = Color.FromArgb(255, 128, 0);
            equalButton.Dock = DockStyle.Fill;
            equalButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            equalButton.Location = new Point(243, 283);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(76, 50);
            equalButton.TabIndex = 23;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += OperationButtonClicked;
            // 
            // commaButton
            // 
            commaButton.AutoSize = true;
            commaButton.Dock = DockStyle.Fill;
            commaButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            commaButton.Location = new Point(163, 283);
            commaButton.Name = "commaButton";
            commaButton.Size = new Size(74, 50);
            commaButton.TabIndex = 22;
            commaButton.Text = ",";
            commaButton.UseVisualStyleBackColor = true;
            commaButton.Click += OperationButtonClicked;
            // 
            // value0Button
            // 
            value0Button.AutoSize = true;
            value0Button.Dock = DockStyle.Fill;
            value0Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value0Button.Location = new Point(83, 283);
            value0Button.Name = "value0Button";
            value0Button.Size = new Size(74, 50);
            value0Button.TabIndex = 21;
            value0Button.Text = "0";
            value0Button.UseVisualStyleBackColor = true;
            value0Button.Click += NumButtonClicked;
            // 
            // negateButton
            // 
            negateButton.AutoSize = true;
            negateButton.Dock = DockStyle.Fill;
            negateButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            negateButton.Location = new Point(3, 283);
            negateButton.Name = "negateButton";
            negateButton.Size = new Size(74, 50);
            negateButton.TabIndex = 20;
            negateButton.Text = "+/-";
            negateButton.UseVisualStyleBackColor = true;
            negateButton.Click += OperationButtonClicked;
            // 
            // plusButton
            // 
            plusButton.AutoSize = true;
            plusButton.Dock = DockStyle.Fill;
            plusButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            plusButton.Location = new Point(243, 227);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(76, 50);
            plusButton.TabIndex = 19;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += OperationButtonClicked;
            // 
            // value3Button
            // 
            value3Button.AutoSize = true;
            value3Button.Dock = DockStyle.Fill;
            value3Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value3Button.Location = new Point(163, 227);
            value3Button.Name = "value3Button";
            value3Button.Size = new Size(74, 50);
            value3Button.TabIndex = 18;
            value3Button.Text = "3";
            value3Button.UseVisualStyleBackColor = true;
            value3Button.Click += NumButtonClicked;
            // 
            // value2Button
            // 
            value2Button.AutoSize = true;
            value2Button.Dock = DockStyle.Fill;
            value2Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value2Button.Location = new Point(83, 227);
            value2Button.Name = "value2Button";
            value2Button.Size = new Size(74, 50);
            value2Button.TabIndex = 17;
            value2Button.Text = "2";
            value2Button.UseVisualStyleBackColor = true;
            value2Button.Click += NumButtonClicked;
            // 
            // value1Button
            // 
            value1Button.AutoSize = true;
            value1Button.Dock = DockStyle.Fill;
            value1Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value1Button.Location = new Point(3, 227);
            value1Button.Name = "value1Button";
            value1Button.Size = new Size(74, 50);
            value1Button.TabIndex = 16;
            value1Button.Text = "1";
            value1Button.UseVisualStyleBackColor = true;
            value1Button.Click += NumButtonClicked;
            // 
            // minusButton
            // 
            minusButton.AutoSize = true;
            minusButton.Dock = DockStyle.Fill;
            minusButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            minusButton.Location = new Point(243, 171);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(76, 50);
            minusButton.TabIndex = 15;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += OperationButtonClicked;
            // 
            // value6Button
            // 
            value6Button.AutoSize = true;
            value6Button.Dock = DockStyle.Fill;
            value6Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value6Button.Location = new Point(163, 171);
            value6Button.Name = "value6Button";
            value6Button.Size = new Size(74, 50);
            value6Button.TabIndex = 14;
            value6Button.Text = "6";
            value6Button.UseVisualStyleBackColor = true;
            value6Button.Click += NumButtonClicked;
            // 
            // value5Button
            // 
            value5Button.AutoSize = true;
            value5Button.Dock = DockStyle.Fill;
            value5Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value5Button.Location = new Point(83, 171);
            value5Button.Name = "value5Button";
            value5Button.Size = new Size(74, 50);
            value5Button.TabIndex = 13;
            value5Button.Text = "5";
            value5Button.UseVisualStyleBackColor = true;
            value5Button.Click += NumButtonClicked;
            // 
            // value4Button
            // 
            value4Button.AutoSize = true;
            value4Button.Dock = DockStyle.Fill;
            value4Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value4Button.Location = new Point(3, 171);
            value4Button.Name = "value4Button";
            value4Button.Size = new Size(74, 50);
            value4Button.TabIndex = 12;
            value4Button.Text = "4";
            value4Button.UseVisualStyleBackColor = true;
            value4Button.Click += NumButtonClicked;
            // 
            // mulButton
            // 
            mulButton.AutoSize = true;
            mulButton.Dock = DockStyle.Fill;
            mulButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            mulButton.Location = new Point(243, 115);
            mulButton.Name = "mulButton";
            mulButton.Size = new Size(76, 50);
            mulButton.TabIndex = 11;
            mulButton.Text = "*";
            mulButton.UseVisualStyleBackColor = true;
            mulButton.Click += OperationButtonClicked;
            // 
            // value9Button
            // 
            value9Button.AutoSize = true;
            value9Button.Dock = DockStyle.Fill;
            value9Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value9Button.Location = new Point(163, 115);
            value9Button.Name = "value9Button";
            value9Button.Size = new Size(74, 50);
            value9Button.TabIndex = 10;
            value9Button.Text = "9";
            value9Button.UseVisualStyleBackColor = true;
            value9Button.Click += NumButtonClicked;
            // 
            // value8Button
            // 
            value8Button.AutoSize = true;
            value8Button.Dock = DockStyle.Fill;
            value8Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value8Button.Location = new Point(83, 115);
            value8Button.Name = "value8Button";
            value8Button.Size = new Size(74, 50);
            value8Button.TabIndex = 9;
            value8Button.Text = "8";
            value8Button.UseVisualStyleBackColor = true;
            value8Button.Click += NumButtonClicked;
            // 
            // value7Button
            // 
            value7Button.AutoSize = true;
            value7Button.Dock = DockStyle.Fill;
            value7Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            value7Button.Location = new Point(3, 115);
            value7Button.Name = "value7Button";
            value7Button.Size = new Size(74, 50);
            value7Button.TabIndex = 8;
            value7Button.Text = "7";
            value7Button.UseVisualStyleBackColor = true;
            value7Button.Click += NumButtonClicked;
            // 
            // divButton
            // 
            divButton.AutoSize = true;
            divButton.Dock = DockStyle.Fill;
            divButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            divButton.Location = new Point(243, 59);
            divButton.Name = "divButton";
            divButton.Size = new Size(76, 50);
            divButton.TabIndex = 7;
            divButton.Text = "/";
            divButton.UseVisualStyleBackColor = true;
            divButton.Click += OperationButtonClicked;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button7.Location = new Point(163, 59);
            button7.Name = "button7";
            button7.Size = new Size(74, 50);
            button7.TabIndex = 6;
            button7.Text = "√x";
            button7.UseVisualStyleBackColor = true;
            button7.Click += OperationButtonClicked;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button6.Location = new Point(83, 59);
            button6.Name = "button6";
            button6.Size = new Size(74, 50);
            button6.TabIndex = 5;
            button6.Text = "x²";
            button6.UseVisualStyleBackColor = true;
            button6.Click += OperationButtonClicked;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button5.Location = new Point(3, 59);
            button5.Name = "button5";
            button5.Size = new Size(74, 50);
            button5.TabIndex = 4;
            button5.Text = "1/x";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OperationButtonClicked;
            // 
            // delButton
            // 
            delButton.AutoSize = true;
            delButton.Dock = DockStyle.Fill;
            delButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            delButton.Location = new Point(243, 3);
            delButton.Name = "delButton";
            delButton.Size = new Size(76, 50);
            delButton.TabIndex = 3;
            delButton.Text = "⌫";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += OperationButtonClicked;
            // 
            // cButton
            // 
            cButton.AutoSize = true;
            cButton.Dock = DockStyle.Fill;
            cButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cButton.Location = new Point(163, 3);
            cButton.Name = "cButton";
            cButton.Size = new Size(74, 50);
            cButton.TabIndex = 2;
            cButton.Text = "C";
            cButton.UseVisualStyleBackColor = true;
            cButton.Click += OperationButtonClicked;
            // 
            // ceButton
            // 
            ceButton.AutoSize = true;
            ceButton.Dock = DockStyle.Fill;
            ceButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ceButton.Location = new Point(83, 3);
            ceButton.Name = "ceButton";
            ceButton.Size = new Size(74, 50);
            ceButton.TabIndex = 1;
            ceButton.Text = "CE";
            ceButton.UseVisualStyleBackColor = true;
            ceButton.Click += OperationButtonClicked;
            // 
            // percentButton
            // 
            percentButton.AutoSize = true;
            percentButton.Dock = DockStyle.Fill;
            percentButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            percentButton.Location = new Point(3, 3);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(74, 50);
            percentButton.TabIndex = 0;
            percentButton.Text = "%";
            percentButton.UseVisualStyleBackColor = true;
            percentButton.Click += OperationButtonClicked;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(button29, 4, 0);
            tableLayoutPanel2.Controls.Add(button28, 3, 0);
            tableLayoutPanel2.Controls.Add(button27, 2, 0);
            tableLayoutPanel2.Controls.Add(button26, 1, 0);
            tableLayoutPanel2.Controls.Add(button25, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 76);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(322, 31);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // button29
            // 
            button29.AutoSize = true;
            button29.Dock = DockStyle.Fill;
            button29.Location = new Point(259, 3);
            button29.Name = "button29";
            button29.Size = new Size(60, 25);
            button29.TabIndex = 4;
            button29.Text = "MS";
            button29.UseVisualStyleBackColor = true;
            button29.Click += MemoryButtonClicked;
            // 
            // button28
            // 
            button28.AutoSize = true;
            button28.Dock = DockStyle.Fill;
            button28.Location = new Point(195, 3);
            button28.Name = "button28";
            button28.Size = new Size(58, 25);
            button28.TabIndex = 3;
            button28.Text = "M-";
            button28.UseVisualStyleBackColor = true;
            button28.Click += MemoryButtonClicked;
            // 
            // button27
            // 
            button27.AutoSize = true;
            button27.Dock = DockStyle.Fill;
            button27.Location = new Point(131, 3);
            button27.Name = "button27";
            button27.Size = new Size(58, 25);
            button27.TabIndex = 2;
            button27.Text = "M+";
            button27.UseVisualStyleBackColor = true;
            button27.Click += MemoryButtonClicked;
            // 
            // button26
            // 
            button26.AutoSize = true;
            button26.Dock = DockStyle.Fill;
            button26.Location = new Point(67, 3);
            button26.Name = "button26";
            button26.Size = new Size(58, 25);
            button26.TabIndex = 1;
            button26.Text = "MR";
            button26.UseVisualStyleBackColor = true;
            button26.Click += MemoryButtonClicked;
            // 
            // button25
            // 
            button25.AutoSize = true;
            button25.Dock = DockStyle.Fill;
            button25.Location = new Point(3, 3);
            button25.Name = "button25";
            button25.Size = new Size(58, 25);
            button25.TabIndex = 0;
            button25.Text = "MC";
            button25.UseVisualStyleBackColor = true;
            button25.Click += MemoryButtonClicked;
            // 
            // inputTextBox
            // 
            inputTextBox.BackColor = SystemColors.Window;
            inputTextBox.BorderStyle = BorderStyle.FixedSingle;
            inputTextBox.Dock = DockStyle.Bottom;
            inputTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            inputTextBox.Location = new Point(0, 33);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ReadOnly = true;
            inputTextBox.Size = new Size(322, 43);
            inputTextBox.TabIndex = 3;
            inputTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // operationTextBox
            // 
            operationTextBox.BorderStyle = BorderStyle.FixedSingle;
            operationTextBox.Dock = DockStyle.Bottom;
            operationTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            operationTextBox.Location = new Point(0, 0);
            operationTextBox.Name = "operationTextBox";
            operationTextBox.Size = new Size(322, 33);
            operationTextBox.TabIndex = 4;
            operationTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 443);
            Controls.Add(operationTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button equalButton;
        private Button commaButton;
        private Button value0Button;
        private Button negateButton;
        private Button plusButton;
        private Button value3Button;
        private Button value2Button;
        private Button value1Button;
        private Button minusButton;
        private Button value6Button;
        private Button value5Button;
        private Button value4Button;
        private Button mulButton;
        private Button value9Button;
        private Button value8Button;
        private Button value7Button;
        private Button divButton;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button delButton;
        private Button cButton;
        private Button ceButton;
        private Button percentButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button29;
        private Button button28;
        private Button button27;
        private Button button26;
        private Button button25;
        private TextBox inputTextBox;
        private TextBox operationTextBox;
    }
}
