using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
            ////18
            //try
            //{         
            //    Console.WriteLine("----Введите размеры массива----");
            //    Console.Write("Ширина массива:");         
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("Высота масива: ");         
            //    int b = int.Parse(Console.ReadLine());
            //    if (a > 0 && b > 0)         
            //    {
            //        int[,] arr = new int[a, b];         
            //        for (int i = 0; i < a; i++)
            //        {         
            //            for (int j = 0; j < b; j++)
            //            {         
            //                Console.Write($"Элемент : ");
            //                arr[i, j] = int.Parse(Console.ReadLine());         
            //            }
            //        }         
            //        Console.Write("Введите K: ");
            //        int k = int.Parse(Console.ReadLine());         
            //        if (k > 0)
            //        {         
            //            Console.Write("Введите K1: ");
            //            int k1 = int.Parse(Console.ReadLine());         
            //            Console.Write("Введите K2: ");
            //            int k2 = int.Parse(Console.ReadLine());         
            //            int count = 0;
            //            int sum = 0;        
            //            for (int i = 0; i < a; i++)
            //            {         
            // for (int j = 0; j < b; j++)
            //                {         
            //                    if (arr[i, j] > 0 && arr[i, j] % k == 0)
            //                    {         
            //                        count++;
            //                    }         
            //                    if (i >= k1 - 1 && i <= k2 - 1)
            //                    {        
            //                        sum += arr[i, j];
            //                    }         
            //                }
            //            }        
            //            Console.WriteLine("----Массив----");
            //            foreach (int element in arr)         
            //            {
            //                Console.WriteLine(element + "\t");
            //            }            
            //            Console.WriteLine("----Итоги----");
            //            Console.WriteLine($"Колличевство положительных чисел кратных {k}: {count}");            
            //            Console.WriteLine($"Сумма чисел в промежутке от {k1} до {k2}:{sum}");
            //        }            
            //        else
            //        {           
            //            Console.WriteLine("K должно быть больше 0");
            //        }            
            //    }
            //    else           
            //    {
            //        Console.WriteLine("Размеры массива не могут быть меньше 0");           
            //    }
            //}            
            //catch
            //{            
            //    Console.WriteLine("Неверный тип данных");
            //}            
            //Console.ReadKey();

            //19
            Random rnd = new Random();
            Console.WriteLine("Введите какого размера нужен двумерный массив");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение k1");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение k2");
            int k2 = Convert.ToInt32(Console.ReadLine());
            int[,] x = new int[y, y];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = rnd.Next(-20, 20 + 1);
                }
            }
            int k_res = 0, k12_res = 1;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (x[i, j] % a == 0 || x[i, j] % b == 0)
                        k_res++;
                    if ((i >= k1 && i <= k2) && x[i, j] < 0)
                        k12_res *= x[i, j];
                    Console.Write($"{x[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{k_res} Чисел кратных {a} и {b}\n{k12_res} сумма чисел из столбцов c {k1} по {k2}");
            Console.ReadKey();
        }
    }
}
