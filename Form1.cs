using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //массив простых чисел
        int[] masPrCh = new int[] 
        { 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,
          43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        int p = 0, q = 0, n = 0, f_n = 0, E = 0, d = 0;

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Список известных простых чисел: \n\r" +
           " 3, 5, 7, 11, 13, 17,\n\r" + " 19, 23, 29, 31, 37, 41,\n\r" +
           " 43, 47, 53, 59, 61, 67,\n\r" + " 71, 73, 79, 83, 89, 97");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получение p и q
            p = Convert.ToInt32(textBox3.Text);
            q = Convert.ToInt32(textBox4.Text);
            //получение n и f_n
            n = p * q; f_n = (p - 1) * (q - 1);
            //нахождение e
            for (int i = 0; i < masPrCh.Length; i++)
            { if(f_n % masPrCh[i] == 1) { E = masPrCh[i]; break; } }
            //нахождение d
            for (int i = 0; i < 100; i++)
            { if((i * E) % f_n == 1) { d = i; break; } }
            //отправка От. ключа
            textBox5.Text = "" + E; textBox6.Text = "" + n;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int ModPow(int x, int y, int z)
       => y == 0 ? 1 : (x * ModPow(x, y - 1, z)) % z;
            //От. ключ
            int E1 = Convert.ToInt32(textBox5.Text);
            int n1 = Convert.ToInt32(textBox6.Text);
            //исходное сообщение
            int M = Convert.ToInt32(textBox1.Text);
            //Зашифровка и отправка
            double C = ModPow(M, E, n);
            textBox2.Text = "" + C;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int ModPow(int x, int y, int z)
      => y == 0 ? 1 : (x * ModPow(x, y - 1, z)) % z;
            //Шифр текст
            int C = Convert.ToInt32(textBox2.Text);
            //Расшифровка
            double M = ModPow(C, d ,n);
            textBox7.Text = "" + M;
        }

    }
}
