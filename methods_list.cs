using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace methods_list
{
    internal class Program
    {
        static public void Print(List<char> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i] + " ");
            }
        }
        public static void Add(List<char> lst,char a)//1
        {
        lst.Add(a);
        Print(lst);
        }
        public static void Remove(List<char> lst, char a)//2
        {
            lst.Remove(a);
            Print(lst);
        }
        public static void RemoveRange(List<char> lst, int index,int count)//3
        {
            lst.RemoveRange(index,count);
            Print(lst);
        }
        public static void RemoveAt(List<char> lst, int index)//4
        {
            lst.RemoveAt(index);
            Print(lst);
        }
        public static void Reverse(List<char> lst)//5
        {
            lst.Reverse();
            Print(lst);
        }
        public static void ToArray(List<char> lst)//6
        {
            char[] output = lst.ToArray();
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i] + " ");
            }
        }
        public static void BinarySearch(List<char> lst,char item)//7
        {
            Console.WriteLine(lst.BinarySearch(item));
        }
        public static void Clear(List<char> lst)//8
        {
            lst.Clear();
            Print(lst);

        }
        public static void IndexOf(List<char> lst, char c)//9
        {
            Console.WriteLine(lst.IndexOf(c));
        }
        static void Main(string[] args)
        {
            List<char> lst=new List<char>();
            lst.Add('A');
            lst.Add('B');
            lst.Add('C');
            lst.Add('D');

            bool k = true;

            while (k == true)
            {
                Console.Clear();
                string[] menu = new string[] { "Add", "Remove", "RemoveRange", "RemoveAt", "Reverse", "ToArray", "BinarySearch", "Clear", "IndexOf" };
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
                           Add(lst, 'P');
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 1)
                        {
                            Console.Clear();
                            Remove(lst,'A');
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 2)
                        {
                            Console.Clear();
                            RemoveRange(lst,1,2);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 3)
                        {
                            Console.Clear();
                            RemoveAt(lst,2);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 4)
                        {
                            Console.Clear();
                            Reverse(lst);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 5)
                        {
                            Console.Clear();
                            ToArray(lst);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 6)
                        {
                            Console.Clear();
                            BinarySearch(lst,'B');
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 7)
                        {
                            Console.Clear();
                            Clear(lst);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 8)
                        {
                            Console.Clear();
                            IndexOf(lst,'C');
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
