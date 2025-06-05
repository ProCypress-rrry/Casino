using System;
using System.Windows.Forms;

namespace Casino
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Hook into application exit event to stop music
            Application.ApplicationExit += OnApplicationExit;

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            // Clean up audio when the whole app closes
            AudioManager.Cleanup();
        }
    }
}
