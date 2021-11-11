using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using System.Runtime.InteropServices;

namespace AudioDownloader
{
    public partial class AudioDownloader : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        struct FLASHWINFO
        {
            public UInt32 cbSize;
            public IntPtr hwnd;
            public UInt32 dwFlags;
            public UInt32 uCount;
            public UInt32 dwTimeout;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        bool flash()
        {
            var fInfo = new FLASHWINFO()
            {
                cbSize = Convert.ToUInt32(Marshal.SizeOf<FLASHWINFO>()),
                hwnd = Handle,
                dwFlags = 3 | 12,
                uCount = UInt32.MaxValue,
                dwTimeout = 0
            };
            return FlashWindowEx(ref fInfo);
        }

        public AudioDownloader()
        {
            InitializeComponent();
        }

        private void _btnSaveAs_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                DefaultExt = "mp3",
                AddExtension = true,
                Filter = "MP3 Files (*.mp3)|*.mp3",
                Title = "Save As..."
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _txtFilePath.Text = dlg.FileName;
            }
        }

        private async void _btnDownload_Click(object sender, EventArgs e)
        {
            _txtUrl.Enabled = false;
            _txtFilePath.Enabled = false;
            _btnSaveAs.Enabled = false;
            _btnDownload.Enabled = false;

            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(_txtUrl.Text);
            var manifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

            var streamInfo = manifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            await youtube.Videos.Streams.DownloadAsync(streamInfo, _txtFilePath.Text);

            _txtUrl.Enabled = true;
            _txtFilePath.Enabled = true;
            _btnSaveAs.Enabled = true;
            _btnDownload.Enabled = true;

            flash();
        }
    }
}
