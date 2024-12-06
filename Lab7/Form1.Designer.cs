namespace Lab7
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
            calculateButton = new Button();
            matrixProgressBar = new ProgressBar();
            matrixBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            rowANumericUpDown = new NumericUpDown();
            rowBNumericUpDown = new NumericUpDown();
            colBNumericUpDown = new NumericUpDown();
            colANumericUpDown = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rowANumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rowBNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colBNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colANumericUpDown).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            calculateButton.Location = new Point(3, 18);
            calculateButton.Margin = new Padding(3, 4, 3, 4);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(130, 31);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += CalculateButtonClick;
            // 
            // matrixProgressBar
            // 
            matrixProgressBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            matrixProgressBar.Location = new Point(139, 19);
            matrixProgressBar.Name = "matrixProgressBar";
            matrixProgressBar.Size = new Size(766, 29);
            matrixProgressBar.TabIndex = 3;
            // 
            // matrixBackgroundWorker
            // 
            matrixBackgroundWorker.WorkerReportsProgress = true;
            matrixBackgroundWorker.WorkerSupportsCancellation = true;
            matrixBackgroundWorker.DoWork += matrixBackgroundWorker_DoWork;
            matrixBackgroundWorker.ProgressChanged += matrixBackgroundWorker_ProgressChanged;
            matrixBackgroundWorker.RunWorkerCompleted += matrixBackgroundWorker_ProgressComplete;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(rowANumericUpDown, 1, 0);
            tableLayoutPanel1.Controls.Add(rowBNumericUpDown, 3, 0);
            tableLayoutPanel1.Controls.Add(colBNumericUpDown, 3, 1);
            tableLayoutPanel1.Controls.Add(colANumericUpDown, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 114);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(908, 407);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(3, 60);
            label1.Name = "label1";
            label1.Size = new Size(175, 82);
            label1.TabIndex = 9;
            label1.Text = "number of rows";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(456, 60);
            label2.Name = "label2";
            label2.Size = new Size(175, 82);
            label2.TabIndex = 10;
            label2.Text = "number of rows";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(456, 264);
            label5.Name = "label5";
            label5.Size = new Size(175, 82);
            label5.TabIndex = 11;
            label5.Text = "number of columns";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(3, 264);
            label6.Name = "label6";
            label6.Size = new Size(175, 82);
            label6.TabIndex = 12;
            label6.Text = "number of columns";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rowANumericUpDown
            // 
            rowANumericUpDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowANumericUpDown.Font = new Font("Segoe UI", 18F);
            rowANumericUpDown.Location = new Point(184, 78);
            rowANumericUpDown.Margin = new Padding(3, 5, 3, 5);
            rowANumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            rowANumericUpDown.Name = "rowANumericUpDown";
            rowANumericUpDown.Size = new Size(266, 47);
            rowANumericUpDown.TabIndex = 13;
            // 
            // rowBNumericUpDown
            // 
            rowBNumericUpDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rowBNumericUpDown.Font = new Font("Segoe UI", 18F);
            rowBNumericUpDown.Location = new Point(637, 78);
            rowBNumericUpDown.Margin = new Padding(3, 5, 3, 5);
            rowBNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            rowBNumericUpDown.Name = "rowBNumericUpDown";
            rowBNumericUpDown.Size = new Size(268, 47);
            rowBNumericUpDown.TabIndex = 14;
            // 
            // colBNumericUpDown
            // 
            colBNumericUpDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            colBNumericUpDown.Font = new Font("Segoe UI", 18F);
            colBNumericUpDown.Location = new Point(637, 281);
            colBNumericUpDown.Margin = new Padding(3, 5, 3, 5);
            colBNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            colBNumericUpDown.Name = "colBNumericUpDown";
            colBNumericUpDown.Size = new Size(268, 47);
            colBNumericUpDown.TabIndex = 15;
            // 
            // colANumericUpDown
            // 
            colANumericUpDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            colANumericUpDown.Font = new Font("Segoe UI", 18F);
            colANumericUpDown.Location = new Point(184, 281);
            colANumericUpDown.Margin = new Padding(3, 5, 3, 5);
            colANumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            colANumericUpDown.Name = "colANumericUpDown";
            colANumericUpDown.Size = new Size(266, 47);
            colANumericUpDown.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(457, 24);
            label4.Name = "label4";
            label4.Size = new Size(448, 54);
            label4.TabIndex = 1;
            label4.Text = "matrix B";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(448, 54);
            label3.TabIndex = 0;
            label3.Text = "matrix A";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(908, 102);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 415F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.Size = new Size(914, 600);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9874058F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.0125961F));
            tableLayoutPanel4.Controls.Add(matrixProgressBar, 1, 0);
            tableLayoutPanel4.Controls.Add(calculateButton, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 529);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(908, 67);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Matrix multiplication";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rowANumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rowBNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)colBNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)colANumericUpDown).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button calculateButton;
        private ProgressBar matrixProgressBar;
        private System.ComponentModel.BackgroundWorker matrixBackgroundWorker;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericUpDown rowANumericUpDown;
        private NumericUpDown rowBNumericUpDown;
        private NumericUpDown colBNumericUpDown;
        private NumericUpDown colANumericUpDown;
    }
}
