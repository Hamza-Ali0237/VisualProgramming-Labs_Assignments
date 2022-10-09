namespace DemoWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(text.Text == "10" || text.Text == "11" || text.Text == "12")
            {
                label2.Text = "Winter";
            } else if(text.Text == "1" || text.Text == "2" || text.Text == "3"){
                label2.Text = "Spring";
            } else if (text.Text == "4" || text.Text == "5" || text.Text == "6")
            {
                label2.Text = "Summer";
            }
            else if (text.Text == "7" || text.Text == "8" || text.Text == "9")
            {
                label2.Text = "Autumn";
            } else
            {
                label2.Text = "Enter A Proper Number Of Month";
            }
        }
    }
}