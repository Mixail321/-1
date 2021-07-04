using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deffi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double usrer1 =Convert.ToDouble(textBox1.Text);
            double usrer2 = Convert.ToDouble(textBox2.Text);
            double p = Convert.ToDouble(textBox3.Text);
            double g = Convert.ToDouble(textBox4.Text);
            double A;
            double B;
            double K1;
            double K2;
            A = Math.Pow(g, usrer1) % p;
            B = Math.Pow(g, usrer2) % p;
            K1= Math.Pow(B, usrer1) % p;
            K2 = Math.Pow(A, usrer2) % p;
            if(K1==K2)
            {
                textBox5.Text =Convert.ToString(K1);
            }
            else
            {
                MessageBox.Show("Ключи неверны!Ошибка шифрования!");
            }
        }
    }
}
