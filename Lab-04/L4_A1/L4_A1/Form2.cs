using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4_A1
{
    public partial class Form2 : Form
    {
        public static int[] matrix1 = new int[6];
        public static int[] matrix2Values;

        public Form2()
        {
            //Form1 obj1 = new Form1();
            InitializeComponent();
            matrix2Values = new int[6];
            matrix1 = Form1.matrix1Values;
        }

        public void storeMatrixTwo()
        {
            matrix2Values[0] = Convert.ToInt32(textBox1.Text);
            matrix2Values[1] = Convert.ToInt32(textBox2.Text);
            matrix2Values[2] = Convert.ToInt32(textBox3.Text);
            matrix2Values[3] = Convert.ToInt32(textBox4.Text);
            matrix2Values[4] = Convert.ToInt32(textBox5.Text);
            matrix2Values[5] = Convert.ToInt32(textBox6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storeMatrixTwo();
            this.Hide();
            Form3 obj = new Form3();
            obj.Show();
        }
    }
}
