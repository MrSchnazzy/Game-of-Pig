using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Pig
{
    public partial class GameForm : Form
    {
        int turn = 1;
        int totalScore, turn1Score, turn2Score, turn3Score, turn4Score, turn5Score, currentTurnScore, die;
        Random roll = new Random();

        public GameForm()
        {
            InitializeComponent();
            reset();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            die = roll.Next(1, 7);

            if (die == 1)
            {
                currentTurnScore = 0;
                dicePictureBox.Load(@"..\..\Resources\1dieGrey.png");
                keepButton_Click(sender, e);
            }
            else if (die == 2)
            {
                dicePictureBox.Load(@"..\..\Resources\2dieRed.png");
                currentTurnScore += die;
            }
            else if (die == 3)
            {
                dicePictureBox.Load(@"..\..\Resources\3dieRed.png");
                currentTurnScore += die;
            }
            else if (die == 4)
            {
                dicePictureBox.Load(@"..\..\Resources\4dieRed.png");
                currentTurnScore += die;
            }
            else if (die == 5)
            {
                dicePictureBox.Load(@"..\..\Resources\5dieRed.png");
                currentTurnScore += die;
            }
            else
            {
                dicePictureBox.Load(@"..\..\Resources\6dieRed.png");
                currentTurnScore += die;
            }

            if (turn == 1)
            {
                turn1Score = currentTurnScore;
                turn1ScoreLabel.Text = turn1Score.ToString();

            }
            else if (turn == 2)
            {
                turn2Score = currentTurnScore;
                turn2ScoreLabel.Text = turn2Score.ToString();
            }
            else if (turn == 3)
            {
                turn3Score = currentTurnScore;
                turn3ScoreLabel.Text = turn3Score.ToString();
            }
            else if (turn == 4)
            {
                turn4Score = currentTurnScore;
                turn4ScoreLabel.Text = turn4Score.ToString();
            }
            else
            {
                turn5Score = currentTurnScore;
                turn5ScoreLabel.Text = turn5Score.ToString();
            }
        }

        private void keepButton_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                totalScore += currentTurnScore;
                totalScorelabel.Text = totalScore.ToString();
                turn1ScoreLabel.Text = currentTurnScore.ToString();
                turn1Label.Enabled = false;
                turn2Label.Enabled = true;
                turn1ScoreLabel.BackColor = SystemColors.ControlDark;
                turn2ScoreLabel.BackColor = SystemColors.Control;
                currentTurnScore = 0;
                turn++;
            }
            else if (turn == 2)
            {
                totalScore += currentTurnScore;
                totalScorelabel.Text = totalScore.ToString();
                turn2ScoreLabel.Text = currentTurnScore.ToString();
                turn2Label.Enabled = false;
                turn3Label.Enabled = true;
                turn2ScoreLabel.BackColor = SystemColors.ControlDark;
                turn3ScoreLabel.BackColor = SystemColors.Control;
                currentTurnScore = 0;
                turn++;
            }
            else if (turn == 3)
            {
                totalScore += currentTurnScore;
                totalScorelabel.Text = totalScore.ToString();
                turn3ScoreLabel.Text = currentTurnScore.ToString();
                turn3Label.Enabled = false;
                turn4Label.Enabled = true;
                turn3ScoreLabel.BackColor = SystemColors.ControlDark;
                turn4ScoreLabel.BackColor = SystemColors.Control;
                currentTurnScore = 0;
                turn++;
            }
            else if (turn == 4)
            {
                totalScore += currentTurnScore;
                totalScorelabel.Text = totalScore.ToString();
                turn4ScoreLabel.Text = currentTurnScore.ToString();
                turn4Label.Enabled = false;
                turn5Label.Enabled = true;
                turn4ScoreLabel.BackColor = SystemColors.ControlDark;
                turn5ScoreLabel.BackColor = SystemColors.Control;
                currentTurnScore = 0;
                turn++;
            }
            else
            {
                totalScore += currentTurnScore;
                totalScorelabel.Text = totalScore.ToString();
                turn5ScoreLabel.Text = currentTurnScore.ToString();
                turn5Label.Enabled = false;
                rollButton.Enabled = false;
                keepButton.Enabled = false;
                turn5ScoreLabel.BackColor = SystemColors.ControlDark;
                currentTurnScore = 0;
            }

            if (die == 2)
            {
                dicePictureBox.Load(@"..\..\Resources\2dieGrey.png");
            }
            else if (die == 3)
            {
                dicePictureBox.Load(@"..\..\Resources\3dieGrey.png");
            }
            else if (die == 4)
            {
                dicePictureBox.Load(@"..\..\Resources\4dieGrey.png");
            }
            else if (die == 5)
            {
                dicePictureBox.Load(@"..\..\Resources\5dieGrey.png");
            }
            else if (die == 6)
            {
                dicePictureBox.Load(@"..\..\Resources\6dieGrey.png");
            }
            else
            {
                dicePictureBox.Load(@"..\..\Resources\1dieGrey.png");
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset()
        {
            rollButton.Focus();
            rollButton.Enabled = true;
            keepButton.Enabled = true;
            turn2Label.Enabled = false;
            turn3Label.Enabled = false;
            turn4Label.Enabled = false;
            turn5Label.Enabled = false;

            turn2ScoreLabel.BackColor = SystemColors.ControlDark;
            turn3ScoreLabel.BackColor = SystemColors.ControlDark;
            turn4ScoreLabel.BackColor = SystemColors.ControlDark;
            turn5ScoreLabel.BackColor = SystemColors.ControlDark;

            turn = 1;
            totalScore = 0;
            turn1Score = 0;
            turn2Score = 0;
            turn3Score = 0;
            turn4Score = 0;
            turn5Score = 0;
            currentTurnScore = 0;

            totalScorelabel.Text = totalScore.ToString();
            turn1ScoreLabel.Text = "";
            turn2ScoreLabel.Text = "";
            turn3ScoreLabel.Text = "";
            turn4ScoreLabel.Text = "";
            turn5ScoreLabel.Text = "";
            dicePictureBox.Image = null;
        }
    }
}
