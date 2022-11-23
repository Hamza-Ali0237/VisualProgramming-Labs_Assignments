using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.CompilerServices;
using System.IO;

namespace L4_A3
{
    public partial class Form1 : Form
    {
        string directoryName = "C:\\Users\\Humza's Macbook\\Desktop\\PicturesForL4A3";
        int count = 0;

        string[] images = new string[] { "pic1.jpeg", "pic2.jpeg"};

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.picSlideShow.ImageLocation = directoryName + @"\\" + "pic1.jpeg";
            count += 1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (count > 0)

            {

                count -= 1;

            }
            this.picSlideShow.ImageLocation = directoryName + @"\\" + images[count];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (count < images.Length - 1)
            {

                count += 1;

            }

            this.picSlideShow.ImageLocation = directoryName + @"\\" + images[count];
        }
    }
}