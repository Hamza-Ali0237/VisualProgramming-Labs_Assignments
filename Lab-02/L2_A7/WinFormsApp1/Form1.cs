namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblBill_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateBill_Click(object sender, EventArgs e)
        {
            int units = Convert.ToInt32(txtUnits.Text);
            int calUnits;
            if(units <= 0)
            {
                lblBill.Text = "Wrong units! No bill to calculate";
            } else if(units >= 0 && units <=100)
            {
                calUnits = 2 * units;
                lblBill.Text = Convert.ToString(calUnits);
            } else if(units > 100 && units <= 200)
            {
                calUnits = 3 * units;
                lblBill.Text = Convert.ToString(calUnits);
            } else if(units > 200 && units <= 300)
            {
                calUnits = 4 * units;
                lblBill.Text = Convert.ToString(calUnits);
            } else if(units > 300 && units <= 400)
            {
                calUnits = 7 * units;
                lblBill.Text = Convert.ToString(calUnits);
            } else if(units > 400)
            {
                int hundred = units / 100;
                hundred = hundred * 2;
                lblBill.Text = Convert.ToString(hundred + (7 * units));
            }
        }
    }
}