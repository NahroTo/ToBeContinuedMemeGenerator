using System.Windows.Forms;

namespace ToBeContinuedMemeGenerator
{
    public static class Utilities
    {
        public static string SelectFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }

        public static string SelectFolderPath()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            return folderBrowserDialog.SelectedPath;
        }
    }
}
