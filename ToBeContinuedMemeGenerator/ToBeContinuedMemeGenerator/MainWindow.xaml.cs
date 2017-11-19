using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace ToBeContinuedMemeGenerator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                PathTextBox.Text = openFileDialog.FileName;
        }
    }
}