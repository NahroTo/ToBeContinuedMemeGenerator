using System;
using System.Windows;

namespace ToBeContinuedMemeGenerator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            InputPathTextBox.Text = Utilities.SelectFilePath();
        }

        private void BtnOutput_Click(object sender, RoutedEventArgs e)
        {
            OutputFolderTextBox.Text = Utilities.SelectFolderPath();
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            var videoEditor = new VideoEditor();
            videoEditor.MakeMeme(InputPathTextBox.Text, Int32.Parse(OffsetTextBox.Text), OutputFolderTextBox.Text);
        }
    }
}