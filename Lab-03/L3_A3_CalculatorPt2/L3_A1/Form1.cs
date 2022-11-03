using System.Data;

namespace L3_A1
{
    public partial class Form1 : Form
    {

        //int firstValue;
        //int secondValue;
        //string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBox.Clear();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBox.Text += "+";
            //firstValue = Convert.ToInt32(txtBox.Text);
            //operation = "+";
            //txtBox.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtBox.Text +="-";
            //firstValue = Convert.ToInt32(txtBox.Text);
            //operation = "-";
            //txtBox.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtBox.Text += "*";
            //irstValue = Convert.ToInt32(txtBox.Text);
            //operation = "*";
            //txtBox.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtBox.Text += "/";
            //firstValue = Convert.ToInt32(txtBox.Text);
            //operation = "/";
            //txtBox.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            /*if(string.Equals(operation, "+"))
            {
                secondValue = Convert.ToInt32(txtBox.Text);
                txtBox.Text = "" + (firstValue + secondValue);
            } else if(string.Equals(operation, "-")) 
            {
                secondValue = Convert.ToInt32(txtBox.Text);
                txtBox.Text = "" + (firstValue - secondValue);
            } else if(string.Equals(operation, "*"))
            {
                secondValue = Convert.ToInt32(txtBox.Text);
                txtBox.Text = "" + (firstValue * secondValue);
            } else if(string.Equals(operation, "/"))
            {
                secondValue = Convert.ToInt32(txtBox.Text);
                txtBox.Text = "" + (firstValue / secondValue);
            }*/
            DataTable dt = new DataTable();
            var results = dt.Compute(txtBox.Text, "");
            results = Convert.ToDouble(results);
            txtBox.Text = Convert.ToString(results);
        }
    }
}