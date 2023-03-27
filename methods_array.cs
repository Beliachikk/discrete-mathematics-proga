using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace methods_array
{
    internal class Program
    {
        public static void PrintV(int[] a)//принт для int
        {
            foreach(int i in a)
            {
                Console.WriteLine("\t{0}",i);
            }
            Console.WriteLine();
        }
        public static void PrintV(Object[] b)//принт для object
        {
            foreach (int i in b)
            {
                Console.WriteLine("\t{0}", i);
            }
            Console.WriteLine();
        }
        public static void Copyy(int[] a, Object[] b, int c)//1 копирование первых элементов из одного массива в другой
        {
            System.Array.Copy(a, b, c);
            PrintV(a);
            PrintV(b);
        }

        public static void IsFixedSizee(int[] a)//2 должно true вывести
        {
            Console.WriteLine(a.IsFixedSize);
        }
        public static void Lengthh(int[] a)//3 длина
        {
            Console.WriteLine(a.Length);
        }
        public static void Rankk(int[] a)//4 кол-во измерений
        {
            Console.WriteLine(a.Rank);
        }
        public static void Clearr(int[] a,int x, int y)//5 
        {
            Array.Clear(a, x, y);
            PrintV(a);
        }
        public static void Equall(int[] a, object[] b)//6 равенство
        {
            Console.WriteLine(a.Equals(b)); 
        }
        public static void Findd (int[] a,int x)//7
        {
            Console.WriteLine(Array.Find(a, k => k == x));
        }
        public static void GetValuee(int[] a, int x)//8 получает значение, хранящееся в указанной позиции одномерного массива
        {
            Console.WriteLine(a.GetValue(x));//8
        }
        public static void Reversee(int[] a, int x, int y)//9 
        {
            Array.Reverse(a, x, y);
            PrintV(a);
        }
        static void Main(string[] args)
        {
            int[] myInt = new int[5] { 1, 2, 3, 4, 5 };
            Object[] myObj = new Object[5] {26,27,28,29,30};
         
            bool k = true;

            while (k == true)
            {
                Console.Clear();
                string[] menu = new string[] { "Copy", " IsFixedSize", "Length", "Rank", "Clear", "Equals", "Find", "GetValue", "Reverse" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n");
                Console.SetCursorPosition(30, 0);
                bool x = true;
                int j = 0;
                for (int i = 0; x == true;)
                {
                    ConsoleKeyInfo ke = Console.ReadKey(true);
                    if (i == 0)
                    {
                        if (ke.Key == ConsoleKey.Enter && j == 0)
                        {
                            Console.Clear();
                            Copyy(myInt,myObj,3);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 1)
                        {
                            Console.Clear();
                            IsFixedSizee(myInt);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 2)
                        {
                            Console.Clear();
                            Lengthh(myInt);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 3)
                        {
                            Console.Clear();
                            Rankk(myInt);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 4)
                        {
                            Console.Clear();
                            Clearr(myInt,1,2);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 5)
                        {
                            Console.Clear();
                            Equall(myInt,myObj);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 6)
                        {
                            Console.Clear();
                            Findd(myInt,3);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 7)
                        {
                            Console.Clear();
                            GetValuee(myInt,3);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 8)
                        {
                            Console.Clear();
                            Reversee(myInt,1,3);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        // управление консоли
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 8) || (ke.Key == ConsoleKey.UpArrow && j == 1))
                        {
                            Console.SetCursorPosition(35, 0);
                            j = 0;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 0) || (ke.Key == ConsoleKey.UpArrow && j == 2))
                        {
                            Console.SetCursorPosition(35, 1);
                            j = 1;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 1) || (ke.Key == ConsoleKey.UpArrow && j == 3))
                        {
                            Console.SetCursorPosition(35, 2);
                            j = 2;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 2) || (ke.Key == ConsoleKey.UpArrow && j == 4))
                        {
                            Console.SetCursorPosition(35, 3);
                            j = 3;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 3) || (ke.Key == ConsoleKey.UpArrow && j == 5))
                        {
                            Console.SetCursorPosition(35, 4);
                            j = 4;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 4) || (ke.Key == ConsoleKey.UpArrow && j == 6))
                        {
                            Console.SetCursorPosition(35, 5);
                            j = 5;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 5) || (ke.Key == ConsoleKey.UpArrow && j == 7))
                        {
                            Console.SetCursorPosition(35, 6);
                            j = 6;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 6) || (ke.Key == ConsoleKey.UpArrow && j == 8))
                        {
                            Console.SetCursorPosition(35, 7);
                            j = 7;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 7) || (ke.Key == ConsoleKey.UpArrow && j == 0))
                        {
                            Console.SetCursorPosition(35, 8);
                            j = 8;
                        }
                    }

                }

            }
        }
    }
}
