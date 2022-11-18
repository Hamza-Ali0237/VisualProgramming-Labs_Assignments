
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4_A2_MatrixMultiplication
{
    public partial class Form3 : Form
    {

        public static int[,] matrixFrm3 = new int[3, 3];
        public static int[,] matrixValueFrm1;
        public static int[,] matrixValueFrm2;

        public Form3()
        {
            //matrixFrm3 = new int[3, 3];
            matrixValueFrm1 = Form1.matrixFrm1;
            matrixValueFrm2 = Form2.matrixFrm2;
            InitializeComponent();
            matrixMultiplication();
            showResults();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void matrixMultiplication()
        {
            matrixFrm3[0, 0] = (matrixValueFrm1[0, 0] * matrixValueFrm2[0, 0]) + (matrixValueFrm1[0, 1] * matrixValueFrm2[1, 0]) + (matrixValueFrm1[0, 2] + matrixValueFrm2[2, 0]);
            matrixFrm3[0, 1] = (matrixValueFrm1[0, 0] * matrixValueFrm2[0, 1]) + (matrixValueFrm1[0, 1] * matrixValueFrm2[1, 1]) + (matrixValueFrm1[0, 2] + matrixValueFrm2[2, 1]);
            matrixFrm3[0, 2] = (matrixValueFrm1[0, 0] * matrixValueFrm2[0, 2]) + (matrixValueFrm1[0, 1] * matrixValueFrm2[1, 2]) + (matrixValueFrm1[0, 2] + matrixValueFrm2[2, 2]);

            matrixFrm3[1, 0] = (matrixValueFrm1[1, 0] * matrixValueFrm2[0, 0]) + (matrixValueFrm1[1, 1] * matrixValueFrm2[1, 0]) + (matrixValueFrm1[1, 2] + matrixValueFrm2[2, 0]);
            matrixFrm3[1, 1] = (matrixValueFrm1[1, 0] * matrixValueFrm2[0, 1]) + (matrixValueFrm1[1, 1] * matrixValueFrm2[1, 1]) + (matrixValueFrm1[1, 2] + matrixValueFrm2[2, 1]);
            matrixFrm3[1, 2] = (matrixValueFrm1[1, 0] * matrixValueFrm2[0, 2]) + (matrixValueFrm1[1, 1] * matrixValueFrm2[1, 2]) + (matrixValueFrm1[1, 2] + matrixValueFrm2[2, 2]);

            matrixFrm3[2, 0] = (matrixValueFrm1[2, 0] * matrixValueFrm2[0, 0]) + (matrixValueFrm1[2, 1] * matrixValueFrm2[1, 0]) + (matrixValueFrm1[2, 2] + matrixValueFrm2[2, 0]);
            matrixFrm3[2, 1] = (matrixValueFrm1[2, 0] * matrixValueFrm2[0, 1]) + (matrixValueFrm1[2, 1] * matrixValueFrm2[1, 1]) + (matrixValueFrm1[2, 2] + matrixValueFrm2[2, 1]);
            matrixFrm3[2, 2] = (matrixValueFrm1[2, 0] * matrixValueFrm2[0, 2]) + (matrixValueFrm1[2, 1] * matrixValueFrm2[1, 2]) + (matrixValueFrm1[2, 2] + matrixValueFrm2[2, 2]);

        }

        public void showResults()
        {
            matrixMultiplication();
            for(int i =0; i<matrixFrm3.GetLength(0); i++)
            {
                for (int j = 0; j < matrixFrm3.GetLength(1); j++)
                {
                    label1.Text += Convert.ToString(matrixFrm3[i,j]) + "  ";
                }

                label1.Text += "\n";
            }
        }
    }
}
