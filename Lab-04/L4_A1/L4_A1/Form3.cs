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
    public partial class Form3 : Form
    {
        public int[] resultMatrix = new int[6];
        public static int[] matrix2;
        public static int[] matrix1frm3;

        public Form3()
        {
            InitializeComponent();
            matrix2 = Form2.matrix2Values;
            matrix1frm3 = Form2.matrix1;
            additionOfMatrices();
            showResult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void additionOfMatrices()
        {
            Form1 obj1 = new Form1();
            Form2 obj2 = new Form2();

            resultMatrix[0] = matrix1frm3[0] + matrix2[0];
            resultMatrix[1] = matrix1frm3[1] + matrix2[1];
            resultMatrix[2] = matrix1frm3[2] + matrix2[2];
            resultMatrix[3] = matrix1frm3[3] + matrix2[3];
            resultMatrix[4] = matrix1frm3[4] + matrix2[4];
            resultMatrix[5] = matrix1frm3[5] + matrix2[5];
        }

        /*private void label1_Click(object sender, EventArgs e)
        {
            additionOfMatrices();
            label1.Text = "";

            label1.Text += Convert.ToString(resultMatrix[0]) + "\t\t";
            label1.Text += Convert.ToString(resultMatrix[1] + "\t\t");
            label1.Text += Convert.ToString(resultMatrix[2] + "\t\t" + "\n");
            label1.Text += Convert.ToString(resultMatrix[3] + "\t\t");
            label1.Text += Convert.ToString(resultMatrix[4] + "\t\t");
            label1.Text += Convert.ToString(resultMatrix[5] + "\t\t");
        }*/

        private void showResult()
        {
            additionOfMatrices();
            label1.Text = "";

            label1.Text += Convert.ToString(resultMatrix[0]) + "  ";
            label1.Text += Convert.ToString(resultMatrix[1] + "  ");
            label1.Text += Convert.ToString(resultMatrix[2] + "" + "\n");
            label1.Text += Convert.ToString(resultMatrix[3] + "  ");
            label1.Text += Convert.ToString(resultMatrix[4] + "  ");
            label1.Text += Convert.ToString(resultMatrix[5] + "");
        }
    }
}
