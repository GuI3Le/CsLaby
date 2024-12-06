using System.ComponentModel;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            matrixBackgroundWorker.RunWorkerAsync();

        }

        private void matrixBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int rowANumber = int.Parse(rowANumericUpDown.Text);
            int colANumber = int.Parse(colANumericUpDown.Text);
            int rowBNumber = int.Parse(rowBNumericUpDown.Text);
            int colBNumber = int.Parse(colBNumericUpDown.Text);
            int[,] matrixA = new int[rowANumber, colANumber];
            int[,] matrixB = new int[rowBNumber, colBNumber];
            for (int i = 0; i < rowANumber; i++)
            {
                for (int j = 0; j < colANumber; j++)
                {
                    matrixA[i, j] = rnd.Next(1,1000);
                    //matrixB[i, j] = rnd.Next(1, 10);
                }
            }
            for (int i = 0; i < rowBNumber; i++)
            {
                for (int j = 0; j < colBNumber; j++)
                {
                    matrixB[i, j] = rnd.Next(1000);
                    //matrixB[i, j] = rnd.Next(1, 10);
                }
            }
            int[,] matrixC = new int[rowANumber, colBNumber];
            int percentComplete = 0;
            int highestPercentReached = 0;
            for (int i = 0; i < rowANumber; i++)
            {
                for (int j = 0; j < colBNumber; j++)
                {
                    for (int k = 0; k < colANumber; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }


                    percentComplete = (int)((i + 1) * (j + 1) / (float)rowANumber / (float)colBNumber * 100);
                    if (percentComplete > highestPercentReached)
                    {
                        highestPercentReached = percentComplete;
                        matrixBackgroundWorker.ReportProgress(percentComplete);

                    }
                }

                

            }

        }

        private void matrixBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.matrixProgressBar.Value = e.ProgressPercentage;
        }

        private void matrixBackgroundWorker_ProgressComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Matrix has been calculated", "Calculation ended successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
