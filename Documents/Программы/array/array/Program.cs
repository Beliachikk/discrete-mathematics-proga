using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace array
{

    internal class Program
    {

        public static void PrintValues(IEnumerable myList)
        {
            Console.WriteLine("Вот,что получилось:\n");
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
        public static void Addd(ArrayList a)//1 метод
        {
            Console.WriteLine("Введите элемент массива, который хотите добавить");
            int b = int.Parse(Console.ReadLine());
            a.Add(b);
            PrintValues(a);
        }
        public static void Countt(ArrayList a)//2 метод
        {
            Console.WriteLine("Количество элементов\n"+ a.Count);
        }
        public static void Removee(ArrayList a)//3 метод
        {
            Console.WriteLine("Введите элемент массива, который хотите удалить");
            int b = int.Parse(Console.ReadLine());
            a.Remove(b);
            
            PrintValues(a);
        }
        public static void Sortt(ArrayList a)//4 метод
        {
            a.Sort();
            PrintValues(a);
        }
        public static void Searchh(ArrayList a)//5 метод// бинарный поиск работает только после сортировки
        {
            Console.WriteLine("Введите элемент массива,индекс которого хотите получить");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Индекс элемента {b}" + a.BinarySearch(b));
        }
        public static void Clearr (ArrayList a)//6 метод
        {
            Console.WriteLine("Все элементы массива удалены");
            a.Clear();
            PrintValues(a);
        }

        public static void Indexx(ArrayList a)//7 метод
        {
            Console.WriteLine("Введите элемент массива,индекс которого хотите найти\n");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Элемент {b} имеет индекс" + a.IndexOf(b)); ;
        }
       
        public static void Reversee(ArrayList a)//8 метод
        {
            a.Reverse();
            PrintValues(a);
        }
        public static void AddRangee(ArrayList a,ArrayList c)//9 метод
        {
            a.AddRange(c);
            PrintValues(a);
        }
        static void Main(string[] args)
        {
            ArrayList p = new ArrayList() { 10,7};
            ArrayList p2 = new ArrayList() {666, 999 };
           bool k = true;
            
            while (k == true)
            {
                Console.Clear();
                string[] menu = new string[] { "Add", "Count", "Remove","Sort","Search","Clear","Index","Reverse","AddRange" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n");
                Console.SetCursorPosition(30, 0);
               bool x = true;
                int j = 0;
                for (int i = 0;x == true;)
                {
                    ConsoleKeyInfo ke = Console.ReadKey(true);
                    if (i == 0)
                    {
                        if (ke.Key == ConsoleKey.Enter && j == 0)
                        {
                            Console.Clear();
                            Addd(p);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 1)
                        {
                            Console.Clear();
                            Countt(p);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 2)
                        {
                            Console.Clear();
                            Removee(p);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 3)
                        {
                            Console.Clear();
                            Sortt(p);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 4)
                        {
                            Console.Clear();
                            Searchh(p);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 5)
                        {
                            Console.Clear();
                            Clearr(p);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 6)
                        {
                            Console.Clear();
                            Indexx(p);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 7)
                        {
                            Console.Clear();
                            Reversee(p);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 8)
                        {
                            Console.Clear();
                            AddRangee(p, p2);
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
