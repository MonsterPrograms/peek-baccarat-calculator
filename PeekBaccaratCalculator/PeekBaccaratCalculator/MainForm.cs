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

        private void CheckInput(object sender, KeyPressEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            cb.DroppedDown = true;
            string strFindStr = "";
            if (e.KeyChar == (char)8)
            {
                if (cb.SelectionStart <= 1)
                {
                    cb.Text = "";
                    return;
                }

                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text.Substring(0, cb.Text.Length - 1);
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1);
            }
            else
            {
                if (cb.SelectionLength == 0)
                    strFindStr = cb.Text + e.KeyChar;
                else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart) + e.KeyChar;
            }

            int intIdx = -1;

            intIdx = cb.FindString(strFindStr);
            if (intIdx != -1)
            {
                cb.SelectedText = "";
                cb.SelectedIndex = intIdx;
                cb.SelectionStart = strFindStr.Length;
                cb.SelectionLength = cb.Text.Length;
                e.Handled = true;
            }
            else
                e.Handled = true;
        }

        private void Calculate(object sender, EventArgs e)
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
                var random = new Random();
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

                    // both player and banker will receive 2 cards each, so let's get random cards/values for the ones that have not been peeked yet
                    if (playerCard1 == -1)
                    {
                        var index = random.Next(0, newShoe.Count);
                        playerCard1 = newShoe[index];
                        newShoe.RemoveAt(index);
                    }

                    if (playerCard2 == -1)
                    {
                        var index = random.Next(0, newShoe.Count);
                        playerCard2 = newShoe[index];
                        newShoe.RemoveAt(index);
                    }

                    if (bankerCard1 == -1)
                    {
                        var index = random.Next(0, newShoe.Count);
                        bankerCard1 = newShoe[index];
                        newShoe.RemoveAt(index);
                    }

                    if (bankerCard2 == -1)
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

                    // determine if player and/or banker needs a third card
                    if (playerTotal >= 0 && playerTotal <= 7)
                    {
                        var playerCard3 = -1;

                        // determine if player needs a third card
                        if (playerTotal <= 5)
                        {
                            var index = random.Next(0, newShoe.Count);
                            playerCard3 = newShoe[index];
                            newShoe.RemoveAt(index);
                        }

                        var bankerCard3 = -1;

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
                        else if (bankerTotal == 4 && (playerCard3 == -1 || playerCard3 >= 2 && playerCard3 <= 7))
                        {
                            var index = random.Next(0, newShoe.Count);
                            bankerCard3 = newShoe[index];
                            newShoe.RemoveAt(index);
                        }
                        else if (bankerTotal == 5 && (playerCard3 == -1 || playerCard3 >= 4 && playerCard3 <= 7))
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

                        // determine if the player was dealt a third card
                        if (playerCard3 != -1)
                        {
                            // add on the third card to the total for player
                            playerTotal += playerCard3;

                            // make sure the total is added correctly by removing the first digit if the player total is over 9
                            if (playerTotal > 9)
                            {
                                var stringPlayerTotal = playerTotal.ToString().Remove(0, 1);
                                playerTotal = int.Parse(stringPlayerTotal);
                            }
                        }

                        // determine if the banker was dealt a third card
                        if (bankerCard3 != -1)
                        {
                            // add on the third card to the total for banker
                            bankerTotal += bankerCard3;

                            // make sure the total is added correctly by removing the first digit if the banker total is over 9
                            if (bankerTotal > 9)
                            {
                                var stringBankerTotal = bankerTotal.ToString().Remove(0, 1);
                                bankerTotal = int.Parse(stringBankerTotal);
                            }
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
