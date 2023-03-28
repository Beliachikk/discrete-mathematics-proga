using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace methods_sortedlist
{
    internal class Program
    {
        public static void Print(SortedList sl)
        {
            ICollection c = sl.Keys;
           foreach(string str in c)
                Console.WriteLine(str + ":" + sl[str]);
           Console.WriteLine();
        }
        public static void Add(SortedList sl,string key,string value)//1
        {
            sl.Add(key,value);
            Print(sl);
        }
        public static void ContainsKey(SortedList sl, string key)//2
        {
            Console.WriteLine(sl.ContainsKey(key));
            
        }
        public static void ContainsValue(SortedList sl, string value)//3
        {
            Console.WriteLine(sl.ContainsValue(value));

        }
        public static void GetByIndex(SortedList sl, int ind)//4
        {
            Console.WriteLine(sl.GetByIndex(ind));

        }
        public static void GetKey(SortedList sl, int ind)//5
        {
            Console.WriteLine(sl.GetKey(ind));
        }
        public static void IndexOfKey(SortedList sl, string key)//6
        {
            Console.WriteLine(sl.IndexOfKey(key));
        }
        public static void IndexOfValue(SortedList sl, string value)//7
        {
            Console.WriteLine(sl.IndexOfKey(value));
        }
        public static void SetByIndex(SortedList sl, string value,int ind)//8
        {
           sl.SetByIndex(ind,value);
            Print(sl);
        }
        public static void GetValueList(SortedList sl)//9
        {
            IList myValueList = sl.GetValueList();
            for (int i = 0; i < sl.Count; i++)
                Console.WriteLine("\t{0}", myValueList[i]);
        }
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("здание", "жилое помещение");
            sl.Add("машина", "транспортное средство");
            bool k = true;

            while (k == true)
            {
                Console.Clear();
                string[] menu = new string[] { "Add", "ContainsKey", "ContainsValue", "GetByIndex", "GetKey", "IndexOfKey", "IndexOfValue", "SetByIndex", "GetValueList" };
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
                            Add(sl, "a", "b");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 1)
                        {
                            Console.Clear();
                            ContainsKey(sl,"здание");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 2)
                        {
                            Console.Clear();
                            ContainsValue(sl,"жилое помещение");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 3)
                        {
                            Console.Clear();
                            GetByIndex(sl,1);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 4)
                        {
                            Console.Clear();
                            GetKey(sl, 1);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 5)
                        {
                            Console.Clear();
                            IndexOfKey(sl, "здание");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 6)
                        {
                            Console.Clear();
                            IndexOfValue(sl, "транспортное средство");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 7)
                        {
                            Console.Clear();
                            SetByIndex(sl, "хочу кушать",1);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 8)
                        {
                            Console.Clear();
                            GetValueList(sl);
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
