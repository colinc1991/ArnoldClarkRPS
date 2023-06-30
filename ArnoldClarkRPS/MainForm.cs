using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArnoldClarkRPS
{
    public partial class MainForm : Form
    {
        // global variables
        byte playerScore;
        byte opponentScore;
        readonly BaseClass baseClass;

        public MainForm()
        {
            InitializeComponent();
            playerScore = 0;
            opponentScore = 0;
            lblOpponentChoice.Text = "";
            lblOutcome.Text = "";
            baseClass = new BaseClass();
        }


        #region Form events

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            // assign the players gesture to the selected value of the listbox
            string playerGesture = listBoxPlayer.SelectedItem.ToString();


            // assign opponent a "gesture"
            string opponentGesture = ChooseGesture();
            lblOpponentChoice.Text = $"Your opponent has chosen {opponentGesture}.";


            // if both players have same gesture, game is a draw
            if (playerGesture == opponentGesture)
            {
                lblOutcome.Text = "Draw!";
                return;
            }


            // otherwise players must have different gestures
            // depending on what the player has chosen, instantiate the relevant class and call the GameResult() method
            var gestureClass = baseClass.GetChildClass(playerGesture);

            GameResult(gestureClass.GetStrengths().Contains(opponentGesture), playerGesture, opponentGesture);
        }

        /// <summary>
        /// This method simply calls the ResetGame() method when the "reset" game button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        
        private void listBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
        }
        #endregion



        #region Form methods

        /// <summary>
        /// This method uses a random number (between 1 and 5) to determine the opponent's gesture.
        /// </summary>
        /// <returns>Returns a string used to contain the opponent's gesture.</returns>
        private string ChooseGesture()
        {
            Random randNumGen = new Random();
            int randNum = randNumGen.Next(1, 6);

            switch (randNum)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                case 4:
                    return "Lizard";
                case 5:
                    return "Spock";
                default:
                    return "Rock";
            }
        }

        /// <summary>
        /// This method controls the scoring system and updates the "Outcome" and "Score" labels with the match result.
        /// </summary>
        /// <param name="playerHasWon">Boolean value used to control the if statement.</param>
        /// <param name="playerGestureIn">The player's gesture.</param>
        /// <param name="opponentGestureIn">The opponent's gesture.</param>
        private void GameResult(bool playerHasWon, string playerGestureIn, string opponentGestureIn)
        {
            string verb = playerHasWon ? "win" : "lose";
            lblOutcome.Text = $"You {verb} because {(playerHasWon ? playerGestureIn : opponentGestureIn)} {GetVerb(playerGestureIn, opponentGestureIn)} {(playerHasWon ? opponentGestureIn : playerGestureIn)}.";
            
            if (playerHasWon)
            {
                playerScore++;
            }

            else
            {
                opponentScore++;
            }

            DisplayScores();

            if (playerScore == 255 || opponentScore == 255)
            {
                MessageBox.Show("You have reached the maximum possible score - the game will now reset.", "Max score reached.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
        }

        /// <summary>
        /// This method selects the appropriate verb to return based on the supplied parameters.
        /// </summary>
        /// <param name="gestureOne">Gesture belonging to either the player or the opponent.</param>
        /// <param name="gestureTwo">Gesture belonging to either the player or the opponent.</param>
        /// <returns>Returns the appropriate verb based on the supplied input.</returns>
        private string GetVerb(string gestureOne, string gestureTwo)
        {
            List<string> combinedGestures = new List<string>() { gestureOne, gestureTwo};
            // initial if statement is slightly more complicated because "crushes" applies to both scissors and lizard
            if (combinedGestures.Contains("Rock") && (combinedGestures.Contains("Scissors") || combinedGestures.Contains("Lizard")))
            {
                return "crushes";
            }

            if (combinedGestures.Contains("Paper") && combinedGestures.Contains("Rock"))
            {
                return "covers";
            }

            if (combinedGestures.Contains("Paper") && combinedGestures.Contains("Scissors"))
            {
                return "cuts";
            }

            if (combinedGestures.Contains("Lizard") && combinedGestures.Contains("Spock"))
            {
                return "poisons";
            }

            if (combinedGestures.Contains("Spock") && combinedGestures.Contains("Scissors"))
            {
                return "smashes";
            }

            if (combinedGestures.Contains("Scissors") && combinedGestures.Contains("Lizard"))
            {
                return "decapitates";
            }

            if (combinedGestures.Contains("Paper") && combinedGestures.Contains("Lizard"))
            {
                return "eats";
            }

            if (combinedGestures.Contains("Paper") && combinedGestures.Contains("Spock"))
            {
                return "disproves";
            }

            if (combinedGestures.Contains("Spock") && combinedGestures.Contains("Rock"))
            {
                return "vaporises";
            }

            return "beats";
        }

        /// <summary>
        /// This method updates the relevant "scores" labels with the current scores.
        /// </summary>
        private void DisplayScores()
        {
            lblOpponentScore.Text = $"Opponent score: {opponentScore}";
            lblPlayerScore.Text = $"Player score: {playerScore}";
        }

        /// <summary>
        /// This method sets the form back to its initial state - player scores are set back to zero and the relevant labels are cleared.
        /// </summary>
        private void ResetGame()
        {
            lblOpponentChoice.Text = "";
            lblOutcome.Text = "";
            playerScore = 0;
            opponentScore = 0;
            DisplayScores();
        }

        #endregion
    }
}