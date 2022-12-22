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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SingleLinkedList list = new SingleLinkedList();

        


        public void add_record()
        {
            string first_name = Std_name.Text;
            string last_name = std_last_name.Text;
            string city_name = city.Text;
            string address = Address.Text;
            string mob_no = phone_no.Text;

            list.Insert_at_end(first_name, last_name, address, city_name, mob_no);

        }

        public void clr_text()
        {
            Std_name.Text = "";
            std_last_name.Text = "";
            city.Text = "";
            Address.Text = "";
            phone_no.Text = "";
        }

        private void show_std_info_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form = new Form2();
            Node temp = list.head;
            form.node_set(temp);

            form.ShowDialog();
            this.Dispose();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clr_text();
        }

        private void add_std_Click(object sender, EventArgs e)
        {
            add_record();
            clr_text();
        }
    }


    public class Node
    {
        public string first_name;
        public string last_name;
        public string address;
        public string city_name;
        public string mob_no;

        public Node next;
        public Node(string a, string b, string c, string d, string e)
        {
            first_name = a;
            last_name = b;
            address = c;
            city_name = d;
            mob_no = e;
            next = null;
        }
    }

    class SingleLinkedList
    {
        public Node head;

        public void Insert_at_end(string first_name, string last_name, string address, string city_name, string mob_no)
        {
            Node new_node = new Node(first_name, last_name, address, city_name, mob_no);

            if (head == null)
            {
                head = new_node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = new_node;
            }
        }
    }
}
