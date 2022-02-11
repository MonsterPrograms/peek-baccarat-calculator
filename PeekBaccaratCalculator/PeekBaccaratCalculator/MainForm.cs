using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PeekBaccaratCalculator
{
    public partial class MainForm : Form
    {
        private static readonly Random Random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var playerOrBanker = comboPlayerOrBanker.SelectedIndex;
            var beforePlayerCard1 = comboPlayerCard1.SelectedIndex;
            var beforePlayerCard2 = comboPlayerCard2.SelectedIndex;
            var beforeBankerCard1 = comboBankerCard1.SelectedIndex;
            var beforeBankerCard2 = comboBankerCard2.SelectedIndex;

            if (playerOrBanker == -1)
            {
                MessageBox.Show("You must enter if you are betting on player or banker.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (beforePlayerCard1 == -1 && beforePlayerCard2 == -1 && beforeBankerCard1 == -1 && beforeBankerCard2 == -1)
            {
                MessageBox.Show("You must enter at least 1 revealed card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int playerWins = 0, bankerWins = 0, ties = 0;

                // fresh 8 deck shoe
                var shoe = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0, 1 };

                // remove any revealed cards from the shoe
                shoe.Remove(beforePlayerCard1);
                shoe.Remove(beforePlayerCard2);
                shoe.Remove(beforeBankerCard1);
                shoe.Remove(beforeBankerCard2);

                // simulations begin
                for (var i = 0; i < numSimulations.Value; i++)
                {
                    // assign the shoe we will be using for each simulation
                    var newShoe = (List<int>)Activator.CreateInstance(typeof(List<int>), shoe);

                    // assign the starting values of each of the cards
                    var playerCard1 = beforePlayerCard1;
                    var playerCard2 = beforePlayerCard2;
                    var bankerCard1 = beforeBankerCard1;
                    var bankerCard2 = beforeBankerCard2;

                    // assign a value to each card that haven't been peeked
                    if (playerCard1 == -1)
                    {
                        playerCard1 = RemoveAndReturnRandomCard(newShoe);
                    }

                    if (playerCard2 == -1)
                    {
                        playerCard2 = RemoveAndReturnRandomCard(newShoe);
                    }

                    if (bankerCard1 == -1)
                    {
                        bankerCard1 = RemoveAndReturnRandomCard(newShoe);
                    }

                    if (bankerCard2 == -1)
                    {
                        bankerCard2 = RemoveAndReturnRandomCard(newShoe);
                    }

                    // calculate the initial two-card totals for player and banker
                    var playerTotal = CalculateTotal(playerCard1, playerCard2);
                    var bankerTotal = CalculateTotal(bankerCard1, bankerCard2);

                    // determine if player and/or banker needs a third card
                    if (playerTotal >= 0 && playerTotal <= 7)
                    {
                        var playerCard3 = -1;

                        // determine if player needs a third card
                        if (playerTotal <= 5)
                        {
                            playerCard3 = RemoveAndReturnRandomCard(newShoe);
                        }

                        var bankerCard3 = -1;

                        // determine if banker needs a third card
                        if (bankerTotal >= 0 && bankerTotal <= 2)
                        {
                            bankerCard3 = RemoveAndReturnRandomCard(newShoe);
                        }
                        else if (bankerTotal == 3 && playerCard3 != 8)
                        {
                            bankerCard3 = RemoveAndReturnRandomCard(newShoe);
                        }
                        else if (bankerTotal == 4 && (playerCard3 == -1 || playerCard3 >= 2 && playerCard3 <= 7))
                        {
                            bankerCard3 = RemoveAndReturnRandomCard(newShoe);
                        }
                        else if (bankerTotal == 5 && (playerCard3 == -1 || playerCard3 >= 4 && playerCard3 <= 7))
                        {
                            bankerCard3 = RemoveAndReturnRandomCard(newShoe);
                        }
                        else if (bankerTotal == 6 && (playerCard3 == 6 || playerCard3 == 7))
                        {
                            bankerCard3 = RemoveAndReturnRandomCard(newShoe);
                        }

                        // determine if the player was dealt a third card
                        if (playerCard3 != -1)
                        {
                            // add on the third card to the total for player
                            playerTotal = CalculateTotal(playerTotal, playerCard3);
                        }

                        // determine if the banker was dealt a third card
                        if (bankerCard3 != -1)
                        {
                            // add on the third card to the total for banker
                            bankerTotal = CalculateTotal(bankerTotal, bankerCard3);
                        }
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
                if (playerOrBanker == 0)
                {
                    tripleEv = playerWinOdds * 2.80m - bankerWinOdds * 3.20m - tieOdds * 0.20m;
                    continueEv = playerWinOdds * 0.80m - bankerWinOdds * 1.20m - tieOdds * 0.20m;
                }
                else if (playerOrBanker == 1)
                {
                    tripleEv = bankerWinOdds * 2.65m - playerWinOdds * 3.20m - tieOdds * 0.20m;
                    continueEv = bankerWinOdds * 0.75m - playerWinOdds * 1.20m - tieOdds * 0.20m;
                }

                // display the optimal strategy based on ev
                MessageBox.Show($"{(tripleEv >= continueEv ? "Triple" : "Continue")}\n\nTriple EV: {tripleEv}\nContinue EV: {continueEv}", "Optimal Strategy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static int RemoveAndReturnRandomCard(IList<int> shoe)
        {
            var index = Random.Next(shoe.Count);
            var card = shoe[index];
            shoe.RemoveAt(index);
            return card;
        }

        private static int CalculateTotal(int card1, int card2)
        {
            var total = card1 + card2;

            return total > 9 ? int.Parse(total.ToString().Remove(0, 1)) : total;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numSimulations.Value = 100000;
            comboPlayerOrBanker.SelectedIndex = -1;
            comboPlayerCard1.SelectedIndex = -1;
            comboPlayerCard2.SelectedIndex = -1;
            comboBankerCard1.SelectedIndex = -1;
            comboBankerCard2.SelectedIndex = -1;
        }

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkTopMost.Checked;
        }
    }
}
