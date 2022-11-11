using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace tekrar5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // -----------GERİYE DEĞER DÖNDÜRMEYEN METODLAR-------------

        // [1] Renklendirme metodu
        public void Renklendir()
        {
            textBox1.BackColor = Color.Aqua;
            textBox2.BackColor = Color.DarkOrchid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renklendir();
        }


        // [2] Temizleme metodu
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.BackColor = DefaultBackColor;
            textBox2.BackColor = DefaultBackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        // [3] Hesapla adlı iki parametreli metod ile çarpma yapma
        public void Hesapla(int s1, int s2)
        {
            int sonuc = s1 * s2;
            label1.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hesapla(10, 20);
        }

        // [4] Hesapla2 adlı iki parametreli metod ile girilen sayıları çarpma
        public void Hesapla2(int s1, int s2)
        {
            int carpim = s1 * s2;
            MessageBox.Show(s1 + " * " + s2 + " = " + carpim);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox3.Text);
            int s2 = Convert.ToInt16(textBox4.Text);
            Hesapla2(s1, s2);
        }

        // [5] başka bir namespace,class altında bulunan bir metodu çağırma 
        public void Bar()
        {
            MessageBox.Show("Bar");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Test.Sample.Foo();
            Bar();
        }
    }
}

// [5] başka bir namespace,class altında bulunan bir metodu çağırma
namespace Test
{
    class Sample
    {
        public static void Foo()
        {
            MessageBox.Show("Foo");
        }
    }
}
