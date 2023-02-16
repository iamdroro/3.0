using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_12__вариант_3__задание_4_
{
    class Sport
    {
        public string name = "Пусто";
        public string surname = "Пусто";
        public string familyname = "Пусто";
        public string gender="Не выбран";
        public int age;
        public short rost;
        public short ves;
        public string vsport = "Пусто";
        public int idealvesbrok= 0;
        public double idealveskuper = 0;
        public string Info(string gender1)
        {
            gender= gender1;
            string sportman = "Спортсмен: " + familyname + " " + name + " " + surname + "\n" + "Возраст: " + age + "\n" + "Рост: " + rost + "\n" + "Вес: " + ves + "\n" + "Вид спорта: " + vsport + "\n" + "Пол: " + gender + "\n" + "Идеальный вес по формуле Брока: " + idealvesbrok + "\n" + "Идеальный вес по формуле Купера: " + Math.Round(idealveskuper,3);
            return sportman;
        }
        public int IdealVes()
        {
            if (age <= 40) idealvesbrok = rost - 110;
            else idealvesbrok = rost - 100;
            return idealvesbrok;
        }
        public double IdealVes2(string gender1)
        {
            gender=gender1;
            if (gender == "Мужской")
            { idealveskuper = (rost * 4 / 2.54 - 128) * 0.453; 
            }
            else idealveskuper = (rost * 3.5/2.54-108)*0.453;
            return idealveskuper;
        }
        public bool Scan(string name1, string familyname1, string surname1, DateTime data, short rost1, short ves1, string vsport1)
        {
            DateTime now = DateTime.Today;
            int age1 = now.Year - data.Year;
            if (data > now.AddYears(-age1)) age1--;
            bool scan = true;
            char[] scanname = name1.ToCharArray();
            char[] scanfamily = familyname1.ToCharArray();
            char[] scansurname = surname1.ToCharArray(); char[] scanvsport = vsport.ToCharArray();
            if (name1.Replace(" ", "") != "" && familyname1.Replace(" ", "") != "" && surname1.Replace(" ", "") != "" && vsport1.Replace(" ", "") != "")
            {
                for (int i = 0; i < scanname.Length; i++)
                {
                    if (!Char.IsLetter(scanname[i]))
                    {
                        MessageBox.Show("Некорректный ввод имени", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;
                    }
                }
                for (int i = 0; i < scanfamily.Length; i++)
                {
                    if (!Char.IsLetter(scanfamily[i]))
                    {
                        MessageBox.Show("Некорректный ввод фамилии", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;

                    }
                }
                for (int i = 0; i < scansurname.Length; i++)
                {
                    if (!Char.IsLetter(scansurname[i]))
                    {
                        MessageBox.Show("Некорректный ввод отчества", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;
                    }
                }
                for (int i = 0; i < vsport1.Length; i++)
                {
                    if (!Char.IsLetter(vsport1[i]))
                    {
                        MessageBox.Show("Некорректный ввод строки (вид спорта)", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;
                    }
                }
                if (rost1 > 0 && rost1 < 250)
                {
                    rost = rost1;
                }
                else 
                { 
                    MessageBox.Show("Рост введен неправильно", "Сообщение", MessageBoxButtons.OK);
                    scan = false;
                }
                if (ves1 > 0 && ves1 < 250)
                {
                    ves = ves1;
                }
                else
                {
                    MessageBox.Show("Вес введен неправильно", "Сообщение", MessageBoxButtons.OK);
                    scan = false;
                }
                if (scan)
                {
                    name = name1;
                    surname = surname1;
                    familyname = familyname1;
                    vsport = vsport1;
                    age = age1;
                }
                return scan;
            }
            else
            { MessageBox.Show("Найдены пустая строка(и)", "Сообщение", MessageBoxButtons.OK);
                scan = false;
                return scan;
            }
            
        }
    }
}
