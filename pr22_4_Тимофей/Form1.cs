using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_12__вариант_3__задание_4_
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
            bool sc; string info, gender;
            try
            {
                RadioButton rb = new RadioButton();
                if (radioButton1.Checked) gender = radioButton1.Text;
                else if (radioButton2.Checked) gender = radioButton2.Text;
                else gender = "Не выбран";
                    Sport sport = new Sport();
                sc=sport.Scan(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDateTime(textBox5.Text), short.Parse(textBox6.Text), short.Parse(textBox7.Text), textBox8.Text);
                sport.IdealVes();
                sport.IdealVes2(gender);
                if (sc) { info = sport.Info(gender); MessageBox.Show(info, "Сообщение", MessageBoxButtons.OK); }
            }
            catch { MessageBox.Show("Найден некорректный ввод данных", "Дата", MessageBoxButtons.OK); }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
