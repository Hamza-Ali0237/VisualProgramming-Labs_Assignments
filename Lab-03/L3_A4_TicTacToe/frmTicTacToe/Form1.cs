namespace frmTicTacToe
{
    public partial class Form1 : Form
    {
        Class1 obj = new Class1();
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (obj.getToggleValue)
            {
                button1.Text = obj.getUserOne;
                
                obj.toggleValue = false;
            } else
            {
                button1.Text = obj.getUserTwo;
                obj.toggleValue = true;
            }
            togglePlayer();
            button1.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (obj.getToggleValue)
            {
                button2.Text = obj.getUserOne;
                obj.toggleValue = false;
            }
            else
            {
                button2.Text = obj.getUserTwo;
                obj.toggleValue = true;
            }
            togglePlayer();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (obj.getToggleValue)
            {
                button3.Text = obj.getUserOne;
                obj.toggleValue = false;
            }
            else
            {
                button3.Text = obj.getUserTwo;
                obj.toggleValue = true;
            }
            togglePlayer();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (obj.getToggleValue)
            {
                button4.Text = obj.getUserOne;
                obj.toggleValue = false;
            }
            else
            {
                button4.Text = obj.getUserTwo;
                obj.toggleValue = true;
            }
            togglePlayer();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (obj.getToggleValue)
            {
                button5.Text = obj.getUserOne;
                obj.toggleValue = false;

            }
            else
            {
                button5.Text = obj.getUserTwo;
                obj.toggleValue = true;

            }
            togglePlayer();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (obj.getToggleValue)
            {
                button6.Text = obj.getUserOne;
                obj.toggleValue = false;
            }
            else
            {
                button6.Text = obj.getUserTwo;
                obj.toggleValue = true;
            }
            togglePlayer();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (obj.getToggleValue)
            {
                button7.Text = obj.getUserOne;
                obj.toggleValue = false;
            }
            else
            {
                button7.Text = obj.getUserTwo;
                obj.toggleValue = true;

            }
            togglePlayer();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (obj.getToggleValue)
            {
                button8.Text = obj.getUserOne;
                obj.toggleValue = false;
            }
            else
            {
                button8.Text = obj.getUserTwo;
                obj.toggleValue = true;
            }
            togglePlayer();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (obj.getToggleValue)
            {
                button9.Text = obj.getUserOne;
                obj.toggleValue = false;
            }
            else
            {
                button9.Text = obj.getUserTwo;
                obj.toggleValue = true;
            }
            togglePlayer();
            button9.Enabled = false;
        }

        private void togglePlayer()
        {
            if(obj.getToggleValue)
            {
                turnLabel.Text = "Turn: Player1";
            } else
            {
                turnLabel.Text = "Turn: Player2";
            }
        }

    }
}