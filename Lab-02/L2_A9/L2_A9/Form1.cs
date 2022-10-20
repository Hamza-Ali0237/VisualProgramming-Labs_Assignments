namespace L2_A9
{
    public partial class Form1 : Form
    {
        int firstValue;
        int secondValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToInt32(this.textFirstValue.Text);
            secondValue = Convert.ToInt32(this.txtSecondValue.Text);

            this.txtResult.Text = "" + (firstValue + secondValue);

            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToInt32(this.textFirstValue.Text);
            secondValue = Convert.ToInt32(this.txtSecondValue.Text);

            this.txtResult.Text = "" + (firstValue - secondValue);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToInt32(this.textFirstValue.Text);
            secondValue = Convert.ToInt32(this.txtSecondValue.Text);

            this.txtResult.Text = "" + (firstValue * secondValue);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToInt32(this.textFirstValue.Text);
            secondValue = Convert.ToInt32(this.txtSecondValue.Text);

            this.txtResult.Text = "" + (firstValue / secondValue);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textFirstValue.Clear();
            this.txtSecondValue.Clear();
            this.txtResult.Clear();
        }
    }
}