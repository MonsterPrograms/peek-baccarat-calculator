using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PeekBaccaratCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            // initialize all the variables we need before the loop starts
            var random = new Random();
            int index;
            int playerTotal;
            int bankerTotal;
            string stringPlayerTotal;
            string stringBankerTotal;
            int playerCard3 = 0;
            int bankerCard3 = 0;
            int playerWins = 0;
            int bankerWins = 0;
            int ties = 0;

            // 20,000 simulations begin
            for (var i = 0; i < 20000; i++)
            {
                // a fresh 8 deck shoe for beggining of each game round
                var shoe = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1 };

                // find out what cards have already been dealt and remove those from the shoe to get the most accurate shoe as possible
                if (int.TryParse(txtPlayerCard1.Text, out int playerCard1) && playerCard1 >= 1 && playerCard1 <= 10)
                {
                    index = shoe.IndexOf(playerCard1);
                    if (index > -1)
                        shoe.RemoveAt(index);
                }
                if (int.TryParse(txtPlayerCard2.Text, out int playerCard2) && playerCard2 >= 1 && playerCard2 <= 10)
                {
                    index = shoe.IndexOf(playerCard2);
                    if (index > -1)
                        shoe.RemoveAt(index);
                }
                if (int.TryParse(txtBankerCard1.Text, out int bankerCard1) && bankerCard1 >= 1 && bankerCard1 <= 10)
                {
                    index = shoe.IndexOf(bankerCard1);
                    if (index > -1)
                        shoe.RemoveAt(index);
                }
                if (int.TryParse(txtBankerCard2.Text, out int bankerCard2) && bankerCard2 >= 1 && bankerCard2 <= 10)
                {
                    index = shoe.IndexOf(bankerCard2);
                    if (index > -1)
                        shoe.RemoveAt(index);
                }

                // both player and banker will receive 2 cards each, so let's get random cards/values for the ones that have not been peeked yet
                if (playerCard1 == 0)
                {
                    index = random.Next(0, shoe.Count);
                    playerCard1 = shoe[index];
                    shoe.RemoveAt(index);
                }

                if (playerCard2 == 0)
                {
                    index = random.Next(0, shoe.Count);
                    playerCard2 = shoe[index];
                    shoe.RemoveAt(index);
                }

                if (bankerCard1 == 0)
                {
                    index = random.Next(0, shoe.Count);
                    bankerCard1 = shoe[index];
                    shoe.RemoveAt(index);
                }

                if (bankerCard2 == 0)
                {
                    index = random.Next(0, shoe.Count);
                    bankerCard2 = shoe[index];
                    shoe.RemoveAt(index);
                }

                // calculate the initial two-card totals for player and banker
                playerTotal = playerCard1 + playerCard2;
                bankerTotal = bankerCard1 + bankerCard2;

                // make sure the totals are added correctly by removing the first digit if the player and/or banker total is over 9
                if (playerTotal > 9)
                {
                    stringPlayerTotal = playerTotal.ToString().Remove(0, 1);
                    playerTotal = int.Parse(stringPlayerTotal);
                }

                if (bankerTotal > 9)
                {
                    stringBankerTotal = bankerTotal.ToString().Remove(0, 1);
                    bankerTotal = int.Parse(stringBankerTotal);
                }

                // determine if player needs a third card
                if (playerTotal >= 0 && playerTotal <= 5)
                {
                    index = random.Next(0, shoe.Count);
                    playerCard3 = shoe[index];
                    shoe.RemoveAt(index);
                }

                // determine if banker needs a third card
                if (bankerTotal >= 0 && bankerTotal <= 2)
                {
                    index = random.Next(0, shoe.Count);
                    bankerCard3 = shoe[index];
                    shoe.RemoveAt(index);
                }
                else if (bankerTotal == 3 && playerCard3 != 8)
                {
                    index = random.Next(0, shoe.Count);
                    bankerCard3 = shoe[index];
                    shoe.RemoveAt(index);
                }
                else if (bankerTotal == 4 && (playerCard3 == 0 || (playerCard3 >= 2 && playerCard3 <= 7)))
                {
                    index = random.Next(0, shoe.Count);
                    bankerCard3 = shoe[index];
                    shoe.RemoveAt(index);
                }
                else if (bankerTotal == 5 && (playerCard3 == 0 || playerCard3 >= 4 && playerCard3 <= 7))
                {
                    index = random.Next(0, shoe.Count);
                    bankerCard3 = shoe[index];
                    shoe.RemoveAt(index);
                }
                else if (bankerTotal == 6 && (playerCard3 == 6 || playerCard3 == 7))
                {
                    index = random.Next(0, shoe.Count);
                    bankerCard3 = shoe[index];
                    shoe.RemoveAt(index);
                }

                // add on the third card to the totals for player and banker
                playerTotal += playerCard3;
                bankerTotal += bankerCard3;

                // make sure the totals are added correctly by removing the first digit if the player and/or banker total is over 9
                if (playerTotal > 9)
                {
                    stringPlayerTotal = playerTotal.ToString().Remove(0, 1);
                    playerTotal = int.Parse(stringPlayerTotal);
                }

                if (bankerTotal > 9)
                {
                    stringBankerTotal = bankerTotal.ToString().Remove(0, 1);
                    bankerTotal = int.Parse(stringBankerTotal);
                }

                // calculate the end result
                if (playerTotal > bankerTotal)
                {
                    playerWins++;
                }
                else if (bankerTotal > playerTotal)
                {
                    bankerWins++;
                }
                else
                {
                    ties++;
                }
            }

            // display the optimal strategy at the end of the 20,000 simulations by doing ev calculations
            if (txtPlayerOrBanker.Text.ToLower() == "player" || txtPlayerOrBanker.Text.ToLower() == "p")
            {
                decimal winOdds = (decimal)playerWins / (decimal)(playerWins + bankerWins + ties);
                decimal loseOdds = (decimal)bankerWins / (decimal)(bankerWins + playerWins + ties);
                decimal tieOdds = (decimal)ties / (decimal)(playerWins + bankerWins + ties);
                decimal tripleEv = winOdds * 2.80m - loseOdds * 3.20m - tieOdds * 0.20m;
                decimal continueEv = winOdds * 0.80m - loseOdds * 1.20m - tieOdds * 0.20m;

                if (tripleEv >= continueEv)
                {
                    MessageBox.Show($"Triple\n\nTriple EV: {tripleEv}\nContinue EV: {continueEv}", "Optimal Strategy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Continue\n\nTriple EV: {tripleEv}\nContinue EV: {continueEv}", "Optimal Strategy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtPlayerOrBanker.Text.ToLower() == "banker" || txtPlayerOrBanker.Text.ToLower() == "b")
            {
                decimal winOdds = (decimal)bankerWins / (decimal)(playerWins + bankerWins + ties);
                decimal loseOdds = (decimal)playerWins / (decimal)(bankerWins + playerWins + ties);
                decimal tieOdds = (decimal)ties / (decimal)(playerWins + bankerWins + ties);
                decimal tripleEv = winOdds * 2.65m - loseOdds * 3.20m - tieOdds * 0.20m;
                decimal continueEv = winOdds * 0.75m - loseOdds * 1.20m - tieOdds * 0.20m;

                if (tripleEv >= continueEv)
                {
                    MessageBox.Show($"Triple\n\nTriple EV: {tripleEv}\nContinue EV: {continueEv}", "Optimal Strategy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Continue\n\nTriple EV: {tripleEv}\nContinue EV: {continueEv}", "Optimal Strategy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPlayerCard1.Clear();
            txtPlayerCard2.Clear();
            txtBankerCard1.Clear();
            txtBankerCard2.Clear();
        }

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkTopMost.Checked;
        }
    }
}
