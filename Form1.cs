using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayYourCardsRightWinForms
{
    public partial class Form1 : Form
    {
        Game game = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// What happens when the start button is clicked?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            game.Reset();
            StartButton.Enabled = false;
            UPSelect.Enabled = true;
            DownSelect.Enabled = true;
            UpdateScore();
            UpdateCard();
        }

        /// <summary>
        /// Lose the game. Disable all buttons except start. Show score.
        /// </summary>
        private void LoseGame()
        {
            StartButton.Enabled = true;
            UPSelect.Enabled = false;
            DownSelect.Enabled = false;
            MessageBox.Show($"Game Over\nYour Score Was {game.GetScore()}\n" +
                $"The next card was {game.getCurrentCard().ToString()}", "You Lose", 
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            CardPicture.Image = Properties.Resources.card_back;
        }

        /// <summary>
        /// Update the picture on the card.
        /// </summary>
        private void UpdateCard()
        {
            // Update the picture with the new image from the resources. 
            // we don't know the name so we search for it using the resource manager.
            CardPicture.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(game.getCurrentCard().propertystring);
        }

        /// <summary>
        /// Update the score on the UI
        /// </summary>
        private void UpdateScore()
        {
            ScoreLabel.Text = game.GetScore().ToString();
        }

        /// <summary>
        /// What happens when up arrow is clicked?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UPSelect_Click(object sender, EventArgs e)
        {
            if (!game.Guess(true))
            {
                LoseGame();
            }
            else
            {
                UpdateCard();
                UpdateScore();
            }
        }

        /// <summary>
        /// What happens when down arrow is clicked?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownSelect_Click(object sender, EventArgs e)
        {
            if (!game.Guess(false))
            {
                LoseGame();
            }
            else
            {
                UpdateCard();
                UpdateScore();
            }
        }
    }
}
