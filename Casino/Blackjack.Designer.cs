namespace Casino
{
    partial class Blackjack
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnDeal = new Button();
            btnHit = new Button();
            btnStand = new Button();
            btnExit = new Button();
            lblPlayerCards = new Label();
            lblDealerCards = new Label();
            lblPlayerScore = new Label();
            lblDealerScore = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Location = new System.Drawing.Point(155, 354);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new System.Drawing.Size(112, 44);
            btnDeal.TabIndex = 0;
            btnDeal.Text = "Deal";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnHit
            // 
            btnHit.Location = new System.Drawing.Point(291, 354);
            btnHit.Name = "btnHit";
            btnHit.Size = new System.Drawing.Size(112, 44);
            btnHit.TabIndex = 1;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Location = new System.Drawing.Point(425, 354);
            btnStand.Name = "btnStand";
            btnStand.Size = new System.Drawing.Size(112, 44);
            btnStand.TabIndex = 2;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(554, 354);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(112, 44);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblPlayerCards
            // 
            lblPlayerCards.AutoSize = true;
            lblPlayerCards.Location = new System.Drawing.Point(199, 112);
            lblPlayerCards.Name = "lblPlayerCards";
            lblPlayerCards.Size = new System.Drawing.Size(101, 25);
            lblPlayerCards.TabIndex = 4;
            lblPlayerCards.Text = "Player Cards";
            // 
            // lblDealerCards
            // 
            lblDealerCards.AutoSize = true;
            lblDealerCards.Location = new System.Drawing.Point(459, 112);
            lblDealerCards.Name = "lblDealerCards";
            lblDealerCards.Size = new System.Drawing.Size(109, 25);
            lblDealerCards.TabIndex = 5;
            lblDealerCards.Text = "Dealer Cards";
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new System.Drawing.Point(225, 69);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new System.Drawing.Size(101, 25);
            lblPlayerScore.TabIndex = 6;
            lblPlayerScore.Text = "Player Score";
            // 
            // lblDealerScore
            // 
            lblDealerScore.AutoSize = true;
            lblDealerScore.Location = new System.Drawing.Point(478, 69);
            lblDealerScore.Name = "lblDealerScore";
            lblDealerScore.Size = new System.Drawing.Size(111, 25);
            lblDealerScore.TabIndex = 7;
            lblDealerScore.Text = "Dealer Score";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblResult.Location = new System.Drawing.Point(340, 200);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(72, 28);
            lblResult.TabIndex = 8;
            lblResult.Text = "Result";
            // 
            // Blackjack
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(lblDealerScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(lblDealerCards);
            Controls.Add(lblPlayerCards);
            Controls.Add(btnExit);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(btnDeal);
            Name = "Blackjack";
            Text = "Blackjack";
            Load += Blackjack_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnDeal;
        private Button btnHit;
        private Button btnStand;
        private Button btnExit;
        private Label lblPlayerCards;
        private Label lblDealerCards;
        private Label lblPlayerScore;
        private Label lblDealerScore;
        private Label lblResult;
    }
}
