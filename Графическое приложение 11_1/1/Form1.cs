using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int n, stl, scal;
        class Mas
        {
            //Поля класса
            int[,] IntArray;
            int n;
            //Конструктор класса
            public Mas(int n)
            {
                this.n = n;
                IntArray = new int[n, n];
            }
            //Метод ввода массива с клавиатуры
            public void Input(RichTextBox mas_textBox)
            {
                if (string.IsNullOrWhiteSpace(mas_textBox.Text))
                {
                    MessageBox.Show("Введите элементы массива.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var sNums = new string[n, n];
                var arr1 = mas_textBox.Text.Split('\n');
                if (arr1.Length != n)
                {
                    MessageBox.Show("Длина массива не соответствует введенному!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < n; i++)
                {
                    var arr2 = arr1[i].Split(' ');
                    if (arr2.Length != n)
                    {
                        MessageBox.Show("Длина массива не соответствует введенному!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    for (int j = 0; j < n; j++)
                    {

                        sNums[i, j] = arr2[j];
                    }
                }

                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            IntArray[i, j] = int.Parse(sNums[i, j]);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод данных. Попробуйте снова");
                    return;
                }
            }
            //Метод вывода массива
            public void Print(RichTextBox res_textBox)
            {
                res_textBox.Text += "Mассив: "+'\n';
                for (int i = 0; i < n; i++, res_textBox.Text += "\n")
                {
                    for (int j = 0; j < n; j++)
                    {
                        res_textBox.Text += IntArray[i, j];
                    }
                }
            }
            //Метод, вычисляющий сумму столбцов
            public void Sum(int stl, RichTextBox res_textBox)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += IntArray[i, stl];
                }
                res_textBox.Text += "Сумма = " + sum+'\n';

            }
            //позволяющее вычислить количество нулевых элементов в массиве (доступное только для чтения);
            public int Kol_Zero_Element
            {
                get
                {
                    int count = 0;
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                        {
                            if (IntArray[i, j] == 0)
                                count++;
                        }
                    return count;
                }
            }
            // позволяющее установить значение всех элементы главной диагонали массива равное скаляру (доступное только для записи).
            public int Scal
            {
                set
                {
                    for (int i = 0; i < n; i++)
                        IntArray[i, i] = value;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void res_Button_Click(object sender, EventArgs e)
        {
            if (n_textBox.Text == "" || mas_textBox.Text == "" || skl_textBox.Text == "" || stl_textBox.Text == "")
            {
                MessageBox.Show("Введены не все данные");
            }
            else
            {
                res_textBox.Text = "";
                try
                {
                    n = int.Parse(n_textBox.Text);
                    if (n <= 0)
                    {
                        MessageBox.Show("Минимальное значение 1");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод");
                    return;
                }
            }
            Mas mas = new Mas(n);
            mas.Input(mas_textBox);
            mas.Print(res_textBox);
            try
            {
                stl = int.Parse(stl_textBox.Text);
                if (stl < 0)
                {
                    MessageBox.Show("Число должно быть положительным");
                    return;
                }
                if (stl > (n - 1))
                {
                    MessageBox.Show("Значение должно быть меньше");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }
            mas.Sum(stl, res_textBox);
            res_textBox.Text += "Количество нулевых элементов: " + mas.Kol_Zero_Element+'\n';
            try
            {
                scal = int.Parse(skl_textBox.Text);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }
            res_textBox.Text += "Все элементы главной диагонали равны скаляру: "+'\n';
            mas.Scal = scal;
            mas.Print(res_textBox);
        }
    }
}

