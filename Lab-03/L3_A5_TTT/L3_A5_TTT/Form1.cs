namespace L3_A5_TTT
{
    public partial class Form1 : Form
    {

        bool playerTurn = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void checkForWinner()
        {
            bool winner = false;

            // Check for horizontal
            if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text != "")
            {
                winner = true;
            }
            else if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "")
            {
                winner = true;
            }
            else if (c1.Text == c2.Text && c2.Text == c3.Text && c1.Text != "")
            {
                winner = true;
            }

            // Check for vertical
            else if (a1.Text == b1.Text && b1.Text == c1.Text && a1.Text != "")
            {
                winner = true;
            }
            else if (a2.Text == b2.Text && b2.Text == c2.Text && a2.Text != "")
            {
                winner = true;
            }
            else if (a3.Text == b3.Text && b3.Text == c3.Text && a3.Text != "")
            {
                winner = true;
            }

            // Check for diagonal
            else if (a1.Text == b2.Text && b2.Text == c3.Text && a1.Text != "")
            {
                winner = true;
            }
            else if (c1.Text == b2.Text && b2.Text == a3.Text && c1.Text != "")
            {
                winner = true;
            }

            if(winner == true)
            {
                if (playerTurn == true)
                    lblwinnerStatus.Text = "Winner is: Player Two";
                else
                    lblwinnerStatus.Text = "Winner is: Player One";

                foreach (Control b in Controls.OfType<Button>())
                {
                    b.Enabled = false;
                }

                btnPlayAgain.Enabled = true;


            } else if(turnCount == 9)
            {
                lblwinnerStatus.Text = "Match Draw!";
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            foreach(Control b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                btnPlayAgain.Text = "Play Again";
                b.Text = "";
            }

            turnCount = 0;
            lblwinnerStatus.Text = "Winner is: Still Playing";
            playerTurn = true;
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                a1.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                a1.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            a1.Enabled = false;
            checkForWinner();
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                a2.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                a2.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            a2.Enabled = false;
            checkForWinner();
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                a3.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                a3.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            a3.Enabled = false;
            checkForWinner();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                b1.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                b1.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            b1.Enabled = false;
            checkForWinner();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                b2.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                b2.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            b2.Enabled = false;
            checkForWinner();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                b3.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                b3.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            b3.Enabled = false;
            checkForWinner();
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                c1.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                c1.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            c1.Enabled = false;
            checkForWinner();
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                c2.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                c2.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            c2.Enabled = false;
            checkForWinner();
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (playerTurn == true)
            {
                c3.Text = "X";
                playerTurn = false;
                Console.WriteLine("OK");
            }
            else
            {
                c3.Text = "O";
                playerTurn = true;
            }

            
            turnCount++;
            c3.Enabled = false;
            checkForWinner();
        }
    }


}