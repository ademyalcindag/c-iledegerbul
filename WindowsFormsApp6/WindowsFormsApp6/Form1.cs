using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            int sayi1= 1;
            int tplm;
            int grln;


            grln = Convert.ToInt32(textBox1.Text);
            fibonacci.Items.Add(sayi1);
            for (int a = 0; a < grln - a; a++)
            {
                tplm= sayi + sayi1;
                fibonacci.Items.Add(tplm);
                sayi = sayi1;
                sayi1 = tplm;
            }

        }

        private void fibonacci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
