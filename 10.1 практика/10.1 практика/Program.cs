using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_практика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*try
            {

                int n, m;
                int countbol = 0;
                int countnech = 0;
                int countkrat = 0;
                double sumnech = 0;
                double sumkrat = 0;
                Console.WriteLine("Количество строк");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Количество столбиков");
                m = int.Parse(Console.ReadLine());
                int[,] mass = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.WriteLine($"Введи число {i + 1}-й строки {j + 1}-го столбца");
                        mass[i, j] = int.Parse(Console.ReadLine());
                    }

                }
                Console.WriteLine("=====================");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{mass[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("=====================");

                //Больше 15 во втором столбике
                for (int j = 0; j < n; j++)
                {
                    if (mass[j, 1] > 15)
                        countbol++;
                }
                Console.WriteLine("Больше 15 во втором столбике:" + countbol);
                Console.WriteLine("=====================");

                //Среднее арифметическое нечетных элементов пятой строки
                for (int i = 0; i < m; i++)
                {
                    if (mass[4, i] % 2 != 0)
                    {
                        sumnech += mass[4, i];
                        countnech++;
                    }
                }
                Console.WriteLine("Среднее арифметическое нечетных элементов пятой строки:" + Math.Round(sumnech / countnech, 2));
                Console.WriteLine("=====================");

                //Среднее арифметическое четвертого столбца кратное 4
                for (int j = 0; j < n; j++)
                {
                    if (mass[j, 3] % 4 == 0)
                    {
                        sumkrat += mass[j, 3];
                        countkrat++;
                    }
                }
                Console.WriteLine("Среднее арифметическое четвертого столбца чисел кратных 4:" + Math.Round(sumkrat / countkrat, 2));
                Console.WriteLine("=====================");
            }
            catch { Console.WriteLine("Ошибка"); }
            Console.ReadLine();*/

            //19
            try
            {
                int countab = 0;
                Random rnd = new Random();
                int n, m;
                double proiz = 1;
                Console.WriteLine("Количество строк");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Количество столбиков");
                m = int.Parse(Console.ReadLine());
                int[,] mass = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.WriteLine($"Введи число {i + 1}-й строки {j + 1}-го столбца");
                        mass[i, j] = int.Parse(Console.ReadLine());
                    }

                }
                Console.WriteLine("=====================");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{mass[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("=====================");
                Console.WriteLine("Введите a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    countab = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (mass[i, j] % a == 0)
                            countab++;
                    }
                    Console.WriteLine($"Количество чисел {i + 1}-й строки кратные {a}:{countab}");
                }
                Console.WriteLine();
                for (int i = 0; i < m; i++)
                {
                    countab = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (mass[j, i] % a == 0)
                            countab++;
                    }
                    Console.WriteLine($"Количество чисел {i + 1}-о столбика кратные {a}:{countab}");
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    countab = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (mass[i, j] % b == 0)
                            countab++;
                    }
                    Console.WriteLine($"Количество чисел {i + 1}-й строки кратные {b}:{countab}");
                }
                Console.WriteLine();
                for (int i = 0; i < m; i++)
                {
                    countab = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (mass[j, i] % b == 0)
                            countab++;
                    }
                    Console.WriteLine($"Количество чисел {i + 1}-о столбика кратные {b}:{countab}");
                }
                Console.WriteLine();

                //19.2
                int k1, k2;
                Console.WriteLine("От столбика");
                k1 = int.Parse(Console.ReadLine());
                Console.WriteLine("До столбика");
                k2 = int.Parse(Console.ReadLine());
                for (int i = k1 - 1; i < k2; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (mass[j, i] < 0)
                        {
                            proiz *= mass[j, i];
                        }
                    }
                }
                Console.WriteLine("Произведение:" + Math.Round(proiz, 2));
            }
            catch { Console.WriteLine("Ошибка"); }
            Console.ReadLine();
        }
    }
}
