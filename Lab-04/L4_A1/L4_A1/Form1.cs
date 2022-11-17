namespace L4_A1
{
    public partial class Form1 : Form
    {
        public static int[] matrix1Values;
        public Form1()
        {
            InitializeComponent();
            matrix1Values = new int[6];
        }

        public void storeMatrixOne()
        {
            matrix1Values[0] = Convert.ToInt32(textBox1.Text);
            matrix1Values[1] = Convert.ToInt32(textBox2.Text);
            matrix1Values[2] = Convert.ToInt32(textBox3.Text);
            matrix1Values[3] = Convert.ToInt32(textBox4.Text);
            matrix1Values[4] = Convert.ToInt32(textBox5.Text);
            matrix1Values[5] = Convert.ToInt32(textBox6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storeMatrixOne();
            //MessageBox.Show(Convert.ToString(matrix1Values[0]));
            this.Hide();

            Form2 obj = new Form2();
            obj.Show();
        }
    }
}