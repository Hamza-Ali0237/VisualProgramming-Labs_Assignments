namespace L2_A8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.btnDemo.Top -= 10;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.btnDemo.Left = this.btnDemo.Left - 10;
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            this.btnDemo.Top += 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.btnDemo.Left = this.btnDemo.Left + 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}