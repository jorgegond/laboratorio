using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool content = true; int i = 35;string mystring = " hello world";

            int [] myints = {3,5,6};

            textBox1.Text= Convert.ToString(content);
            //textBox1.Text = "Hello World";
            textBox2.Text = Convert.ToString(i);
            textBox3.Text = mystring;
            string vec = "";
            for (int x = 0; x < myints.Length; x++) {
               vec +=" "+ myints[x].ToString();
            } textBox4.Text = vec;
           
            bool myTest;
            myTest=true;

            if(myTest== false)
            {
                textBox5.Text = "Hello1";
            }
            else
            { textBox5.Text = "Hello2"; }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
