using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Casino
{
    public partial class Blackjack : Form
    {
        List<Card> playerHand = new List<Card>();
        List<Card> dealerHand = new List<Card>();
        Deck deck;

        public Blackjack()
        {
            InitializeComponent();
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            deck = new Deck();
            playerHand.Clear();
            dealerHand.Clear();

            playerHand.Add(deck.DrawCard());
            playerHand.Add(deck.DrawCard());

            dealerHand.Add(deck.DrawCard());
            dealerHand.Add(deck.DrawCard());

            btnHit.Enabled = true;
            btnStand.Enabled = true;
            lblResult.Text = "";

            UpdateUI();
            CheckBlackjack();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            playerHand.Add(deck.DrawCard());
            UpdateUI();

            if (CalculateScore(playerHand) > 21)
                EndGame("Player Busts! Dealer Wins!");
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (CalculateScore(dealerHand) < 17)
                dealerHand.Add(deck.DrawCard());

            UpdateUI();
            int playerScore = CalculateScore(playerHand);
            int dealerScore = CalculateScore(dealerHand);

            if (dealerScore > 21 || playerScore > dealerScore)
                EndGame("Player Wins!");
            else if (playerScore < dealerScore)
                EndGame("Dealer Wins!");
            else
                EndGame("Push (Tie)!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void EndGame(string result)
        {
            lblResult.Text = result;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }

        void CheckBlackjack()
        {
            if (CalculateScore(playerHand) == 21)
                EndGame("Blackjack! Player Wins!");
        }

        int CalculateScore(List<Card> hand)
        {
            int score = hand.Sum(c => c.Value);
            int aceCount = hand.Count(c => c.Rank == "A");

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        void UpdateUI()
        {
            lblPlayerCards.Text = string.Join(", ", playerHand);
            lblDealerCards.Text = string.Join(", ", dealerHand);
            lblPlayerScore.Text = $"Score: {CalculateScore(playerHand)}";
            lblDealerScore.Text = $"Score: {CalculateScore(dealerHand)}";
        }
    }

    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public int Value
        {
            get
            {
                if (Rank == "A") return 11;
                if (Rank == "K" || Rank == "Q" || Rank == "J") return 10;
                return int.Parse(Rank);
            }
        }

        public override string ToString() => $"{Rank} of {Suit}";
    }

    public class Deck
    {
        private List<Card> cards;
        private Random rand = new Random();

        public Deck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            cards = (from suit in suits
                     from rank in ranks
                     select new Card { Suit = suit, Rank = rank }).ToList();
        }

        public Card DrawCard()
        {
            if (cards.Count == 0) return null;
            int index = rand.Next(cards.Count);
            Card card = cards[index];
            cards.RemoveAt(index);
            return card;
        }
    }
}
