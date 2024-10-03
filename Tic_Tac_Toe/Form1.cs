using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private bool isPlayerOneTurn = true;  // true = Player 1's turn, false = Player 2's turn
        private int turnCount = 0;            // Count the number of turns taken
        private int playerOneScore = 0;
        private int playerTwoScore = 0;
        private Label playerOneScoreLabel;
        private Label playerTwoScoreLabel;
        private Label winnerLabel;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (isPlayerOneTurn)
                {
                    button.Text = "X";
                    button.ForeColor = Color.Red;
                }
                else
                {
                    button.Text = "O";
                    button.ForeColor = Color.Blue;
                }
                isPlayerOneTurn = !isPlayerOneTurn;
                turnCount++;

                if (CheckForWinner())
                {
                    DisableButtons();
                    string winner = isPlayerOneTurn ? "Player 2" : "Player 1";

                    // Update the score
                    if (!isPlayerOneTurn)  // Player 1 wins
                    {
                        playerOneScore++;
                        playerOneScoreLabel.Text = "Player 1: " + playerOneScore.ToString();
                    }
                    else  // Player 2 wins
                    {
                        playerTwoScore++;
                        playerTwoScoreLabel.Text = "Player 2: " + playerTwoScore.ToString();
                    }

                    winnerLabel.Text = winner + " wins!";

                }
                else if (turnCount == 9)
                {
                    // Game is a draw
                    winnerLabel.Text = "It's a draw!";
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Define a black pen
            Pen blackPen = new Pen(Color.Black,12);

            // Draw vertical lines
            e.Graphics.DrawLine(blackPen, A2.Left - 5, A1.Top, A2.Left - 5, C1.Bottom); // Between column 1 and 2
            e.Graphics.DrawLine(blackPen, A3.Left - 5, A1.Top, A3.Left - 5, C1.Bottom); // Between column 2 and 3

            // Draw horizontal lines
            e.Graphics.DrawLine(blackPen, A1.Left, B1.Top - 5, A3.Right, B1.Top - 5);  // Between row 1 and 2
            e.Graphics.DrawLine(blackPen, A1.Left, C1.Top - 5, A3.Right, C1.Top - 5);  // Between row 2 and 3
        }

        private bool CheckForWinner()
        {
            // Horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Text != ""))
                return true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != ""))
                return true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != ""))
                return true;

            // Vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != ""))
                return true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != ""))
                return true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != ""))
                return true;

            // Diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != ""))
                return true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Text != ""))
                return true;

            return false;
        }

        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && c.Name != "resetButton")
                {
                    ((Button)c).Enabled = false;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            isPlayerOneTurn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                if (c is Button && c.Name != "resetButton")
                {
                    ((Button)c).Enabled = true;
                    ((Button)c).Text = "";
                }
            }
            // Reset the winner label
            winnerLabel.Text = "";
        }

        
    }
}