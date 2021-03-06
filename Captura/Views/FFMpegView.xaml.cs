﻿using System.Windows;

namespace Captura
{
    public partial class FFMpegView
    {
        void OpenFFMpegLog(object sender, RoutedEventArgs e)
        {
            FFMpegLogView.Instance.ShowAndFocus();
        }
        
        void FFDownload(object sender, RoutedEventArgs e)
        {
            FFMpegService.FFMpegDownloader?.Invoke();
        }
    }
}
