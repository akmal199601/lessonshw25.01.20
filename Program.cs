using System;
using System.Linq;

namespace lessons3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание № 1

            //Console.Write("Введите первое число А = ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите первое число B =");
            //int b = Convert.ToInt32(Console.ReadLine());
            //for (int i = a; i <= b; i++) Console.WriteLine(i);
            //int n = b - a + 1;
            //Console.WriteLine("");
            //Console.ReadKey();

            //Задание 1.1

            //Console.WriteLine("Введите ваши два числа ");
            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = A; i <= B ; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);
            //for (int i = A; i <= B; i++)
            //{
            //    if(i % 2 ==1)
            //        Console.WriteLine(i);
            //}

            //Задание№4

            //double dep = 1000;
            //double per = Convert.ToDouble(Console.ReadLine());
            //int mes = 0;
            //while (dep <= 1100)
            //{
            //    mes++;
            //    dep = dep * (per / 100 + 1);
            //}
            //Console.WriteLine("Количество месяцев " + dep);
            //Console.WriteLine("Итоговый размер вклада " + mes);
            //Console.ReadKey();


            // Треугольник
            //int i1 = 0, i2 = 0;
            //for (int a = 0; a < 14; a++)
            //{
            //    for (int b = 0; b < 15; b++)
            //    {

            //        if (b == i1 || b == i2) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.Write("\n");
            //    i2++;
            //}
            //for (int b = 0; b < 15; b++)
            //{
            //    Console.Write("*");
            //}
            //Console.Read();


            // Прямоугольник

            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= 40; j++)
            //    {
            //        if ((j == 0 || j == 40) || (i == 0 || i == 10))
            //            Console.Write("*");

            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();




            //    int indent = n / 2 + 1;
            //    string s = "*".PadLeft(indent);
            //for (int k = 0; k < indent; k++)
            //{
            //    Console.WriteLine(s);
            //    s = s.Substring(1) + "**";
            //}


            //int h, h1, h2, h3, h4, h5, h6;
            //int s;
            //h = Int32.Parse(Console.ReadLine());




            //int number, i, k, count = 1;
            //Console.Write("Enter number of rows\n");
            //number = int.Parse(Console.ReadLine());
            //count = number - 1;
            //for (k = 1; k <= number; k++)
            //{
            //    for (i = 1; i <= count; i++)
            //        Console.Write(" ");
            //    count--;
            //    for (i = 1; i <= 2 * k - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //count = 1;
            //for (k = 1; k <= number - 1; k++)
            //{
            //    for (i = 1; i <= count; i++)
            //        Console.Write(" ");
            //    count++;
            //    for (i = 1; i <= 2 * (number - k) - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //Console.ReadLine();




            //Задание  № 1 из 2 дз

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //Random random1 = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random1.Next(1000);
            //    Console.WriteLine($"arr[{i}]=" + arr[i]);
            //}
            //int max = arr[0];
            //int min = arr[0];
            //int sum = 0;
            //int count = 0;
            //int medium = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //    count++;
            //    sum = sum + arr[i];
            //    medium = sum / count;

            //}
            //Console.WriteLine();
            //Console.WriteLine(" Максимальное значение = " + max);
            //Console.WriteLine(" Минимальное значение = " + min);
            //Console.WriteLine(" Сумма = " + sum);
            //Console.WriteLine(" Среднее = " + medium);
            //Console.WriteLine();
            //Console.WriteLine(" Нечетные значения в массиве ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        Console.WriteLine($"arr[{i}]=" + arr[i]);
            //        {
            //        };



            //   задание№3 ромб

            //int aki = 7;
            //int f = aki / 2 + 1;
            //for (int i = 1; i <= aki; i++)
            //  {
            //            for (int j = 1; j <= aki; j++)
            //            {
            //                if ((j == f || j == aki - f + 1))
            //                {
            //                    Console.Write("*");
            //                }
            //                else
            //                {
            //                 Console.Write(" ");
            //                }
            //            }
            //            if (i <= aki / 2)
            //            {
            //                f--;
            //            }
            //            else
            //            {
            //                f++;
            //            }
            //            Console.WriteLine();
            //  }
            //Console.ReadKey();



            //int userSize = Convert.ToInt32(Console.ReadLine());
            //int[] number = new int[userSize];
            //Random rnd = new Random();
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = rnd.Next(1000);
            //}
            //foreach (var numbers in number)
            //{
            //    Console.WriteLine(numbers);
            //}
            //var count = Convert.ToInt32(Console.ReadLine());
            //var index = Convert.ToInt32(Console.ReadLine());
            //int[] empty = new int[count];
            //for (int z = 0; z < empty.Length; z++)
            //{
            //    if (z + index < number.Length)
            //        empty[z] = number[z + index];

            //    else
            //        empty[z] = 1;
            //}
            //for (int z = 0; z < empty.Length; z++)
            //{
            //    Console.WriteLine(empty[z]);
            //}




















        }
            }
        }
    }   }

            