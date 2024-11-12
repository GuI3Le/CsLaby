using System.Windows.Forms;

namespace Lab4a2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BrowseInputButtonClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = @"Select starting folder containing JPG photos";
                string solutionFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\");
                folderBrowserDialog.InitialDirectory = Path.GetFullPath(solutionFile);
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    inputTextBox.Text = folderBrowserDialog.SelectedPath;
                    // string[] photos = Directory.GetFiles(selectedFolder, "*.jpg");
                }
            }
        }

        private void BrowseOutputButtonClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog outputFolderBrowserDialog = new FolderBrowserDialog())
            {
                outputFolderBrowserDialog.Description = @"Select folder to copy photos";
                string solutionFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\");
                outputFolderBrowserDialog.InitialDirectory = Path.GetFullPath(solutionFile);
                if (outputFolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    outputTextBox.Text = outputFolderBrowserDialog.SelectedPath;
                }
            }
        }

        private static string resultFolderPath = "";
        private const string EXTENSION = ".jpg";


        private static void ProcessFile(string path)
        {
            string date = File.GetCreationTime(path).ToString("yyyyMMddHHmmss");
            string sourceDir = Path.GetDirectoryName(path)!;
            sourceDir = Path.GetFileName(sourceDir);
            string filename = Path.GetFileNameWithoutExtension(path);
            string newFilename = $@"{date}_{sourceDir}_{filename}{EXTENSION}";
            string newPath = Path.Combine(resultFolderPath,newFilename);
            if (!File.Exists(path))
            {
                File.Copy(path, newPath);
            }
        }


        public static void ProcessDirectory(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            foreach (var file in files)
            {
                if (Path.GetExtension(file).ToLower() == EXTENSION)
                {
                    ProcessFile(file);
                }
            }
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (var subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory);
            }
        }

        private void CopyButtonClick(object sender, EventArgs e)
        {
            string sourceFolder = inputTextBox.Text;
            resultFolderPath = outputTextBox.Text;
            if (Directory.Exists(sourceFolder))
            {
                ProcessDirectory(sourceFolder);
            }

        }
    }


}
