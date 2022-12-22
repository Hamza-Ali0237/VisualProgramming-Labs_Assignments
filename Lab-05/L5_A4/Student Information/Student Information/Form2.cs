using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information
{
    public partial class Form2 : Form
    {
        SingleLinkedList_new list = new SingleLinkedList_new();
        public Form2()
        {
            InitializeComponent();
        }

        public void node_set(Node temp)
        {
            list.head_setter(temp);
            Display_in_list_Box();
        }

        public void Display_in_list_Box()
        {
            Node temp = list.head;

            Std_name.Text = temp.first_name;
            std_last_name.Text = temp.last_name;
            Address.Text = temp.address;
            city.Text = temp.city_name;
            phone_no.Text = temp.mob_no;            
            
            while(temp != null)
            {
                list_box.Items.Add(temp.first_name);
                temp = temp.next;
            }

        }

        public void text_setter(string str)
        {
            Node temp = list.SearchElement(str);

            Std_name.Text = temp.first_name;
            std_last_name.Text = temp.last_name;
            Address.Text = temp.address;
            city.Text = temp.city_name;
            phone_no.Text = temp.mob_no;

        }

        private void clr_Click(object sender, EventArgs e)
        {
            Display_in_list_Box();
        }

        private void list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = list_box.SelectedItem.ToString();
            text_setter(str);
        }
    }

    class SingleLinkedList_new
    {
        public Node head;

        public void head_setter(Node temp)
        {
            head = temp;
        }

        public Node SearchElement(string searchValue)
        {

            Node temp = head;

            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.first_name == searchValue)
                    {
                        break;
                    }
                    temp = temp.next;
                }
            }

            return temp;
        }

    }
}