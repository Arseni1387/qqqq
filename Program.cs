using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания/функции:\n");
            Console.WriteLine(" 1)Типы.\n 2)Строки.\n 3)Массивы.\n 4)Кортежи.\n 5)Работа с массивами.\n 6)Работа с checked/unchecked.\n");
            int num_switch = Convert.ToInt32(Console.ReadLine());
            switch (num_switch)
            {
                case 1:
                    func1(args);
                    break;
                case 2:
                    func2(args);
                    break;
                case 3:
                    func3(args);
                    break;
                case 4:
                    func4(args);
                    break;
                case 5:
                    func5(args);
                    break;
                case 6:
                    func6(args);
                    break;
            }
        }
        static void func1(string[] args)
        {
            Console.WriteLine("Вывод переменных: ");

            Console.WriteLine("Тип sbyte: ");
            sbyte s = 2;
            Console.WriteLine(s);

            Console.WriteLine("Тип short: ");
            short sh = 3;
            Console.WriteLine(sh);

            Console.WriteLine("Тип int: ");
            int i32 = 32;
            Console.WriteLine(i32);

            Console.WriteLine("Тип long: ");
            long i64 = 64;
            Console.WriteLine(i64);

            Console.WriteLine("Тип byte: ");
            byte b = 8;
            Console.WriteLine(b);

            Console.WriteLine("Тип ushort: ");
            ushort us = 16;
            Console.WriteLine(us);

            Console.WriteLine("Тип uint: ");
            uint ui = 32;
            Console.WriteLine(ui);

            Console.WriteLine("Тип ulong: ");
            ulong ul = 64;
            Console.WriteLine(ul);

            Console.WriteLine("Тип char: ");
            char ch = 'e';
            Console.WriteLine(ch);

            Console.WriteLine("Тип bool: ");
            bool bo = true;
            Console.WriteLine(bo);

            Console.WriteLine("Тип float: ");
            float fl = 32.4f;
            Console.WriteLine(fl);

            Console.WriteLine("Тип double: ");
            double doubl = 34.5d;
            Console.WriteLine(doubl);

            Console.WriteLine("Тип decimal: ");
            decimal dec = 100.5m;
            Console.WriteLine(dec);

            //Неявное приведение:
            int x1 = 5;
            long x2 = x1;

            short x3 = 6;
            int x4 = x3;

            uint x5 = 7;
            ulong x6 = x5;

            sbyte x7 = 127;
            short x8 = x7;

            float x9 = 45.5f;
            double x10 = x9;


            //Явное приведение: 
            int y1 = 6;
            byte y2 = (byte)y1;

            short y3 = 2;
            int y4 = (int)y3;

            uint y5 = 7;
            ulong y6 = (ulong)y5;

            sbyte y7 = 126;
            short y8 = (short)y7;

            float y9 = 46.5f;
            double y10 = (double)y9;

            //Возможности класса Convert:
            int n = Convert.ToInt32("23");
            Console.WriteLine(n.GetType());

            //Упаковка и распаковка значимых типов:
            int price = 4;
            object obj = price;
            int price2 = (int)obj;

            //Работа с неявно типизированной переменной:
            var egor = Convert.ToString(s);
            Console.WriteLine(egor.GetType());

            //Работа с Nullable переменной:
            int? c66 = 7;
            if (c66 != null)
            {
                Console.WriteLine($"c is {c66.Value}");
            }
            else
            {
                Console.WriteLine("c does not have a value");
            }
            //ошибка
            var qqq = 2;
            int qqqq = qqq;
            //

        }
        static void func2(string[] args)
        {
            Console.WriteLine("Работа со строками: ");

            Console.WriteLine("Введите первую строку: ");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1);

            Console.WriteLine("Введите вторую строку: ");
            string s2 = Console.ReadLine();
            Console.WriteLine(s2);

            Console.WriteLine("Результат сравнения:" + (s1 == s2));

            string str1 = "Первая строка";
            string str2 = "Вторая строка";
            string str3 = "Третья строка";
            Console.WriteLine("Конкантинация:" + (str1 + str2 + str3));
            Console.WriteLine("Выделение подстроки:" + (str1.Substring(2, 4)));
            string[] words = str1.Split(' ');
            Console.WriteLine("Первое слово:" + words[0]);
            Console.WriteLine("Второе слово:" + words[1]);
            string modif = str2.Insert(3, str1);
            Console.WriteLine("После вставки подстроки: " + modif);
            string modif2 = str2.Remove(3);
            Console.WriteLine("После удаления подстроки: " + modif2);

            string name = "Arseni Kravzhul";
            int age = 18;
            Console.WriteLine($"{name} is {age} years old");

            //Создайте пустую и null строку. Продемонстрируйте
            //использование метода string.IsNullOrEmpty.
            //Продемонстрируйте что еще можно выполнить с такими строками
            Console.WriteLine("Пустая и null строки: ");
            string st1 = "";
            string st2 = null;
            Console.WriteLine(string.IsNullOrEmpty(st1));
            Console.WriteLine(string.IsNullOrEmpty(st2));

            //Создайте строку на основе StringBuilder. Удалите определенные
            //позиции и добавьте новые символы в начало и конец строки.

            Console.WriteLine("StringBuilder: ");
            StringBuilder sb = new StringBuilder("ABC", 50);
            Console.WriteLine(sb);
            sb.Append(" HELLO");
            Console.WriteLine(sb);
            sb.Remove(0, 2);
            Console.WriteLine(sb);
            sb.Insert(0, "ABC");
            Console.WriteLine(sb);

        }
        static void func3(string[] args)
        {
            Console.WriteLine("Двумерный массив:");


            int[,] mas = { { 1, 2, 3 },
                           { 4, 5, 6 },
                           { 7, 8, 9 },
                           { 10, 11, 12 }
            };
            int hight = mas.GetLength(0);  //метод определяет количество элементов в первом измерении то есть 4 высота таблицы
            int width = mas.GetLength(1); //метод определяет количество элементов во втором измерении то есть 3 это ширина таблицы
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Массив строк
            string[] mas2 = { "первый", "второй", "третий" };
            int length = mas2.Length;
            Console.WriteLine();
            for (int i = 0; i < length; ++i)
            {
                if (i == 2)
                {
                    mas2[i] = "не второй ";
                }
            }
            Console.WriteLine();
            for (int i = 0; i < length; ++i)
            {
                Console.WriteLine(mas2[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Длинна массива : {0}", length);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[][] mas3 = new int[3][];
            mas3[0] = new int[2];
            mas3[1] = new int[3];
            mas3[2] = new int[4];

            for (int i = 0; i < mas3.Length; i++)
            {
                for (int j = 0; j < mas3[i].Length; j++)
                {
                    Console.WriteLine($"введите элемент встроку {i}");

                    mas3[i][j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
            for (int i1 = 0; i1 < mas3.Length; i1++)
            {
                for (int j1 = 0; j1 < mas3[i1].Length; j1++)
                {

                    Console.Write(mas3[i1][j1] + "\t");

                }
                Console.WriteLine();


            }
            var arrayy = new object[0];
            var strr = "Arseni";
        }
        static void func4(string[] args)
        {
            Console.WriteLine("Работа с кортэжами:");
            (int, string, char, string, ulong) tuple = (18, "Kravzhul", 'A', "D.", 73);
            Console.WriteLine(tuple.GetType().Name);
            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);

            (var a, var b) = ("123", 456);
            Console.WriteLine($"{a} {b}");


            (int a, byte b) left = (6, 10);
            (long a, int b) right = (5, 10);
            Console.WriteLine(left == right);  // output: True
            Console.WriteLine(left != right);
        }
        static void func5(string[] args)
        {
            string strok = "Arseni Kravzhul";
            int[] mas = { 1, 2, 4, 5, 6, 7 };
            string First = strok.Remove(1);
            int minValue = mas.Min();
            int maxValue = mas.Max();
            int sumValue = mas.Sum();
            var tuple = (minValue, maxValue, sumValue, First);
            Console.WriteLine(tuple);

        }
        static void func6(string[] args)
        {
            int ten = 10;
            checked //при переполнении типа считает заново, при чеке выдаёт ошибку

            {

                int i1 = 2147483647 + ten;
                Console.WriteLine(i1);
            }
        }
    }
}
