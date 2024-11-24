namespace Lab6a
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
            currentDateLabel = new Label();
            currentTimeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // currentDateLabel
            // 
            currentDateLabel.Anchor = AnchorStyles.None;
            currentDateLabel.AutoSize = true;
            currentDateLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentDateLabel.Location = new Point(294, 48);
            currentDateLabel.Name = "currentDateLabel";
            currentDateLabel.Size = new Size(211, 128);
            currentDateLabel.TabIndex = 0;
            currentDateLabel.Text = "test";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.Anchor = AnchorStyles.None;
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentTimeLabel.Location = new Point(294, 273);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(211, 128);
            currentTimeLabel.TabIndex = 1;
            currentTimeLabel.Text = "test";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += TimerTick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(currentTimeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(currentDateLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Timer";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label currentDateLabel;
        private Label currentTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
