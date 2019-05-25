using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArnoldClarkRPS
{
    public partial class Form1 : Form
    {
        // global variables
        byte playerScore;
        byte opponentScore;

        public Form1()
        {
            InitializeComponent();
            playerScore = 0;
            opponentScore = 0;
            lblOpponentChoice.Text = "";
            lblOutcome.Text = "";
        }


        #region Form events

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                // local variables
                string playerGesture = listBoxPlayer.SelectedItem.ToString();
                Random randNumGen = new Random();
                int randNum = randNumGen.Next(1, 6);


                // assign opponent a "gesture"
                string opponentGesture = ChooseGesture(randNum);
                lblOpponentChoice.Text = $"Your opponent has chosen {opponentGesture}.";


                // if both players have same gesture, game is a draw
                if (playerGesture == opponentGesture)
                {
                    lblOutcome.Text = "Draw!";
                }


                // otherwise players must have different gestures
                // depending on what the player has chosen, instantiate the relevant class and call the GameResult() method
                else
                {
                    if (playerGesture == "Rock")
                    {
                        Rock myRock = new Rock();

                        if (myRock.GetStrengths().Contains(opponentGesture))
                        {
                            GameResult(true, playerGesture, opponentGesture);
                        }
                        else
                        {
                            GameResult(false, playerGesture, opponentGesture);
                        }
                    }

                    else if (playerGesture == "Paper")
                    {
                        Paper myPaper = new Paper();

                        if (myPaper.GetStrengths().Contains(opponentGesture))
                        {
                            GameResult(true, playerGesture, opponentGesture);
                        }
                        else
                        {
                            GameResult(false, playerGesture, opponentGesture);
                        }
                    }

                    else if (playerGesture == "Scissors")
                    {
                        Scissors myScissors = new Scissors();

                        if (myScissors.GetStrengths().Contains(opponentGesture))
                        {
                            GameResult(true, playerGesture, opponentGesture);
                        }
                        else
                        {
                            GameResult(false, playerGesture, opponentGesture);
                        }
                    }

                    else if (playerGesture == "Spock")
                    {
                        Spock mySpock = new Spock();

                        if (mySpock.GetStrengths().Contains(opponentGesture))
                        {
                            GameResult(true, playerGesture, opponentGesture);
                        }
                        else
                        {
                            GameResult(false, playerGesture, opponentGesture);
                        }
                    }

                    else if (playerGesture == "Lizard")
                    {
                        Lizard myLizard = new Lizard();

                        if (myLizard.GetStrengths().Contains(opponentGesture))
                        {
                            GameResult(true, playerGesture, opponentGesture);
                        }
                        else
                        {
                            GameResult(false, playerGesture, opponentGesture);
                        }
                    }
                }
            }


            // user has not chosen a gesture
            catch (NullReferenceException)
            {
                MessageBox.Show("Please choose a gesture.", "Gesture not chosen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        #endregion



        #region Form methods

        /// <summary>
        /// This method takes in a number (between 1 and 5) which is then used to determine the opponent's gesture.
        /// </summary>
        /// <param name="randNumIn">Random number used to determine opponent's gesture.</param>
        /// <returns>Returns a string used to contain the opponent's gesture.</returns>
        private string ChooseGesture(int randNumIn)
        {
            switch (randNumIn)
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
            if (playerHasWon)
            {
                playerScore++;
                lblOutcome.Text = $"You win because {playerGestureIn} {GetVerb(playerGestureIn, opponentGestureIn)} {opponentGestureIn}.";
            }

            else
            {
                opponentScore++;
                lblOutcome.Text = $"You lose because {opponentGestureIn} {GetVerb(playerGestureIn, opponentGestureIn)} {playerGestureIn}.";
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
            // initial if statement is slightly more complicated because "crushes" applies to both scissors and lizard
            if ((gestureOne == "Rock" && (gestureTwo == "Scissors" || gestureTwo == "Lizard")) || ((gestureOne == "Scissors" || gestureOne == "Lizard") && gestureTwo == "Rock"))
            {
                return "crushes";
            }

            else if ((gestureOne == "Paper" && gestureTwo == "Rock") || (gestureOne == "Rock" && gestureTwo == "Paper"))
            {
                return "covers";
            }

            else if ((gestureOne == "Scissors" && gestureTwo == "Paper") || (gestureOne == "Paper" && gestureTwo == "Scissors"))
            {
                return "cuts";
            }

            else if ((gestureOne == "Lizard" && gestureTwo == "Spock") || (gestureOne == "Spock" && gestureTwo == "Lizard"))
            {
                return "poisons";
            }

            else if ((gestureOne == "Spock" && gestureTwo == "Scissors") || (gestureOne == "Scissors" && gestureTwo == "Spock"))
            {
                return "smashes";
            }

            else if ((gestureOne == "Scissors" && gestureTwo == "Lizard") || (gestureOne == "Lizard" && gestureTwo == "Scissors"))
            {
                return "decapitates";
            }

            else if ((gestureOne == "Paper" && gestureTwo == "Lizard") || (gestureOne == "Lizard" && gestureTwo == "Paper"))
            {
                return "eats";
            }

            else if ((gestureOne == "Paper" && gestureTwo == "Spock") || (gestureOne == "Spock" && gestureTwo == "Paper"))
            {
                return "disproves";
            }

            else if ((gestureOne == "Spock" && gestureTwo == "Rock") || (gestureOne == "Rock" && gestureTwo == "Spock"))
            {
                return "vaporises";
            }

            else
            {
                return "beats";
            }
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