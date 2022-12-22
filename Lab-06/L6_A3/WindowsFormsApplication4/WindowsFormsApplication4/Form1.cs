using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        string com;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        foreach (Control c in groupBox1.Controls)
            {

                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = c as RadioButton;
                    if (rb.Checked)
                    {
                        com = "Size is:" + rb.Name +"\n"; 
                       
                    }
                }
            }

        foreach (Control c in groupBox2.Controls)
        {
            if (c.GetType() == typeof(CheckBox))
            {
                CheckBox rb = c as CheckBox;
                if (rb.Checked)
                {
                    //MessageBox.Show("Toppings:" + rb.Name);
                    com+= "Toppings:" + rb.Name +"\n"; 
                   
                }
            }
        }


        foreach (Control c in groupBox3.Controls)
        {
            if (c.GetType() == typeof(RadioButton))
            {
                RadioButton rb = c as RadioButton;
                if (rb.Checked)
                {
                   // MessageBox.Show("CrustType:" + rb.Name);

                    com += "CrustType:" + rb.Name + "\n"; 
                }
            }
        }

        foreach (Control c in groupBox4.Controls)
        {
            if (c.GetType() == typeof(RadioButton))
            {
                RadioButton rb = c as RadioButton;
                if (rb.Checked)
                {
                    MessageBox.Show(com+ "Service:"+rb.Name);
                }
            }
        }

            }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        }
    }

