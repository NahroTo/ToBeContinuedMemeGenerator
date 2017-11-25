using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace ToBeContinuedMemeGenerator
{
    public class VideoEditor
    {
        private readonly string OutputFileName = "DankMeme";

        public void MakeMeme(string inputPath, int offset, string outputFolderPath)
        {
            string songPath = Path.Combine(Directory.GetCurrentDirectory(), @"Assets/continued.mp3");
            string outputPath = String.Format(@"{0}\{1}.mp4", outputFolderPath, OutputFileName);

            string args = String.Format(
                @"-i {0} -itsoffset {1} -i {2} -c copy {3}",
                inputPath,
                offset,
                songPath,
                outputPath);
            try
            {
                var process = new ProcessStartInfo
                {
                    UseShellExecute = true,
                    WorkingDirectory = @"C:\Windows\System32",
                    FileName = @"C:\ffmpeg\bin\ffmpeg.exe",
                    Verb = "runas",
                    Arguments = args,
                    // WindowStyle = ProcessWindowStyle.Hidden
                };
                Process.Start(process);
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
