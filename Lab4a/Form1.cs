using System.Windows.Forms;
using Lab1Core;

namespace Lab4a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string solutionFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\");
                openFileDialog.InitialDirectory = Path.GetFullPath(solutionFile);
                openFileDialog.Filter=@"CSV files |*.csv|All files |*.*";
                openFileDialog.Title = @"Select CSV file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string csvFilePath = openFileDialog.FileName;
                    inputTextBox.Text = csvFilePath;
                }
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string solutionFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\");
                saveFileDialog.InitialDirectory = Path.GetFullPath(solutionFile);
                saveFileDialog.Filter = @"HTML files |*.html|All files |*.*";
                saveFileDialog.Title = @"Select HTML file";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string htmlFilePath = saveFileDialog.FileName;
                    outputTextBox.Text = htmlFilePath;
                }

            }
        }

        private void ConvertButtonClick(object sender, EventArgs e)
        {
            string inputFile = inputTextBox.Text;
            string outputFile = outputTextBox.Text;
            if (File.Exists(inputFile))
            {
                Converter.CsvToHtml.Convert(inputFile, outputFile);
            }
        }

    }
}
