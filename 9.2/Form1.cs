using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._2
    
{
    interface Imes
    {
        void Mes(string a, string b, string c);
    }
    public partial class Form1 : Form, Imes
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  void  Mes(string a , string b , string c)
        {
            string a1 = a;
            textBox2.Text = a1;
            string a2 = b;
            textBox3.Text = a2;
            string a3 = c;
            textBox4.Text = a3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h =  textBox1.Text;
            if (h == "зима")
            {
                Mes("декабрь" ,"январь","февраль");
            }
            else if (h == "весна")
            { 
                Mes("март", "апрель", "май");
            }
            else if(h=="лето")
            {
                Mes("июнь", "июль", "август");
            }
            else
            {
                Mes("сентябрь", "октябрь", "ноябрь");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
