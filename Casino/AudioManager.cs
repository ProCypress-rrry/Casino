using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace Casino
{
    public static class AudioManager
    {
        private static WaveOutEvent outputDevice;
        private static AudioFileReader audioFile;

        public static bool IsMuted { get; private set; } = false;
        public static float Volume { get; private set; } = 0.5f;

        public static void Initialize(string audioPath)
        {
            if (outputDevice != null) return; // Already initialized

            audioFile = new AudioFileReader(audioPath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            SetVolume(Volume);
            outputDevice.Play();
        }

        public static void Play(string audioPath)
        {
            Initialize(audioPath);
        }

        public static void SetVolume(float volume)
        {
            Volume = volume;
            if (!IsMuted && audioFile != null)
            {
                audioFile.Volume = volume;
            }
        }

        public static void Mute(bool mute)
        {
            IsMuted = mute;
            if (audioFile != null)
            {
                audioFile.Volume = mute ? 0 : Volume;
            }
        }

        public static void ToggleMute()
        {
            Mute(!IsMuted);
        }

        public static void Cleanup()
        {
            try
            {
                outputDevice?.Stop();
                outputDevice?.Dispose();
                outputDevice = null;

                audioFile?.Dispose();
                audioFile = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Audio cleanup error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
