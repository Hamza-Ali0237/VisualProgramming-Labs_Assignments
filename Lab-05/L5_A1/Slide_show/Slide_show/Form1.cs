using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_show
{
    
    public partial class Form1 : Form
    {
        int i = 1;
        int turn = 0;
        string[] images;
        public Form1()
        {
            InitializeComponent();
            images = new string[13];

            for(int j = 0 ; j< 13 ; j++)
            {
                images[j] = "F:/Wallpaper/Mix/Colour" + j + ".jpg";
                
            }

        }

        public void slide_Show()
        {
  
            while (true)
            {
                wait(1000);
                i++;
                pic.ImageLocation = images[i];

                if(i == 12)
                {
                    i = 0;
                }
                if (turn == 0)
                {
                    break;
                }
            } 

        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if(i == 13)
            {
                i = 0;
            }
            i++;
            pic.ImageLocation = images[i];
            
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            if(i == 1)
            {
                i = 13;
            }
            i--;
            pic.ImageLocation = images[i];
        }

        private void play_Click(object sender, EventArgs e)
        {
            turn = 1;
            slide_Show();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            turn = 0;

        }
    }
}
