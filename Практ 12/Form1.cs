using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практ_12
{
    public partial class Form1 : Form
    {
        string buffer;
        public Form1()
        {
            InitializeComponent();

            DateTime d = DateTime.Now;//Создание объекта
            statusStrip1.Items[0].Text = d.ToString("HH:mm");//Время
            statusStrip1.Items[1].Text = d.ToString("dd.MM.yyyy");//Дата
            if (tabControl1.SelectedIndex == 0) statusStrip1.Items[2].Text = "Задание 1";//Изначально выбрана 1 страница с индексом 0
        }

        //Расчет площади по 1 заданию
        private void button1_Click(object sender, EventArgs e)
        {
            //Передача фокуса 1 элементу блока "Исходные данные"
            textBox1.Focus();

            //Проверка
            if (textBox1.Text == "")  MessageBox.Show("Пустое поле A");
            if (textBox2.Text == "")  MessageBox.Show("Пустое поле B");

            //Расчет по заданию
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int S = a * b;
            textBox3.Text = S.ToString();
        }

        //Расчет периметра по 1 заданию
        private void btnResultP_Click(object sender, EventArgs e)
        {
            //Передача фокуса 1 элементу блока "Исходные данные"
            textBox1.Focus();

            //Расчет по заданию
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int P = 2 * (a + b);
            textBox3.Text = P.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //При выборе страницы с индексом 0 в статус стрип запишется Задание 1
            if (tabControl1.SelectedIndex == 0) statusStrip1.Items[2].Text = "Задание 1";
            //При выборе страницы с индексом 1 в статус стрип запишется Задание 2
            if (tabControl1.SelectedIndex == 1) statusStrip1.Items[2].Text = "Задание 2";
        }

        //При изменении исходных данных очищать поле результата. 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        //При изменении исходных данных очищать поле результата. 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-31 \n" +
                "Подъяблонский Данила Владимирович \n" +
                "Задание 1: \n" +
                "Даны стороны прямоугольника a и b. Найти его площадь периметр \n" +
                "Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.");
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-31 \n" +
                "Подъяблонский Данила Владимирович \n" +
                "Задание 1: \n" +
                "Даны стороны прямоугольника a и b. Найти его площадь периметр \n" +
                "Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox4.Text);
            int thirdnum = number % 10;
            int twonum = number / 10 % 10;
            int onenum = number / 100;
            MessageBox.Show(thirdnum.ToString() + twonum.ToString() + onenum.ToString());
        }
    }
}
