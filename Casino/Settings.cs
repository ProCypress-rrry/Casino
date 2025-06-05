using System;
using System.Windows.Forms;

namespace Casino
{
    public partial class Settings : Form
    {
        private Main mainForm;

        public Settings(Main form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Setup trackBar volume range and initial value
            trackBarVolume.Minimum = 0;
            trackBarVolume.Maximum = 100;
            trackBarVolume.Value = (int)(AudioManager.Volume * 100);

            // Update label to show current volume percentage
            label2.Text = $"{trackBarVolume.Value}%";

            // Subscribe to trackBar scroll event
            trackBarVolume.Scroll += TrackBarVolume_Scroll;
        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {
            float volume = trackBarVolume.Value / 100f;
            AudioManager.SetVolume(volume);

            // Update label with the current volume percentage
            label2.Text = $"{trackBarVolume.Value}%";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }
}
