namespace L4_A2_MatrixMultiplication
{
    public partial class Form1 : Form
    {
        public static int[,] matrixFrm1 = new int[3, 3];
        public Form1()
        {
            //matrixFrm1 = new int[3, 3];
            InitializeComponent();;

        }

        public void setValues()
        {
            matrixFrm1[0, 0] = Convert.ToInt32(textBox1.Text);
            matrixFrm1[0, 1] = Convert.ToInt32(textBox2.Text);
            matrixFrm1[0, 2] = Convert.ToInt32(textBox3.Text);

            matrixFrm1[1, 0] = Convert.ToInt32(textBox4.Text);
            matrixFrm1[1, 1] = Convert.ToInt32(textBox5.Text);
            matrixFrm1[1, 2] = Convert.ToInt32(textBox6.Text);

            matrixFrm1[2, 0] = Convert.ToInt32(textBox7.Text);
            matrixFrm1[2, 1] = Convert.ToInt32(textBox8.Text);
            matrixFrm1[2, 2] = Convert.ToInt32(textBox9.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setValues();
            this.Hide();
            Form2 obj = new Form2();
            obj.ShowDialog();
        }
    }
}