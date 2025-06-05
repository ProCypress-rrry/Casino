using System;

namespace Casino
{
    public static class GameData
    {
        private static int chips = Properties.Settings.Default.Chips;

        // Event triggered when chips change
        public static event Action ChipsChanged;

        public static int Chips
        {
            get => chips;
            set
            {
                if (chips != value)
                {
                    chips = value;

                    // Save to user settings
                    Properties.Settings.Default.Chips = chips;
                    Properties.Settings.Default.Save();

                    // Notify subscribers (forms/UI) to update
                    ChipsChanged?.Invoke();
                }
            }
        }
    }
}
