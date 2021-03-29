using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THEMOSTBEAUTIFULPROGRAMMINYOURLIFE
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

        /* ПРОСМОТР */
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            if (radioButton1.Checked == true)
                textBox4.Text += radioButton1.Text;
            else if (radioButton2.Checked == true)
                textBox4.Text += radioButton2.Text;
            else textBox4.Text += radioButton3.Text;
            textBox4.Text += " " + comboBox1.Text + "," + "\r\n"; //закончили обращение, перенесли строку

            textBox4.Text += "приглашаю Вас ";
            if (checkBox1.Checked == true)
                textBox4.Text += checkBox1.Text; //с партнером
            textBox4.Text += "\r\n" + "на " + textBox1.Text + "," + "\r\n" + "которое состоится " + monthCalendar1.SelectionStart.ToShortDateString() + "\r\n" + "место проведения: " + textBox2.Text + "," + "\r\n";
            if (checkBox2.Checked == true)
                textBox4.Text += checkBox2.Text + "," + "\r\n"; //с величайшим уважением
            textBox4.Text += textBox3.Text + "\r\n" + "\r\n"; //отправитель

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string T = textBox4.Text;
            for (byte i = 1; i < numericUpDown1.Value; i++)
            {
                textBox4.Text += T;
            }                           
        }
    }
}
