using System;
using System.Drawing;
using System.Windows.Forms;

namespace Casino
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Subscribe to chips changed event
            GameData.ChipsChanged += UpdateChipsDisplay;

            // Show initial chip count
            UpdateChipsDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roullete roulettegame = new roullete();
            roulettegame.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Optional: extra chip update if needed
            UpdateChipsDisplay();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // You can remove this if unused
        }

        private void UpdateChipsDisplay()
        {
            labelChips.Text = $"Chips: {GameData.Chips}";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            GameData.ChipsChanged -= UpdateChipsDisplay;
            base.OnFormClosed(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Blackjack blackjack = new Blackjack();
            blackjack.Show();
            this.Hide();
        }
    }
}
