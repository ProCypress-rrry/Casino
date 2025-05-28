using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave; // For playing audio

namespace Casino
{
    public partial class Main : Form
    {
        // Audio playback components from NAudio
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        // Used to track mute state
        private bool isMuted = false;

        // Stores volume when muted so it can be restored
        private float lastVolume = 0.5f;

        // Mute button displayed as an image
        private PictureBox pictureBoxMute;

        public Main()
        {
            InitializeComponent();

            // Call our own method to set up the mute button and audio
            SetupAudioAndMuteIcon();
        }

        private void SetupAudioAndMuteIcon()
        {
            // Setup the PictureBox as a mute/unmute toggle
            pictureBoxMute = new PictureBox();
            pictureBoxMute.Size = new Size(32, 32); // Size in pixels
            pictureBoxMute.Location = new Point(10, 10); // Position on the form
            pictureBoxMute.SizeMode = PictureBoxSizeMode.StretchImage; // Makes image fill the box

            // Load the default icon (unmuted)
            pictureBoxMute.Image = Image.FromFile("Resources\\Unmute.png");

            // Add a click event so it can toggle mute
            pictureBoxMute.Click += PictureBoxMute_Click;

            // Add it to the form so it's visible
            this.Controls.Add(pictureBoxMute);

            try
            {
                // Load the audio file
                string audioFilePath = "Resources\\BackgroundSound.wav";
                audioFile = new AudioFileReader(audioFilePath);
                audioFile.Volume = lastVolume; // Start at default volume

                // Play the audio in the background
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading audio: " + ex.Message);
            }
        }

        // Called when the mute/unmute PictureBox is clicked
        private void PictureBoxMute_Click(object sender, EventArgs e)
        {
            if (audioFile == null) return;

            if (isMuted)
            {
                // If currently muted, restore volume and icon
                audioFile.Volume = lastVolume;
                pictureBoxMute.Image = Image.FromFile("Resources\\unmute.png");
            }
            else
            {
                // If currently unmuted, save volume and mute audio
                lastVolume = audioFile.Volume;
                audioFile.Volume = 0;
                pictureBoxMute.Image = Image.FromFile("Resources\\mute.png");
            }

            // Toggle the mute state
            isMuted = !isMuted;
        }

        // When the form is closing, clean up resources
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            outputDevice?.Stop();        // Stop playback
            outputDevice?.Dispose();     // Release audio device
            audioFile?.Dispose();        // Release the file

            base.OnFormClosing(e);       // Call base method
        }

        // Your existing button logic
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the app
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
