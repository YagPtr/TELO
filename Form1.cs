using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TELO
{
    public partial class Form1 : Form
    {
        String CurEx="placeholder";
        int control = 0;
        int countdown=20;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (control == 0)
            {
                String i = chose();
                //i += "\r\n";
                textBox1.Text += DateTime.Now.ToString("HH:mm:ss tt");
                textBox1.Text += i;
                CurEx = i;
                control = 1;
                timer1.Enabled = false; timer2.Enabled=false;
                countdown = 20;
            }
        }
        private String chose()
        {
            String ex="Чето сломалось";
            Random rnd = new Random();
            int i;
            int forotj;
            i=rnd.Next(17);
            forotj = rnd.Next(3)+1;

            switch (i)
            {
                case 0:
                    ex = "Отжимания Трицепс 20 ";
                    ex += forotj;
                    break;
                case 1:
                    ex = "Приседания 20";
                    break;
                case 2:
                    ex = "Скручивания полные 20";
                    break;
                case 3:
                    ex = "Отжимания Грудь 20 ";
                    ex += forotj;
                    break;
                case 4:
                    ex = "Отжимания Спина 20 ";
                    ex += forotj/2;
                    break;
                case 5:
                    ex = "Отжимания Плечи 20 ";
                    ex += forotj;
                    break;
                case 6:
                    ex = "Приседания с гантелью 10";
                    break;
                case 7:
                    ex = "Скручивания неполные 30";
                    break;
                case 8:
                    ex = "Плечи 30кг 5 раз";
                    break;
                case 9:
                    ex = "Ножки уголком 35с";
                    break;
                case 10:
                    ex = "Гига березка 30с";
                    break;
                case 11:
                    ex = "Эспандер 30с";
                    break;
                case 12:
                    ex = "Планка боковая 35с";
                    break;
                case 13:
                    ex = "Скручивания вбок 36";
                    break;
                case 14:
                    ex = "Бицепс 30кг 5";
                    break;
                case 15:
                    ex = "Планка 69";
                    break;
                case 16:
                    ex = "Планка на вытянутых 46";
                    break;

            }
            return ex;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (control == 1)
            {
                String Krasivo = DateTime.Now.ToString("HH:mm:ss tt");
                Krasivo += " ";
                Krasivo += CurEx;
                Krasivo += "\r\n";
                textBox2.Text += Krasivo;
                textBox1.Text += " ✔\r\n";
                control = 0;
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (control == 1)
            {
  
                textBox1.Text += " X\r\n";
                control = 0;
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            button1_Click(sender, e);
            timer1.Enabled = false;
            countdown = 20;
            String str = countdown.ToString();
            textBox3.Text=str;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            countdown -= 1;
            String str=countdown.ToString();
            textBox3.Text=str;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
