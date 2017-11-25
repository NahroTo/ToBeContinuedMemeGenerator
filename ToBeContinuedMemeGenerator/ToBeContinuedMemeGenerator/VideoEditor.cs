using System;
using System.Windows;

namespace ToBeContinuedMemeGenerator
{
    public class VideoEditor
    {
        public void Test()
        {
            string fileName = Helper.GetSafePath(@"./Assets/zoo.mp4");
            if (fileName != null)
            {
                try
                {
                    AviManager aviManager = new AviManager(fileName, true);
                    aviManager.AddAudioStream(Helper.GetSafePath(@"./Assets/zoo.mp4"), 0);
                    aviManager.Close();
                } catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
    }
}
