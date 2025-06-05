using System;
using System.Drawing;
using System.Windows.Forms;

namespace Casino
{
    public partial class Main : Form
    {
        private PictureBox pictureBoxMute;
        private int currentChips;


        public Main()
        {
            InitializeComponent();
            SetupAudioAndMuteIcon();
            // Load saved chips
            currentChips = Properties.Settings.Default.Chips;
        }

        private void SetupAudioAndMuteIcon()
        {
            // Mute button setup
            pictureBoxMute = new PictureBox
            {
                Size = new Size(32, 32),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile("Resources\\Unmute.png")
            };
            pictureBoxMute.Click += PictureBoxMute_Click;
            Controls.Add(pictureBoxMute);

            // Start audio playback
            AudioManager.Play("Resources\\BackgroundSound.wav");
        }

        private void PictureBoxMute_Click(object sender, EventArgs e)
        {
            AudioManager.ToggleMute();
            pictureBoxMute.Image = Image.FromFile(
                AudioManager.IsMuted ? "Resources\\Mute.png" : "Resources\\Unmute.png"
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            AudioManager.Cleanup();
        }

    }
}
