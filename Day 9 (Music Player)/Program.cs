using System;
using System.Windows.Forms;
using System.Media;

namespace MusicPlayerApp
{
    public partial class MusicPlayerForm : Form
    {
        private SoundPlayer player;

        public MusicPlayerForm()
        {
            InitializeComponent();
            player = new SoundPlayer();
        }

        private void btnPlayClick(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.SampleMusic;
            player.Play();
        }

        private void btnPauseClick(object sender, EventArgs e)
        {
            if (player != null && player.Stream != null)
            {
                player.Stop();
            }
        }

        private void btnStopClick(object sender, EventArgs e)
        {
            if (player != null && player.Stream != null)
            {
                player.Stop();
                player.Stream.Position = 0;
            }
        }

        private void trackBarVolumeScroll(object sender, EventArgs e)
        {
            player.Volume = trackBarVolume.Value;
        }
    }
}
