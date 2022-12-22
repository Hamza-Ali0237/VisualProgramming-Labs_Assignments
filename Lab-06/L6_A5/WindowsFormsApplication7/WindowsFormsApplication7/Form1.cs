using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
       
  
        public Form1()
        {
            InitializeComponent();
        }
        string pic = "D:\\vp\\LABS\\Lab-04\\pictureShow\\wallpapers\\";
        int count = 1;
        int prev;
        int no = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = System.IO.DriveInfo.GetDrives();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         pictureBox1.ImageLocation = pic + "\\" + count + ".jpg";
            count++;
            prev = count - 1;

            if (count > 5)
            {
                //MessageBox.Show("No More Pics !");
                count = 1;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = pic + "\\" + prev + ".jpg";
            
            if (prev < 1)
            {
                prev = 5;
                count = prev;
                pictureBox1.ImageLocation = pic + "\\" + prev + ".jpg";
            }
            prev--;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.ImageLocation = pic +"\\"+ count + ".jpg";
            count++;
            if(count == 5)
            {
                count = 1;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] dirs = System.IO.Directory.GetDirectories("C:\\");
            int i;
            String[] files = System.IO.Directory.GetFiles("C:\\");
            if (comboBox1.SelectedIndex == 0){
           
            
            for (i = 0; i < dirs.Length; i++)
            {
                listBox1.Items.Add(dirs[i]);
            }
            
            for (i = 0; i < files.Length; i++)
            {
                listBox1.Items.Add(files[i]);
            }
        }
            else if (comboBox1.SelectedIndex == 1)
            {
                dirs = System.IO.Directory.GetDirectories("D:\\");
                files = System.IO.Directory.GetFiles("D:\\");
                listBox1.Items.Clear();

                for (i = 0; i < dirs.Length; i++)
                {
                    
                    listBox1.Items.Add(dirs[i]);
                    
                }

                for (i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
               

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dirs = System.IO.Directory.GetDirectories("E:\\");
                files = System.IO.Directory.GetFiles("E:\\");
                listBox1.Items.Clear();

                for (i = 0; i < dirs.Length; i++)
                {
                    
                    listBox1.Items.Add(dirs[i]);
                    
                }

                for (i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
                

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           pic = listBox1.SelectedItem.ToString();
             no = System.IO.Directory.GetFiles(pic).Length;
            Console.WriteLine(no);
            pictureBox1.ImageLocation = pic+"\\" + count+ ".jpg";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = pic + "\\" + no + ".jpg";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = pic + "\\" + "1" + ".jpg";
        }
    }

}
