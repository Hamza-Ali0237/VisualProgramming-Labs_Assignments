//using L4_A2_MatrixMultiplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace L4_A2_MatrixMultiplication
{
    public partial class Form2 : Form
    {
        public static int[,] matrixFrm2 = new int[3, 3];
        public static int[,] matrixValueFrm1;
        public Form2()
        {
            //matrixFrm2 = new int[3, 3];
            matrixValueFrm1 = Form1.matrixFrm1;
            InitializeComponent();
            //setValues();
        }

        public void setValues()
        {
            matrixFrm2[0, 0] = Convert.ToInt32(textBox1.Text);
            matrixFrm2[0, 1] = Convert.ToInt32(textBox2.Text);
            matrixFrm2[0, 2] = Convert.ToInt32(textBox3.Text);

            matrixFrm2[1, 0] = Convert.ToInt32(textBox4.Text);
            matrixFrm2[1, 1] = Convert.ToInt32(textBox5.Text);
            matrixFrm2[1, 2] = Convert.ToInt32(textBox6.Text);

            matrixFrm2[2, 0] = Convert.ToInt32(textBox7.Text);
            matrixFrm2[2, 1] = Convert.ToInt32(textBox8.Text);
            matrixFrm2[2, 2] = Convert.ToInt32(textBox9.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setValues();
            this.Hide();
            Form3 obj = new Form3();
            obj.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
