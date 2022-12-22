using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_named_frmSignUp
{
    public partial class Form1 : Form
    {
        TextBox[] textfield = new TextBox[4];
        Label[] label = new Label[4];
        int counter = 0;
        int height = 155;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                textfield[i] = new System.Windows.Forms.TextBox();
                textfield[i].Size = new System.Drawing.Size(219, 26);
                textfield[i].TabIndex = i + 3;

                label[i] = new System.Windows.Forms.Label();
                label[i].Size = new System.Drawing.Size(128, 16);
                int k = i + 2;
                label[i].Text = "Enter Contact No # " + k;


            }
        }


        public void modify()
        {
            height += 50;

            // setting end space label for adjustment
            space.Location = new System.Drawing.Point(233, height + 80);

            // setting text fileds
            textfield[counter].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            textfield[counter].Location = new System.Drawing.Point(156, height);

            // setting button variable location
            add.Location = new System.Drawing.Point(396, height);

            // setting label variable location
            label[counter].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label[counter].Location = new System.Drawing.Point(22, height);

            

            this.Controls.Add(textfield[counter]);
            this.Controls.Add(label[counter]);
            counter++;

            if(counter == 4)
            {
                add.Enabled = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            modify();
        }
    }
}
