using System.Text;

namespace HangmanGame
{
    public partial class Form1 : Form
    {
         char[] wordSolved = {' ',' ','l',' ',' ',' ',' ',' ','a',' ',' ',' ',' ',' '};
        int errors = 0;
        int guessed = 0;
        int guessesLeft = 11;
        public Form1()
        {
            InitializeComponent();
            txtGuessed.Text = guessed.ToString();
            txtGuessesLeft.Text = guessesLeft.ToString();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            // string letter = (this.txtGuessBox.Text).ToString();
            char[] word = "hallucination".ToCharArray();

           
                string letter = (this.txtGuessBox.Text).ToString();

                if (letter == "a")
                {
                    int count = 0;

                    foreach (char ch in wordSolved)
                    {

                        if (ch == 'a')
                        {
                            count++;
                        }
                    }
                    if (count < 2)
                    {
                        if (wordSolved[1] == 'a')
                        {
                            wordSolved[8] = 'a';

                            string labelGuessed = lblRandom.Text;
                            int pos = 16;
                            char replace = 'a';
                            
        
                            StringBuilder sb = new StringBuilder(labelGuessed);
                            sb[pos] = replace;
                            lblRandom.Text = sb.ToString();

                       

                            guessed++;
                            txtGuessed.Text = guessed.ToString();
                            guessesLeft--;
                            txtGuessesLeft.Text = guessesLeft.ToString();

                            if (guessesLeft == 0)
                            {
                                MessageBox.Show("You Won!");
                            }
                            
                        }
                        else
                        {
                            wordSolved[1] = 'a';



                        string labelGuessed = lblRandom.Text;
                        int pos = 2;
                        char replace = 'a';


                        StringBuilder sb = new StringBuilder(labelGuessed);
                        sb[pos] = replace;
                        lblRandom.Text = sb.ToString();

                        guessed++;
                            txtGuessed.Text = guessed.ToString();
                            guessesLeft--;
                            txtGuessesLeft.Text = guessesLeft.ToString();
                            
                            if (guessesLeft == 0)
                            {
                                MessageBox.Show("You Won!");
                            }
                           


                        }
                    }
                    else
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                        MessageBox.Show("You Lost!");
                        txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;
                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }
                           
                        }
                    }
                }
                else if (letter == "l")
                {
                    int count = 0;

                    foreach (char ch in wordSolved)
                    {
                        if (ch == 'l')
                        {
                            count++;
                        }
                    }
                    if (count < 2)
                    {
                        if (wordSolved[3] == 'l')
                        {
                            wordSolved[4] = 'l';

                        string labelGuessed = lblRandom.Text;
                        int pos = 8;
                        char replace = 'l';


                        StringBuilder sb = new StringBuilder(labelGuessed);
                        sb[pos] = replace;
                        lblRandom.Text = sb.ToString();

                        guessed++;
                            txtGuessed.Text = guessed.ToString();
                            guessesLeft--;
                            txtGuessesLeft.Text = guessesLeft.ToString();

                            if (guessesLeft == 0)
                            {
                                MessageBox.Show("You Won!");
                            }
                             
                        }
                        else
                        {
                            wordSolved[3] = 'l';

                        string labelGuessed = lblRandom.Text;
                        int pos = 6;
                        char replace = 'l';


                        StringBuilder sb = new StringBuilder(labelGuessed);
                        sb[pos] = replace;
                        lblRandom.Text = sb.ToString();

                        guessed++;
                            txtGuessed.Text = guessed.ToString();
                            guessesLeft--;
                            txtGuessesLeft.Text = guessesLeft.ToString();

                            if (guessesLeft == 0)
                            {
                                MessageBox.Show("You Won!");
                            }
                            
                        }
                    }
                    else
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                            MessageBox.Show("You Lost!");
                            txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;

                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }
                           
                        }
                    }
                }
                else if (letter == "i")
                {
                    int count = 0;
                    foreach (char ch in wordSolved)
                    {
                        if (ch == 'i')
                        {
                            count++;
                        }
                    }
                    if (count < 2)
                    {
                        if (wordSolved[6] == 'i')
                        {
                            wordSolved[10] = 'i';

                        string labelGuessed = lblRandom.Text;
                        int pos = 20;
                        char replace = 'i';


                        StringBuilder sb = new StringBuilder(labelGuessed);
                        sb[pos] = replace;
                        lblRandom.Text = sb.ToString();

                        guessed++;
                            txtGuessed.Text = guessed.ToString();
                            guessesLeft--;
                            txtGuessesLeft.Text = guessesLeft.ToString();

                            if (guessesLeft == 0)
                            {
                                MessageBox.Show("You Won!");
                            }
                          

                        }
                        else
                        {
                            wordSolved[6] = 'i';

                        string labelGuessed = lblRandom.Text;
                        int pos = 12;
                        char replace = 'i';


                        StringBuilder sb = new StringBuilder(labelGuessed);
                        sb[pos] = replace;
                        lblRandom.Text = sb.ToString();

                        guessed++;
                            txtGuessed.Text = guessed.ToString();
                            guessesLeft--;
                            txtGuessesLeft.Text = guessesLeft.ToString();

                            if (guessesLeft == 0)
                            {
                                MessageBox.Show("You Won!");
                            }
                           
                        }
                    }
                    else
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                            MessageBox.Show("You Lost!");
                            txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;
                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }
                       
                        }
                    }

                }
                else if (letter == "n")
                {
                    int count = 0;
                    foreach (char ch in wordSolved)
                    {
                        if (ch == 'n')
                        {
                            count++;
                        }
                    }
                    if (count < 2)
                    {
                        if (wordSolved[7] == 'n')
                        {
                            wordSolved[12] = 'n';

                        string labelGuessed = lblRandom.Text;
                        int pos = 24;
                        char replace = 'n';


                        StringBuilder sb = new StringBuilder(labelGuessed);
                        sb[pos] = replace;
                        lblRandom.Text = sb.ToString();

                        guessed++;
                            txtGuessed.Text = guessed.ToString();
                            guessesLeft--;
                            txtGuessesLeft.Text = guessesLeft.ToString();

                            if (guessesLeft == 0)
                            {
                                MessageBox.Show("You Won!");
                            }
                           

                        }
                        else
                        {
                            wordSolved[7] = 'n';

                        string labelGuessed = lblRandom.Text;
                        int pos = 14;
                        char replace = 'n';


                        StringBuilder sb = new StringBuilder(labelGuessed);
                        sb[pos] = replace;
                        lblRandom.Text = sb.ToString();

                        guessed++;
                            txtGuessed.Text = guessed.ToString();
                            guessesLeft--;
                            txtGuessesLeft.Text = guessesLeft.ToString();

                            if (guessesLeft == 0)
                            {
                                MessageBox.Show("You Won!");
                            }
                           
                        }
                    }
                    else
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                        MessageBox.Show("You Lost!");
                        txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;
                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }
                          
                        }
                    }
                }
                else if (letter == "h")
                {
                    if (wordSolved[0] == 'h')
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                        MessageBox.Show("You Lost!");
                        txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;
                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }
                       
                        }
                    }
                    else
                    {
                        wordSolved[0] = 'h';

                    string labelGuessed = lblRandom.Text;
                    int pos = 0;
                    char replace = 'h';


                    StringBuilder sb = new StringBuilder(labelGuessed);
                    sb[pos] = replace;
                    lblRandom.Text = sb.ToString();

                    guessed++;
                        txtGuessed.Text = guessed.ToString();
                        guessesLeft--;
                        txtGuessesLeft.Text = guessesLeft.ToString();

                        if (guessesLeft == 0)
                        {
                            MessageBox.Show("You Won!");
                        }
                    
                    }
                }
                else if (letter == "u")
                {
                    if (wordSolved[4] == 'u')
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                        MessageBox.Show("You Lost!");
                        txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;
                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }
                            
                        }
                    }
                    else
                    {
                        wordSolved[4] = 'u';

                    string labelGuessed = lblRandom.Text;
                    int pos = 8;
                    char replace = 'u';


                    StringBuilder sb = new StringBuilder(labelGuessed);
                    sb[pos] = replace;
                    lblRandom.Text = sb.ToString();

                    guessed++;
                        txtGuessed.Text = guessed.ToString();
                        guessesLeft--;
                        txtGuessesLeft.Text = guessesLeft.ToString();

                        if (guessesLeft == 0)
                        {
                            MessageBox.Show("You Won!");
                        }
                   
                    }
                }
                else if (letter == "c")
                {
                    if (wordSolved[5] == 'c')
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                        MessageBox.Show("You Lost!");
                        txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;
                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }
                          
                        }
                    }
                    else
                    {
                        wordSolved[5] = 'c';

                    string labelGuessed = lblRandom.Text;
                    int pos = 10;
                    char replace = 'c';


                    StringBuilder sb = new StringBuilder(labelGuessed);
                    sb[pos] = replace;
                    lblRandom.Text = sb.ToString();

                    guessed++;
                        txtGuessed.Text = guessed.ToString();
                        guessesLeft--;
                        txtGuessesLeft.Text = guessesLeft.ToString();

                        if (guessesLeft == 0)
                        {
                            MessageBox.Show("You Won!");
                        }

                    }
                }
                else if (letter == "t")
                {
                    if (wordSolved[9] == 't')
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                        MessageBox.Show("You Lost!");
                        txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;
                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }

                        }
                    }
                    else
                    {
                        wordSolved[9] = 't';

                    string labelGuessed = lblRandom.Text;
                    int pos = 18;
                    char replace = 't';


                    StringBuilder sb = new StringBuilder(labelGuessed);
                    sb[pos] = replace;
                    lblRandom.Text = sb.ToString();

                    guessed++;
                        txtGuessed.Text = guessed.ToString();
                        guessesLeft--;
                        txtGuessesLeft.Text = guessesLeft.ToString();

                        if (guessesLeft == 0)
                        {
                            MessageBox.Show("You Won!");
                        }
                       
                    }
                }
                else if (letter == "o")
                {
                    if (wordSolved[11] == 'o')
                    {
                        if (errors == 5)
                        {
                            picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                            errors++;
                        MessageBox.Show("You Lost!");
                        txtGuessBox.ReadOnly = true;
                    }
                        else
                        {
                            errors++;
                            switch (errors)
                            {
                                case 0:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                    break;
                                case 1:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                    break;
                                case 2:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                    break;
                                case 3:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                    break;
                                case 4:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                    break;
                                case 5:
                                    picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Error");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        wordSolved[11] = 'o';

                    string labelGuessed = lblRandom.Text;
                    int pos = 22;
                    char replace = 'o';


                    StringBuilder sb = new StringBuilder(labelGuessed);
                    sb[pos] = replace;
                    lblRandom.Text = sb.ToString();
                    guessed++;
                        txtGuessed.Text = guessed.ToString();
                        guessesLeft--;
                        txtGuessesLeft.Text = guessesLeft.ToString();

                        if (guessesLeft == 0)
                        {
                            MessageBox.Show("You Won!");
                        }
                     
                    }
                }
                else
                {
                    if (errors == 5)
                    {
                        picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                        errors++;
                    MessageBox.Show("You Lost!");
                    txtGuessBox.ReadOnly = true;
                }
                    else
                    {
                        errors++;
                        switch (errors)
                        {
                            case 0:
                                picGuess.Image = HangmanGame.Properties.Resources.hangman0;
                                break;
                            case 1:
                                picGuess.Image = HangmanGame.Properties.Resources.hangman1;
                                break;
                            case 2:
                                picGuess.Image = HangmanGame.Properties.Resources.hangman2;
                                break;
                            case 3:
                                picGuess.Image = HangmanGame.Properties.Resources.hangman3;
                                break;
                            case 4:
                                picGuess.Image = HangmanGame.Properties.Resources.hangman4;
                                break;
                            case 5:
                                picGuess.Image = HangmanGame.Properties.Resources.hangman5;
                                break;
                            case 6:
                                picGuess.Image = HangmanGame.Properties.Resources.hangman6;
                                break;
                            default:
                                Console.WriteLine("Unknown Error");
                                break;
                        }
                     
                    }
                }
            
          

        }

        private void txtGuessBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void picGuess_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}