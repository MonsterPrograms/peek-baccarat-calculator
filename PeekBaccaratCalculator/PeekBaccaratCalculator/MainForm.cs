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
            var simulations = int.Parse(txtSimulations.Text);
            var random = new Random();
            int playerWins = 0, bankerWins = 0, ties = 0;
            
            // fresh 8 deck shoe
            var shoe = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 1 };

            // find out what cards have already been dealt and remove those from the shoe
            if (int.TryParse(txtPlayerCard1.Text, out var beforePlayerCard1) && beforePlayerCard1 >= 1 && beforePlayerCard1 <= 10)
            {
                var index = shoe.IndexOf(beforePlayerCard1);
                if (index > -1)
                    shoe.RemoveAt(index);
            }
            if (int.TryParse(txtPlayerCard2.Text, out var beforePlayerCard2) && beforePlayerCard2 >= 1 && beforePlayerCard2 <= 10)
            {
                var index = shoe.IndexOf(beforePlayerCard2);
                if (index > -1)
                    shoe.RemoveAt(index);
            }
            if (int.TryParse(txtBankerCard1.Text, out var beforeBankerCard1) && beforeBankerCard1 >= 1 && beforeBankerCard1 <= 10)
            {
                var index = shoe.IndexOf(beforeBankerCard1);
                if (index > -1)
                    shoe.RemoveAt(index);
            }
            if (int.TryParse(txtBankerCard2.Text, out var beforeBankerCard2) && beforeBankerCard2 >= 1 && beforeBankerCard2 <= 10)
            {
                var index = shoe.IndexOf(beforeBankerCard2);
                if (index > -1)
                    shoe.RemoveAt(index);
            }

            // simulations begin
            for (var i = 0; i < simulations; i++)
            {
                // assign the shoe we will be using for each simulation
                List<int> newShoe = (List<int>)Activator.CreateInstance(typeof(List<int>), shoe);

                // assign the starting values of each of the cards
                var playerCard1 = beforePlayerCard1;
                var playerCard2 = beforePlayerCard2;
                var bankerCard1 = beforeBankerCard1;
                var bankerCard2 = beforeBankerCard2;

                // both player and banker will receive 2 cards each, so let's get random cards/values for the ones that have not been peeked yet
                if (playerCard1 == 0)
                {
                    var index = random.Next(0, newShoe.Count);
                    playerCard1 = newShoe[index];
                    newShoe.RemoveAt(index);
                }

                if (playerCard2 == 0)
                {
                    var index = random.Next(0, newShoe.Count);
                    playerCard2 = newShoe[index];
                    newShoe.RemoveAt(index);
                }

                if (bankerCard1 == 0)
                {
                    var index = random.Next(0, newShoe.Count);
                    bankerCard1 = newShoe[index];
                    newShoe.RemoveAt(index);
                }

                if (bankerCard2 == 0)
                {
                    var index = random.Next(0, newShoe.Count);
                    bankerCard2 = newShoe[index];
                    newShoe.RemoveAt(index);
                }

                // calculate the initial two-card totals for player and banker
                var playerTotal = playerCard1 + playerCard2;
                var bankerTotal = bankerCard1 + bankerCard2;

                // make sure the totals are added correctly by removing the first digit if the player and/or banker total is over 9
                if (playerTotal > 9)
                {
                    var stringPlayerTotal = playerTotal.ToString().Remove(0, 1);
                    playerTotal = int.Parse(stringPlayerTotal);
                }

                if (bankerTotal > 9)
                {
                    var stringBankerTotal = bankerTotal.ToString().Remove(0, 1);
                    bankerTotal = int.Parse(stringBankerTotal);
                }

                var playerCard3 = 0;

                // determine if player needs a third card
                if (playerTotal >= 0 && playerTotal <= 5)
                {
                    var index = random.Next(0, newShoe.Count);
                    playerCard3 = newShoe[index];
                    newShoe.RemoveAt(index);
                }

                var bankerCard3 = 0;

                // determine if banker needs a third card
                if (bankerTotal >= 0 && bankerTotal <= 2)
                {
                    var index = random.Next(0, newShoe.Count);
                    bankerCard3 = newShoe[index];
                    newShoe.RemoveAt(index);
                }
                else if (bankerTotal == 3 && playerCard3 != 8)
                {
                    var index = random.Next(0, newShoe.Count);
                    bankerCard3 = newShoe[index];
                    newShoe.RemoveAt(index);
                }
                else if (bankerTotal == 4 && (playerCard3 == 0 || (playerCard3 >= 2 && playerCard3 <= 7)))
                {
                    var index = random.Next(0, newShoe.Count);
                    bankerCard3 = newShoe[index];
                    newShoe.RemoveAt(index);
                }
                else if (bankerTotal == 5 && (playerCard3 == 0 || playerCard3 >= 4 && playerCard3 <= 7))
                {
                    var index = random.Next(0, newShoe.Count);
                    bankerCard3 = newShoe[index];
                    newShoe.RemoveAt(index);
                }
                else if (bankerTotal == 6 && (playerCard3 == 6 || playerCard3 == 7))
                {
                    var index = random.Next(0, newShoe.Count);
                    bankerCard3 = newShoe[index];
                    newShoe.RemoveAt(index);
                }

                // add on the third card to the totals for player and banker
                playerTotal += playerCard3;
                bankerTotal += bankerCard3;

                // make sure the totals are added correctly by removing the first digit if the player and/or banker total is over 9
                if (playerTotal > 9)
                {
                    var stringPlayerTotal = playerTotal.ToString().Remove(0, 1);
                    playerTotal = int.Parse(stringPlayerTotal);
                }

                if (bankerTotal > 9)
                {
                    var stringBankerTotal = bankerTotal.ToString().Remove(0, 1);
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

            // calculate odds for player & banker & tie
            var playerWinOdds = playerWins / (decimal)(playerWins + bankerWins + ties);
            var bankerWinOdds = bankerWins / (decimal)(bankerWins + playerWins + ties);
            var tieOdds = ties / (decimal)(playerWins + bankerWins + ties);
            decimal tripleEv = 0, continueEv = 0;

            // calculate the ev of triple & continue for player/banker
            if (txtPlayerOrBanker.Text.ToLower() == "player" || txtPlayerOrBanker.Text.ToLower() == "p")
            {
                tripleEv = playerWinOdds * 2.80m - bankerWinOdds * 3.20m - tieOdds * 0.20m;
                continueEv = playerWinOdds * 0.80m - bankerWinOdds * 1.20m - tieOdds * 0.20m;
            }
            else if (txtPlayerOrBanker.Text.ToLower() == "banker" || txtPlayerOrBanker.Text.ToLower() == "b")
            {
                tripleEv = bankerWinOdds * 2.65m - playerWinOdds * 3.20m - tieOdds * 0.20m;
                continueEv = bankerWinOdds * 0.75m - playerWinOdds * 1.20m - tieOdds * 0.20m;
            }

            // display the optimal strategy based on ev
            MessageBox.Show($"{(tripleEv >= continueEv ? "Triple" : "Continue")}\n\nTriple EV: {tripleEv}\nContinue EV: {continueEv}", "Optimal Strategy", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
