using System.Windows.Forms;

namespace Lab4a2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BrowseButtonClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = @"Select starting folder containing JPG photos";
                string solutionFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\");
                folderBrowserDialog.InitialDirectory = Path.GetFullPath(solutionFile);
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;
                    inputTextBox.Text = selectedFolder;
                    // string[] photos = Directory.GetFiles(selectedFolder, "*.jpg");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }


}
