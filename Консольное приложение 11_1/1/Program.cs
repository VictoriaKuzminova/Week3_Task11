        using System;

namespace _1
{
    class Program
    {
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
            public void Input()
            {
                Console.WriteLine("Ввод элементов массива: ");
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        Console.Write("Элемент №[{0},{1}] = ", i, j);
                        IntArray[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            //Метод вывода массива
            public void Print()
            {
                Console.WriteLine("Mассив: ");
                for (int i = 0; i < n; i++, Console.WriteLine())
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,5} ", IntArray[i, j]);
                    }
                }
            }
            //Метод, вычисляющий сумму столбцов
            public void Sum(int stl)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += IntArray[i, stl];
                }
                Console.WriteLine("Сумма = "+sum);

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
        static void Main(string[] args)
        {
            int n, stl, scal;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите размерность массива (n*n): ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Минимальное значение 1");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            Mas mas = new Mas(n);
            mas.Input();
            mas.Print();
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите номер столбца: ");
                    stl = int.Parse(Console.ReadLine());
                    if (stl < 0)
                    {
                        Console.WriteLine("Число должно быть положительным");
                        continue;
                    }
                    if (stl > (n-1))
                    {
                        Console.WriteLine("Значение должно быть меньше");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            mas.Sum(stl);
            Console.WriteLine("Количество нулевых элементов: {0}", mas.Kol_Zero_Element);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите значение скаляра: ");
                    scal = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            Console.WriteLine("Все элементы главной диагонали равны скаляру: ");
            mas.Scal = scal;
            mas.Print();
        }
    }
}
