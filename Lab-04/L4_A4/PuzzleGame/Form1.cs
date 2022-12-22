using System.Media;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        static int count;
        List<int> list = new List<int>();
        int number;
        //QPicNumber for the original picture number of question.
        static int QPicNumber;
        //Priority that if reaches 0, button needs to have QPicNumber's picture.
        int priority;
        int errors;

        SoundPlayer music;
        SoundPlayer win;
        SoundPlayer fail;
        
        public Form1()
        {
            playMusic();
            InitializeComponent();
            Random rnd = new Random();
            QPicNumber = rnd.Next(1,15);
            btnPic.BackgroundImage = Image.FromFile(@$"E:\Academic\5th\VP\Lab 04\PuzzleGame\PuzzleGame\picDirectory\{QPicNumber.ToString()}.png");
            btnPic.BackgroundImageLayout = ImageLayout.Stretch;
            count = 0;
            priority = 3;
            this.errors = 0;

            
           

            win = new SoundPlayer(@"E:\Academic\5th\VP\Lab 04\PuzzleGame\PuzzleGame\soundDirectory\win.wav");
            fail = new SoundPlayer(@"E:\Academic\5th\VP\Lab 04\PuzzleGame\PuzzleGame\soundDirectory\fail.wav");
            
        }

        void playMusic()
        {
            music = new SoundPlayer(@"E:\Academic\5th\VP\Lab 04\PuzzleGame\PuzzleGame\soundDirectory\music.wav");
            music.Load();
            music.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        void checkWinner()
        {
            if (count == 3)
            {
                music.Stop();
                win.Play();
                DialogResult dialogResult = MessageBox.Show("You Won! \nDo you want to play again?", "Congrats!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                this.Dispose();

                this.Dispose();
            }
        }

        

        void checkLose()
        {
            if(errors == 3)
            {
                music.Stop();
                fail.Play();
                DialogResult dialogResult = MessageBox.Show("You Lost! \nDo you want to play again?", "You Failed", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                this.Dispose();
            }
        }

        void SetImage(Button btn){
            /*
            if (count == 3)
            {
                list.Add(QPicNumber);
                do
                {
                    number = rnd.Next(1, 15);
                } while (list.Contains(number));
                btn.BackgroundImage = Image.FromFile($@"E:\Academic\5th\VP\Lab 04\PuzzleGame\PuzzleGame\picDirectory\{number.ToString()}.png");
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
            */
            if(priority == 0)
            {
               btn.BackgroundImage = Image.FromFile($@"E:\Academic\5th\VP\Lab 04\PuzzleGame\PuzzleGame\picDirectory\{QPicNumber.ToString()}.png");
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                //Counting if the button's image is same as the btnPic's image then incrementing the counter.
                count++;
                priority += 3;
                checkWinner();
          
            }

            else
            {
                do
                {
                    number = rnd.Next(1, 15);
                } while (list.Contains(number));
                
                btn.BackgroundImage = Image.FromFile($@"E:\Academic\5th\VP\Lab 04\PuzzleGame\PuzzleGame\picDirectory\{number.ToString()}.png");
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                if (number != QPicNumber)
                {
                    list.Add(number);
                    priority--;
                    errors++;
                    checkLose();
                }
                else
                {
                    priority += 3;
                    count++;
                    checkWinner();
                }               
            }
           
                
        
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btnEvery_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SetImage(btn);

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {

        }

        private void btn11_Click(object sender, EventArgs e)
        {

        }

        private void btn12_Click(object sender, EventArgs e)
        {

        }

        private void btn13_Click(object sender, EventArgs e)
        {

        }

        private void btn14_Click(object sender, EventArgs e)
        {

        }

        private void btn15_Click(object sender, EventArgs e)
        {

        }

        private void btn16_Click(object sender, EventArgs e)
        {

        }
    }
}